
namespace SFCS_CMS_Kurulum
{
    partial class Kurulum_1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kurulum_1));
            this.bilgi_label = new System.Windows.Forms.Label();
            this.Kur_Bilgi_Label = new System.Windows.Forms.Label();
            this.Kur_Button = new System.Windows.Forms.Button();
            this.Yardim_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bilgi_label
            // 
            this.bilgi_label.AutoSize = true;
            this.bilgi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgi_label.Location = new System.Drawing.Point(12, 429);
            this.bilgi_label.Name = "bilgi_label";
            this.bilgi_label.Size = new System.Drawing.Size(470, 32);
            this.bilgi_label.TabIndex = 1;
            this.bilgi_label.Text = "SFCS Digital Signage CMS sisteminin kurulumu için yönergeleri izleyebilirsiniz.\r\n" +
    "Ayrıntılı bilgi için YARDIM butonu kullanınız.";
            // 
            // Kur_Bilgi_Label
            // 
            this.Kur_Bilgi_Label.AutoSize = true;
            this.Kur_Bilgi_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kur_Bilgi_Label.Location = new System.Drawing.Point(12, 157);
            this.Kur_Bilgi_Label.Name = "Kur_Bilgi_Label";
            this.Kur_Bilgi_Label.Size = new System.Drawing.Size(455, 140);
            this.Kur_Bilgi_Label.TabIndex = 2;
            this.Kur_Bilgi_Label.Text = resources.GetString("Kur_Bilgi_Label.Text");
            // 
            // Kur_Button
            // 
            this.Kur_Button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Kur_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Kur_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kur_Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Kur_Button.Location = new System.Drawing.Point(138, 326);
            this.Kur_Button.Name = "Kur_Button";
            this.Kur_Button.Size = new System.Drawing.Size(207, 80);
            this.Kur_Button.TabIndex = 4;
            this.Kur_Button.Text = "KURULUMU BAŞLAT";
            this.Kur_Button.UseVisualStyleBackColor = false;
            this.Kur_Button.Click += new System.EventHandler(this.Kur_Button_Click);
            // 
            // Yardim_Button
            // 
            this.Yardim_Button.Location = new System.Drawing.Point(427, 12);
            this.Yardim_Button.Name = "Yardim_Button";
            this.Yardim_Button.Size = new System.Drawing.Size(66, 33);
            this.Yardim_Button.TabIndex = 5;
            this.Yardim_Button.Text = "YARDIM";
            this.Yardim_Button.UseVisualStyleBackColor = true;
            this.Yardim_Button.Click += new System.EventHandler(this.Yardim_Button_Click);
            // 
            // Kurulum_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SFCS_CMS_Kurulum.Properties.Resources.SFCS_500x70;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(505, 470);
            this.Controls.Add(this.Yardim_Button);
            this.Controls.Add(this.Kur_Button);
            this.Controls.Add(this.Kur_Bilgi_Label);
            this.Controls.Add(this.bilgi_label);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 509);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(521, 509);
            this.Name = "Kurulum_1";
            this.Text = "SFCS Digital Signage Kurulum";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Kurulum_1_InputLanguageChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bilgi_label;
        private System.Windows.Forms.Label Kur_Bilgi_Label;
        private System.Windows.Forms.Button Kur_Button;
        private System.Windows.Forms.Button Yardim_Button;
    }
}

