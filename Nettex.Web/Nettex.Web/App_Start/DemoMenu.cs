using System.Web;
using System.Web.Mvc;
using Nettex.WebMVC.Framework.UI;

namespace Nettex.WebMVC
{
    public partial class DemoMenu
    {
        public static Nav GetDemoMenu()
        {
            var nav = new Nav();
            var url = new UrlHelper(HttpContext.Current.Request.RequestContext);

            var homes = new Dropdown("Home")
            {
                Dropdowns = {
                   new Dropdown("Home - Variation 1", url.Action("Index", "Home")),
                   new Dropdown("Home - Variation 2", url.Action("Index2", "Home")),
                   new Dropdown("Home - Variation 3", url.Action("Index3", "Home")),
                   new Dropdown("Home - Variation 4", url.Action("Index4", "Home")),
                   new Dropdown("Home - Variation 5", url.Action("Index5", "Home")),
                   new Dropdown("Home - Variation 6", url.Action("Index6", "Home")),
                   new Dropdown("Home - Variation 7", url.Action("Index7", "Home")),
                   new Dropdown("Home - Variation 8", url.Action("Index8", "Home")),
                   new Dropdown("Home - Variation 9", url.Action("Index9", "Home")),
                   new Dropdown("Home - Variation 10", url.Action("Index10", "Home")),
                   new Dropdown("Home - Variation 11", url.Action("Index11", "Home")),
                   new Dropdown("Home - Variation 12", url.Action("Index12", "Home")),
                   new Dropdown("Home - Variation 13", url.Action("Index14", "Home")),
                   new Dropdown("Home - Event", url.Action("Index13", "Home"))
                }
            };
            var pages = new Dropdown("Pages")
            {
                Dropdowns = {
                   new Dropdown("About") {
                       Dropdowns = {
                          new Dropdown("About Us", url.Action("AboutUs", "Page")),
                          new Dropdown("About Me", url.Action("AboutMe", "Page"))
                       }
                   },
                   new Dropdown("Contact") {
                       Dropdowns = {
                          new Dropdown("Contact Us", url.Action("ContactUs", "Page")),
                          new Dropdown("Contact Us 2", url.Action("ContactUs2", "Page")),
                          new Dropdown("Contact Us 3", url.Action("ContactUs3", "Page"))
                       }
                   },
                   new Dropdown("Services", url.Action("Services", "Page")),
                   new Dropdown("Team", url.Action("Team", "Page")),
                   new Dropdown("Jobs", url.Action("Jobs", "Page")),
                   new Dropdown("Help", url.Action("Help", "Page")),
                   new Dropdown("Pricing", url.Action("Pricing", "Page")),
                   new Dropdown("FAQs", url.Action("Faqs", "Page")),
                   new Dropdown("Page 404", url.Action("Category", "Blog")),
                }
            };
            var blog = new Dropdown("Blog")
            {
                Dropdowns = {
                   new Dropdown("Card") {
                       Dropdowns = {
                          new Dropdown("Left Sidebar", url.Action("CardLeftSidebar", "Blog")),
                          new Dropdown("Right Sidebar", url.Action("CardRightSidebar", "Blog")),
                          new Dropdown("Full Width", url.Action("CardFullWidth", "Blog"))
                       }
                   },
                   new Dropdown("Grid") {
                       Dropdowns = {
                          new Dropdown("Left Sidebar", url.Action("GridLeftSidebar", "Blog")),
                          new Dropdown("Right Sidebar", url.Action("GridRightSidebar", "Blog")),
                          new Dropdown("Full Width", url.Action("GridFullWidth", "Blog"))
                       }
                   },
                   new Dropdown("List") {
                       Dropdowns = {
                          new Dropdown("Left Sidebar", url.Action("ListLeftSidebar", "Blog")),
                          new Dropdown("Right Sidebar", url.Action("ListRightSidebar", "Blog")),
                          new Dropdown("Full Width", url.Action("ListFullWidth", "Blog"))
                       }
                   },
                   new Dropdown("Single") {
                       Dropdowns = {
                          new Dropdown("Video", "/this-is-vide-post-example-with-default-view"),
                          new Dropdown("Audio", "/audio-post-example-with-default-view"),
                          new Dropdown("Quote", "/this-is-quote-post-with-center-view"),
                          new Dropdown(DropdownType.Divider),
                          new Dropdown("Center View", "/mobile-friendly-design"),
                          new Dropdown("Standard View", "/new-es2019-features-every-javascript-developer-should-know"),
                          new Dropdown("Fullwidth View", "/whats-new-in-life"),
                          new Dropdown("Fullwidth No Sidebar", "/10-best-games-for-console-2019")
                       }
                   }
                }
            };
            var portfolio = new Dropdown("Portfolio")
            {
                Dropdowns = {
                   new Dropdown("Agency", url.Action("Agency", "Portfolio")),
                   new Dropdown("Awesome Work", url.Action("AwesomeWork", "Portfolio")),
                   new Dropdown("Masonry", url.Action("Masonry", "Portfolio")),
                }
            };
            var features = new Dropdown("Features", url.Action("Index", "Features"))
            {
                Dropdowns = {
                    new Dropdown("<strong>Features</strong>", url.Action("Index", "Features")),
                    new Dropdown(DropdownType.Divider),
                    new Dropdown("Blog Post", url.Action("BlogPost", "Features")),
                    new Dropdown("Portfolio", url.Action("Portfolio", "Features")),
                    new Dropdown("Team Member", url.Action("TeamMember", "Features")),
                    new Dropdown("Clients", url.Action("Clients", "Features")),
                    new Dropdown("Testimonials", url.Action("Testimonials", "Features")),
                    new Dropdown("Jobs", url.Action("Jobs", "Features")),
                }
            };

            var doc = new Dropdown("Docs", "/Documentation/introduction.html");

            nav.Dropdowns.Add(homes);
            nav.Dropdowns.Add(pages);
            nav.Dropdowns.Add(blog);
            nav.Dropdowns.Add(portfolio); 
            nav.Dropdowns.Add(features);
            nav.Dropdowns.Add(doc);

            return nav;
        }
    }
}