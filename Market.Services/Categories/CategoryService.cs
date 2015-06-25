﻿using System;
using System.Linq;
using Market.Data.Repositories;
using Market.Domain.Entities;

namespace Market.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IQueryable<Category> Get()
        {
            return _categoryRepository.Get();
        }

        public Category Get(int id)
        {
            return _categoryRepository.Get(id);
        }

        public Category Create(Category category)
        {
            category.CreatedAt = DateTime.Now;
            category.UpdatedAt = DateTime.Now;
            return _categoryRepository.Create(category);
        }

        public Category Update(Category category)
        {
            category.UpdatedAt = DateTime.Now;
            return _categoryRepository.Update(category);
        }

        public void Delete(int id)
        {
            Category category = _categoryRepository.Get(id);
            _categoryRepository.Delete(category);
        }
    }
}
