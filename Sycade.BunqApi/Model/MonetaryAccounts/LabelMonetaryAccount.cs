﻿using Newtonsoft.Json;
using Sycade.BunqApi.Model.Users;

namespace Sycade.BunqApi.Model.MonetaryAccounts
{
    public class LabelMonetaryAccount : BunqEntity
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }
        [JsonProperty("is_light")]
        public bool? IsLight { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }

        [JsonProperty("label_user")]
        public LabelUser LabelUser { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("bunq_me")]
        public Alias BunqMe { get; set; }

        internal LabelMonetaryAccount() { }
    }
}
