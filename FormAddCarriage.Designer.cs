namespace Task3
{
    partial class FormAddCarriage
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
            this.AddButton = new System.Windows.Forms.Button();
            this.labelComfortLevel = new System.Windows.Forms.Label();
            this.labelPassengerAmount = new System.Windows.Forms.Label();
            this.labelBaggageAmount = new System.Windows.Forms.Label();
            this.ComfortLevel = new System.Windows.Forms.NumericUpDown();
            this.PassengerAmount = new System.Windows.Forms.NumericUpDown();
            this.BaggageAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ComfortLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaggageAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(210, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // labelComfortLevel
            // 
            this.labelComfortLevel.AutoSize = true;
            this.labelComfortLevel.Location = new System.Drawing.Point(1, 91);
            this.labelComfortLevel.Name = "labelComfortLevel";
            this.labelComfortLevel.Size = new System.Drawing.Size(72, 13);
            this.labelComfortLevel.TabIndex = 1;
            this.labelComfortLevel.Text = "ComfortLevel:";
            // 
            // labelPassengerAmount
            // 
            this.labelPassengerAmount.AutoSize = true;
            this.labelPassengerAmount.Location = new System.Drawing.Point(1, 118);
            this.labelPassengerAmount.Name = "labelPassengerAmount";
            this.labelPassengerAmount.Size = new System.Drawing.Size(96, 13);
            this.labelPassengerAmount.TabIndex = 2;
            this.labelPassengerAmount.Text = "PassengerAmount:";
            // 
            // labelBaggageAmount
            // 
            this.labelBaggageAmount.AutoSize = true;
            this.labelBaggageAmount.Location = new System.Drawing.Point(1, 144);
            this.labelBaggageAmount.Name = "labelBaggageAmount";
            this.labelBaggageAmount.Size = new System.Drawing.Size(89, 13);
            this.labelBaggageAmount.TabIndex = 3;
            this.labelBaggageAmount.Text = "BaggageAmount:";
            // 
            // ComfortLevel
            // 
            this.ComfortLevel.Location = new System.Drawing.Point(100, 89);
            this.ComfortLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ComfortLevel.Name = "ComfortLevel";
            this.ComfortLevel.Size = new System.Drawing.Size(53, 20);
            this.ComfortLevel.TabIndex = 4;
            // 
            // PassengerAmount
            // 
            this.PassengerAmount.Location = new System.Drawing.Point(100, 116);
            this.PassengerAmount.Name = "PassengerAmount";
            this.PassengerAmount.Size = new System.Drawing.Size(53, 20);
            this.PassengerAmount.TabIndex = 5;
            // 
            // BaggageAmount
            // 
            this.BaggageAmount.Location = new System.Drawing.Point(100, 142);
            this.BaggageAmount.Name = "BaggageAmount";
            this.BaggageAmount.Size = new System.Drawing.Size(53, 20);
            this.BaggageAmount.TabIndex = 6;
            // 
            // FormAddCarriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.BaggageAmount);
            this.Controls.Add(this.PassengerAmount);
            this.Controls.Add(this.ComfortLevel);
            this.Controls.Add(this.labelBaggageAmount);
            this.Controls.Add(this.labelPassengerAmount);
            this.Controls.Add(this.labelComfortLevel);
            this.Controls.Add(this.AddButton);
            this.Name = "FormAddCarriage";
            this.Text = "AddCarriageForm";
            ((System.ComponentModel.ISupportInitialize)(this.ComfortLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaggageAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label labelComfortLevel;
        private System.Windows.Forms.Label labelPassengerAmount;
        private System.Windows.Forms.Label labelBaggageAmount;
        private System.Windows.Forms.NumericUpDown ComfortLevel;
        private System.Windows.Forms.NumericUpDown PassengerAmount;
        private System.Windows.Forms.NumericUpDown BaggageAmount;
    }
}