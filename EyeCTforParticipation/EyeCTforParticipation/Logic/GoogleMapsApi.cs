using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using System.Net;
using Newtonsoft.Json;
using System.Device.Location;

namespace EyeCTforParticipation.Logic
{
    class GoogleMapsApi
    {
        static public Response Get(string address)
        {
            using (WebClient wc = new WebClient())
            {
                Response response = JsonConvert.DeserializeObject<Response>(wc.DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + address));
                if (response.Succes)
                {
                    return response;
                }
            }

            return null;
        }
        public class Response
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

            public List<Result> results
            {
                set
                {
                    Location = new GeoCoordinate(value[0].geometry.location.lat, value[0].geometry.location.lng);
                }
            }

            public string formatted_address
            {
                set
                {
                    Address = value;
                }
            }

            public string Status
            {
                set
                {
                    Succes = value == "OK" ? true : false;
                }
            }

            public GeoCoordinate Location;
            public string Address;
            public bool Succes;
        }
    }
}
