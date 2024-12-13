using System;
using System.Collections.Generic;
using System.Text;

namespace TrackItemAttribute
{
    public class History_Dots
    {
        public object Visibility { get; set; }
        public EnumColor Fg { get; set; }
        public EnumColor Bg { get; set; }
        public object Symbol { get; set; }

        public override string ToString()
        {
            return $"Visibility: {Visibility}, Fg: {Fg}, Bg: {Bg}, Symbol: {Symbol}";
        }
    }
}
