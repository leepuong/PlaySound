namespace PlaySound
{
    partial class frmPlaySound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaySound));
            this.btnFF = new System.Windows.Forms.Button();
            this.btnAngHiu = new System.Windows.Forms.Button();
            this.lblStop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFF
            // 
            this.btnFF.BackColor = System.Drawing.Color.Red;
            this.btnFF.Location = new System.Drawing.Point(183, 337);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(75, 23);
            this.btnFF.TabIndex = 0;
            this.btnFF.Text = "FreeFire";
            this.btnFF.UseVisualStyleBackColor = false;
            this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
            // 
            // btnAngHiu
            // 
            this.btnAngHiu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAngHiu.Location = new System.Drawing.Point(538, 337);
            this.btnAngHiu.Name = "btnAngHiu";
            this.btnAngHiu.Size = new System.Drawing.Size(75, 23);
            this.btnAngHiu.TabIndex = 0;
            this.btnAngHiu.Text = "ĂngHiu";
            this.btnAngHiu.UseVisualStyleBackColor = false;
            this.btnAngHiu.Click += new System.EventHandler(this.btnAngHiu_Click);
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.BackColor = System.Drawing.Color.Transparent;
            this.lblStop.ForeColor = System.Drawing.Color.Transparent;
            this.lblStop.Location = new System.Drawing.Point(373, 20);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(35, 16);
            this.lblStop.TabIndex = 1;
            this.lblStop.Text = "Stop";
            this.lblStop.Click += new System.EventHandler(this.lblStop_Click);
            // 
            // frmPlaySound
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PlaySound.Properties.Resources.morpheus1_1590897312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 451);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.btnAngHiu);
            this.Controls.Add(this.btnFF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlaySound";
            this.Text = "Your choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnAngHiu;
        private System.Windows.Forms.Label lblStop;
    }
}

