using GestionAromaRazan.Dal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAromaRazan.Controlleur
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    class Dashboards: DalSqlServeur
    {
        SqlConnection cnx = new DalSqlServeur().conexionBd;


        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int NumClient { get; private set; }
        public int Numfournisseur { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        //Constructor
        public Dashboards()
        {
        }
        //Private methods
        private void GetNumberItems()
        {
            cnx.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = cnx;
                //Get Total Number of Client
                command.CommandText = "select count(CNIE) from Clients";
                NumClient = (int)command.ExecuteScalar();
                //Get Total Number of fournisseur
                command.CommandText = "select count(IdFournisseur) from Fournisseur";
                Numfournisseur = (int)command.ExecuteScalar();
                //Get Total Number of produit
                command.CommandText = "select count(IdProduit) from Produit";
                NumProducts = (int)command.ExecuteScalar();
                //Get Total Number of commande
                command.CommandText = @"select count(IdCommande) from CommandeClient where DateCommande between  @fromDate and @toDate";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                NumOrders = (int)command.ExecuteScalar();
            }
            cnx.Close();
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
          
                cnx.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = cnx;
                    command.CommandText = @"select DateCommande , sum(PrixTotal) from CommandeClient
                                            where DateCommande between @fromDate and @toDate
                                            group by DateCommande";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m;//20%
                    reader.Close();
                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            cnx.Close();
            
        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
           
                cnx.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = cnx;
                    //Get Top 5 products
                    command.CommandText = @"select top 5 P.NomProduit, sum(DetailsCommande.Qte) as Q
                                            from DetailsCommande
                                            inner join Produit P on P.IdProduit = DetailsCommande.IdProduit
                                            inner
                                            join CommandeClient O on O.IdCommande = DetailsCommande.IdCommande
                                            where DateCommande between @fromDate and @toDate
                                            group by P.NomProduit
                                            order by Q desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                    //Get Understock
                    command.CommandText = @"select NomProduit, Qte_Stock from Produit where Qte_Stock <= 6 ";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            cnx.Close();
            
        }
        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
