﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevBuild_Assessment6_PutMeOnTheList.Models
{

    public class RootObject
    {
        public CharacterSheet[] CharacterSheet { get; set; }
    }

    public class CharacterSheet
    {
        public string url { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string culture { get; set; }
        public string born { get; set; }
        public string died { get; set; }
        public string[] titles { get; set; }
        public string[] aliases { get; set; }
        public string father { get; set; }
        public string mother { get; set; }
        public string spouse { get; set; }
        public string[] allegiances { get; set; }
        public string[] books { get; set; }
        public object[] povBooks { get; set; }
        public string[] tvSeries { get; set; }
        public string[] playedBy { get; set; }
    }

}