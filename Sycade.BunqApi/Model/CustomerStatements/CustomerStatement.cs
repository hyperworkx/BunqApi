﻿using Newtonsoft.Json;
using System;

namespace Sycade.BunqApi.Model.CustomerStatements
{
    public class CustomerStatement : BunqEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("date_start")]
        public DateTime DateStart { get; set; }
        [JsonProperty("date_end")]
        public DateTime DateEnd { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}