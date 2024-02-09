namespace Play_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.AccessibleName = "background";
            this.background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.background.Location = new System.Drawing.Point(-1, -3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(811, 463);
            this.background.TabIndex = 0;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startbutton.Location = new System.Drawing.Point(338, 72);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(123, 57);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Begin Game";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // gametimer
            // 
            this.gametimer.AccessibleName = "Background";
            this.gametimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gametimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gametimer.Location = new System.Drawing.Point(164, 240);
            this.gametimer.Name = "gametimer";
            this.gametimer.Size = new System.Drawing.Size(458, 176);
            this.gametimer.TabIndex = 2;
            this.gametimer.Text = "Ready in Three !!!";
            this.gametimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gametime
            // 
            this.gametime.AccessibleName = "Background";
            this.gametime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gametime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gametime.Location = new System.Drawing.Point(171, 137);
            this.gametime.Name = "gametime";
            this.gametime.Size = new System.Drawing.Size(458, 176);
            this.gametime.TabIndex = 3;
            this.gametime.Text = "Begin !!!";
            this.gametime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gametime);
            this.Controls.Add(this.gametimer);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label gametimer;
        private System.Windows.Forms.Label gametime;
        private System.Windows.Forms.Button startbutton;
    }
}

