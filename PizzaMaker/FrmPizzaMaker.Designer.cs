using System.Drawing;
using System.Windows.Forms;

namespace PizzaMaker
{
    partial class FrmPizzaMaker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            grpIngredients = new GroupBox();
            chbPepperoni = new CheckBox();
            chbBacon = new CheckBox();
            chbOlives = new CheckBox();
            chbMushrooms = new CheckBox();
            chbPineapple = new CheckBox();
            chbPepper = new CheckBox();
            chbSausage = new CheckBox();
            chbTomatoes = new CheckBox();
            label1 = new Label();
            lsbStrangeAddOns = new ListBox();
            gpbCrust = new GroupBox();
            rdoThinCrust = new RadioButton();
            rdoDeepDish = new RadioButton();
            rdoStuffedCrust = new RadioButton();
            rdoGlutenFree = new RadioButton();
            gpbExtraGoodies = new GroupBox();
            lblCheese = new Label();
            lblSauce = new Label();
            label2 = new Label();
            hsbSauce = new HScrollBar();
            label3 = new Label();
            hsbCheese = new HScrollBar();
            label6 = new Label();
            dtpDeliveryTime = new DateTimePicker();
            label7 = new Label();
            picPizzaBoxColor = new PictureBox();
            label8 = new Label();
            lblPizzaPrice = new Label();
            btnResetForm = new Button();
            btnCreatePizza = new Button();
            btnSeeFullOrder = new Button();
            grpIngredients.SuspendLayout();
            gpbCrust.SuspendLayout();
            gpbExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 29);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 35);
            txtName.TabIndex = 1;
            txtName.Leave += TxtNameLeaveEH;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chbPepperoni);
            grpIngredients.Controls.Add(chbBacon);
            grpIngredients.Controls.Add(chbOlives);
            grpIngredients.Controls.Add(chbMushrooms);
            grpIngredients.Controls.Add(chbPineapple);
            grpIngredients.Controls.Add(chbPepper);
            grpIngredients.Controls.Add(chbSausage);
            grpIngredients.Controls.Add(chbTomatoes);
            grpIngredients.Font = new Font("Georgia", 12F, FontStyle.Bold);
            grpIngredients.Location = new Point(28, 89);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(422, 195);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // chbPepperoni
            // 
            chbPepperoni.AutoSize = true;
            chbPepperoni.Font = new Font("Georgia", 12F);
            chbPepperoni.Location = new Point(15, 34);
            chbPepperoni.Name = "chbPepperoni";
            chbPepperoni.Size = new Size(150, 33);
            chbPepperoni.TabIndex = 0;
            chbPepperoni.Text = "Pepperoni";
            chbPepperoni.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Font = new Font("Georgia", 12F);
            chbBacon.Location = new Point(15, 73);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(105, 33);
            chbBacon.TabIndex = 1;
            chbBacon.Text = "Bacon";
            chbBacon.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Font = new Font("Georgia", 12F);
            chbOlives.Location = new Point(15, 112);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(105, 33);
            chbOlives.TabIndex = 2;
            chbOlives.Text = "Olives";
            chbOlives.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Font = new Font("Georgia", 12F);
            chbMushrooms.Location = new Point(15, 151);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(166, 33);
            chbMushrooms.TabIndex = 3;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Font = new Font("Georgia", 12F);
            chbPineapple.Location = new Point(209, 34);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(146, 33);
            chbPineapple.TabIndex = 4;
            chbPineapple.Text = "Pineapple";
            chbPineapple.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPepper
            // 
            chbPepper.AutoSize = true;
            chbPepper.Font = new Font("Georgia", 12F);
            chbPepper.Location = new Point(209, 73);
            chbPepper.Name = "chbPepper";
            chbPepper.Size = new Size(116, 33);
            chbPepper.TabIndex = 5;
            chbPepper.Text = "Pepper";
            chbPepper.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Font = new Font("Georgia", 12F);
            chbSausage.Location = new Point(209, 112);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(124, 33);
            chbSausage.TabIndex = 6;
            chbSausage.Text = "Sausage";
            chbSausage.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Font = new Font("Georgia", 12F);
            chbTomatoes.Location = new Point(209, 151);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(143, 33);
            chbTomatoes.TabIndex = 7;
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 293);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 3;
            label1.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddOns
            // 
            lsbStrangeAddOns.ItemHeight = 29;
            lsbStrangeAddOns.Items.AddRange(new object[] { "Eggs", "Anchovies", "Garlic" });
            lsbStrangeAddOns.Location = new Point(30, 329);
            lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            lsbStrangeAddOns.SelectionMode = SelectionMode.MultiSimple;
            lsbStrangeAddOns.Size = new Size(180, 120);
            lsbStrangeAddOns.TabIndex = 4;
            lsbStrangeAddOns.SelectedIndexChanged += LsbStrangeAddOnsSelectedIndexChangedEH;
            // 
            // gpbCrust
            // 
            gpbCrust.Controls.Add(rdoThinCrust);
            gpbCrust.Controls.Add(rdoDeepDish);
            gpbCrust.Controls.Add(rdoStuffedCrust);
            gpbCrust.Controls.Add(rdoGlutenFree);
            gpbCrust.Font = new Font("Georgia", 12F, FontStyle.Bold);
            gpbCrust.Location = new Point(239, 328);
            gpbCrust.Name = "gpbCrust";
            gpbCrust.Size = new Size(211, 180);
            gpbCrust.TabIndex = 5;
            gpbCrust.TabStop = false;
            gpbCrust.Text = "Crust";
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Font = new Font("Georgia", 12F);
            rdoThinCrust.Location = new Point(14, 31);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(151, 33);
            rdoThinCrust.TabIndex = 0;
            rdoThinCrust.Text = "Thin Crust";
            rdoThinCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoDeepDish
            // 
            rdoDeepDish.AutoSize = true;
            rdoDeepDish.Font = new Font("Georgia", 12F);
            rdoDeepDish.Location = new Point(14, 70);
            rdoDeepDish.Name = "rdoDeepDish";
            rdoDeepDish.Size = new Size(149, 33);
            rdoDeepDish.TabIndex = 1;
            rdoDeepDish.Text = "Deep Dish";
            rdoDeepDish.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoStuffedCrust
            // 
            rdoStuffedCrust.AutoSize = true;
            rdoStuffedCrust.Font = new Font("Georgia", 12F);
            rdoStuffedCrust.Location = new Point(14, 109);
            rdoStuffedCrust.Name = "rdoStuffedCrust";
            rdoStuffedCrust.Size = new Size(178, 33);
            rdoStuffedCrust.TabIndex = 2;
            rdoStuffedCrust.Text = "Stuffed Crust";
            rdoStuffedCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoGlutenFree
            // 
            rdoGlutenFree.AutoSize = true;
            rdoGlutenFree.Font = new Font("Georgia", 12F);
            rdoGlutenFree.Location = new Point(14, 148);
            rdoGlutenFree.Name = "rdoGlutenFree";
            rdoGlutenFree.Size = new Size(164, 33);
            rdoGlutenFree.TabIndex = 3;
            rdoGlutenFree.Text = "Gluten Free";
            rdoGlutenFree.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // gpbExtraGoodies
            // 
            gpbExtraGoodies.Controls.Add(lblCheese);
            gpbExtraGoodies.Controls.Add(lblSauce);
            gpbExtraGoodies.Controls.Add(label2);
            gpbExtraGoodies.Controls.Add(hsbSauce);
            gpbExtraGoodies.Controls.Add(label3);
            gpbExtraGoodies.Controls.Add(hsbCheese);
            gpbExtraGoodies.Font = new Font("Georgia", 12F, FontStyle.Bold);
            gpbExtraGoodies.Location = new Point(31, 553);
            gpbExtraGoodies.Name = "gpbExtraGoodies";
            gpbExtraGoodies.Size = new Size(419, 235);
            gpbExtraGoodies.TabIndex = 6;
            gpbExtraGoodies.TabStop = false;
            gpbExtraGoodies.Text = "Extra Goodies";
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F);
            lblCheese.Location = new Point(232, 146);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(43, 29);
            lblCheese.TabIndex = 5;
            lblCheese.Text = "00";
            lblCheese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F);
            lblSauce.Location = new Point(229, 55);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(43, 29);
            lblSauce.TabIndex = 4;
            lblSauce.Text = "00";
            lblSauce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F);
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(194, 29);
            label2.TabIndex = 0;
            label2.Text = "Amount of Sauce";
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(12, 87);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(372, 39);
            hsbSauce.TabIndex = 1;
            hsbSauce.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(207, 29);
            label3.TabIndex = 2;
            label3.Text = "Amount of Cheese";
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(12, 175);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(372, 39);
            hsbCheese.TabIndex = 3;
            hsbCheese.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold);
            label6.Location = new Point(525, 41);
            label6.Name = "label6";
            label6.Size = new Size(184, 29);
            label6.TabIndex = 7;
            label6.Text = "Delivery Time";
            // 
            // dtpDeliveryTime
            // 
            dtpDeliveryTime.CustomFormat = "mm/dd/yyyy hh:mm";
            dtpDeliveryTime.Format = DateTimePickerFormat.Custom;
            dtpDeliveryTime.Location = new Point(525, 89);
            dtpDeliveryTime.Name = "dtpDeliveryTime";
            dtpDeliveryTime.Size = new Size(409, 35);
            dtpDeliveryTime.TabIndex = 8;
            dtpDeliveryTime.FormatChanged += DtpDeliveryTimeValueChangedEH;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold);
            label7.Location = new Point(525, 151);
            label7.Name = "label7";
            label7.Size = new Size(204, 29);
            label7.TabIndex = 9;
            label7.Text = "Pizza Box Color";
            // 
            // picPizzaBoxColor
            // 
            picPizzaBoxColor.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBoxColor.Location = new Point(529, 200);
            picPizzaBoxColor.Name = "picPizzaBoxColor";
            picPizzaBoxColor.Size = new Size(405, 135);
            picPizzaBoxColor.TabIndex = 10;
            picPizzaBoxColor.TabStop = false;
            picPizzaBoxColor.BackColorChanged += PicPizzaBoxColorClickEH;
            picPizzaBoxColor.Click += PicPizzaBoxColorClickEH;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 12F, FontStyle.Bold);
            label8.Location = new Point(529, 351);
            label8.Name = "label8";
            label8.Size = new Size(157, 29);
            label8.TabIndex = 11;
            label8.Text = "Pizza Price:";
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Font = new Font("Georgia", 12F, FontStyle.Bold);
            lblPizzaPrice.ForeColor = Color.Red;
            lblPizzaPrice.Location = new Point(710, 351);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(45, 29);
            lblPizzaPrice.TabIndex = 12;
            lblPizzaPrice.Text = "$0";
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(529, 405);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(150, 35);
            btnResetForm.TabIndex = 13;
            btnResetForm.Text = "Reset Form";
            btnResetForm.Click += BtnResetFormClickEH;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.Location = new Point(738, 405);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(178, 35);
            btnCreatePizza.TabIndex = 14;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.Click += BtnResetFormClickEH;
            // 
            // btnSeeFullOrder
            // 
            btnSeeFullOrder.Location = new Point(533, 455);
            btnSeeFullOrder.Name = "btnSeeFullOrder";
            btnSeeFullOrder.Size = new Size(383, 42);
            btnSeeFullOrder.TabIndex = 15;
            btnSeeFullOrder.Text = "See Full Order ";
            btnSeeFullOrder.UseVisualStyleBackColor = true;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 833);
            Controls.Add(btnSeeFullOrder);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(grpIngredients);
            Controls.Add(label1);
            Controls.Add(lsbStrangeAddOns);
            Controls.Add(gpbCrust);
            Controls.Add(gpbExtraGoodies);
            Controls.Add(label6);
            Controls.Add(dtpDeliveryTime);
            Controls.Add(label7);
            Controls.Add(picPizzaBoxColor);
            Controls.Add(label8);
            Controls.Add(lblPizzaPrice);
            Controls.Add(btnResetForm);
            Controls.Add(btnCreatePizza);
            Font = new Font("Georgia", 12F);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            gpbCrust.ResumeLayout(false);
            gpbCrust.PerformLayout();
            gpbExtraGoodies.ResumeLayout(false);
            gpbExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblName;
        private TextBox txtName;
        private GroupBox grpIngredients;
        private CheckBox chbPepperoni;
        private CheckBox chbOlives;
        private CheckBox chbBacon;
        private CheckBox chbMushrooms;
        private CheckBox chbPineapple;
        private CheckBox chbPepper;
        private CheckBox chbSausage;
        private CheckBox chbTomatoes;
        private Label label1;
        private ListBox lsbStrangeAddOns;
        private GroupBox gpbCrust;
        private RadioButton rdoThinCrust;
        private RadioButton rdoGlutenFree;
        private RadioButton rdoStuffedCrust;
        private RadioButton rdoDeepDish;
        private GroupBox gpbExtraGoodies;
        private HScrollBar hsbSauce;
        private HScrollBar hsbCheese;
        private Label label2;
        private Label label3;
        private Label label6;
        private DateTimePicker dtpDeliveryTime;
        private Label label7;
        private PictureBox picPizzaBoxColor;
        private Label label8;
        private Label lblPizzaPrice;
        private Button btnResetForm;
        private Button btnCreatePizza;
        private Label lblCheese;
        private Label lblSauce;
        private Button btnSeeFullOrder;
    }
}
