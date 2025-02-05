﻿using Nettex.WebMVC.Framework.Utilities;

namespace Nettex.WebMVC.Framework.UI
{
    public class Badge: ViewComponentBase
    {
        public Badge()
        {
            this.BSColor = BootstrapColor.Secondary;
        }

        public string Text { get; set; }
        public BootstrapColor BSColor { get; set; }

        public override void GenerateHtmlAtributes()
        {
            this.AppendCssClass(string.Format("badge-{0}", this.BSColor.ToCssClass()));
        }
    } 
}