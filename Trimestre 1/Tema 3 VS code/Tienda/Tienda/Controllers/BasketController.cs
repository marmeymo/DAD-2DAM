using Models.DAO;
using Models.Entities;
using System;

namespace Controllers
{
    public class BasketController
    {
        BasketDAO basketDAO = new BasketDAO();
        public BasketController() { }

        public Boolean saveBasket(int id, string name, double total)
        {
            return basketDAO.saveBasket(new Basket(id, name, total));
        }

    }
}
