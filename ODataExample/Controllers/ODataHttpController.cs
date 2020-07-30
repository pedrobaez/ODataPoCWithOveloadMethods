using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace ODataExample.Controllers
{
    public class ODataHttpControllerSelector : DefaultHttpControllerSelector
    {
        private readonly HttpConfiguration _configuration;
        private readonly Lazy<ConcurrentDictionary<string, Type>> _apiControllerTypes;

        public ODataHttpControllerSelector(HttpConfiguration configuration)
            : base(configuration)
        {
            _configuration = configuration;
            _apiControllerTypes = new Lazy<ConcurrentDictionary<string, Type>>(GetControllerTypes);
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            return this.GetApiController(request);
        }

        private static ConcurrentDictionary<string, Type> GetControllerTypes()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var types = assemblies
                .SelectMany(a => a
                    .GetTypes().Where(t =>
                        !t.IsAbstract &&
                        t.Name.EndsWith(ControllerSuffix, StringComparison.OrdinalIgnoreCase) &&
                        typeof(IHttpController).IsAssignableFrom(t)))
                .ToDictionary(t => t.FullName, t => t);

            return new ConcurrentDictionary<string, Type>(types);
        }

        private HttpControllerDescriptor GetApiController(HttpRequestMessage request)
        {
            var isOData = IsOData(request);
            if (isOData)
            {
                var controllerName = GetControllerName(request);
                var type = GetODataControllerType(controllerName);
                return new HttpControllerDescriptor(_configuration, controllerName, type);
            }
            return base.SelectController(request);
        }

        private static bool IsOData(HttpRequestMessage request)
        {
            var data = request.RequestUri.ToString();
            bool match = 
                data.IndexOf("/OData/", StringComparison.OrdinalIgnoreCase) >= 0 ||
                data.EndsWith("/OData", StringComparison.OrdinalIgnoreCase) || 
                data.IndexOf("/Default.",StringComparison.OrdinalIgnoreCase) >= 0;
            return match;
        }

        private Type GetODataControllerType(string controllerName)
        {
            return _apiControllerTypes.Value
                .AsEnumerable()
                .WhereODataOnly()
                .ByControllerName(controllerName)
                .Select(x => x.Value)
                .Single();
        }
    }

    public static class ControllerTypeSpecifications
    {
        public static IEnumerable<KeyValuePair<string, Type>> WhereODataOnly(this IEnumerable<KeyValuePair<string, Type>> query)
        {
            return query.Where(x => x.Key.IndexOf(".OData.", StringComparison.OrdinalIgnoreCase) >= 0);
        }

         

        public static IEnumerable<KeyValuePair<string, Type>> ByControllerName(this IEnumerable<KeyValuePair<string, Type>> query, string controllerName)
        {
            var controllerNameToFind = string.Format(CultureInfo.InvariantCulture, ".{0}OData{1}", controllerName, DefaultHttpControllerSelector.ControllerSuffix);

            return query.Where(x => x.Key.EndsWith(controllerNameToFind, StringComparison.OrdinalIgnoreCase));
        }
    }
}