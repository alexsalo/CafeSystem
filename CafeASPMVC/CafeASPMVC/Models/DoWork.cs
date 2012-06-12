using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.EntityClient;
using CafeASPMVC.Models;

namespace CafeASPMVC.Models
{
    public class DoWork
    {
        private Models.enjCafeEntities m_cafemodel;
        private static DoWork instanse;

        private DoWork() 
        {
            m_cafemodel = new Models.enjCafeEntities();
        }
        public static DoWork Instanse
        {
            get
            {
                if (instanse == null)
                    instanse = new DoWork();
                return instanse;
            }

        }
        public List<food_category> getFoodCategory()
        {
            
            IQueryable<food_category> qfc = from fc in m_cafemodel.food_category
                                            select fc;
            List<food_category> fcA = qfc.ToList();
            return fcA;
        }
        public List<recipe> getRecipesListByCategory(int id_food_category)
        {
            IQueryable<recipe> qr = from r in m_cafemodel.recipe
                                    where r.food_category_id == id_food_category
                                    select r;
            return qr.ToList();
        }
    }
}