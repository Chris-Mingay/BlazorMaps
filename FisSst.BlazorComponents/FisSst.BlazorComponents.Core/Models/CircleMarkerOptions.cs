﻿namespace FisSst.BlazorMaps.Models
{
    public class CircleMarkerOptions : PathOptions
    {
        public CircleMarkerOptions()
        {
            Fill = true;
            Radius = 10;
        }

        public double Radius { get; init; }
    }
}
