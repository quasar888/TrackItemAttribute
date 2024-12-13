using System;
using System.Collections.Generic;
using System.Text;

namespace TrackItemAttribute
{
    public class Position_Symbol
    {
        public object Visibility { get; set; }
        public EnumColor Fg { get; set; }
        public EnumColor Bg { get; set; }
        public object Shape_Of_Symbol { get; set; }
        public Action Symbol_Action { get; set; }

        public override string ToString()
        {
            return $"Visibility: {Visibility}, Fg: {Fg}, Bg: {Bg}, Shape: {Shape_Of_Symbol}";
        }
    }

}
