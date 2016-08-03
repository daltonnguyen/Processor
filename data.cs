using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public class data
    {
        [JsonProperty("type")]
        public string type {get;set;}

        [JsonProperty("time")]
        public time time;

        [JsonProperty("event_id")]
        public string event_id { get; set; }

        [JsonProperty("device")]
        public device device { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }


      
       
    }

    public class user_interaction
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("view_id")]
        public string view_id { get; set; }

    }

    public class time
    {
        [JsonProperty("create_timestamp")]
        public string createTimestamp { get; set; }

        [JsonProperty("send_timestamp")]
        public string sendTimestamp { get; set; }
    }

    public class device
    {
        [JsonProperty("operating_system")]
        public operatingSystem operatinSgystem;

        [JsonProperty("manufacturer")]
        public string manufacturer { get; set; }

        [JsonProperty("model")]
        public string model { get; set; }

        [JsonProperty("display_resolution")]
        public displayresolution displayResolution;

        [JsonProperty("device_id")]
        public string deviceId { get; set; }

        [JsonProperty("language")]
        public string language { get; set; }

        [JsonProperty("timezone")]
        public string timezone { get; set; }

        [JsonProperty("rooted")]
        public string rooted { get; set; }
        
        public class operatingSystem 
        {
            [JsonProperty("kind")]
            public string kind { get; set; }

            [JsonProperty("version")]
            public string version { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }
        }


        public class displayresolution
        {
            [JsonProperty("width")]
            public string width { get; set; }

            [JsonProperty("height")]
            public string height { get; set; }

        }
    }

    public class application
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("version")]
        public string version { get; set; }

        [JsonProperty("package_name")]
        public string package_name { get; set; }

        [JsonProperty("language")]
        public string language { get; set; }
    }

    public class consent
    {
        [JsonProperty("product_improvement")]
        public string productImprovement { get; set; }

        [JsonProperty("tips")]
        public string tips { get; set; }

        [JsonProperty("offers")]
        public string offers { get; set; }
    }

    public class network
    {
        [JsonProperty("carrier")]
        public string carrier { get; set; }

        [JsonProperty("connection")]
        public string connection { get; set; }
    }

    public class senderInfo
    {
        [JsonProperty("agent")]
        public string agent { get; set; }

        [JsonProperty("received_timestamp")]
        public long receivedTimestamp { get; set; }

        [JsonProperty("ip")]
        public string ip { get; set; }

        [JsonProperty("geo")]
        public geo Geo;

        public class senderDevice
        {
            [JsonProperty("os")]
            public string os { get; set; }

            [JsonProperty("phone")]
            public string phone { get; set; }

            [JsonProperty("tablet")]
            public string tablet { get; set; }

            [JsonProperty("user_agent")]
            public string userAgent { get; set; }
        }

        public class geo
        {
            [JsonProperty("range")]
            public string[] range { get; set; }
           
            [JsonProperty("country")]
            public string country { get; set; }

            [JsonProperty("region")]
            public string region { get; set; }

            [JsonProperty("city")]
            public string city { get; set; }

            [JsonProperty("ll")]
            public string[] ll { get; set; }

            [JsonProperty("metro")]
            public string metro { get; set; }
        }
    }

    public class system
    {
        [JsonProperty("deployment_name")]
        public string deploymentName { get; set; }
    }
}
