/*
 * Moses Muamba-Nzambi
 * CST – 250
 * Feb 22, 2026
 * Pizza Maker
 * Activity 4
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;


namespace PizzaMaker
{
    public partial class FrmOrderDetails : Form
    {
        // Declare class level variables
        private List<PizzaModel> _pizzaOrder;
        private PizzaLogic _pizzaLogic;

        /// <summary>
        /// Default constructor for FrmOrderDetails
        /// </summary>
        public FrmOrderDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parameterized constructor for FrmOrderDetails
        /// </summary>
        /// <param name="pizzaOrderList"></param>
        /// <param name="pizzaBusinessLogic"></param>
        public FrmOrderDetails(List<PizzaModel> pizzaOrderList, PizzaLogic pizzaBusinessLogic)
        {
            InitializeComponent();

            _pizzaOrder = pizzaOrderList;
            _pizzaLogic = pizzaBusinessLogic;
        }

        /// <summary>
        /// Display the pizzas on the form
        /// </summary>
        public void DisplayPizzas()
        {
            lblOrderDetails.Text = "";

            foreach (PizzaModel pizza in _pizzaOrder)
            {
                lblOrderDetails.Text +=
                    "Name: " + pizza.ClientName + Environment.NewLine +
                    "Ingredients: " + string.Join(", ", pizza.Ingredients) + Environment.NewLine +
                    "Strange Add Ons: " + string.Join(", ", pizza.StrangeAddOns) + Environment.NewLine +
                    "Crust: " + pizza.Crust + Environment.NewLine +
                    "Sauce: " + pizza.SauceQty + Environment.NewLine +
                    "Cheese: " + pizza.CheeseQty + Environment.NewLine +
                    "Delivery Time: " + pizza.DeliveryTime + Environment.NewLine +
                    "Pizza Box Color: " + pizza.PizzaBoxColor + Environment.NewLine +
                    "Price: " + pizza.Price + Environment.NewLine + Environment.NewLine;
            }
        }

        /// <summary>
        /// Click event handler for btnSaveOrder
        /// </summary>
        private void BtnSaveOrderClickEH(object sender, EventArgs e)
        {
            // Declare and initialize
            bool isSaveSuccess = false;

            // Write the order to the file
            isSaveSuccess = _pizzaLogic.WriteOrderToFile();

            // Check if the save was successful
            if (isSaveSuccess)
            {
                // Show a success message to the user
                MessageBox.Show("The pizza order was saved.");
            }
            else
            {
                // Show a failure message to the user
                MessageBox.Show("An error occurred while trying to save your order. Please try again later.");
            }
        }

    }
}
