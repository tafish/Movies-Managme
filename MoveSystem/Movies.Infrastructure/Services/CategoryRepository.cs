﻿using Ecommerce.Application.Repository;
using Ecommerce.Infrastructure.Presistance;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Services
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(DBContextApplication context) : base(context)
        {
        }

    }
}