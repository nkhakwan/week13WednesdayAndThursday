using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcApiCall.Models
  {

    public class Place
    {
      public int PlaceId { get; set; }
      public string City { get; set; }
      public string Country { get; set; }
      public string Description { get; set; }
      public int Rating { get; set; }
      public string ImageUrl { get; set; }
      

      
      public static List<Place> GetPlaces()
      {
        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||Hey i am in GetPlaces of Plcaes.cs");
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;
        if(result == null)
        {
          Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||Wow got null in getplaces");
        }
          Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||Wow didn't get null");
        

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Place> placeList = JsonConvert.DeserializeObject<List<Place>>(jsonResponse.ToString());
        Console.WriteLine($"|||||||||||||||||||||||||||||||||||||||||||||||{placeList[0].City}");
        return placeList;
      }

      public static Place GetDetails(int id)
      {
        var apiCallTask = ApiHelper.Get(id);
        var result = apiCallTask.Result;

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        Place place = JsonConvert.DeserializeObject<Place>(jsonResponse.ToString());

        return place;
      }


      public static void Post(Place place)
      {
        string jsonPlace = JsonConvert.SerializeObject(place);
        var apiCallTask = ApiHelper.Post(jsonPlace);
      }

      public static void Put(Place place)
      {
        string jsonPlace = JsonConvert.SerializeObject(place);
        var apiCallTask = ApiHelper.Put(place.PlaceId, jsonPlace);
      }

      
    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  
  }
  }
  





  
 

