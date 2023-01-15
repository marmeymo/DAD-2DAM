using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class CategoriesController
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public List<Category> getAllCategories()
        {
            return categoryDAO.loadCategories();
        }
    }
}
