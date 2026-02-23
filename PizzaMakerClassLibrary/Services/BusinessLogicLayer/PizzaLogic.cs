/*
 * Moses Muamba-Nzambi
 * CST – 250
 * Feb 22, 2026
 * Pizza Maker
 * Activity 4
 */

using PizzaMakerClassLibrary.Models;
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
        public (bool, int) AddPizzaToOrder(PizzaModel pizza)
        {
            bool isValid = true;

            // Validate Name
            if (string.IsNullOrWhiteSpace(pizza.ClientName))
                isValid = false;

            // Validate Crust
            if (string.IsNullOrWhiteSpace(pizza.Crust) || pizza.Crust == "Unknown")
                isValid = false;

            // Must have at least one ingredient
            if (pizza.Ingredients == null || pizza.Ingredients.Count == 0)
                isValid = false;

            // Cheese and Sauce must be > 0
            if (pizza.CheeseQty <= 0 || pizza.SauceQty <= 0)
                isValid = false;

            if (!isValid)
                return (false, -1);

            // Add pizza if valid
            _pizzaDAO.AddPizzaToOrder(pizza);

            int count = _pizzaDAO.GetPizzaOrder().Count;

            return (true, count);
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

        /// <summary>
        /// Write the pizza order to a text file
        /// </summary>
        /// <returns></returns>
        public bool WriteOrderToFile()
        {
            // Get and return WriteOrderToFile from the DAO
            return _pizzaDAO.WriteOrderToFile();
        }


    }
}
