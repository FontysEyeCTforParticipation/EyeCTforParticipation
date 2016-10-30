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
                object googleMapsAPI = JsonConvert.DeserializeObject(wc.DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + postalCode + "+Netherlands"));
            }

            return new GeoCoordinate();
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
        bool status;
    }
}
