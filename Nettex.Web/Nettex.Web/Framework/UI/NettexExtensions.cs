using System;
using System.Web.Mvc;

namespace Nettex.WebMVC.Framework.UI
{
    public static class NettexExtensions
    {
        public static NettexHelper Nettex(this HtmlHelper htmlHelper)
        {
            var Nettex = new NettexHelper(htmlHelper);
            return Nettex;
        }

        public static NettexHelper<TModel> Nettex<TModel>(this HtmlHelper<TModel> htmlHelper)
        {
            var Nettex = new NettexHelper<TModel>(htmlHelper);
            return Nettex;
        }
    }

    public class NettexHelper
    {
        public NettexHelper(HtmlHelper htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }

        public HtmlHelper HtmlHelper { get; set; }
    }

    public class NettexHelper<TModel> : NettexHelper
    {
        public NettexHelper(HtmlHelper<TModel> htmlHelper)
            : base(htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }

        public new HtmlHelper<TModel> HtmlHelper { get; set; }
    }
}