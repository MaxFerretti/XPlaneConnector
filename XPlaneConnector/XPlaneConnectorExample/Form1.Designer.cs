namespace XPlaneConnectorExample
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStart = new System.Windows.Forms.Button();
            this.btBatteryOn = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.btBatteryOff = new System.Windows.Forms.Button();
            this.btNavUp = new System.Windows.Forms.Button();
            this.btNavDown = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btBatteryOn
            // 
            this.btBatteryOn.BackColor = System.Drawing.Color.Green;
            this.btBatteryOn.Location = new System.Drawing.Point(12, 318);
            this.btBatteryOn.Name = "btBatteryOn";
            this.btBatteryOn.Size = new System.Drawing.Size(75, 23);
            this.btBatteryOn.TabIndex = 2;
            this.btBatteryOn.Text = "Batt ON";
            this.btBatteryOn.UseVisualStyleBackColor = false;
            this.btBatteryOn.Click += new System.EventHandler(this.btBatteryOn_Click);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(12, 41);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(732, 271);
            this.tbOut.TabIndex = 3;
            // 
            // btBatteryOff
            // 
            this.btBatteryOff.BackColor = System.Drawing.Color.Red;
            this.btBatteryOff.Location = new System.Drawing.Point(93, 318);
            this.btBatteryOff.Name = "btBatteryOff";
            this.btBatteryOff.Size = new System.Drawing.Size(75, 23);
            this.btBatteryOff.TabIndex = 4;
            this.btBatteryOff.Text = "Batt OFF";
            this.btBatteryOff.UseVisualStyleBackColor = false;
            this.btBatteryOff.Click += new System.EventHandler(this.btBatteryOff_Click);
            // 
            // btNavUp
            // 
            this.btNavUp.Location = new System.Drawing.Point(669, 318);
            this.btNavUp.Name = "btNavUp";
            this.btNavUp.Size = new System.Drawing.Size(75, 23);
            this.btNavUp.TabIndex = 5;
            this.btNavUp.Text = "NAV UP";
            this.btNavUp.UseVisualStyleBackColor = true;
            this.btNavUp.Click += new System.EventHandler(this.btNavUp_Click);
            // 
            // btNavDown
            // 
            this.btNavDown.Location = new System.Drawing.Point(669, 347);
            this.btNavDown.Name = "btNavDown";
            this.btNavDown.Size = new System.Drawing.Size(75, 23);
            this.btNavDown.TabIndex = 6;
            this.btNavDown.Text = "NAV DW";
            this.btNavDown.UseVisualStyleBackColor = true;
            this.btNavDown.Click += new System.EventHandler(this.btNavDown_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(12, 349);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(75, 23);
            this.btQuit.TabIndex = 7;
            this.btQuit.Text = "QUIT";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 384);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btNavDown);
            this.Controls.Add(this.btNavUp);
            this.Controls.Add(this.btBatteryOff);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.btBatteryOn);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "X-Plane Connector Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btBatteryOn;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Button btBatteryOff;
        private System.Windows.Forms.Button btNavUp;
        private System.Windows.Forms.Button btNavDown;
        private System.Windows.Forms.Button btQuit;
    }
}

