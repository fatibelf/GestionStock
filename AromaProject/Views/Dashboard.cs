using GestionAromaRazan.Controlleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAromaRazan.Views
{
    public partial class Dashboard : Form
    {
        //Fields
        private Dashboards model;
        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            model = new Dashboards();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblNumOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = "DH" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "DH" + model.TotalProfit.ToString();
                lblNumCustomers.Text = model.NumClient.ToString();
                lblNumSuppliers.Text = model.Numfournisseur.ToString();
                lblNumProducts.Text = model.NumProducts.ToString();
                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series["Series"].XValueMember = "DateCommande";
                chartGrossRevenue.Series["Series"].YValueMembers = "PrixTotal";
                chartGrossRevenue.DataBind();
                chartTopProducts.DataSource = model.TopProductsList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();
                dgvUnderstock.DataSource = model.UnderstockList;
                dgvUnderstock.Columns[0].HeaderText = "Item";
                dgvUnderstock.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            
        }

        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
