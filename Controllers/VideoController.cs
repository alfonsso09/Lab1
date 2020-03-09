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

        [HttpPost]
        public ActionResult Create(int idvideo,
                                   string titulo,
                                   int repro,
                                   string url)
        {
            //Guardar el video 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("insert into video values(@idvideo, @titulo, @repro, @url)",
                                          CommandType.Text, parametros);

            return View();
        }

        public ActionResult Eliminar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Eliminar(int idvideo)
        {
            //Eliminar un video ya existente
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));

            BaseHelper.ejecutarSentencia("delete from video where idvideo=@idvideo",
                                         CommandType.Text, parametros);
            return View();
        }

        public ActionResult Actualizar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Actualizar(int idvideo,
                                   string titulo,
                                   int repro,
                                   string url)
        {
            //Actualizar los datos de un video ya creado
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("UPDATE video SET titulo=@titulo, repro=@repro, url=@url WHERE idvideo=@idvideo",
                                         CommandType.Text, parametros);
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
