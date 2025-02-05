﻿using System.Web.Mvc;
using Nettex.WebMVC.Framework.Utilities;

namespace Nettex.WebMVC.Framework.UI
{
    public class SpinnerBuilder : ViewComponentBuilderBase<Spinner, SpinnerBuilder>
    {
        public SpinnerBuilder(HtmlHelper htmlHelper, Spinner model)
            : base(htmlHelper, model) { }

        public SpinnerBuilder Color(BootstrapColor color)
        {
            this.Component.Color = color;
            return this;
        }

        public SpinnerBuilder Text(string text)
        {
            this.Component.Text = text;
            return this;
        }

        public SpinnerBuilder Growing()
        {
            this.Component.Growing = true;
            return this;
        }

        public SpinnerBuilder Size(SpinnerSize size)
        {
            this.Component.Size = size;
            return this;
        }
    }
}