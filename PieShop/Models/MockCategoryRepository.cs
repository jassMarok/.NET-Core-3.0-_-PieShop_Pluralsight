using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category {CategoryId = 1, CategoryName = "Fruit Pies",  Description = "Best Fruit Pies"},
            new Category {CategoryId = 2, CategoryName = "Cheese Cakes", Description = "Best Cheese Cakes"},
            new Category {CategoryId = 3, CategoryName = "Seasonal Pies", Description = "Best Seasonal Pies"}
        };
    }
}
