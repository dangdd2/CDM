using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Tmag.SugarOneOffDataTransferJob.Models;

namespace Tmag.SugarOneOffDataTransferJob
{
    public class StaticTables
    {
        private readonly IRepository _repository;
        private readonly SugarDataContext _sugarDataContext;
        private readonly ILogger<StaticTables> _logger;
        private readonly StaticTableHelper _staticTableHelper;
        
        private dynamic loogUpObject = new[] { new { id = 0, lookUpType = "", lookupValue = "", sortOrder = 0, defaultValue = "" } };
        public StaticTables(SugarDataContext sugarDataContext, ILogger<StaticTables> logger, 
            StaticTableHelper staticTableHelper, IRepository repository)//
        {
            _repository = repository;
            _sugarDataContext = sugarDataContext;
            _logger = logger;
            _staticTableHelper = staticTableHelper;
        }
        public void Migrate()
        {
            GenerateRegions();
            LoadStaticFromApis();
            _logger.LogInformation("#################Starting Migration of Static tables");
        }

        private void GenerateRegions()
        {
            _logger.LogInformation($"Creating regions");

            var regions = _repository.Query<Region>().ToList();

            if (!regions.Any(x => x.Code == "USA"))
            {
                _logger.LogInformation($"Adding USA region");
                var region = new Region();
                region.Code = "USA";
                region.Description = "United States Of America";
                _repository.SaveQueue(region);
            }
            else
            {
                _logger.LogInformation($"USA found skipping");
            }

            _repository.Save();
        }


        private void LoadStaticFromApis()
        {
            var response = PostJson("https://my.taylormadegolf.com/myFittingExp/api/authentication?j_username=tmagitadmin&j_password=AtuS3VhLw2&remember-me=true&submit=Login", new { });
            var csrfToken = response.Cookies["CSRF-TOKEN"].Value;
            var jSessionId = response.Cookies["JSESSIONID"].Value;

            // flex
            var ironFlex = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Profile_Current_Shaft_Flex", response.Cookies);
            var flexString = GetDataString(ironFlex);

            
            var flexIronObjects = JsonConvert.DeserializeAnonymousType(flexString, loogUpObject);

            var ironCategoryId = _staticTableHelper.GetCategoryId("Iron");
            var driverCategoryId = _staticTableHelper.GetCategoryId("Driver");
            var fairwayCategoryId = _staticTableHelper.GetCategoryId("Fairway");
            var rescueCategoryId = _staticTableHelper.GetCategoryId("Rescue");
            var wedgeCategoryId = _staticTableHelper.GetCategoryId("Wedge");

            foreach (var item in flexIronObjects)
            {
                var i = new ClubShaftFlex();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                
                _repository.SaveQueue(i);
            }

            //drive loft
            var driverLoft = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Industry_Driver_Loft", response.Cookies);
            var driverLoftString = GetDataString(driverLoft);
            
            var driverLoftObjects = JsonConvert.DeserializeAnonymousType(driverLoftString, loogUpObject);
            
            foreach (var item in driverLoftObjects)
            {
                var i = new ClubLoft();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                i.ClubCategoryId = driverCategoryId;
                _repository.SaveQueue(i);
            }

            //fw loft
            var fwLoft = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Industry_FW_Loft", response.Cookies);
            var fwLoftString = GetDataString(fwLoft);

            var fwObjects = JsonConvert.DeserializeAnonymousType(fwLoftString, loogUpObject);

            foreach (var item in fwObjects)
            {
                var i = new ClubLoft();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                i.ClubCategoryId = fairwayCategoryId;
                _repository.SaveQueue(i);
            }

            //fw loft
            var RescueLoft = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Industry_Rescue_Loft", response.Cookies);
            var RescueLoftString = GetDataString(RescueLoft);

            var RescueObjects = JsonConvert.DeserializeAnonymousType(RescueLoftString, loogUpObject);

            foreach (var item in RescueObjects)
            {
                var i = new ClubLoft();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                i.ClubCategoryId = rescueCategoryId;
                _repository.SaveQueue(i);
            }

            //iron loft
            var ironLoft = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Industry_Iron_Loft", response.Cookies);
            var ironLoftString = GetDataString(ironLoft);

            var ironObjects = JsonConvert.DeserializeAnonymousType(ironLoftString, loogUpObject);

            foreach (var item in ironObjects)
            {
                var i = new ClubLoft();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                i.ClubCategoryId = ironCategoryId;
                _repository.SaveQueue(i);
            }
            //iron loft
            var ironLoft12 = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/WITB_Wedge_Loft", response.Cookies);
            var ironLoftString12 = GetDataString(ironLoft12);

            var ironObjects12 = JsonConvert.DeserializeAnonymousType(ironLoftString12, loogUpObject);

            foreach (var item in ironObjects12)
            {
                var i = new ClubLoft();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                i.ClubCategoryId = wedgeCategoryId;
                _repository.SaveQueue(i);
            }

            //Club shaflength
            var shaflength = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Profile_Current_Iron_Length", response.Cookies);
            var shaflengthString = GetDataString(shaflength);

            var shaflengthO = JsonConvert.DeserializeAnonymousType(shaflengthString, loogUpObject);

            foreach (var item in shaflengthO)
            {
                var i = new ClubShaftLength();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                _repository.SaveQueue(i);
            }

            //clubLie
            var clubLie = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/Profile_Current_Iron_Lie", response.Cookies);
            var clubLieString = GetDataString(clubLie);

            var clubLieStringo = JsonConvert.DeserializeAnonymousType(clubLieString, loogUpObject);

            foreach (var item in clubLieStringo)
            {
                var i = new ClubLie();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                _repository.SaveQueue(i);
            }

            LoadClubCategoryTypes(response.Cookies, ironCategoryId, "WITB_Iron_Head_Loft");
            LoadClubCategoryTypes(response.Cookies, fairwayCategoryId, "WITB_FW_Head_Loft");
            LoadClubCategoryTypes(response.Cookies, rescueCategoryId, "WITB_Rescue_Head_Loft");
            LoadClubCategoryTypes(response.Cookies, wedgeCategoryId, "WITB_Wedge_Head_Loft");

            LoadClubLoftAdjustment(response.Cookies);

            var putterCategoryId = _staticTableHelper.GetCategoryId("Putter");

            LoadClubBrands(response.Cookies, 1, driverCategoryId);
            LoadClubBrands(response.Cookies,2, ironCategoryId);
            LoadClubBrands(response.Cookies, 3, fairwayCategoryId);
            LoadClubBrands(response.Cookies, 4, rescueCategoryId);
            LoadClubBrands(response.Cookies, 5, putterCategoryId);
            LoadClubBrands(response.Cookies, 6, wedgeCategoryId);

            _repository.Save();
        }

