using System.Collections.Generic;
using System.Web.Http;
using Tmag.GvcPassThroughApi.Models;

namespace Tmag.GvcPassThroughApi.Controllers
{
    public class GvcController : ApiController
    {
        public const string GvcKey = "Tmag0nly!81";
        public const string GvcUsername = "TMaGsnhg3eS9";
        public const string GvcPassword = "qO5K5TBCC3dF";

        public IEnumerable<ClubCategory> Get([FromUri]string key)
        {
            if (key != GvcKey) return new List<ClubCategory>();

            var service = new GvCommerce.PriceBookServiceClient();

            service.ClientCredentials.UserName.UserName = GvcUsername;
            service.ClientCredentials.UserName.Password = GvcPassword;

            var productTypes = service.GetProductTypeList();

            var clubCategories = new List<ClubCategory>();

            foreach (var type in productTypes)
            {
                var newType = new ClubCategory() { Name = type.Name, brands = new List<Brand>() };
                var brands = service.GetBrandList(type.ProductTypeID);

                foreach (var brand in brands)
                {
                    var newBrand = new Brand() { Name = brand.BrandName, Models = new List<Model>() };

                    var models = service.GetPriceBookItems(
                        new GvCommerce.PriceBookRequest()
                        {
                            ProductTypeID = type.ProductTypeID,
                            BrandID = brand.BrandID
                        });

                    foreach (var model in models)
                    {
                        var newModel = new Model()
                        {
                            Name = model.ModelName,
                            ImageLarge = model.ImageURLLarge,
                            ImageReg = model.ImageURLReg,
                            ImageSmall = model.ImageURLSmall,
                            ImageThumb = model.ImageURLThumb,
                            ThirdPartyId = model.ModelID.ToString()
                        };

                        newBrand.Models.Add(newModel);
                    }
                    newType.brands.Add(newBrand);
                }

                clubCategories.Add(newType);
            }

            return clubCategories;
        }

    }
}
