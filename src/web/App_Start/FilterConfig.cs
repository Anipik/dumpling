﻿using System.Web;
using System.Web.Mvc;

namespace dumpling.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new telemetry.AiHandleErrorAttribute());
        }
    }
}
