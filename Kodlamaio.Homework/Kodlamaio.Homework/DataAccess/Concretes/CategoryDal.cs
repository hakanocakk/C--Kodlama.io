using Kodlamaio.Homework.DataAccess.Abstracts;
using Kodlamaio.Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Homework.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public CategoryDal()
        {
            Category category1 = new Category {Id=1,Name="Programming" };
            Category category2 = new Category {Id=2,Name="All" };

            categories = new List<Category> { category1, category2 };
        }

        List<Category> categories;
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }
    }
}
