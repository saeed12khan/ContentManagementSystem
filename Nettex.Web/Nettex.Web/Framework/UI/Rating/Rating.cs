﻿namespace Nettex.WebMVC.Framework.UI
{
    public class Rating : ViewComponentBase
    {
        public RatingRate Rate { get; set; }

        public override void GenerateHtmlAtributes()
        {
        }
    }

    public enum RatingRate
    {
        One,
        Two,
        Three,
        Four,
        Five
    }
}