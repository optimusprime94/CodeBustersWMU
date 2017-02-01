using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBustersWMU1.Models
{
    public class Search
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public void SearchOrder()
        {
            var product =
    from p in db.Products
    where p.ArticleId == id
    select p;
        } 

    }
}