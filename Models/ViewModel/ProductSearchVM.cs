using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23DH113217_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        public List<Product> Products { get; set; }

        public string SortOrder { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}