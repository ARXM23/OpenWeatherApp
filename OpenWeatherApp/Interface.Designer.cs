namespace OpenWeatherApp
{
    partial class Interface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(100, 12);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(152, 26);
            this.TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(258, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.Black;
            this.labCondition.Location = new System.Drawing.Point(26, 122);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(186, 21);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condiciones Climaticas";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.Black;
            this.labDetails.Location = new System.Drawing.Point(26, 143);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(68, 21);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Detalles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amanacer:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.Black;
            this.labSunset.Location = new System.Drawing.Point(96, 204);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(41, 21);
            this.labSunset.TabIndex = 6;
            this.labSunset.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ocaso:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.Black;
            this.labSunrise.Location = new System.Drawing.Point(121, 178);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(41, 21);
            this.labSunrise.TabIndex = 8;
            this.labSunrise.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(249, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Velocidad del Viento:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.Black;
            this.labWindSpeed.Location = new System.Drawing.Point(434, 143);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(41, 21);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(249, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Presión:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.Black;
            this.labPressure.Location = new System.Drawing.Point(341, 164);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(41, 21);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(30, 56);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(249, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura:";
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.ForeColor = System.Drawing.Color.Black;
            this.labTemperature.Location = new System.Drawing.Point(362, 103);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(41, 21);
            this.labTemperature.TabIndex = 15;
            this.labTemperature.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Humedad:";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.Black;
            this.labHumidity.Location = new System.Drawing.Point(341, 190);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(41, 21);
            this.labHumidity.TabIndex = 17;
            this.labHumidity.Text = "N/A";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(523, 394);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Interface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labHumidity;
    }
}

