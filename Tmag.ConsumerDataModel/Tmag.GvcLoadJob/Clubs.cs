using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Tmag.ConsumerData.Models;

namespace Tmag.GvcLoadJob
{
    public class Clubs
    {
        private readonly Repository _repository;
        private readonly ILogger<Consumer> _logger;
        private readonly int _splitCount = 100;

        public Clubs(Repository repository, ILogger<Consumer> logger)
        {
            this._repository = repository;
            this._logger = logger;
        }
        public void Migrate()
        {
            try
            {
                var response = GetJson($"http://tmaggvcpassthroughapi.azurewebsites.net/api/gvc?key=" + "Tmag0nly!81");
                var stringData = GetDataString(response);

                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClubCategory>>(stringData);

                var categories = _repository.Query<ClubCategory>()
                    .Include(x => x.Brands)
                    .Include(x => x.Brands).ThenInclude(x => x.Models);

                foreach (var gvcCat in data)
                {

                    if (gvcCat.Name == "Iron Set") gvcCat.Name = "Irons";
                    else if (gvcCat.Name == "Fairway Wood") gvcCat.Name = "Fairway";
                    else if (gvcCat.Name == "Hybrid") gvcCat.Name = "Rescue";
                    var cat = categories.FirstOrDefault(x => x.Name.ToLower() == gvcCat.Name.ToLower());
                    if (cat == null)
                    {
                        cat = new ClubCategory() { Name = gvcCat.Name, Brands = new List<Brand>() };
                        _repository.Save(cat);
                    }
                    foreach (var gvcBrand in gvcCat.Brands)
                    {
                        var brand = cat.Brands
                            .FirstOrDefault(x => x.Name.ToLower() == gvcBrand.Name.ToLower());
                        if (brand == null)
                        {
                            brand = new Brand() { Name = gvcBrand.Name, Models = new List<Model>(), ClubCategoryId = cat.Id };
                            cat.Brands.Add(brand);
                            _repository.Save(brand);
                            // _repository.SaveQueue(brand);
                        }

                        foreach (var model in brand.Models)
                        {
                            model.Deleted = DateTime.UtcNow;
                        }

                        foreach (var gvcModel in gvcBrand.Models)
                        {
                            var model = brand.Models
                                .FirstOrDefault(x => x.Name.ToLower() == gvcModel.Name.ToLower());
                            if (model == null)
                            {
                                model = new Model()
                                {
                                    Name = gvcModel.Name,
                                    ImageLarge = gvcModel.ImageLarge,
                                    ImageReg = gvcModel.ImageReg,
                                    ImageSmall = gvcModel.ImageSmall,
                                    ImageThumb = gvcModel.ImageThumb,
                                    ThirdPartyId = gvcModel.ThirdPartyId,
                                    Created = DateTime.UtcNow,
                                    BrandId = brand.Id
                                };
                                brand.Models.Add(model);
                                _repository.Save(model);
                            }
                            else
                            {
                                model.Deleted = null;
                                if (model.ImageLarge != gvcModel.ImageLarge)
                                    model.ImageLarge = gvcModel.ImageLarge;
                                if (model.ImageReg != gvcModel.ImageReg)
                                    model.ImageReg = gvcModel.ImageReg;
                                if (model.ImageSmall != gvcModel.ImageSmall)
                                    model.ImageSmall = gvcModel.ImageSmall;
                                if (model.ImageThumb != gvcModel.ImageThumb)
                                    model.ImageThumb = gvcModel.ImageThumb;
                                if (model.ThirdPartyId != gvcModel.ThirdPartyId)
                                    model.ThirdPartyId = gvcModel.ThirdPartyId;
                            }
                        }
                    }
                    _repository.SaveQueue(cat);
                }
                _repository.Save();
            }catch(Exception e)
            {
                throw e;
            }
        }
        public HttpWebResponse GetJson(string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            if (httpWebRequest.CookieContainer == null)
                httpWebRequest.CookieContainer = new CookieContainer();



            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            return httpResponse;
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var responseText = streamReader.ReadToEnd();

            //    return true;
            //}
        }
        public string GetDataString(HttpWebResponse webResponse)
        {
            using (var streamReader = new StreamReader(webResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();

                return responseText;
            }
        }
    }
}
