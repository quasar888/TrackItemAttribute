using System;

namespace TrackItemAttribute
{
    public class Speed_Vector
    {
        public object Visibility { get; set; }
        public EnumColor Fg { get; set; }
        public EnumColor Bg { get; set; }

        public override string ToString()
        {
            return $"Visibility: {Visibility}, Fg: {Fg}, Bg: {Bg}";
        }
    }
}
