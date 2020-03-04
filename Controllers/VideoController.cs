using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Eliminar()
        {
            return View();
        }

        public ActionResult Actualizar()
        {
            return View();
        }

        public ActionResult Mostrar()
        {
            //Consultar los datos de BD
            ViewData["datavideo"] = BaseHelper.ejecutarConsulta("select * from video", CommandType.Text);

            return View();
        }

    }
}
