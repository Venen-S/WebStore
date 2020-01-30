﻿using System.Collections.Generic;

namespace WebStore.Models
{
    public class CatalogViewModel
    {
        public int? BrandId { get; set; }
        public int? Section { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}