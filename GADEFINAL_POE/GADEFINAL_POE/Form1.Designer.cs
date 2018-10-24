namespace GADEFINAL_POE
{
    partial class frmGameSimulation
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
            this.components = new System.ComponentModel.Container();
            this.cmbUnitsDisplay = new System.Windows.Forms.ComboBox();
            this.lblHeroResCounter = new System.Windows.Forms.Label();
            this.lblRogueResCounter = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMapDisplay = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbUnitsDisplay
            // 
            this.cmbUnitsDisplay.FormattingEnabled = true;
            this.cmbUnitsDisplay.Location = new System.Drawing.Point(444, 233);
            this.cmbUnitsDisplay.Name = "cmbUnitsDisplay";
            this.cmbUnitsDisplay.Size = new System.Drawing.Size(237, 21);
            this.cmbUnitsDisplay.TabIndex = 0;
            // 
            // lblHeroResCounter
            // 
            this.lblHeroResCounter.AutoSize = true;
            this.lblHeroResCounter.Location = new System.Drawing.Point(441, 35);
            this.lblHeroResCounter.Name = "lblHeroResCounter";
            this.lblHeroResCounter.Size = new System.Drawing.Size(35, 13);
            this.lblHeroResCounter.TabIndex = 1;
            this.lblHeroResCounter.Text = "label1";
            // 
            // lblRogueResCounter
            // 
            this.lblRogueResCounter.AutoSize = true;
            this.lblRogueResCounter.Location = new System.Drawing.Point(441, 67);
            this.lblRogueResCounter.Name = "lblRogueResCounter";
            this.lblRogueResCounter.Size = new System.Drawing.Size(35, 13);
            this.lblRogueResCounter.TabIndex = 2;
            this.lblRogueResCounter.Text = "label2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(429, 170);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 36);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMapDisplay
            // 
            this.lblMapDisplay.AutoSize = true;
            this.lblMapDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMapDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapDisplay.Location = new System.Drawing.Point(62, 50);
            this.lblMapDisplay.Name = "lblMapDisplay";
            this.lblMapDisplay.Size = new System.Drawing.Size(70, 20);
            this.lblMapDisplay.TabIndex = 4;
            this.lblMapDisplay.Text = "label3";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(429, 306);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(74, 33);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(620, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(620, 306);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 33);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.Location = new System.Drawing.Point(597, 50);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(14, 13);
            this.lblTimeDisplay.TabIndex = 8;
            this.lblTimeDisplay.Text = "T";
            // 
            // frmGameSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeDisplay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblMapDisplay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRogueResCounter);
            this.Controls.Add(this.lblHeroResCounter);
            this.Controls.Add(this.cmbUnitsDisplay);
            this.Name = "frmGameSimulation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnitsDisplay;
        private System.Windows.Forms.Label lblHeroResCounter;
        private System.Windows.Forms.Label lblRogueResCounter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMapDisplay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.Label lblTimeDisplay;
    }
}

