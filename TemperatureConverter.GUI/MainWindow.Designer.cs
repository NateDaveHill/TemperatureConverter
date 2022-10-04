namespace TemperatureConverter.GUI
{
    partial class MainWindow
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
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTempertureUnit = new System.Windows.Forms.Label();
            this.lblConvertedTemperature = new System.Windows.Forms.Label();
            this.lblConvertedUnit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKtoC = new System.Windows.Forms.RadioButton();
            this.rbCtoK = new System.Windows.Forms.RadioButton();
            this.rbFtoC = new System.Windows.Forms.RadioButton();
            this.rbCtoF = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(32, 33);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(96, 20);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Temperature:";
            // 
            // lblTempertureUnit
            // 
            this.lblTempertureUnit.AutoSize = true;
            this.lblTempertureUnit.Location = new System.Drawing.Point(209, 33);
            this.lblTempertureUnit.Name = "lblTempertureUnit";
            this.lblTempertureUnit.Size = new System.Drawing.Size(52, 20);
            this.lblTempertureUnit.TabIndex = 1;
            this.lblTempertureUnit.Text = "temp1";
            // 
            // lblConvertedTemperature
            // 
            this.lblConvertedTemperature.AutoSize = true;
            this.lblConvertedTemperature.Location = new System.Drawing.Point(143, 74);
            this.lblConvertedTemperature.Name = "lblConvertedTemperature";
            this.lblConvertedTemperature.Size = new System.Drawing.Size(52, 20);
            this.lblConvertedTemperature.TabIndex = 2;
            this.lblConvertedTemperature.Text = "temp2";
            // 
            // lblConvertedUnit
            // 
            this.lblConvertedUnit.AutoSize = true;
            this.lblConvertedUnit.Location = new System.Drawing.Point(209, 74);
            this.lblConvertedUnit.Name = "lblConvertedUnit";
            this.lblConvertedUnit.Size = new System.Drawing.Size(52, 20);
            this.lblConvertedUnit.TabIndex = 3;
            this.lblConvertedUnit.Text = "temp3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKtoC);
            this.groupBox1.Controls.Add(this.rbCtoK);
            this.groupBox1.Controls.Add(this.rbFtoC);
            this.groupBox1.Controls.Add(this.rbCtoF);
            this.groupBox1.Location = new System.Drawing.Point(32, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Umrechnung";
            // 
            // rbKtoC
            // 
            this.rbKtoC.AutoSize = true;
            this.rbKtoC.Location = new System.Drawing.Point(21, 125);
            this.rbKtoC.Name = "rbKtoC";
            this.rbKtoC.Size = new System.Drawing.Size(150, 24);
            this.rbKtoC.TabIndex = 3;
            this.rbKtoC.TabStop = true;
            this.rbKtoC.Text = "Kevin nach Celsius";
            this.rbKtoC.UseVisualStyleBackColor = true;
            this.rbKtoC.CheckedChanged += new System.EventHandler(this.rbKtoC_CheckedChanged);
            // 
            // rbCtoK
            // 
            this.rbCtoK.AutoSize = true;
            this.rbCtoK.Location = new System.Drawing.Point(21, 95);
            this.rbCtoK.Name = "rbCtoK";
            this.rbCtoK.Size = new System.Drawing.Size(150, 24);
            this.rbCtoK.TabIndex = 2;
            this.rbCtoK.TabStop = true;
            this.rbCtoK.Text = "Celsius nach Kevin";
            this.rbCtoK.UseVisualStyleBackColor = true;
            this.rbCtoK.CheckedChanged += new System.EventHandler(this.rbCtoK_CheckedChanged);
            // 
            // rbFtoC
            // 
            this.rbFtoC.AutoSize = true;
            this.rbFtoC.Location = new System.Drawing.Point(21, 65);
            this.rbFtoC.Name = "rbFtoC";
            this.rbFtoC.Size = new System.Drawing.Size(182, 24);
            this.rbFtoC.TabIndex = 1;
            this.rbFtoC.TabStop = true;
            this.rbFtoC.Text = "Fahrenheit nach Celsius";
            this.rbFtoC.UseVisualStyleBackColor = true;
            this.rbFtoC.CheckedChanged += new System.EventHandler(this.rbFtoC_CheckedChanged);
            // 
            // rbCtoF
            // 
            this.rbCtoF.AutoSize = true;
            this.rbCtoF.Location = new System.Drawing.Point(21, 35);
            this.rbCtoF.Name = "rbCtoF";
            this.rbCtoF.Size = new System.Drawing.Size(182, 24);
            this.rbCtoF.TabIndex = 0;
            this.rbCtoF.TabStop = true;
            this.rbCtoF.Text = "Celsius nach Fahrenheit";
            this.rbCtoF.UseVisualStyleBackColor = true;
            this.rbCtoF.CheckedChanged += new System.EventHandler(this.rbCtoF_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(32, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(254, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(133, 33);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(70, 27);
            this.txtTemperature.TabIndex = 6;
            this.txtTemperature.TextChanged += new System.EventHandler(this.txtTemperature_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 344);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblConvertedUnit);
            this.Controls.Add(this.lblConvertedTemperature);
            this.Controls.Add(this.lblTempertureUnit);
            this.Controls.Add(this.lblTemperature);
            this.Name = "MainWindow";
            this.Text = "TemperatureConverter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTemperature;
        private Label lblTempertureUnit;
        private Label lblConvertedTemperature;
        private Label lblConvertedUnit;
        private GroupBox groupBox1;
        private RadioButton rbKtoC;
        private RadioButton rbCtoK;
        private RadioButton rbFtoC;
        private RadioButton rbCtoF;
        private Button btnClose;
        private TextBox txtTemperature;
    }
}