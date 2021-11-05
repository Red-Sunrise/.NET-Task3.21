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
        private List<CarriageDisplay> ListDisplayedCarriages = new List<CarriageDisplay>();
        private Train Train = new Train();
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
            foreach(CarriageDisplay current in this.ListDisplayedCarriages)
            {
                current.Visible = false;
                this.Train.Carriages.Remove(current.carriage);
            }
            this.ListDisplayedCarriages.Clear();
            ChangeScroller();
            UpdateTrainInformation();
        }

        private void ChangeScrollerValue(object sender,EventArgs e)
        {
            SetCarriageLocation(0);
        }

        private void UpdateCarriagesListFilters(object sender,EventArgs e)
        {
            foreach(CarriageDisplay current in this.ListDisplayedCarriages)
            {
                current.Visible = false;
            }
            this.ListDisplayedCarriages.Clear();

            foreach(Carriage carriage in this.Train.Carriages)
            {
                int index = PositionInList(carriage);
                if(index >= 0)
                {
                    this.ListDisplayedCarriages.Insert(index, new CarriageDisplay(carriage, this));
                    SetCarriageLocation(index);
                    ChangeScroller();
                }
            }
        }

        private void RemoveCarriage(CarriageDisplay carriage)
        {
            this.ListDisplayedCarriages.Remove(carriage);
            Train.Carriages.Remove(carriage.carriage);
            carriage.Visible = false;
            SetCarriageLocation(0);
            ChangeScroller();
            UpdateTrainInformation();
        }

        public void AddCarriage(Carriage carriage)
        {
            Train.Carriages.Add(carriage);
            int index = PositionInList(carriage);
            if (index >= 0)
            {
                this.ListDisplayedCarriages.Insert(index, new CarriageDisplay(carriage, this));
                SetCarriageLocation(index);
                ChangeScroller();
            }
            UpdateTrainInformation();
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
            foreach(CarriageDisplay current in this.ListDisplayedCarriages)
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
            if (this.ListDisplayedCarriages.Count <= 3)
            {
                this.vScrollBar1.Value = 0;
                this.vScrollBar1.Maximum = 0;
            }
            else
            {
                int max = (this.ListDisplayedCarriages.Count - 3) * 90;
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
            for (int i = startIndex; i < this.ListDisplayedCarriages.Count; i++)
            {
                CarriageDisplay current = this.ListDisplayedCarriages[i];
                current.Location = AddNewPoint(i);
            }
        }

        private void UpdateTrainInformation()
        {
            int totalPassengerAmount = Train.GetPassengerAmount();
            int totalBaggageAmount = Train.GetBaggageAmount();
            TotalPassengerAmount.Text = Convert.ToString(totalPassengerAmount);
            TotalBaggageAmount.Text = Convert.ToString(totalBaggageAmount);
        }

        private class CarriageDisplay : Panel
        {
            internal Carriage carriage;
            private Label descriptionLabel = new Label();
            private Button removeButton = new Button();
            private Form1 form;

            private void removeButton_Click(object sender,EventArgs e)
            {
                this.form.RemoveCarriage(this);
            }
            
            public CarriageDisplay(Carriage carriage,Form1 form)
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
