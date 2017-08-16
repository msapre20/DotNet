namespace SandwichSelectorr
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.grpBread = new System.Windows.Forms.GroupBox();
            this.rdoWheat = new System.Windows.Forms.RadioButton();
            this.rdoItalian = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.grpCheese = new System.Windows.Forms.GroupBox();
            this.rdoPepperJack = new System.Windows.Forms.RadioButton();
            this.rdoAmerican = new System.Windows.Forms.RadioButton();
            this.rdoCheddar = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.grpMeats = new System.Windows.Forms.GroupBox();
            this.chkNone = new System.Windows.Forms.CheckBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkRoastedBeef = new System.Windows.Forms.CheckBox();
            this.chkFriedChicken = new System.Windows.Forms.CheckBox();
            this.grpCondiments = new System.Windows.Forms.GroupBox();
            this.chkPickles = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.chkMustard = new System.Windows.Forms.CheckBox();
            this.txtOrder = new System.Windows.Forms.RichTextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBread.SuspendLayout();
            this.grpCheese.SuspendLayout();
            this.grpMeats.SuspendLayout();
            this.grpCondiments.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBread
            // 
            this.grpBread.Controls.Add(this.rdoWheat);
            this.grpBread.Controls.Add(this.rdoItalian);
            this.grpBread.Controls.Add(this.rdoWhite);
            this.grpBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBread.Location = new System.Drawing.Point(44, 45);
            this.grpBread.Name = "grpBread";
            this.grpBread.Size = new System.Drawing.Size(200, 176);
            this.grpBread.TabIndex = 0;
            this.grpBread.TabStop = false;
            this.grpBread.Text = "Bread";
            // 
            // rdoWheat
            // 
            this.rdoWheat.AutoSize = true;
            this.rdoWheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWheat.Location = new System.Drawing.Point(7, 129);
            this.rdoWheat.Name = "rdoWheat";
            this.rdoWheat.Size = new System.Drawing.Size(72, 22);
            this.rdoWheat.TabIndex = 2;
            this.rdoWheat.TabStop = true;
            this.rdoWheat.Text = "Wheat";
            this.rdoWheat.UseVisualStyleBackColor = true;
            this.rdoWheat.CheckedChanged += new System.EventHandler(this.rdoWheat_CheckedChanged);
            // 
            // rdoItalian
            // 
            this.rdoItalian.AutoSize = true;
            this.rdoItalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoItalian.Location = new System.Drawing.Point(7, 89);
            this.rdoItalian.Name = "rdoItalian";
            this.rdoItalian.Size = new System.Drawing.Size(66, 22);
            this.rdoItalian.TabIndex = 1;
            this.rdoItalian.TabStop = true;
            this.rdoItalian.Text = "Italian";
            this.rdoItalian.UseVisualStyleBackColor = true;
            this.rdoItalian.CheckedChanged += new System.EventHandler(this.rdoItalian_CheckedChanged);
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWhite.Location = new System.Drawing.Point(7, 45);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(67, 22);
            this.rdoWhite.TabIndex = 0;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White";
            this.rdoWhite.UseVisualStyleBackColor = true;
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // grpCheese
            // 
            this.grpCheese.Controls.Add(this.rdoPepperJack);
            this.grpCheese.Controls.Add(this.rdoAmerican);
            this.grpCheese.Controls.Add(this.rdoCheddar);
            this.grpCheese.Controls.Add(this.rdoNone);
            this.grpCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheese.Location = new System.Drawing.Point(321, 45);
            this.grpCheese.Name = "grpCheese";
            this.grpCheese.Size = new System.Drawing.Size(200, 216);
            this.grpCheese.TabIndex = 1;
            this.grpCheese.TabStop = false;
            this.grpCheese.Text = "Cheese";
            // 
            // rdoPepperJack
            // 
            this.rdoPepperJack.AutoSize = true;
            this.rdoPepperJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPepperJack.Location = new System.Drawing.Point(17, 164);
            this.rdoPepperJack.Name = "rdoPepperJack";
            this.rdoPepperJack.Size = new System.Drawing.Size(108, 22);
            this.rdoPepperJack.TabIndex = 3;
            this.rdoPepperJack.TabStop = true;
            this.rdoPepperJack.Text = "PepperJack";
            this.rdoPepperJack.UseVisualStyleBackColor = true;
            this.rdoPepperJack.CheckedChanged += new System.EventHandler(this.rdoPepperJack_CheckedChanged);
            // 
            // rdoAmerican
            // 
            this.rdoAmerican.AutoSize = true;
            this.rdoAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAmerican.Location = new System.Drawing.Point(17, 119);
            this.rdoAmerican.Name = "rdoAmerican";
            this.rdoAmerican.Size = new System.Drawing.Size(91, 22);
            this.rdoAmerican.TabIndex = 2;
            this.rdoAmerican.TabStop = true;
            this.rdoAmerican.Text = "American";
            this.rdoAmerican.UseVisualStyleBackColor = true;
            this.rdoAmerican.CheckedChanged += new System.EventHandler(this.rdoAmerican_CheckedChanged);
            // 
            // rdoCheddar
            // 
            this.rdoCheddar.AutoSize = true;
            this.rdoCheddar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCheddar.Location = new System.Drawing.Point(17, 77);
            this.rdoCheddar.Name = "rdoCheddar";
            this.rdoCheddar.Size = new System.Drawing.Size(85, 22);
            this.rdoCheddar.TabIndex = 1;
            this.rdoCheddar.TabStop = true;
            this.rdoCheddar.Text = "Cheddar";
            this.rdoCheddar.UseVisualStyleBackColor = true;
            this.rdoCheddar.CheckedChanged += new System.EventHandler(this.rdoCheddar_CheckedChanged);
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNone.Location = new System.Drawing.Point(17, 36);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(65, 22);
            this.rdoNone.TabIndex = 0;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // grpMeats
            // 
            this.grpMeats.Controls.Add(this.chkNone);
            this.grpMeats.Controls.Add(this.chkSalami);
            this.grpMeats.Controls.Add(this.chkRoastedBeef);
            this.grpMeats.Controls.Add(this.chkFriedChicken);
            this.grpMeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeats.Location = new System.Drawing.Point(44, 267);
            this.grpMeats.Name = "grpMeats";
            this.grpMeats.Size = new System.Drawing.Size(200, 267);
            this.grpMeats.TabIndex = 2;
            this.grpMeats.TabStop = false;
            this.grpMeats.Text = "Meats";
            // 
            // chkNone
            // 
            this.chkNone.AutoSize = true;
            this.chkNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNone.Location = new System.Drawing.Point(17, 205);
            this.chkNone.Name = "chkNone";
            this.chkNone.Size = new System.Drawing.Size(66, 22);
            this.chkNone.TabIndex = 3;
            this.chkNone.Text = "None";
            this.chkNone.UseVisualStyleBackColor = true;
            // 
            // chkSalami
            // 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalami.Location = new System.Drawing.Point(17, 158);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(75, 22);
            this.chkSalami.TabIndex = 2;
            this.chkSalami.Text = "Salami";
            this.chkSalami.UseVisualStyleBackColor = true;
            // 
            // chkRoastedBeef
            // 
            this.chkRoastedBeef.AutoSize = true;
            this.chkRoastedBeef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRoastedBeef.Location = new System.Drawing.Point(17, 110);
            this.chkRoastedBeef.Name = "chkRoastedBeef";
            this.chkRoastedBeef.Size = new System.Drawing.Size(120, 22);
            this.chkRoastedBeef.TabIndex = 1;
            this.chkRoastedBeef.Text = "Roasted Beef";
            this.chkRoastedBeef.UseVisualStyleBackColor = true;
            // 
            // chkFriedChicken
            // 
            this.chkFriedChicken.AutoSize = true;
            this.chkFriedChicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriedChicken.Location = new System.Drawing.Point(17, 56);
            this.chkFriedChicken.Name = "chkFriedChicken";
            this.chkFriedChicken.Size = new System.Drawing.Size(121, 22);
            this.chkFriedChicken.TabIndex = 0;
            this.chkFriedChicken.Text = "Fried Chicken";
            this.chkFriedChicken.UseVisualStyleBackColor = true;
            // 
            // grpCondiments
            // 
            this.grpCondiments.Controls.Add(this.chkPickles);
            this.grpCondiments.Controls.Add(this.chkOnions);
            this.grpCondiments.Controls.Add(this.chkTomato);
            this.grpCondiments.Controls.Add(this.chkLettuce);
            this.grpCondiments.Controls.Add(this.chkMustard);
            this.grpCondiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCondiments.Location = new System.Drawing.Point(321, 267);
            this.grpCondiments.Name = "grpCondiments";
            this.grpCondiments.Size = new System.Drawing.Size(200, 272);
            this.grpCondiments.TabIndex = 3;
            this.grpCondiments.TabStop = false;
            this.grpCondiments.Text = "Condiments";
            // 
            // chkPickles
            // 
            this.chkPickles.AutoSize = true;
            this.chkPickles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPickles.Location = new System.Drawing.Point(17, 231);
            this.chkPickles.Name = "chkPickles";
            this.chkPickles.Size = new System.Drawing.Size(78, 22);
            this.chkPickles.TabIndex = 4;
            this.chkPickles.Text = "Pickles";
            this.chkPickles.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(17, 189);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(78, 22);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomato.Location = new System.Drawing.Point(17, 141);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(82, 22);
            this.chkTomato.TabIndex = 2;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLettuce.Location = new System.Drawing.Point(17, 89);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(78, 22);
            this.chkLettuce.TabIndex = 1;
            this.chkLettuce.Text = "Lettuce";
            this.chkLettuce.UseVisualStyleBackColor = true;
            // 
            // chkMustard
            // 
            this.chkMustard.AutoSize = true;
            this.chkMustard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMustard.Location = new System.Drawing.Point(17, 43);
            this.chkMustard.Name = "chkMustard";
            this.chkMustard.Size = new System.Drawing.Size(84, 22);
            this.chkMustard.TabIndex = 0;
            this.chkMustard.Text = "Mustard";
            this.chkMustard.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(642, 81);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(289, 234);
            this.txtOrder.TabIndex = 4;
            this.txtOrder.Text = "";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(657, 341);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(229, 58);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(657, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(229, 54);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.grpCondiments);
            this.Controls.Add(this.grpMeats);
            this.Controls.Add(this.grpCheese);
            this.Controls.Add(this.grpBread);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.Text = "Sandwich Order";
            this.grpBread.ResumeLayout(false);
            this.grpBread.PerformLayout();
            this.grpCheese.ResumeLayout(false);
            this.grpCheese.PerformLayout();
            this.grpMeats.ResumeLayout(false);
            this.grpMeats.PerformLayout();
            this.grpCondiments.ResumeLayout(false);
            this.grpCondiments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBread;
        private System.Windows.Forms.RadioButton rdoWheat;
        private System.Windows.Forms.RadioButton rdoItalian;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.GroupBox grpCheese;
        private System.Windows.Forms.RadioButton rdoPepperJack;
        private System.Windows.Forms.RadioButton rdoAmerican;
        private System.Windows.Forms.RadioButton rdoCheddar;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.GroupBox grpMeats;
        private System.Windows.Forms.GroupBox grpCondiments;
        private System.Windows.Forms.CheckBox chkNone;
        private System.Windows.Forms.CheckBox chkSalami;
        private System.Windows.Forms.CheckBox chkRoastedBeef;
        private System.Windows.Forms.CheckBox chkFriedChicken;
        private System.Windows.Forms.CheckBox chkPickles;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkMustard;
        private System.Windows.Forms.RichTextBox txtOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}

