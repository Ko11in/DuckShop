using DuckService.Models;
using DuckService.SourceClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckShop
{
    public partial class FormMain : Form
    {
        HttpClient client;
        List<Product> products;
        public FormMain()
        {
            InitializeComponent();
            client = new HttpClient();
            tbAddress.Text = "http://localhost:55354/api/duckshop";
        }
        private async Task<string> SendGetRequest()
        {
                var response = await client.GetAsync(tbAddress.Text);
                return await response.Content.ReadAsStringAsync();
        }

        private async Task<string> SendPostRequest<T>(T attachment)
        {
                var attachstring = JsonConvert.SerializeObject(attachment);
                var content = new StringContent(attachstring, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(tbAddress.Text, content);
                return await result.Content.ReadAsStringAsync();
        }
        private async Task<string> SendPutRequest(List<Product> products)
        {
            var attachstring = JsonConvert.SerializeObject(products);
            var content = new StringContent(attachstring, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(tbAddress.Text, content);
            return await result.Content.ReadAsStringAsync();
        }
        private async void btRefresh_Click(object sender, EventArgs e)
        {
            lvDucks.Items.Clear();
            btRefresh.Enabled = false;
            try
            {
                lbRefresh.Text = "Подождите...";
                string resultstring = await SendGetRequest();
                if (resultstring != null)
                {
                    var prodlist = JsonConvert.DeserializeObject<List<Product>>(resultstring);
                    FillDuckListView(prodlist);
                }
                btSend.Enabled = true;
                btSetValues.Enabled = true;
                lbRefresh.Text = "Обновлено";
                btRefresh.Enabled = true;
            }
            catch (Exception ee)
            {
                lbRefresh.Text = "Ошибка";
                MessageBox.Show("При обновлении списка доступных уточек возникла ошибка: " + ee.Message);
                btRefresh.Enabled = true;
            }
        }
        
        private void FillDuckListView(List<Product> _products)
        {
            //Заполнение списка доступных продуктов
            products = _products;
            lvDucks.Items.Clear();
            foreach(var prod in products)
            {
                ListViewItem item = new ListViewItem();
                item.Text = prod.Name;
                item.SubItems.Add(prod.Quantity.ToString()); 
                lvDucks.Items.Add(item);
            }
        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            List<Product> order = new List<Product>();
            try
            {
                if (nudWhite.Value > 0)
                {
                    Product prod = products.FirstOrDefault(x => x.Color == DuckColors.White);
                    prod.Quantity = (int)nudWhite.Value;
                    order.Add(prod);
                }
                if (nudBlack.Value > 0)
                {
                    Product prod = products.FirstOrDefault(x => x.Color == DuckColors.Black);
                    prod.Quantity = (int)nudBlack.Value;
                    order.Add(prod);
                }
                if (nudBlue.Value > 0)
                {
                    Product prod = products.FirstOrDefault(x => x.Color == DuckColors.Blue);
                    prod.Quantity = (int)nudBlue.Value;
                    order.Add(prod);
                }
                if (nudYellow.Value > 0)
                {
                    Product prod = products.FirstOrDefault(x => x.Color == DuckColors.Yellow);
                    prod.Quantity = (int)nudYellow.Value;
                    order.Add(prod);
                }
                string result=await SendPostRequest(order);
                tbResult.Text = JsonConvert.DeserializeObject(result).ToString();
                MessageBox.Show("Заказ отправлен!");

            }
            catch (Exception ee)
            {
                MessageBox.Show("При отправке заказа возникла ошибка: " + ee.Message);
            }
        }

        private async void btSetValues_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> defineQuantity = new List<Product>();
                Product prod = products.FirstOrDefault(x => x.Color == DuckColors.White);
                prod.Quantity = (int)nudWhite.Value;
                defineQuantity.Add(prod);

                prod = products.FirstOrDefault(x => x.Color == DuckColors.Black);
                prod.Quantity = (int)nudBlack.Value;
                defineQuantity.Add(prod);

                prod = products.FirstOrDefault(x => x.Color == DuckColors.Blue);
                prod.Quantity = (int)nudBlue.Value;
                defineQuantity.Add(prod);

                prod = products.FirstOrDefault(x => x.Color == DuckColors.Yellow);
                prod.Quantity = (int)nudYellow.Value;
                defineQuantity.Add(prod);

                string result = await SendPutRequest(defineQuantity);
                tbResult.Text = JsonConvert.DeserializeObject(result).ToString();
                MessageBox.Show("Обновление успешно выполнено");
            }
            catch (Exception ee)
            {
                MessageBox.Show("При установке значений возникла ошибка: " + ee.Message);
            }
        }
    }
}
