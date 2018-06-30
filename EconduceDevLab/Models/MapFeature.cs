namespace EconduceDevLab.Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class MapFeature
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public partial class Geometry
    {
        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public partial class Properties
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("geodata")]
        public object Geodata { get; set; }

        [JsonProperty("empty_docks")]
        public long EmptyDocks { get; set; }

        [JsonProperty("occupied_docks")]
        public long OccupiedDocks { get; set; }

        [JsonProperty("full")]
        public bool Full { get; set; }

        [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Open { get; set; }

        [JsonProperty("today_hours", NullValueHandling = NullValueHandling.Ignore)]
        public string TodayHours { get; set; }

        [JsonProperty("parent_feature_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentFeatureId { get; set; }
    }
}
