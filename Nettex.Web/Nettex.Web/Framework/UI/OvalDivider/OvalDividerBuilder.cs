﻿using System.Web.Mvc; 

namespace Nettex.WebMVC.Framework.UI
{
    public class OvalDividerBuilder : ViewComponentBuilderBase<OvalDivider, OvalDividerBuilder>
    {
        public OvalDividerBuilder(HtmlHelper htmlHelper, OvalDivider model) : base(htmlHelper, model)
        { 
        }

        public OvalDividerBuilder Position(OvalDividerPosition position)
        {
            this.Component.Position = position;
            return this;
        }
    }
}