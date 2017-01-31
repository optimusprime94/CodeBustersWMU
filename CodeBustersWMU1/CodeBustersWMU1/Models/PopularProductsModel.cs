using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeBustersWMU1.Models
{

    public class PopularProductsModel
    {
       

        private List<Statistic> _listPopular = Popular();

        private static List<CodeBustersWMU1.Models.Statistic> Popular()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var q =
            from s in db.Statistics
            where s.Sold > 10
            select s;
            return q.ToList();

        }


        public Statistic Top
        {
            get
            {
                return this._listPopular.Max();
            }
        }
    }
}