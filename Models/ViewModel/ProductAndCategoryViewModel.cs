using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop4Yourself.Models.ViewModel
{
    public class ProductAndCategoryViewModel
    {
        public IEnumerable<CategoriesModel> CategoryList { get; set; }

        public ProductsModel Products { get; set; }

        public string StatusMessage { get; set; }
    }
}
