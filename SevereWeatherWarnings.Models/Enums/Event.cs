﻿using System.ComponentModel;

namespace SevereWeatherWarnings.Models.Enums
{
    public enum Event
    {
        [Description("Blowing Dust Warning")]
        BlowingDustWarning = 1,
        FlashFloodStatement = 38,
        [Description("Flash Flood Warning")]
        FlashFloodWarning = 39,
        FlashFloodWatch = 40,
        SevereThunderstormWarning = 90,
        SevereThunderstormWatch = 91,
        SevereWeatherStatement = 92,
        TornadoWarning = 108,
        TornadoWatch = 109
    }
}
