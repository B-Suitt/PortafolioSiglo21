using Siglo21.DALC;
using Siglo21.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Siglo21.Controllers
{
    public class BodegaController : Controller
    {
        // GET: Bodega
        public ActionResult HomeBodega()
        {
            return View();
        }


        public ActionResult ListarInsumo()
        {
            List<Insumo> listaInsumo = new List<Insumo>();
            using (var db = new SigloXXIEntities())
            {
                    listaInsumo = (from insumo in db.INSUMO
                                   select new Insumo
                                   {
                                       Id_Insumo = insumo.ID_INSUMO,
                                       Nombre_Insumo = insumo.NOMBRE_INSUMO,
                                       Descripcion = insumo.DESCRIPCION,
                                       Precio_Unitario = insumo.PRECIO_UNITARIO,
                                       Stock = insumo.STOCK
                                   }).ToList();
                
            }
            return View(listaInsumo);
        }

        public ActionResult EliminarInsumo(int id)
        {
            using (var db = new SigloXXIEntities())
            {
                db.SP_DELETE_INSUMO(id);

            }
            return RedirectToAction("ListarInsumo");
        }

        public ActionResult ModificarInsumo(int id)
        {
            if (id is null)
            {
                return RedirectToAction("ListarUsuario");
            }
            else
            {
                using (var db = new SigloXXIEntities())
                {
                    ViewBag.ListaUsuario = db.USUARIO
                        .Where(s => s.ID_USUARIO == id)
                        .First();
                }
                return View();
            }
        }

        public ActionResult FiltroInsumo(string nombre)
        {
            List<Insumo> listaInsumo = new List<Insumo>();
            using (var db = new SigloXXIEntities())
            {
                if (nombre == null)
                    listaInsumo = (from insumo in db.INSUMO
                                   select new Insumo
                                   {
                                       Id_Insumo = insumo.ID_INSUMO,
                                       Nombre_Insumo = insumo.NOMBRE_INSUMO,
                                       Descripcion = insumo.DESCRIPCION,
                                       Precio_Unitario = insumo.PRECIO_UNITARIO,
                                       Stock = insumo.STOCK
                                   }).ToList();
                else
                    listaInsumo = (from insumo in db.INSUMO
                                   where insumo.NOMBRE_INSUMO.Contains(nombre)
                                   select new Insumo
                                   {
                                       Id_Insumo = insumo.ID_INSUMO,
                                       Nombre_Insumo = insumo.NOMBRE_INSUMO,
                                       Descripcion = insumo.DESCRIPCION,
                                       Precio_Unitario = insumo.PRECIO_UNITARIO,
                                       Stock = insumo.STOCK
                                   }).ToList();
            }
            return PartialView("_ListarInsumo", listaInsumo);
        }
    }

}