﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAB.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int ProductId { get; set; }
        public string ProductName { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public IFormFile ThumbnailImage { set; get; }
    }
}
