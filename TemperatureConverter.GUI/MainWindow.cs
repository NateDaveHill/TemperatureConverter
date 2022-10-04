namespace TemperatureConverter.GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbCtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCtoF.Checked)
            {
                lblTempertureUnit.Text = "°C";
                lblConvertedUnit.Text = "°F";
                lblConvertedTemperature.Text = Convert.ToString(numTemperature.Value * 9 / 5 + 32);
            }
        }

        private void rbFtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFtoC.Checked)
            {
                lblTempertureUnit.Text = "°F";
                lblConvertedUnit.Text = "°C";
                lblConvertedTemperature.Text = String.Format("{0:0.000}", (numTemperature.Value - 32) * 5 / 9);
            }
        }

        private void rbCtoK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbKtoC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numTemperature_ValueChanged(object sender, EventArgs e)
        {
            rbCtoF_CheckedChanged(sender, e);
            rbFtoC_CheckedChanged(sender, e);
        }
    }
}