        private void LoadClubCategoryTypes(CookieCollection cookies, Guid ironCategoryId, string urlEnd)
        {
            var response = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/" + urlEnd, cookies);
            var stringData = GetDataString(response);

            var objs = JsonConvert.DeserializeAnonymousType(stringData, loogUpObject);

            foreach (var item in objs)
            {
                var i = new ClubCategoryType();
                i.Type = item.lookupValue;
                i.SortOrder = item.sortOrder;
                i.ClubCategoryId = ironCategoryId;
                _repository.SaveQueue(i);
            }
        }
        private void LoadClubLoftAdjustment(CookieCollection cookies)
        {
            var response = GetJson("https://my.taylormadegolf.com/myFittingExp/api/lookups_by_type/WITB_Face_Loft_Adjustment", cookies);
            var stringData = GetDataString(response);

            var objs = JsonConvert.DeserializeAnonymousType(stringData, loogUpObject);

            foreach (var item in objs)
            {
                var i = new ClubLoftAdjustment();
                i.Value = item.lookupValue;
                i.SortOrder = item.sortOrder;
                _repository.SaveQueue(i);
            }
        }
        private void LoadClubBrands(CookieCollection cookies, int typeId, Guid clubCategoryId)
        {
            var response = GetJson("https://my.taylormadegolf.com/myFittingExp/api/headModels/brands/clubs/" + typeId, cookies);
            var stringData = GetDataString(response);
            var lObj = new[] { new { id = 0, name = "" } };
            var objs = JsonConvert.DeserializeAnonymousType(stringData, lObj);

            foreach (var item in objs)
            {
                var i = new Brand();
                i.Name = item.name;
                i.ClubCategoryId = clubCategoryId;
                i.Models = LoadClubBrandModels(cookies, typeId, item.id);
                _repository.SaveQueue(i);
            }
        }
        private List<Model> LoadClubBrandModels(CookieCollection cookies, int typeId, int brandId)
        {
            var response = GetJson($"https://my.taylormadegolf.com/myFittingExp/api/headModels/brand/{brandId}/clubType/{typeId}", cookies);
            var stringData = GetDataString(response);
            var lObj = new[] { new { id = 0, name = "" } };
            var objs = JsonConvert.DeserializeAnonymousType(stringData, lObj);
            List<Model> models = new List<Model>();
            foreach (var item in objs)
            {
                var i = new Model();
                i.Name = item.name;
                models.Add(i);
            }
            return models;
        }


        public HttpWebResponse PostJson(string url, dynamic data)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";
            if (httpWebRequest.CookieContainer == null)
                httpWebRequest.CookieContainer = new CookieContainer();
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = data != null ? JsonConvert.SerializeObject(data) : "";

                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            return httpResponse;
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var responseText = streamReader.ReadToEnd();

            //    return true;
            //}
        }
        public HttpWebResponse GetJson(string url, CookieCollection cookies)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            if (httpWebRequest.CookieContainer == null)
                httpWebRequest.CookieContainer = new CookieContainer();

            httpWebRequest.CookieContainer.Add(cookies);

            
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
