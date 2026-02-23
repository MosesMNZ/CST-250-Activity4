/*
 * Moses Muamba-Nzambi
 * CST – 250
 * Feb 22, 2026
 * Pizza Maker
 * Activity 4
 */

using PizzaMaker.Models;
using PizzaMakerClassLibrary.Services.DataAccessLayer;

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        // Declare class level variables
        private PizzaDAO _pizzaDAO;

        /// <summary>
        /// Default constructor for PizzaLogic
        /// </summary>
        public PizzaLogic()
        {
            // Initialize the pizza DAO object
            _pizzaDAO = new PizzaDAO();
        }

        /// <summary>
        /// Add a new pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <returns></returns>
        public (bool isValidPizza, int pizzasInOrder) AddPizzaToOrder(PizzaModel newPizza)
        {
            // Declare and initialize
            int pizzas = -1;

            // Call the DAO AddPizzaToOrder
            pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);

            // Return the pizzas variable
            return (true, pizzas);
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns></returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Get and return GetPizzaOrder from the DAO
            return _pizzaDAO.GetPizzaOrder();
        }

    }
}
