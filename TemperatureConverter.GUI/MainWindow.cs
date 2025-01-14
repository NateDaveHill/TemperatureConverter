using TemperatureConverter.Models;

namespace TemperatureConverter.GUI
{
    /// <summary>
    /// This class contains the logic and inialization-methods for my TemperatureConverter App.
    /// </summary> 
    public partial class MainWindow : Form
    {

        /// <summary>
        /// With Line 13 I initialize the Methoden Class so that I can access the defined methods with the converstion Logic
        /// </summary>
        Methoden methoden = new Methoden();

        /// <summary>
        /// MainWindow is the Constructor which runs the InitilizeComponent Method for my MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// In the If-statement I run a breif validation to see if the radiobutton ist checked.
        /// If this is true the Code proceeds to runnig the next lines of Code in the Codeblock.
        /// Definint the Minimum temperature the User can Input, setting the Labels to the right Unit and
        /// converting the UserInput with the Methods from the Temperature.Models Class called "Methoden".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCtoF.Checked)
            {
                GuiTextFilling((decimal)-273.15, "�C", "�F");
                lblConvertedTemperature.Text = methoden.CtoF(numTemperature.Value);
            }
        }

        /// <summary>
        /// In the If-statement I run a breif validation to see if the radiobutton ist checked.
        /// If this is true the Code proceeds to runnig the next lines of Code in the Codeblock.
        /// Definint the Minimum temperature the User can Input, setting the Labels to the right Unit and
        /// converting the UserInput with the Methods from the Temperature.Models Class called "Methoden".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbFtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFtoC.Checked)
            {
                GuiTextFilling((decimal)-459, "�F", "�C");
                lblConvertedTemperature.Text = methoden.FtoC(numTemperature.Value);
            }
        }

        /// <summary>
        /// In the If-statement I run a breif validation to see if the radiobutton ist checked.
        /// If this is true the Code proceeds to runnig the next lines of Code in the Codeblock.
        /// Definint the Minimum temperature the User can Input, setting the Labels to the right Unit and
        /// converting the UserInput with the Methods from the Temperature.Models Class called "Methoden".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCtoK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCtoK.Checked)
            {
                GuiTextFilling((decimal)-273.15, "�C", "�K");
                lblConvertedTemperature.Text = methoden.CtoK(numTemperature.Value);
            }
        }

        /// <summary>
        /// In the If-statement I run a breif validation to see if the radiobutton ist checked.
        /// If this is true the Code proceeds to runnig the next lines of Code in the Codeblock.
        /// Definint the Minimum temperature the User can Input, setting the Labels to the right Unit and
        /// converting the UserInput with the Methods from the Temperature.Models Class called "Methoden".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbKtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKtoC.Checked)
            {
                GuiTextFilling(0, "�K", "�C");
                lblConvertedTemperature.Text = methoden.KtoC(numTemperature.Value);
            }
        }

        /// <summary>
        /// This Method is executed when the Button is clicked and simply closes the MainWindow.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This Method is designed to instantly update the values when the NumericUpDown arrows are being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numTemperature_ValueChanged(object sender, EventArgs e)
        {
            rbCtoF_CheckedChanged(sender, e);
            rbFtoC_CheckedChanged(sender, e);
            rbCtoK_CheckedChanged(sender, e);
            rbKtoC_CheckedChanged(sender, e);
        }

        /// <summary>
        /// This Method was created to reduce redundance in the Code and remove some lines of Code.
        /// </summary>
        /// <param name="tempMin"></param>
        /// <param name="tempUnit"></param>
        /// <param name="tempConvertedUnit"></param>
        private void GuiTextFilling(decimal tempMin, string tempUnit, string tempConvertedUnit)
        {
            numTemperature.Minimum = tempMin;
            lblTempertureUnit.Text = tempUnit;
            lblConvertedUnit.Text = tempConvertedUnit;
        }
    }
}