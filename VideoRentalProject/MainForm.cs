using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject
{
    public partial class MainForm : Form
    {
        Database Database = new Database();
        string WhichButtonClicked = "";
        string RMID = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadBt_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadBt();
            WhichButtonClicked = "Customer";

        }

        private void MovieBt_Click(object sender, EventArgs e)
        {

            MainGrid.DataSource = Database.MovieBt();
            WhichButtonClicked = "Movie";
        }

        private void RentalBt_Click(object sender, EventArgs e)
        {

            MainGrid.DataSource = Database.RentalBt();
            WhichButtonClicked = "Rented";
        }



        public void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCBt_Click(object sender, EventArgs e)
        {
            Database.AddCustomer(NTBox.Text, LNTBox.Text, PHTB.Text, ADDTB.Text);
            LoadBt_Click(null, null);
        }

        private void UPBT_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(CustIDTBox.Text, NTBox.Text, LNTBox.Text, PHTB.Text, ADDTB.Text);
            LoadBt_Click(null, null);
        }

        private void DltCustBt_Click(object sender, EventArgs e)
        {
            Database.DeleteCustomer(CustIDTBox.Text);
            LoadBt_Click(null, null);

        }

       

        private void MovieTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void ADDBt_Click(object sender, EventArgs e)
        {
            Database.ADDBt(RatingTb.Text, Titletb.Text, YearTb.Text, RentalTb.Text, CpiesTb.Text, PlotTb.Text, GenreTb.Text);
            MovieBt_Click(null, null);
        }


        public void DeleteMovie_Click(object sender, EventArgs e)
        {
            Database.DeleteMovie(MovieTb.Text);
            MovieBt_Click(null, null);
        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {
            Database.UpdateMovie(MovieTb.Text, RatingTb.Text, Titletb.Text, YearTb.Text, RentalTb.Text, CpiesTb.Text, PlotTb.Text, GenreTb.Text);
            MovieBt_Click(null, null);
        }

        private void IssueMovie_Click(object sender, EventArgs e)
        {
            Database.IssueMovie(MovieTb.Text, CustTBox.Text);
            RentelBt_Click(null, null);
        }

        private void RentelBt_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.RentalBt();
            WhichButtonClicked = "Rented";
        }

        private void ReturnMovie_Click(object sender, EventArgs e)
        {
            Database.ReturnMovie(RMID);
            RentelBt_Click(null, null);
        }
        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

            if (WhichButtonClicked == "Customer")
            {
                CustTBox.Text = row.Cells[0].Value.ToString();
                NTBox.Text = row.Cells[1].Value.ToString();
                LNTBox.Text = row.Cells[2].Value.ToString();
                ADDTB.Text = row.Cells[3].Value.ToString();
                PHTB.Text = row.Cells[4].Value.ToString();
            }
            else if (WhichButtonClicked == "Movies")
            {

                MovieTb.Text = row.Cells[0].Value.ToString();
                RatingTb.Text = row.Cells[1].Value.ToString();
                Titletb.Text = row.Cells[2].Value.ToString();
                YearTb.Text = row.Cells[3].Value.ToString();
                RentalTb.Text = row.Cells[4].Value.ToString();
                CpiesTb.Text = row.Cells[5].Value.ToString();
                PlotTb.Text = row.Cells[6].Value.ToString();
                GenreTb.Text = row.Cells[7].Value.ToString();
            }
            else if (WhichButtonClicked == "Rented")
            {
                RMID = row.Cells[0].Value.ToString();
                Console.WriteLine(RMID);
            }

        }


        private void PopularMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopularMovie());
        }

        private void PopularCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopularCustomer());
        }

       
    }
    

}
