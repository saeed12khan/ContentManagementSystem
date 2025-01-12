using Nettex.Core.Entities;

namespace Nettex.WebMVC.Framework.UI
{
    public class UserShortInfo : ViewComponentBase
    {
        public UserShortInfo()
        {

        }

        public ApplicationUser User { get; set; }

        public override void GenerateHtmlAtributes()
        { 
        }
    }
}