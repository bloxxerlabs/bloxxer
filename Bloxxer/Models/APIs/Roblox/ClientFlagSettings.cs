﻿namespace Bloxxer.Models.APIs.Roblox
{
    public class ClientFlagSettings
    {
        [JsonPropertyName("applicationSettings")]
        public Dictionary<string, string>? ApplicationSettings { get; set; }
    }
}
