using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nettex.WebMVC.Framework.Utilities;

namespace Nettex.WebMVC.Framework.UI
{
    public class Breadcrumb : ViewComponentBase
    {
        public override void GenerateHtmlAtributes()
        { 
        }
    }

    public enum BreadcrumbAlign
    {
        Left,
        Center,
        Right
    }
}