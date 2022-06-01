using Siglo21.DALC;
using Siglo21.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Siglo21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            Usuario ouser = new Usuario();
            ouser = (Usuario)Session["User"];
            if(ouser == null)
            {
                ViewBag.login = 0;
            }
            else
            {
                ViewBag.login = 1;
            }
            try
            {
                using (var db = new SigloXXIEntities())
                {
                    var ousuario = (from user in db.USUARIO
                                    where user.USERNAME == usuario.Username.Trim() && user.PASSWORD == usuario.Password.Trim()
                                    select user).FirstOrDefault();
                    if(ousuario == null)
                    {
                        ViewBag.Error = "Usuario o contraseña incorrecto";
                        return View();
                    }
                    Session["User"] = ousuario;
                }
                return RedirectToAction("ListarUsuario");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }

        }

        public ActionResult RegistrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarUsuario(Usuario usuario)
        {
            using (var db = new SigloXXIEntities())
            {
                db.SP_INSERT_USUARIO(usuario.Username, usuario.Password, usuario.Nombre, usuario.Apellido, usuario.Rut, usuario.Telefono, "1", usuario.TipoUsuario);
            }
                return View();
        }

        List<SelectListItem> ListaTipoUsuario;
        public void LlenarTipoUsuario()
        {
            using (var db = new SigloXXIEntities())
            {
                
                    ListaTipoUsuario = (from TIPO_USUARIO in db.TIPO_USUARIO
                                    select new SelectListItem
                                    {
                                        Text = TIPO_USUARIO.DESCRIPCION,
                                        Value = TIPO_USUARIO.ID_TIPO_USUARIO.ToString()
                                    }).ToList();
                    ListaTipoUsuario.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
                
            }
        }

        public ActionResult ListarUsuario()
        {
            using (var db = new SigloXXIEntities())
            {
                ViewBag.ListaUsuario = (db.USUARIO).ToList();
            }
            return View(ViewBag.ListaUsuario);
        }

        public ActionResult EliminarUsuario(int id)
        {
            using (var db = new SigloXXIEntities())
            {
                db.SP_DELETE_USUARIO(id);

            }
            return RedirectToAction("ListarUsuario");
        }

        public ActionResult ModificarUsuario(int? id)
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
        [HttpPost]
        public ActionResult ModificarUsuario(Usuario usuario)
        {
            using (var db = new SigloXXIEntities())
            {
                db.SP_UPDATE_USUARIO(usuario.Id, usuario.Username, usuario.Password, usuario.Nombre, usuario.Apellido, usuario.Rut, usuario.Telefono, "1" , usuario.TipoUsuario); 

            }
            return RedirectToAction("ListarUsuario");
        }

    }
}