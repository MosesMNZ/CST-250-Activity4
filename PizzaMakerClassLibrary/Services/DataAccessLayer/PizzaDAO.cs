/*
 * Moses Muamba-Nzambi
 * CST – 250
 * Feb 22, 2026
 * Pizza Maker
 * Activity 4
 */

using System.Collections.Generic;
using PizzaMakerClassLibrary.Models;


namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    public class PizzaDAO
    {
        // Class level variables
        private List<PizzaModel> _pizzaOrder;

        /// <summary>
        /// Default constructor for the pizza DAO
        /// </summary>
        public PizzaDAO()
        {
            // Initialize the _pizzaOrder list
            _pizzaOrder = new List<PizzaModel>();
        }

        /// <summary>
        /// Add a pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <returns></returns>
        public int AddPizzaToOrder(PizzaModel newPizza)
        {
            // Add the new pizza to the _pizzaOrder list
            _pizzaOrder.Add(newPizza);

            // Return the number of pizzas in _pizzaOrder
            return _pizzaOrder.Count;
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns></returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Return the pizzaOrder list
            return _pizzaOrder;
        }


    }
}
