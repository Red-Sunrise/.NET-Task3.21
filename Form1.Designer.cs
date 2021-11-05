namespace Task3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.AddCarriageButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaxBaggageAmount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.MinBaggageAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxComfortLevel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.MinComfortLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxPassengerAmount = new System.Windows.Forms.NumericUpDown();
            this.MinPassengerAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalPassengerAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalBaggageAmount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBaggageAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBaggageAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxComfortLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinComfortLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPassengerAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPassengerAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carriages List";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(251, 5);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 404);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.ChangeScrollerValue);
            // 
            // AddCarriageButton
            // 
            this.AddCarriageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCarriageButton.Location = new System.Drawing.Point(318, 17);
            this.AddCarriageButton.Name = "AddCarriageButton";
            this.AddCarriageButton.Size = new System.Drawing.Size(108, 38);
            this.AddCarriageButton.TabIndex = 1;
            this.AddCarriageButton.Text = "Add Carriage";
            this.AddCarriageButton.UseVisualStyleBackColor = true;
            this.AddCarriageButton.Click += new System.EventHandler(this.AddCarriageButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearListButton.Location = new System.Drawing.Point(432, 17);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(142, 38);
            this.ClearListButton.TabIndex = 2;
            this.ClearListButton.Text = "Clear Carriages List";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxOrder);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.MaxBaggageAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.MinBaggageAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.MaxComfortLevel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MinComfortLevel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.MaxPassengerAmount);
            this.groupBox2.Controls.Add(this.MinPassengerAmount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(318, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 359);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Items.AddRange(new object[] {
            "no order",
            "Comfort Level",
            "Passenger Amount",
            "Baggage Amount"});
            this.comboBoxOrder.Location = new System.Drawing.Point(53, 37);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrder.TabIndex = 17;
            this.comboBoxOrder.Text = "no order";
            this.comboBoxOrder.TextChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Order:";
            // 
            // MaxBaggageAmount
            // 
            this.MaxBaggageAmount.Location = new System.Drawing.Point(189, 231);
            this.MaxBaggageAmount.Name = "MaxBaggageAmount";
            this.MaxBaggageAmount.Size = new System.Drawing.Size(53, 20);
            this.MaxBaggageAmount.TabIndex = 15;
            this.MaxBaggageAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxBaggageAmount.ValueChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "max";
            // 
            // MinBaggageAmount
            // 
            this.MinBaggageAmount.Location = new System.Drawing.Point(101, 231);
            this.MinBaggageAmount.Name = "MinBaggageAmount";
            this.MinBaggageAmount.Size = new System.Drawing.Size(53, 20);
            this.MinBaggageAmount.TabIndex = 13;
            this.MinBaggageAmount.ValueChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Baggage Amount:";
            // 
            // MaxComfortLevel
            // 
            this.MaxComfortLevel.Location = new System.Drawing.Point(189, 169);
            this.MaxComfortLevel.Name = "MaxComfortLevel";
            this.MaxComfortLevel.Size = new System.Drawing.Size(53, 20);
            this.MaxComfortLevel.TabIndex = 10;
            this.MaxComfortLevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxComfortLevel.ValueChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "max";
            // 
            // MinComfortLevel
            // 
            this.MinComfortLevel.Location = new System.Drawing.Point(101, 169);
            this.MinComfortLevel.Name = "MinComfortLevel";
            this.MinComfortLevel.Size = new System.Drawing.Size(53, 20);
            this.MinComfortLevel.TabIndex = 8;
            this.MinComfortLevel.ValueChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comfort Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "min";
            // 
            // MaxPassengerAmount
            // 
            this.MaxPassengerAmount.Location = new System.Drawing.Point(189, 113);
            this.MaxPassengerAmount.Name = "MaxPassengerAmount";
            this.MaxPassengerAmount.Size = new System.Drawing.Size(53, 20);
            this.MaxPassengerAmount.TabIndex = 3;
            this.MaxPassengerAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxPassengerAmount.ValueChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // MinPassengerAmount
            // 
            this.MinPassengerAmount.Location = new System.Drawing.Point(98, 113);
            this.MinPassengerAmount.Name = "MinPassengerAmount";
            this.MinPassengerAmount.Size = new System.Drawing.Size(53, 20);
            this.MinPassengerAmount.TabIndex = 2;
            this.MinPassengerAmount.ValueChanged += new System.EventHandler(this.UpdateCarriagesListFilters);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passenger Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total Passenger Amount = ";
            // 
            // TotalPassengerAmount
            // 
            this.TotalPassengerAmount.AutoSize = true;
            this.TotalPassengerAmount.Location = new System.Drawing.Point(150, 428);
            this.TotalPassengerAmount.Name = "TotalPassengerAmount";
            this.TotalPassengerAmount.Size = new System.Drawing.Size(13, 13);
            this.TotalPassengerAmount.TabIndex = 19;
            this.TotalPassengerAmount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total Baggage Amount =";
            // 
            // TotalBaggageAmount
            // 
            this.TotalBaggageAmount.AutoSize = true;
            this.TotalBaggageAmount.Location = new System.Drawing.Point(150, 441);
            this.TotalBaggageAmount.Name = "TotalBaggageAmount";
            this.TotalBaggageAmount.Size = new System.Drawing.Size(13, 13);
            this.TotalBaggageAmount.TabIndex = 21;
            this.TotalBaggageAmount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.TotalBaggageAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TotalPassengerAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.AddCarriageButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBaggageAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBaggageAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxComfortLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinComfortLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPassengerAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPassengerAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button AddCarriageButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxPassengerAmount;
        private System.Windows.Forms.NumericUpDown MinPassengerAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MaxComfortLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MinComfortLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MaxBaggageAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown MinBaggageAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TotalPassengerAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TotalBaggageAmount;
    }
}