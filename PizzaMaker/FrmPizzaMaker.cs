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
            lblName.Leave += TxtNameLeaveEH;

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
            // Set the pizzas client name to the text of txtName
            _pizza.ClientName = lblName.Text;

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

        /// <summary>
        /// Checked changed event handler for ingredient check boxes
        /// </summary>
        private void ChbIngredientCheckedChangedEH(object sender, EventArgs e)
        {
            // Get the check box from the sender parameter
            CheckBox checkbox = sender as CheckBox;

            // Make sure the checkbox is not null
            if (checkbox != null)
            {
                if (checkbox.Checked)
                {
                    _pizza.Ingredients.Add(checkbox.Text);
                }
                else
                {
                    _pizza.Ingredients.Remove(checkbox.Text);
                }
            }

            // Update the price of the pizza
            UpdatePrice();
        }

        /// <summary>
        /// Selected Index Changed event handler for LsbStrangeAddOns
        /// </summary>
        private void LsbStrangeAddOnsSelectedIndexChangedEH(object sender, EventArgs e)
        {
            _pizza.StrangeAddOns = lsbStrangeAddOns.SelectedItems.Cast<string>().ToList();
            UpdatePrice();
        }

        /// <summary>
        /// Checked changed event handler for crust radio buttons
        /// </summary>
        private void RdoCrustCheckedChangedEH(object sender, EventArgs e)
        {
            // Get the radio button from the sender object
            RadioButton radioButton = sender as RadioButton;

            // Make sure the radio button is not null
            if (radioButton != null && radioButton.Checked)
            {
                _pizza.Crust = radioButton.Text;
            }

            // Update the price of the pizza
            UpdatePrice();
        }

        /// <summary>
        /// Value changed event handler for the horizontal scroll bars
        /// </summary>
        private void HsbExtraGoodiesValueChangedEH(object sender, EventArgs e)
        {
            // Cast the sender object to an HScrollBar
            HScrollBar scrollBar = sender as HScrollBar;

            // Make sure the scroll bar is not null
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

        /// <summary>
        /// Value changed event handler for dtpDeliveryTime
        /// </summary>
        private void DtpDeliveryTimeValueChangedEH(object sender, EventArgs e)
        {
            _pizza.DeliveryTime = dtpDeliveryTime.Value;
        }

        /// <summary>
        /// Click event handler for picPizzaBoxColor
        /// </summary>
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
        /// Click event handler for btnResetForm
        /// </summary>
        private void BtnResetFormClickEH(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Reset the pizza maker form
        /// </summary>
        private void ResetForm()
        {
            _pizza = new PizzaModel();
            ResetControls(this);
            UpdatePrice();
        }

        /// <summary>
        /// Reset the controls within the parent control
        /// </summary>
        /// <param name="parentControl"></param>
        private void ResetControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                Type controlType = control.GetType();
                string type = controlType.Name.ToString();

                switch (type)
                {
                    case "TextBox":
                        TextBox textbox = (TextBox)control;
                        textbox.Clear();
                        break;

                    case "CheckBox":
                        CheckBox checkbox = (CheckBox)control;
                        checkbox.Checked = false;
                        break;

                    case "ListBox":
                        ListBox listbox = (ListBox)control;
                        listbox.ClearSelected();
                        break;

                    case "RadioButton":
                        RadioButton radioButton = (RadioButton)control;
                        radioButton.Checked = false;
                        break;

                    case "HScrollBar":
                        HScrollBar hScrollBar = (HScrollBar)control;
                        hScrollBar.Value = 0;
                        break;

                    case "DateTimePicker":
                        DateTimePicker dateTimePicker = (DateTimePicker)control;
                        dateTimePicker.Value = new DateTime(2025, 1, 1, 0, 0, 0);
                        break;

                    case "PictureBox":
                        PictureBox pictureBox = (PictureBox)control;
                        pictureBox.BackColor = SystemColors.Control;
                        break;
                }

                if (control.HasChildren)
                {
                    ResetControls(control);
                }
            }
        }
    }
}