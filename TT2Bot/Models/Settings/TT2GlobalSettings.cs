﻿namespace TT2Bot.Models
{
    class TT2GlobalSettings
    {
        public string ImageRegex { get; set; }
        public ulong BotBugChannel { get; set; }
        public ulong BotSuggestChannel { get; set; }
        public ulong GHFeedbackChannel { get; set; }
        public DataFileVersions FileVersions { get; set; } = new DataFileVersions();
        public string DefaultVersion { get; set; } = "1.7";

        public class DataFileVersions
        {
            public string Artifact { get; set; }
            public string Pet { get; set; }
            public string Helper { get; set; }
            public string Equipment { get; set; }
            public string HelperSkill { get; set; }
        }
    }
}
