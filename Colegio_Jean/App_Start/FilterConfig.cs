﻿using Colegio_Jean.filtros;
using System.Web;
using System.Web.Mvc;

namespace Colegio_Jean
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new VerificarLogueo());
        }
    }
}
