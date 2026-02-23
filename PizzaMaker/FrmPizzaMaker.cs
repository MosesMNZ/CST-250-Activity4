/*
 * Moses Muamba-Nzambi
 * CST – 250
 * Feb 22, 2026
 * Pizza Maker
 * Activity 4
 */

using System;
using System.Windows.Forms;
using PizzaMaker.Models;

namespace PizzaMaker
{
    public partial class FrmPizzaMaker : Form
    {
        // Class level variable declarations
        private PizzaModel _pizza;

        /// <summary>
        /// Default constructor for FrmPizzaMaker
        /// </summary>
        public FrmPizzaMaker()
        {
            InitializeComponent();

            // Initialize the current order
            _pizza = new PizzaModel();

            // Disable the Create Pizza button
            btnCreatePizza.Enabled = false;

            // Disable the Reset Form button
            btnResetForm.Enabled = false;

            // Wire the Leave event for txtName
            txtName.Leave += TxtNameLeaveEH;

            // Initialize price display
            UpdatePrice();
        }

        /// <summary>
        /// Leave event handler for txtName
        /// </summary>
        private void TxtNameLeaveEH(object sender, EventArgs e)
        {
            // Set the pizzas client name to the text of txtName
            _pizza.ClientName = txtName.Text;

            // Enable buttons
            EnablePizzaCreation();
        }

        /// <summary>
        /// Enables the reset and create buttons
        /// for the order pizza form
        /// </summary>
        public void EnablePizzaCreation()
        {
            btnCreatePizza.Enabled = true;
            btnResetForm.Enabled = true;
        }

        /// <summary>
        /// Update the price of the pizza
        /// </summary>
        public void UpdatePrice()
        {
            // Declare and initialize
            decimal price = 15;

            // Add 50 cents for each ingredient
            price += (_pizza.Ingredients.Count * .50m);

            // Add 50 cents for each special add on
            price += (_pizza.StrangeAddOns.Count * .50m);

            // Add $1 if the crust is gluten free
            if (_pizza.Crust == "Gluten Free")
            {
                price += 1;
            }

            // Update the price of the pizza
            _pizza.Price = price;

            // Update lblPizzaPrice
            lblPizzaPrice.Text = $"{price:C2}";
        }

    }
}
