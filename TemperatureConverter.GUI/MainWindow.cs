using TemperatureConverter.Models;

namespace TemperatureConverter.GUI
{
    public partial class MainWindow : Form
    {
        Methoden methoden = new Methoden();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbCtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCtoF.Checked)
            {
                numTemperature.Minimum = (decimal) -273.15;
                lblTempertureUnit.Text = "°C";
                lblConvertedUnit.Text = "°F";
                lblConvertedTemperature.Text = methoden.CtoF(numTemperature.Value);
            }
        }

        private void rbFtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFtoC.Checked)
            {
                numTemperature.Minimum = (decimal) -459;
                lblTempertureUnit.Text = "°F";
                lblConvertedUnit.Text = "°C";
                lblConvertedTemperature.Text = methoden.FtoC(numTemperature.Value);
            }
        }

        private void rbCtoK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCtoK.Checked)
            {
                lblTempertureUnit.Text = "°C";
                lblConvertedUnit.Text = "°K";
                lblConvertedTemperature.Text = Convert.ToString(numTemperature.Value + (decimal)273.15);
            }
        }

        private void rbKtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKtoC.Checked)
            {
                numTemperature.Minimum = 0;
                lblTempertureUnit.Text = "°K";
                lblConvertedUnit.Text = "°C";
                lblConvertedTemperature.Text = Convert.ToString(numTemperature.Value - (decimal)273.15);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numTemperature_ValueChanged(object sender, EventArgs e)
        {
            rbCtoF_CheckedChanged(sender, e);
            rbFtoC_CheckedChanged(sender, e);
            rbCtoK_CheckedChanged(sender, e);
            rbKtoC_CheckedChanged(sender, e);
        }
    }
}