﻿using System.Text.Json.Serialization;

namespace BuildSteps.ReSharperInspection
{
    public class ReSharperInspectionUserConfig : IBuildStepUserConfig
    {
        [JsonIgnore]
        public string StepName => "ReSharperInspection";

        public bool Enabled { get; set; } = true;
    }
}