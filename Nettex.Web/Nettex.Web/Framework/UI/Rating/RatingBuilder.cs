﻿using System.Web.Mvc;

namespace Nettex.WebMVC.Framework.UI
{
    public class RatingBuilder : ViewComponentBuilderBase<Rating, RatingBuilder>
    {
        public RatingBuilder(HtmlHelper htmlHelper, Rating model) : base(htmlHelper, model)
        { 
        }

        public RatingBuilder Rate(RatingRate rate) // optional method
        {
            this.Component.Rate = rate;
            return this;
        }
    }
}