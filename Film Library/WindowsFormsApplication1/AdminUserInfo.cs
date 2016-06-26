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
    public partial class AdminUserInfo : Form
    {
        Thread th;
        public AdminUserInfo()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDBDataSet);
        }

        private void AdminUserInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDBDataSet.Users);
        }
        private void button1_Click(object sender, EventArgs e)
        {// When Back button gets clicked
         //create new thread and open AdminAlterTablesForm Form and close current
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
