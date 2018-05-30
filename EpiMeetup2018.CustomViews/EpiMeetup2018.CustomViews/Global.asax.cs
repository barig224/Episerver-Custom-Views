using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace EpiMeetup2018.CustomViews
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)

            CreateDefaultRolesAndUser();
        }

        private void CreateDefaultRolesAndUser()
        {
            var adminRole = "WebAdmins";
            var editRole = "WebEditors";

            var username = "localadmin";
            var password = "Abc123";
            var email = "admin@localhost.com";

            if (!Roles.RoleExists(adminRole))
            {
                Roles.CreateRole(adminRole);
            }

            if (!Roles.RoleExists(editRole))
            {
                Roles.CreateRole(editRole);
            }

            if (Membership.GetUser(username) == null)
            {
                var user = Membership.CreateUser(username, password, email);
                user.IsApproved = true;
            }

            if (!Roles.IsUserInRole(username, adminRole))
            {
                Roles.AddUserToRole(username, adminRole);
            }
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            base.RegisterRoutes(routes);

            routes.MapRoute(
                     "ProductionInfo",
                     "ProductionInfo",
                     new { controller = "ProductionInfo", action = "index" }
                 );

            routes.MapRoute(
                     "AboutThisPageType",
                     "AboutThisPageType",
                     new { controller = "AboutThisPageType", action = "index" }
                );

            routes.MapRoute(
                     "SEOProperties",
                     "SEOProperties/{action}",
                     new { controller = "SEOProperties", action = "index" }
                );

            routes.MapRoute(
                 "HeroEditor",
                 "HeroEditor/{action}",
                 new { controller = "HeroEditor", action = "index" }
            );
        }
    }
}