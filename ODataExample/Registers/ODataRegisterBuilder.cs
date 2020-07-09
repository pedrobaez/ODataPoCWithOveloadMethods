using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataExample.Registers
{
    public static class ODataRegisterBuilder
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Address>("Addresses");
            builder.EntitySet<AddressType>("AddressTypes");
            builder.EntitySet<AWBuildVersion>("AWBuildVersions");
            builder.EntitySet<BillOfMaterial>("BillOfMaterials");
            builder.EntitySet<BusinessEntity>("BusinessEntities");
            builder.EntitySet<BusinessEntityAddress>("BusinessEntityAddresses");
            builder.EntitySet<BusinessEntityContact>("BusinessEntityContacts");
            builder.EntitySet<ContactType>("ContactTypes");
            builder.EntitySet<CountryRegion>("CountryRegions");
            builder.EntitySet<CountryRegionCurrency>("CountryRegionCurrencies");
            builder.EntitySet<CreditCard>("CreditCards");
            builder.EntitySet<Culture>("Cultures");
            builder.EntitySet<Currency>("Currencies");
            builder.EntitySet<CurrencyRate>("CurrencyRates");
            builder.EntitySet<Customer>("Customers");
            builder.EntitySet<DatabaseLog>("DatabaseLogs");
            builder.EntitySet<Department>("Departments");
            builder.EntitySet<EmailAddress>("EmailAddresses");
            builder.EntitySet<Employee>("Employees");
            builder.EntitySet<EmployeeDepartmentHistory>("EmployeeDepartmentHistories");
            builder.EntitySet<EmployeePayHistory>("EmployeePayHistories");
            builder.EntitySet<ErrorLog>("ErrorLogs");
            builder.EntitySet<Illustration>("Illustrations");
            builder.EntitySet<JobCandidate>("JobCandidates");
            builder.EntitySet<Location>("Locations");
            builder.EntitySet<Password>("Passwords");
            builder.EntitySet<Person>("People");
            builder.EntitySet<PersonCreditCard>("PersonCreditCards");
            builder.EntitySet<PersonPhone>("PersonPhones");
            builder.EntitySet<PhoneNumberType>("PhoneNumberTypes");
            builder.EntitySet<Product>("Products");
            builder.EntitySet<ProductCategory>("ProductCategories");
            builder.EntitySet<ProductCostHistory>("ProductCostHistories");
            builder.EntitySet<ProductDescription>("ProductDescriptions");
            builder.EntitySet<ProductDocument>("ProductDocuments");
            builder.EntitySet<ProductInventory>("ProductInventories");
            builder.EntitySet<ProductListPriceHistory>("ProductListPriceHistories");
            builder.EntitySet<ProductModel>("ProductModels");
            builder.EntitySet<ProductModelIllustration>("ProductModelIllustrations");
            builder.EntitySet<ProductModelProductDescriptionCulture>("ProductModelProductDescriptionCultures");
            builder.EntitySet<ProductPhoto>("ProductPhotos");
            builder.EntitySet<ProductProductPhoto>("ProductProductPhotos");
            builder.EntitySet<ProductReview>("ProductReviews");
            builder.EntitySet<ProductSubcategory>("ProductSubcategories");
            builder.EntitySet<ProductVendor>("ProductVendors");
            builder.EntitySet<PurchaseOrderDetail>("PurchaseOrderDetails");
            builder.EntitySet<PurchaseOrderHeader>("PurchaseOrderHeaders");
            builder.EntitySet<SalesOrderDetail>("SalesOrderDetails");
            builder.EntitySet<SalesOrderHeader>("SalesOrderHeaders");
            builder.EntitySet<SalesOrderHeaderSalesReason>("SalesOrderHeaderSalesReasons");
            builder.EntitySet<SalesPerson>("SalesPeople");
            builder.EntitySet<SalesPersonQuotaHistory>("SalesPersonQuotaHistories");
            builder.EntitySet<SalesReason>("SalesReasons");
            builder.EntitySet<SalesTaxRate>("SalesTaxRates");
            builder.EntitySet<SalesTerritory>("SalesTerritories");
            builder.EntitySet<SalesTerritoryHistory>("SalesTerritoryHistories");
            builder.EntitySet<ScrapReason>("ScrapReasons");
            builder.EntitySet<Shift>("Shifts");
            builder.EntitySet<ShipMethod>("ShipMethods");
            builder.EntitySet<ShoppingCartItem>("ShoppingCartItems");
            builder.EntitySet<SpecialOffer>("SpecialOffers");
            builder.EntitySet<SpecialOfferProduct>("SpecialOfferProducts");
            builder.EntitySet<StateProvince>("StateProvinces");
            builder.EntitySet<Store>("Stores");
            builder.EntitySet<TransactionHistory>("TransactionHistories");
            builder.EntitySet<TransactionHistoryArchive>("TransactionHistoryArchives");
            builder.EntitySet<UnitMeasure>("UnitMeasures");
            builder.EntitySet<Vendor>("Vendors");
            builder.EntitySet<WorkOrder>("WorkOrders");
            builder.EntitySet<WorkOrderRouting>("WorkOrderRoutings");
           

            builder.Namespace = "Default";
            builder.ContainerName = "DefaultContainer";
            builder.EntityType<Shift>().Collection
                              .Function("GetAll")
                              .ReturnsCollectionFromEntitySet<Shift>("Shifts");

            config.MapODataServiceRoute(
               routeName: "ODataRoute",
               routePrefix: null,
               model: builder.GetEdmModel());
        }
    }
}