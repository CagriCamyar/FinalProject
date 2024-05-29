﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
          //iş kodları
          return _categoryDal.GetAll();
        }

        //select * from Categories where CategoryId = 3 komutunu calıstırır  
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=> c.CategoryId == categoryId); //c.CategoryId tabloya soruyor categoryId benim verdiğim değer
        }
    }
}