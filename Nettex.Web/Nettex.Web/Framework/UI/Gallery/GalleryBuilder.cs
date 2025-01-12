using System.Web.Mvc;
using Nettex.WebMVC.Framework.UI;

namespace Nettex.WebMVC.Framework.UI
{
    public class GalleryBuilder : ViewComponentBuilderBase<Gallery, GalleryBuilder>
    {
        public GalleryBuilder(HtmlHelper htmlHelper, Gallery model) : base(htmlHelper, model)
        { 
        }
    }
}