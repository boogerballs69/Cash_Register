namespace Cash_Register
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.item3Label = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item1Val = new System.Windows.Forms.TextBox();
            this.item2Val = new System.Windows.Forms.TextBox();
            this.item3Val = new System.Windows.Forms.TextBox();
            this.item1Worth = new System.Windows.Forms.Label();
            this.item2Worth = new System.Windows.Forms.Label();
            this.item3Worth = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.item2Amnt = new System.Windows.Forms.Label();
            this.item3Amnt = new System.Windows.Forms.Label();
            this.item1Amnt = new System.Windows.Forms.Label();
            this.item2Cost = new System.Windows.Forms.Label();
            this.item3Cost = new System.Windows.Forms.Label();
            this.item1Cost = new System.Windows.Forms.Label();
            this.subvalLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxvalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalvalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeVal = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(544, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CASH REGISTER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // item1Label
            // 
            this.item1Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item1Label.Location = new System.Drawing.Point(92, 22);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(100, 23);
            this.item1Label.TabIndex = 1;
            this.item1Label.Text = "# of Item1";
            this.item1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3Label
            // 
            this.item3Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item3Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item3Label.Location = new System.Drawing.Point(92, 103);
            this.item3Label.Name = "item3Label";
            this.item3Label.Size = new System.Drawing.Size(100, 23);
            this.item3Label.TabIndex = 3;
            this.item3Label.Text = "# of Item3";
            this.item3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2Label
            // 
            this.item2Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item2Label.Location = new System.Drawing.Point(92, 62);
            this.item2Label.Name = "item2Label";
            this.item2Label.Size = new System.Drawing.Size(100, 23);
            this.item2Label.TabIndex = 4;
            this.item2Label.Text = "# of Item2";
            this.item2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item1Val
            // 
            this.item1Val.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item1Val.Location = new System.Drawing.Point(208, 21);
            this.item1Val.Name = "item1Val";
            this.item1Val.Size = new System.Drawing.Size(100, 25);
            this.item1Val.TabIndex = 5;
            this.item1Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item2Val
            // 
            this.item2Val.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item2Val.Location = new System.Drawing.Point(208, 64);
            this.item2Val.Name = "item2Val";
            this.item2Val.Size = new System.Drawing.Size(100, 25);
            this.item2Val.TabIndex = 6;
            this.item2Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item3Val
            // 
            this.item3Val.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item3Val.Location = new System.Drawing.Point(208, 103);
            this.item3Val.Name = "item3Val";
            this.item3Val.Size = new System.Drawing.Size(100, 25);
            this.item3Val.TabIndex = 7;
            this.item3Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item1Worth
            // 
            this.item1Worth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1Worth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item1Worth.Location = new System.Drawing.Point(12, 21);
            this.item1Worth.Name = "item1Worth";
            this.item1Worth.Size = new System.Drawing.Size(66, 25);
            this.item1Worth.TabIndex = 8;
            this.item1Worth.Text = "$2.17";
            this.item1Worth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2Worth
            // 
            this.item2Worth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2Worth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item2Worth.Location = new System.Drawing.Point(12, 64);
            this.item2Worth.Name = "item2Worth";
            this.item2Worth.Size = new System.Drawing.Size(66, 25);
            this.item2Worth.TabIndex = 9;
            this.item2Worth.Text = "$3.25";
            this.item2Worth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3Worth
            // 
            this.item3Worth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item3Worth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item3Worth.Location = new System.Drawing.Point(12, 103);
            this.item3Worth.Name = "item3Worth";
            this.item3Worth.Size = new System.Drawing.Size(66, 25);
            this.item3Worth.TabIndex = 10;
            this.item3Worth.Text = "$10.00";
            this.item3Worth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(326, 137);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 23);
            this.calcButton.TabIndex = 11;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // item2Amnt
            // 
            this.item2Amnt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2Amnt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item2Amnt.Location = new System.Drawing.Point(12, 212);
            this.item2Amnt.Name = "item2Amnt";
            this.item2Amnt.Size = new System.Drawing.Size(185, 23);
            this.item2Amnt.TabIndex = 14;
            this.item2Amnt.Text = "Item2 0x";
            this.item2Amnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3Amnt
            // 
            this.item3Amnt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item3Amnt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item3Amnt.Location = new System.Drawing.Point(12, 248);
            this.item3Amnt.Name = "item3Amnt";
            this.item3Amnt.Size = new System.Drawing.Size(185, 23);
            this.item3Amnt.TabIndex = 13;
            this.item3Amnt.Text = "Item3 0x";
            this.item3Amnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item1Amnt
            // 
            this.item1Amnt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1Amnt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item1Amnt.Location = new System.Drawing.Point(12, 176);
            this.item1Amnt.Name = "item1Amnt";
            this.item1Amnt.Size = new System.Drawing.Size(185, 23);
            this.item1Amnt.TabIndex = 12;
            this.item1Amnt.Text = "Item1 0x";
            this.item1Amnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2Cost
            // 
            this.item2Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item2Cost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item2Cost.Location = new System.Drawing.Point(208, 212);
            this.item2Cost.Name = "item2Cost";
            this.item2Cost.Size = new System.Drawing.Size(100, 23);
            this.item2Cost.TabIndex = 17;
            this.item2Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3Cost
            // 
            this.item3Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item3Cost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item3Cost.Location = new System.Drawing.Point(208, 248);
            this.item3Cost.Name = "item3Cost";
            this.item3Cost.Size = new System.Drawing.Size(100, 23);
            this.item3Cost.TabIndex = 16;
            this.item3Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item1Cost
            // 
            this.item1Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item1Cost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item1Cost.Location = new System.Drawing.Point(208, 176);
            this.item1Cost.Name = "item1Cost";
            this.item1Cost.Size = new System.Drawing.Size(100, 23);
            this.item1Cost.TabIndex = 15;
            this.item1Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subvalLabel
            // 
            this.subvalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subvalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subvalLabel.Location = new System.Drawing.Point(208, 282);
            this.subvalLabel.Name = "subvalLabel";
            this.subvalLabel.Size = new System.Drawing.Size(100, 23);
            this.subvalLabel.TabIndex = 19;
            this.subvalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subLabel
            // 
            this.subLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subLabel.Location = new System.Drawing.Point(12, 282);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(185, 23);
            this.subLabel.TabIndex = 18;
            this.subLabel.Text = "Subtotal:";
            this.subLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxvalLabel
            // 
            this.taxvalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxvalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taxvalLabel.Location = new System.Drawing.Point(208, 314);
            this.taxvalLabel.Name = "taxvalLabel";
            this.taxvalLabel.Size = new System.Drawing.Size(100, 23);
            this.taxvalLabel.TabIndex = 21;
            this.taxvalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taxLabel.Location = new System.Drawing.Point(12, 314);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(185, 23);
            this.taxLabel.TabIndex = 20;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalvalLabel
            // 
            this.totalvalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalvalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalvalLabel.Location = new System.Drawing.Point(208, 350);
            this.totalvalLabel.Name = "totalvalLabel";
            this.totalvalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalvalLabel.TabIndex = 22;
            this.totalvalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(12, 350);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(185, 23);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(326, 350);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(86, 86);
            this.payButton.TabIndex = 24;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(326, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 25);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeVal
            // 
            this.changeVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeVal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeVal.Location = new System.Drawing.Point(208, 418);
            this.changeVal.Name = "changeVal";
            this.changeVal.Size = new System.Drawing.Size(100, 23);
            this.changeVal.TabIndex = 27;
            this.changeVal.Text = "$0.00";
            this.changeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeLabel.Location = new System.Drawing.Point(97, 418);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 23);
            this.changeLabel.TabIndex = 26;
            this.changeLabel.Text = "Change:";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.changeVal);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalvalLabel);
            this.Controls.Add(this.taxvalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subvalLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.item2Cost);
            this.Controls.Add(this.item3Cost);
            this.Controls.Add(this.item1Cost);
            this.Controls.Add(this.item2Amnt);
            this.Controls.Add(this.item3Amnt);
            this.Controls.Add(this.item1Amnt);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.item3Worth);
            this.Controls.Add(this.item2Worth);
            this.Controls.Add(this.item1Worth);
            this.Controls.Add(this.item3Val);
            this.Controls.Add(this.item2Val);
            this.Controls.Add(this.item1Val);
            this.Controls.Add(this.item2Label);
            this.Controls.Add(this.item3Label);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label item1Label;
        private Label item3Label;
        private Label item2Label;
        private TextBox item1Val;
        private TextBox item2Val;
        private TextBox item3Val;
        private Label item1Worth;
        private Label item2Worth;
        private Label item3Worth;
        private Button calcButton;
        private Label item2Amnt;
        private Label item3Amnt;
        private Label item1Amnt;
        private Label item2Cost;
        private Label item3Cost;
        private Label item1Cost;
        private Label subvalLabel;
        private Label subLabel;
        private Label taxvalLabel;
        private Label taxLabel;
        private Label totalvalLabel;
        private Label totalLabel;
        private Button payButton;
        private TextBox textBox1;
        private Label changeVal;
        private Label changeLabel;
    }
}