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
using System.Configuration;


namespace Ado.Net.Day15.Inclass.Ex2
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    GridDepartment.DataSource = ds.Tables["Department"];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    DataRow dr = ds.Tables["Department"].NewRow();
                    dr["cDepartmentCode"] = TxtDepartCode.Text;
                    dr["vDepartmentName"] = TxtDepartName.Text;
                    dr["vDepartmentHead"] = TxtDepartHead.Text;
                    dr["vLocation"] = TxtLocation.Text;

                    ds.Tables["Department"].Rows.Add(dr);

                    adapter.Update(ds, "Department");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");

                    //Applying Primary key
                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;

                    //Find the Department Code from Dataset
                    DataRow dr = ds.Tables["Department"].Rows.Find(TxtDepartCode.Text);

                    //Delete the row
                    //ds.Tables["Department"].Rows.Remove(dr);
                    dr.Delete();//Removing row using DataRow object

                    //update Dataset to Database
                    adapter.Update(ds, "Department");
                    adapter.Fill(ds, "Department");
                }
            }
        }

        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                   
                    
                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;

                    adapter.Fill(ds, "Department");
                    DataRow dr = ds.Tables["Department"].Rows.Find(TxtDepartCode.Text);
                   String text = TxtDepartHead.Text;
                    dr[1] = text;
                    dr[2] = TxtLocation.Text;

                    adapter.Update(ds);
                    adapter.Fill(ds, "Department");
                   
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department WHERE cDepartmentCode = " + TxtDepartCode.Text, con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();

                    adapter.Fill(ds, "Department");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TxtDepartName.Text = Convert.ToString(ds.Tables["Department"].Rows[0]["vDepartmentName"]);
                        TxtDepartHead.Text = Convert.ToString(ds.Tables["Department"].Rows[0]["vDepartmentHead"]);
                        TxtLocation.Text = Convert.ToString(ds.Tables["Department"].Rows[0]["vLocation"]);
                    }
                }
            }

        }
    }
}
