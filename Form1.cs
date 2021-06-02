namespace SFCS_CMS_Kurulum
{
    using System;
    using System.Windows.Forms;

    public partial class Kurulum_1 : Form
    {
        public Kurulum_1()
        {
            InitializeComponent();
        }

        private void Kur_Button_Click(object sender, EventArgs e)
        {
            Kurulum_2 gec_kur = new Kurulum_2();
            gec_kur.Show();
            Hide();
        }

        private void Kurulum_1_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            Application.Exit();
        }

        private void Yardim_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sfcteknoloji.com.tr");
        }
    }
}
