﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Domain;
using WebStore.Domain.DTO.Products;
using WebStore.Domain.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    [Route(WebAPI.Products)]
    [ApiController]
    public class ProductsAPIController : ControllerBase,IProductData
    {
        private readonly IProductData _ProductData;

        public ProductsAPIController(IProductData ProductData)
        {
            _ProductData = ProductData;
        }
        [HttpGet("sections/{id}")]
        public SectionDTO GetSectionById(int id)=> _ProductData.GetSectionById(id);
        

        [HttpGet("brands")]
        public IEnumerable<BrandDTO> GetBrands() => _ProductData.GetBrands();

        [HttpGet("brands/{id}")]
        public BrandDTO GetBrandById(int id)=>_ProductData.GetBrandById(id);
        

        [HttpGet("{id}")]
        public ProductDTO GetProductById(int id) => _ProductData.GetProductById(id);

        [HttpPost]
        public IEnumerable<ProductDTO> GetProducts([FromBody] ProductFilter Filter = null) => _ProductData.GetProducts(Filter);

        [HttpGet("sections")]
        public IEnumerable<SectionDTO> GetSections() => _ProductData.GetSections();
    }
}