using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.BikeStore.WUI.Models.StoreProcedure
{
   public class InsertProductSP
    {
        public string product_name { get; set; }
        public int brand_id { get; set; }
        public int category_id { get; set; }
        public int model_year { get; set; }
        public decimal list_price { get; set; }

    }
}
