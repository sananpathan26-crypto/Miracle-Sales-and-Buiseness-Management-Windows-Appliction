using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miracle
{
    public partial class OrdersForm : Form
    {
        private readonly string apiBaseUrl = "http://localhost:5271/api/orders";

        public OrdersForm()
        {
            InitializeComponent();
        }

        private async void OrdersForm_Load(object sender, EventArgs e)
        {
            //await SafeLoadOrders();
        }

        private async Task SafeLoadOrders()
        {
            try
            {
                var table = await LoadOrders();

                if (table != null && table.Rows.Count > 0)
                {
                    dgvOrders.DataSource = table;
                    await MarkOrdersAsSeen();
                }
                else
                {
                    MessageBox.Show("No new orders available.",
                        "Orders",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "Backend server is not running.\nPlease start the server and try again.",
                    "Server Offline",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async Task<DataTable> LoadOrders()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiBaseUrl}/all");
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DataTable>(json);
            }
        }

        private async Task MarkOrdersAsSeen()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(
                    $"{apiBaseUrl}/markasseen",
                    new StringContent("")
                );

                response.EnsureSuccessStatusCode();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
