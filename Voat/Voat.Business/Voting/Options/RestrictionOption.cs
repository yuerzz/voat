﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voat.Voting.Options
{
    public abstract class RestrictionOption : Option
    {
        public DateTime CutOffDate { get; set; }
        public TimeSpan Duration { get; set; }
        [JsonIgnore]
        public DateTime StartDate { get => CutOffDate.Subtract(Duration); }
    }
}