﻿using System.Web;
using System.Web.Mvc;

namespace _10_25_Ex1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
