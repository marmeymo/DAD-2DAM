using Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controllers
{
    public class CatmanController
    {
        CatmanDAO catmanDAO = new CatmanDAO();
        public CatmanController() { }
        public List<Catman> getAllCatmans()
        {
            return catmanDAO.loadCatmans();
        }

        public DataTable getCatmansDA()
        {
            return catmanDAO.loadDataAdapter();
        }

        public DataTable getCatmansByCategoryDA(String category)
        {
            return catmanDAO.loadDataAdapterByCategory(category);
        }

        public Boolean UpdateCatman(int id, string name, string category, string description, double price, int quantity)
        {
            return catmanDAO.UpdateCatman(new Catman(id, name, category, description, price, quantity));
        }
    }
}
