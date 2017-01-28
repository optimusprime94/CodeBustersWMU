using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBustersWMU1.Models
{
    public static class ObjectExtension
    {
        public static int ToInt(this Object obj)
        {
            return (int)obj;
        }
    }
}