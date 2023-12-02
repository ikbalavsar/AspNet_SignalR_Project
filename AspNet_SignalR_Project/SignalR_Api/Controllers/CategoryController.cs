﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.CategoryDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll()); // önceki controllerdan farklı olarak burada direkt mapleme işlemi yaptık. 
            return Ok(value); 
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                Name = createCategoryDto.Name,
                Status = true
            });
            return Ok("Category Added.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {

            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Category deleted.");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                Name = updateCategoryDto.Name,
                Status = updateCategoryDto.Status,
                CategoryID = updateCategoryDto.CategoryID
            });
            return Ok("Category updated.");
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }
    }
}
