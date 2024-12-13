using System;
using System.Collections.Generic;
using System.Text;

namespace TrackItemAttribute
{
    public class Leaderline
    {
        public EnumColor Fg { get; set; }
        public EnumColor Bg { get; set; }

        public override string ToString()
        {
            return $"Fg: {Fg}, Bg: {Bg}";
        }
    }
}
