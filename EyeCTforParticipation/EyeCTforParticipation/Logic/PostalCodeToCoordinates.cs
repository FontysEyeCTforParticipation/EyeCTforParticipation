using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Net;
using Newtonsoft.Json;

namespace EyeCTforParticipation.Logic
{
    public class PostalCodeToCoordinates
    {
        static public GeoCoordinate Get(string postalCode)
        {
            using (WebClient wc = new WebClient())
            {
                GoogleMapsApi googleMapsAPI = JsonConvert.DeserializeObject<GoogleMapsApi>(wc.DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + postalCode + "+Netherlands"));
                if(googleMapsAPI.Succes)
                {
                    return new GeoCoordinate(googleMapsAPI.results[0].geometry.location.lat, googleMapsAPI.results[0].geometry.location.lng);
                }
            }

            return null;
        }
    }

    public class GoogleMapsApi
    {
        public class Result
        {
            public class Geometry
            {
                public class Location
                {
                    public double lat;
                    public double lng;
                }
                public Location location;
            }
            public Geometry geometry;
        }
        public List<Result> results;
        public bool Succes;

        public string Status
        {
            set
            {
                Succes = value == "OK" ? true : false;
            }
        }
    }
}
