using System.Web.Mvc;
using Nettex.Core.Entities;
using Nettex.Core.Infrastructure;
using Nettex.Service;

namespace Nettex.WebMVC.Framework.UI
{
    public class UserShortInfoBuilder : ViewComponentBuilderBase<UserShortInfo, UserShortInfoBuilder>
    {
        private readonly ApplicationUserService userService;

        public UserShortInfoBuilder(HtmlHelper htmlHelper, UserShortInfo model)
            : base(htmlHelper, model)
        {
            userService = Engine.Resolve<ApplicationUserService>();
        }

        public override string ToHtmlString()
        {

            return base.ToHtmlString();
        }

        public UserShortInfoBuilder User(ApplicationUser user)
        {
            this.Component.User = user;
            return this;
        }

        public UserShortInfoBuilder User(string userName)
        {
            var user = userService.GetByUserName(userName);
            this.Component.User = user;
            return this;
        }
    }
}