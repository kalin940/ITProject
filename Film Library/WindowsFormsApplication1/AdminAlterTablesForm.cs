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
    public partial class AdminAlterTablesForm : Form
    {
        Thread th;
        public AdminAlterTablesForm()
        {
            InitializeComponent();
        }



        private void AdminAlterTablesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDBDataSet.MovieTypes' table. You can move, or remove it, as needed.
            this.movieTypesTableAdapter.Fill(this.usersDBDataSet.MovieTypes);
            // TODO: This line of code loads data into the 'usersDBDataSet.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.usersDBDataSet.Actors);
            // TODO: This line of code loads data into the 'usersDBDataSet.ActorsDBMovies' table. You can move, or remove it, as needed.
            this.actorsDBMoviesTableAdapter.Fill(this.usersDBDataSet.ActorsDBMovies);
            // TODO: This line of code loads data into the 'usersDBDataSet.MovieDBTypes' table. You can move, or remove it, as needed.
            this.movieDBTypesTableAdapter.Fill(this.usersDBDataSet.MovieDBTypes);
            // TODO: This line of code loads data into the 'usersDBDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.usersDBDataSet.Movies);
        }



        private void button1_Click(object sender, EventArgs e)//Back Button
        {// When Back button gets clicked
         //create new thread and open AdminFormChoice Form and close current
            this.Close();
            th = new Thread(OpenNewLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewLoginForm()
        {
            Application.Run(new AdminFormChoice());
        }

        private void button2_Click(object sender, EventArgs e) //Button Users Info
        {// When Users info  button gets clicked
         //create new thread and open AdminUserInfo Form and close current
            this.Close();
            th = new Thread(OpenNewAdminUserInfoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewAdminUserInfoForm()
        {
            Application.Run(new AdminUserInfo());
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDBDataSet);

        }
    }
}
