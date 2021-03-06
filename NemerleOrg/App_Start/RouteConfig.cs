﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NemerleOrg
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
          name: "Banners",
          url: "Banners/{action}",
          defaults: new { controller = "Banners", action = "Index" }
      );

      routes.MapRoute(
          name: "Download",
          url: "Download/{buildConfiguration}/{buildId}/{name}",
          defaults: new { controller = "Home", action = "Download" }
      );

      routes.MapRoute(
          name: "Default",
          url: "{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}