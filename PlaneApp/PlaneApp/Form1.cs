using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text))
            {
                MessageBox.Show("Введите марку самолета");
                return;
            }

            int engineCount = (int)numEngineCount.Value;
            if (engineCount <= 0)
            {
                MessageBox.Show("Количество двигателей должно быть больше нуля");
                return;
            }

            int altitude = (int)numAltitude.Value;
            string country = cmbCountry.SelectedItem?.ToString();

            Plane plane;
            if ((country == "Россия")||((country == "Франция")))
            {
                plane = new CountryPlane(txtBrand.Text, engineCount, altitude, country);
            }
            else
            {
                plane = new Plane(txtBrand.Text, engineCount, altitude);
            }

            double quality = plane.CalculateQuality();

            lblResult.Text = $"Качество самолета {txtBrand.Text}: {quality}";
            MessageBox.Show(plane.ToString());
        }
    }
}
