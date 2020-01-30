using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Filters;
using WebStore.Infrastructure.Interface;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData _productService;

        public CatalogController(IProductData productService)
        {
            _productService = productService;
        }

        public IActionResult Shop(int? categoryId, int? brandId)
        {
            // получаем список отфильтрованных продуктов
            var products = _productService.GetProducts(
                new ProductFilter { BrandId = brandId, SectionId = categoryId });

            // сконвертируем в CatalogViewModel
            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                Section = categoryId,
                Products = products.Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };

            return View(model);
        }

        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}