using System;
using System.Collections.Generic;
using System.Text;

namespace Paging.Models
{

    public enum PlatformType    { 
        Arcade,
        Board,
        PC,
        Console,
        Handheld,
        Mobile
}
    public class GameData
    {
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public float Rating { get; set; }
        public PlatformType Platform { get; set; }
        public string System { get; set; }
        public string About { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
