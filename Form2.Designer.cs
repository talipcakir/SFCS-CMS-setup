
namespace SFCS_CMS_Kurulum
{
    partial class Kurulum_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kurulum_2));
            this.Xampp_progressBar = new System.Windows.Forms.ProgressBar();
            this.dw_Button = new System.Windows.Forms.Button();
            this.go_Button = new System.Windows.Forms.Button();
            this.textBox_ExtractFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Xampp_progressBar
            // 
            this.Xampp_progressBar.Location = new System.Drawing.Point(3, 171);
            this.Xampp_progressBar.Name = "Xampp_progressBar";
            this.Xampp_progressBar.Size = new System.Drawing.Size(505, 27);
            this.Xampp_progressBar.TabIndex = 0;
            // 
            // dw_Button
            // 
            this.dw_Button.Location = new System.Drawing.Point(136, 204);
            this.dw_Button.Name = "dw_Button";
            this.dw_Button.Size = new System.Drawing.Size(114, 44);
            this.dw_Button.TabIndex = 1;
            this.dw_Button.Text = "İNDİR";
            this.dw_Button.UseVisualStyleBackColor = true;
            this.dw_Button.Click += new System.EventHandler(this.dw_Button_Click);
            // 
            // go_Button
            // 
            this.go_Button.Enabled = false;
            this.go_Button.Location = new System.Drawing.Point(260, 204);
            this.go_Button.Name = "go_Button";
            this.go_Button.Size = new System.Drawing.Size(114, 44);
            this.go_Button.TabIndex = 2;
            this.go_Button.Text = "YÜKLE";
            this.go_Button.UseVisualStyleBackColor = true;
            this.go_Button.Click += new System.EventHandler(this.go_Button_Click);
            // 
            // textBox_ExtractFile
            // 
            this.textBox_ExtractFile.Location = new System.Drawing.Point(3, 146);
            this.textBox_ExtractFile.Name = "textBox_ExtractFile";
            this.textBox_ExtractFile.Size = new System.Drawing.Size(505, 20);
            this.textBox_ExtractFile.TabIndex = 5;
            // 
            // Kurulum_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SFCS_CMS_Kurulum.Properties.Resources.SFCS_500x70;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 256);
            this.Controls.Add(this.textBox_ExtractFile);
            this.Controls.Add(this.go_Button);
            this.Controls.Add(this.dw_Button);
            this.Controls.Add(this.Xampp_progressBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 295);
            this.MinimumSize = new System.Drawing.Size(528, 295);
            this.Name = "Kurulum_2";
            this.Text = "SFCS Digital Signage Kurulum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kurulum_2_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Xampp_progressBar;
        private System.Windows.Forms.Button dw_Button;
        private System.Windows.Forms.Button go_Button;
        private System.Windows.Forms.TextBox textBox_ExtractFile;
    }
}