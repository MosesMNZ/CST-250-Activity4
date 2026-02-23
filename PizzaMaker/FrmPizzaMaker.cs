/*
 * Moses Muamba-Nzambi
 * CST – 250
 * Feb 22, 2026
 * Pizza Maker
 * Activity 4
 */

using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;

namespace PizzaMaker
{
    public partial class FrmPizzaMaker : Form
    {
        // Class level variable declarations
        private PizzaModel _pizza;
        private PizzaLogic _pizzaLogic;

        /// <summary>
        /// Default constructor for FrmPizzaMaker
        /// </summary>
        public FrmPizzaMaker()
        {
            InitializeComponent();

            // Initialize the current order
            _pizza = new PizzaModel();

            // Initialize business logic layer
            _pizzaLogic = new PizzaLogic();

            // Disable the Create Pizza button
            btnCreatePizza.Enabled = false;

            // Disable the Reset Form button
            btnResetForm.Enabled = false;

            btnSeeFullOrder.Enabled = false;

            // Wire the Leave event for txtName (FIXED)
            txtName.Leave += TxtNameLeaveEH;

            // Fix scroll bar maximum bug
            hsbSauce.Maximum = 100 + hsbSauce.LargeChange - 1;
            hsbCheese.Maximum = 100 + hsbCheese.LargeChange - 1;

            // Initialize price display
            UpdatePrice();
        }

        /// <summary>
        /// Leave event handler for txtName
        /// </summary>
        private void TxtNameLeaveEH(object sender, EventArgs e)
        {
            _pizza.ClientName = txtName.Text;
            EnablePizzaCreation();
        }

        /// <summary>
        /// Enables the reset and create buttons
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
            decimal price = 15;

            price += (_pizza.Ingredients.Count * .50m);
            price += (_pizza.StrangeAddOns.Count * .50m);

            if (_pizza.Crust == "Gluten Free")
            {
                price += 1;
            }

            _pizza.Price = price;
            lblPizzaPrice.Text = $"{price:C2}";
        }

        private void ChbIngredientCheckedChangedEH(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;

            if (checkbox != null)
            {
                if (checkbox.Checked)
                    _pizza.Ingredients.Add(checkbox.Text);
                else
                    _pizza.Ingredients.Remove(checkbox.Text);
            }

            UpdatePrice();
        }

        private void LsbStrangeAddOnsSelectedIndexChangedEH(object sender, EventArgs e)
        {
            _pizza.StrangeAddOns = lsbStrangeAddOns.SelectedItems.Cast<string>().ToList();
            UpdatePrice();
        }

        private void RdoCrustCheckedChangedEH(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
                _pizza.Crust = radioButton.Text;

            UpdatePrice();
        }

        private void HsbExtraGoodiesValueChangedEH(object sender, EventArgs e)
        {
            HScrollBar scrollBar = sender as HScrollBar;

            if (scrollBar != null)
            {
                if (scrollBar == hsbSauce)
                {
                    _pizza.SauceQty = scrollBar.Value;
                    lblSauce.Text = scrollBar.Value.ToString();
                }
                else if (scrollBar == hsbCheese)
                {
                    _pizza.CheeseQty = scrollBar.Value;
                    lblCheese.Text = scrollBar.Value.ToString();
                }
            }
        }

        private void DtpDeliveryTimeValueChangedEH(object sender, EventArgs e)
        {
            _pizza.DeliveryTime = dtpDeliveryTime.Value;
        }

        private void PicPizzaBoxColorClickEH(object sender, EventArgs e)
        {
            ColorDialog pizzaBoxColorPicker = new ColorDialog();
            DialogResult result = pizzaBoxColorPicker.ShowDialog();

            if (result == DialogResult.OK)
            {
                _pizza.PizzaBoxColor = pizzaBoxColorPicker.Color;
                picPizzaBoxColor.BackColor = pizzaBoxColorPicker.Color;
            }
        }

        /// <summary>
        /// Click event handler for btnCreatePizza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreatePizzaClickEH(object sender, EventArgs e)
        {
            // Declare and initialize
            bool isValidPizza = false;
            int pizzasInOrder = -1;

            // Use the pizzalogic to call AddPizzaToOrder
            (isValidPizza, pizzasInOrder) = _pizzaLogic.AddPizzaToOrder(_pizza);

            // Check if the pizza was valid
            if (isValidPizza)
            {
                // Enable the See Full Order button
                btnSeeFullOrder.Enabled = true;

                // Reset the form
                ResetForm();
            }
            else
            {
                // Show a failure message to the user
                MessageBox.Show("Your pizza order is not complete.");
            }
        }


        private void BtnResetFormClickEH(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            _pizza = new PizzaModel();
            ResetControls(this);
            UpdatePrice();
        }

        private void ResetControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                Type controlType = control.GetType();
                string type = controlType.Name;

                switch (type)
                {
                    case "TextBox":
                        ((TextBox)control).Clear();
                        break;

                    case "CheckBox":
                        ((CheckBox)control).Checked = false;
                        break;

                    case "ListBox":
                        ((ListBox)control).ClearSelected();
                        break;

                    case "RadioButton":
                        ((RadioButton)control).Checked = false;
                        break;

                    case "HScrollBar":
                        ((HScrollBar)control).Value = 0;
                        break;

                    case "DateTimePicker":
                        ((DateTimePicker)control).Value =
                            new DateTime(2025, 1, 1, 0, 0, 0);
                        break;

                    case "PictureBox":
                        ((PictureBox)control).BackColor = SystemColors.Control;
                        break;
                }

                if (control.HasChildren)
                    ResetControls(control);
            }
        }
        /// <summary>
        /// Click event handler for btnSeeFullOrder
        /// </summary>
        private void BtnSeeFullOrderClickEH(object sender, EventArgs e)
        {
            List<PizzaModel> pizzaList;

            pizzaList = _pizzaLogic.GetPizzaOrder();

            FrmOrderDetails frmOrderDetails =
                new FrmOrderDetails(pizzaList, _pizzaLogic);

            frmOrderDetails.DisplayPizzas();
            frmOrderDetails.ShowDialog();
        }
    }
}
