﻿using Nettex.WebMVC.Framework.Utilities;

namespace Nettex.WebMVC.Framework.UI
{
    public class Page : ViewComponentBase
    {
        public string Title { get; set; }

        /// <summary>
        /// Page style sheets path.
        /// </summary>
        public string Css { get; set; }

        /// <summary>
        /// Page scripts path
        /// </summary>
        public string Script { get; set; }

        public BootstrapColor? BgColor { get; set; }

        public override void GenerateHtmlAtributes()
        {
            if (this.BgColor.HasValue)
            {
                this.AppendCssClass(string.Format("bg-{0}", this.BgColor.Value.ToCssClass()));
            }
        }
    }
}