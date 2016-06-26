using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class IntroForm : Form
    { //SQL connection through connection string
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KBGVJ8B;Initial Catalog=UsersDB;Integrated Security=True;Pooling=False");
        public IntroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//searchButton_Click
        { //creating new empty temporary table
            DataTable dt = new DataTable();
            if (comboBox1.Text.Equals("Movie"))
            { //when the comboBox choice is Movie
              //execute query to find the movie that is written in the searchBox and return all information about it
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb FROM Movies WHERE MovieName='" + searchBox.Text.ToString() + "'", conn);
                SDA.Fill(dt); //fill the new table
                dataGridView1.DataSource = dt; //show the table 
            }
            else if (comboBox1.Text.Equals("Director"))
            {   //when the comboBox choice is Director
                //execute query to find the director that is written in the searchBox and return all his movie and information 
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb FROM Movies WHERE Director='" + searchBox.Text.ToString() + "'", conn);
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {  //when the comboBox choice is Actor
                //execute query to find the Actor that is written in the searchBox and return all his movie and information       
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,Actors.Name FROM Movies ,Actors ,ActorsDBMovies WHERE Movies.IDMovie=ActorsDBMovies.IdMovie AND ActorsDBMovies.IDActor=Actors.IDActor AND Actors.Name='" + searchBox.Text.ToString() + "'", conn);
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostPopularButton_Click(object sender, EventArgs e)
        {//when Most Popular button gets clicked,creating new empty temporary table 
         //execute query that finds all movies that are in the most popular list 
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb FROM Movies WHERE MovieName in ('Warcraft','Star Wars','Zootopia','Now You See Me 2','Angry Birds','The Last King','London Has Fallen')", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {//when Display all button gets clicked,creating new empty temporary table 
         //execute query that shows information about all the movies in the database
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb FROM Movies", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)//New Movies
        {
            //when New button gets clicked,creating new empty temporary table 
            //execute query that finds all movies that have a Release Date that belongs in the past month
            DataTable dt = new DataTable();
            DateTime date = DateTime.Now.AddMonths(-1);
            SqlCommand cc = new SqlCommand(
                "SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb FROM Movies WHERE ReleasedDate>=@date", conn);
            cc.Parameters.AddWithValue("@date", date);
            SqlDataAdapter SDA = new SqlDataAdapter(cc);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void HorrorMovieButton_Click(object sender, EventArgs e)
        {//when Horror button gets clicked,creating new empty temporary table 
         //execute query that shows all movies that are horror
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,MovieTypes.Type FROM Movies ,MovieTypes ,MovieDBTypes WHERE Movies.IDMovie=MovieDBTypes.IDMovie AND MovieDBTypes.ID_MType=MovieTypes.ID_MType AND MovieTypes.Type='Horror'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ActionMovieButton_Click(object sender, EventArgs e)
        {//when Action button gets clicked,creating new empty temporary table 
         //execute query that shows all movies that are action
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,MovieTypes.Type FROM Movies ,MovieTypes ,MovieDBTypes WHERE Movies.IDMovie=MovieDBTypes.IDMovie AND MovieDBTypes.ID_MType=MovieTypes.ID_MType AND MovieTypes.Type='Action'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ComedyMovieButton_Click(object sender, EventArgs e)
        {
            //when Comedy button gets clicked,creating new empty temporary table 
            //execute query that shows all movies that are comedy
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,MovieTypes.Type FROM Movies ,MovieTypes ,MovieDBTypes WHERE Movies.IDMovie=MovieDBTypes.IDMovie AND MovieDBTypes.ID_MType=MovieTypes.ID_MType AND MovieTypes.Type='Comedy'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Thriller_Click(object sender, EventArgs e)
        {
            //when Thriller button gets clicked,creating new empty temporary table 
            //execute query that shows all movies that are thriller
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,MovieTypes.Type FROM Movies ,MovieTypes ,MovieDBTypes WHERE Movies.IDMovie=MovieDBTypes.IDMovie AND MovieDBTypes.ID_MType=MovieTypes.ID_MType AND MovieTypes.Type='Thriller'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FantasyMovieButton_Click(object sender, EventArgs e)
        {
            //when Fantasy button gets clicked,creating new empty temporary table 
            //execute query that shows all movies that are fantasy
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,MovieTypes.Type FROM Movies ,MovieTypes ,MovieDBTypes WHERE Movies.IDMovie=MovieDBTypes.IDMovie AND MovieDBTypes.ID_MType=MovieTypes.ID_MType AND MovieTypes.Type='Fantasy'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DramaMovieButton_Click(object sender, EventArgs e)
        {
            //when Drama button gets clicked,creating new empty temporary table 
            //execute query that shows all movies that are drama
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT Movies.MovieName,Movies.Director,Movies.ReleasedDate,Movies.Country,Movies.IMDb ,MovieTypes.Type FROM Movies ,MovieTypes ,MovieDBTypes WHERE Movies.IDMovie=MovieDBTypes.IDMovie AND MovieDBTypes.ID_MType=MovieTypes.ID_MType AND MovieTypes.Type='Drama'", conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
