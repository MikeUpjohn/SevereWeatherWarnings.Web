﻿using System.ComponentModel;

namespace SevereWeatherWarnings.Models.Display.Enums
{
    public enum WarningParameterType
    {
        [Description("Wind Threat")]
        WindThreat = 1,

        [Description("Max Wind Gust")]
        MaxWindGust = 2,
        [Description("Hail Threat")]
        HailThreat = 3,
        [Description("Max Hail Size")]
        MaxHailSize = 4,
        [Description("Thunderstorm Damage")]
        ThunderstormDamage = 5,
        TornadoDetection = 6,
        TornadoDamageThreat = 7,
        FlashFloodDetection = 8,
        FlashFloodDamage = 9,
        SnowSquallDetection = 10,
        SnowSquallImpact = 11,
        WaterspoutDetection = 12
    }
}
