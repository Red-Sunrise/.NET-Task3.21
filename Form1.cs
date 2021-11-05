using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carriages;

namespace Task3
{
    public partial class Form1 : Form
    {
        private List<CarriageInfo> CarriagesList = new List<CarriageInfo>();
        private List<Carriage> Carriages = new List<Carriage>();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddCarriageButton_Click(object sender, EventArgs e)
        {
            new FormAddCarriage(this).ShowDialog();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            foreach(CarriageInfo current in this.CarriagesList)
            {
                current.Visible = false;
                this.Carriages.Remove(current.carriage);
            }
            this.CarriagesList.Clear();
            ChangeScroller();
        }
        private void ChangeScrollerValue(object sender,EventArgs e)
        {
            SetCarriageLocation(0);
        }

        private void UpdateCarriagesListFilters(object sender,EventArgs e)
        {
            foreach(CarriageInfo current in this.CarriagesList)
            {
                current.Visible = false;
            }
            this.CarriagesList.Clear();

            foreach(Carriage carriage in this.Carriages)
            {
                int index = PositionInList(carriage);
                if(index >= 0)
                {
                    this.CarriagesList.Insert(index, new CarriageInfo(carriage, this));

                    SetCarriageLocation(index);
                    ChangeScroller();
                }
            }
        }

        private void RemoveCarriage(CarriageInfo carriage)
        {
            this.CarriagesList.Remove(carriage);
            this.Carriages.Remove(carriage.carriage);
            carriage.Visible = false;

            SetCarriageLocation(0);
            ChangeScroller();
        }

        public void AddCarriage(Carriage carriage)
        {
            this.Carriages.Add(carriage);
            int index = PositionInList(carriage);
            if (index >= 0)
            {
                this.CarriagesList.Insert(index, new CarriageInfo(carriage, this));

                SetCarriageLocation(index);
                ChangeScroller();
            }
        }

        private int PositionInList(Carriage carriage)
        {
            if (carriage.ComfortLevel < Convert.ToInt32(MinComfortLevel.Value) ||
               carriage.ComfortLevel > Convert.ToInt32(MaxComfortLevel.Value) ||
               carriage.PassengerAmount < Convert.ToInt32(MinPassengerAmount.Value) ||
               carriage.PassengerAmount > Convert.ToInt32(MaxPassengerAmount.Value) ||
               carriage.BaggageAmount < Convert.ToInt32(MinBaggageAmount.Value) ||
               carriage.BaggageAmount > Convert.ToInt32(MaxBaggageAmount.Value)) {
                return -1;
            }

            if ("no order".Equals(comboBoxOrder.Text))
            {
                return 0;
            }

            int index = 0;
            foreach(CarriageInfo current in this.CarriagesList)
            {
                if("Comfort Level".Equals(comboBoxOrder.Text) && carriage.ComfortLevel <= current.carriage.ComfortLevel ||
                    "Passenger Amount".Equals(comboBoxOrder.Text) && carriage.PassengerAmount <= current.carriage.PassengerAmount ||
                    "Baggage Amount".Equals(comboBoxOrder.Text) && carriage.BaggageAmount <= current.carriage.BaggageAmount)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        private void ChangeScroller()
        {
            this.vScrollBar1.Minimum = 0;
            if (this.CarriagesList.Count <= 3)
            {
                this.vScrollBar1.Value = 0;
                this.vScrollBar1.Maximum = 0;
            }
            else
            {
                int max = (this.CarriagesList.Count - 3) * 90;
                if (this.vScrollBar1.Value > max) 
                { 
                    this.vScrollBar1.Value = max; 
                }
 
                this.vScrollBar1.Maximum = max;
            }
        }
        private Point AddNewPoint(int index)
        {
            return new Point(5, 30 + 90 * index - vScrollBar1.Value);
        }
        private void SetCarriageLocation(int startIndex)
        {
            for (int i = startIndex; i < this.CarriagesList.Count; i++)
            {
                CarriageInfo current = this.CarriagesList[i];
                current.Location = AddNewPoint(i);
            }
        }



        private class CarriageInfo : Panel
        {
            internal Carriage carriage;
            private Label descriptionLabel = new Label();
            private Button removeButton = new Button();
            private Form1 form;

            private void removeButton_Click(object sender,EventArgs e)
            {
                this.form.RemoveCarriage(this);
            }
            
            public CarriageInfo(Carriage carriage,Form1 form)
            {
                this.carriage = carriage;
                this.form = form;
                string description = string.Format(" Carriage: Comfort Level-{0}, \n Amount of Passengers-{1}, \n Amount of Baggages-{2}.",
                    carriage.ComfortLevel, carriage.PassengerAmount, carriage.BaggageAmount);
                
                this.descriptionLabel.AutoSize = true;
                this.descriptionLabel.Text = description;
                this.Controls.Add(this.descriptionLabel);

                this.removeButton.AutoSize = true;
                this.removeButton.Text = "Remove.";
                this.removeButton.Click += new EventHandler(this.removeButton_Click);
                this.removeButton.Location = new Point(0, 60);
                this.Controls.Add(this.removeButton);

                form.groupBox1.Controls.Add(this);
                this.Size = new Size(250, 90);
            }
        }
    }
}
