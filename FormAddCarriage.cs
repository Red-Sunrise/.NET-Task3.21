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
    public partial class FormAddCarriage : Form
    {
        Form1 form;
        public FormAddCarriage(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int comfortLevel = Convert.ToInt32(ComfortLevel.Value);
            int passengerAmount = Convert.ToInt32(PassengerAmount.Value);
            int baggageAmount = Convert.ToInt32(BaggageAmount.Value);
            Carriage carriage = new Carriage(comfortLevel, passengerAmount, baggageAmount);
            form.AddCarriage(carriage);
            this.Close();
        }
         
    }
}
