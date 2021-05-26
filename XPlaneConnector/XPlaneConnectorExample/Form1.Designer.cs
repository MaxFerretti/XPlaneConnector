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
            this.btnIgnite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(9, 10);
            this.btStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(56, 19);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btBatteryOn
            // 
            this.btBatteryOn.BackColor = System.Drawing.Color.Green;
            this.btBatteryOn.Location = new System.Drawing.Point(9, 258);
            this.btBatteryOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBatteryOn.Name = "btBatteryOn";
            this.btBatteryOn.Size = new System.Drawing.Size(56, 19);
            this.btBatteryOn.TabIndex = 2;
            this.btBatteryOn.Text = "Batt ON";
            this.btBatteryOn.UseVisualStyleBackColor = false;
            this.btBatteryOn.Click += new System.EventHandler(this.btBatteryOn_Click);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(9, 33);
            this.tbOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(550, 221);
            this.tbOut.TabIndex = 3;
            // 
            // btBatteryOff
            // 
            this.btBatteryOff.BackColor = System.Drawing.Color.Red;
            this.btBatteryOff.Location = new System.Drawing.Point(70, 258);
            this.btBatteryOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBatteryOff.Name = "btBatteryOff";
            this.btBatteryOff.Size = new System.Drawing.Size(56, 19);
            this.btBatteryOff.TabIndex = 4;
            this.btBatteryOff.Text = "Batt OFF";
            this.btBatteryOff.UseVisualStyleBackColor = false;
            this.btBatteryOff.Click += new System.EventHandler(this.btBatteryOff_Click);
            // 
            // btNavUp
            // 
            this.btNavUp.Location = new System.Drawing.Point(502, 258);
            this.btNavUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNavUp.Name = "btNavUp";
            this.btNavUp.Size = new System.Drawing.Size(56, 19);
            this.btNavUp.TabIndex = 5;
            this.btNavUp.Text = "NAV UP";
            this.btNavUp.UseVisualStyleBackColor = true;
            this.btNavUp.Click += new System.EventHandler(this.btNavUp_Click);
            // 
            // btNavDown
            // 
            this.btNavDown.Location = new System.Drawing.Point(502, 282);
            this.btNavDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNavDown.Name = "btNavDown";
            this.btNavDown.Size = new System.Drawing.Size(56, 19);
            this.btNavDown.TabIndex = 6;
            this.btNavDown.Text = "NAV DW";
            this.btNavDown.UseVisualStyleBackColor = true;
            this.btNavDown.Click += new System.EventHandler(this.btNavDown_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(9, 284);
            this.btQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(56, 19);
            this.btQuit.TabIndex = 7;
            this.btQuit.Text = "QUIT";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btnIgnite
            // 
            this.btnIgnite.Location = new System.Drawing.Point(130, 258);
            this.btnIgnite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIgnite.Name = "btnIgnite";
            this.btnIgnite.Size = new System.Drawing.Size(56, 19);
            this.btnIgnite.TabIndex = 8;
            this.btnIgnite.Text = "IGNITE";
            this.btnIgnite.UseVisualStyleBackColor = true;
            this.btnIgnite.Click += new System.EventHandler(this.btnIgnite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 312);
            this.Controls.Add(this.btnIgnite);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btNavDown);
            this.Controls.Add(this.btNavUp);
            this.Controls.Add(this.btBatteryOff);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.btBatteryOn);
            this.Controls.Add(this.btStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnIgnite;
    }
}

