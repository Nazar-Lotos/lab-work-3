using System;
using System.Windows.Forms;

namespace lab_work_3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTv_Click(object sender, EventArgs e)
        {
            Television television = new Television();
            fTelevision fTelevision = new fTelevision(television);
            if(fTelevision.ShowDialog() == DialogResult.OK) 
            {
                tbTvsInfo.Text +=
                string.Format("Бренд: {0}, Модель: {1}. Діагональ: {2} " +
                "Роздільна здатність: {3}, Потужність звуку: {4} Вт. {5}.\r\n\r\n",
                television.Brand,  
                television.Model,  
                television.ScreenSize,  
                television.Resolution,  
                television.SoundPower,  
                television.IsSmartTV ? "Smart TV" : "Не Smart TV");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                Application.Exit();
        }
        private void tbTvsInfo_TextChanged(object sender, EventArgs e){}
    }
}
