using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.EntityClient;
using CafeASPMVC.Models;

namespace CafeASPMVC.Controllers
{
    public class MenuController : Controller
    {
        CafeASPMVC.Models.enjCafeEntities m_cafemodel;
        //
        // GET: /Menu/

        [HttpPost]       
        public recipe[] getRecipes(int id)
        {
            m_cafemodel = new Models.enjCafeEntities();
            IQueryable<recipe> qr = from r in m_cafemodel.recipe                                                           
                                         select r;
            recipe[] rA = qr.ToArray();
            return rA;
        }

        public ActionResult Index()
        {
            m_cafemodel = new Models.enjCafeEntities();
            IQueryable<recipe> qrecipe = from r in m_cafemodel.recipe                                                           
                                         select r;
            recipe[] rA = qrecipe.ToArray();
            recipe m_recipe = rA[1];
            
            //string[] recipeNames = qrecipe.ToArray();
            ViewData["recipeName"] = rA[1].name;
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View();
        }

    }
}
