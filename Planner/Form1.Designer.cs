namespace Planner
{
    partial class Planner
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.trackBarPhiltre = new System.Windows.Forms.TrackBar();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.trackBarMinThreshold = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhiltre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(27, 182);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(151, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trackBarPhiltre
            // 
            this.trackBarPhiltre.Enabled = false;
            this.trackBarPhiltre.Location = new System.Drawing.Point(122, 107);
            this.trackBarPhiltre.Maximum = 255;
            this.trackBarPhiltre.Name = "trackBarPhiltre";
            this.trackBarPhiltre.Size = new System.Drawing.Size(104, 45);
            this.trackBarPhiltre.TabIndex = 3;
            this.trackBarPhiltre.Value = 10;
            this.trackBarPhiltre.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.Filter = "Image files|*.jpg;*.png|All files|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Детализация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фильтр";
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "Images|*.jpg";
            // 
            // trackBarMinThreshold
            // 
            this.trackBarMinThreshold.Enabled = false;
            this.trackBarMinThreshold.Location = new System.Drawing.Point(122, 44);
            this.trackBarMinThreshold.Maximum = 255;
            this.trackBarMinThreshold.Name = "trackBarMinThreshold";
            this.trackBarMinThreshold.Size = new System.Drawing.Size(104, 45);
            this.trackBarMinThreshold.TabIndex = 6;
            this.trackBarMinThreshold.Value = 50;
            this.trackBarMinThreshold.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 220);
            this.Controls.Add(this.trackBarMinThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarPhiltre);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "Planner";
            this.Text = "Planner";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPhiltre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar trackBarPhiltre;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
        private System.Windows.Forms.TrackBar trackBarMinThreshold;
    }
}

