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
        Models.enjCafeEntities m_cafemodel;
        public List<food_category> getFoodCategory()
        {
            m_cafemodel = new Models.enjCafeEntities();
            IQueryable<food_category> qfc = from fc in m_cafemodel.food_category
                                            select fc;
            List<food_category> fcA = qfc.ToList();
            return fcA;
        }
    }
}