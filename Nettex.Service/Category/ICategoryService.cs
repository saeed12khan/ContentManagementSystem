﻿using Nettex.Core.Entities;
using System.Collections.Generic;

namespace Nettex.Service
{
    public interface ICategoryService
    {
        Category GetById(int Id);
        IEnumerable<Category> GetActives();
        IEnumerable<Category> GetCategories();
        bool Insert(Category category);
        bool Update(Category category);
        bool Delete(Category category);
    }
}