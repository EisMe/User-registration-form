using System;
using System.Windows.Forms;


namespace Nika_Iakobashvili_Davaleba_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.users;
        }
    }
}
