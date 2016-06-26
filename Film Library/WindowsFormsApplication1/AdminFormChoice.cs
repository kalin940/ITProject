using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class AdminFormChoice : Form
    {
        Thread th;
        public AdminFormChoice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {// When Continue as user button gets clicked
         //create new thread and open AdminAlterTablesForm Form and close current
            this.Close();
            th = new Thread(OpenNewIntroForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewIntroForm()
        {
            Application.Run(new IntroForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {// When View/Change Data button gets clicked
         //create new thread and open IntroForm Form and close current
            this.Close();
            th = new Thread(OpenNewAdminAlterTablesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewAdminAlterTablesForm()
        {
            Application.Run(new AdminAlterTablesForm());
        }
    }
}
