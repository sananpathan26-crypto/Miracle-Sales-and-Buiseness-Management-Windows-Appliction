using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace miracle
{
    public partial class ViewPurchases : Form
    {
        public ViewPurchases()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadPurchases();
        }

        private void LoadPurchases()
        {
            try
            {
                dgvPurchases.Rows.Clear();

                string query = @"
                    SELECT 
                        p.PurchaseID,
                        p.PurchaseDate,
                        c.CompanyName,
                        pi.SrNo,
                        pi.ProductName,
                        pi.BatchNo,
                        pi.HSNNO,
                        pi.PurchaseRate,
                        pi.MRP,
                        pi.SellingRate,
                        pi.Quantity,
                        pi.Total
                    FROM purchases p
                    INNER JOIN companies c ON c.CompanyID = p.CompanyID
                    INNER JOIN purchase_items pi ON pi.PurchaseID = p.PurchaseID
                    WHERE DATE(p.PurchaseDate) BETWEEN @from AND @to
                    ORDER BY p.PurchaseDate, pi.SrNo";

                using (MySqlConnection con = DBConfig.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@from", dtFrom.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@to", dtTo.Value.ToString("yyyy-MM-dd"));

                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int sr = 1;

                    while (dr.Read())
                    {
                        dgvPurchases.Rows.Add(
                            sr++,                                           // 1. Sr No
                            dr["PurchaseID"].ToString(),                   // 2. Purchase ID
                            dr["CompanyName"].ToString(),                  // 3. Company Name
                            Convert.ToDateTime(dr["PurchaseDate"])
                                .ToString("dd/MM/yyyy"),                   // 4. Purchase Date
                            dr["ProductName"].ToString(),                  // 5. Product Name
                            dr["BatchNo"].ToString(),                      // 6. Batch No
                            dr["HSNNO"].ToString(),                        // 7. HSN No
                            dr["PurchaseRate"].ToString(),                 // 8. Purchase Rate
                            dr["MRP"].ToString(),                          // 9. MRP
                            dr["SellingRate"].ToString(),                  // 10. Selling Rate
                            dr["Quantity"].ToString(),                     // 11. ✔ Correct Quantity
                            dr["Total"].ToString()                         // 12. ✔ Correct Total
                        );
                    }

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
