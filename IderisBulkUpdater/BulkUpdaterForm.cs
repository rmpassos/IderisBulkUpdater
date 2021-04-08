using IderisBulkUpdater.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IderisBulkUpdater
{
    public partial class BulkUpdaterForm : Form
    {
        private List<ProdutoIderis> _produtos = new List<ProdutoIderis>();

        public BulkUpdaterForm()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var apiToken = new IderisApiToken(token.Text);
                var authorization = await IderisDataHandler.LogIn(apiToken);
                ApiHelper.SetJWTAuthToken(authorization.TokenString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnBuscarProdutos_Click(object sender, EventArgs e)
        {
            var prod = await IderisDataHandler.GetAllProducts(Convert.ToInt32(numericUpDown1.Value));
            _produtos = prod.ToList();
            SetDatagridDataSourceAndResize(_produtos);
        }


        private void SetDatagridDataSourceAndResize(object dataSource)
        {
            dg.DataSource = null;
            dg.DataSource = dataSource;

            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dg.Columns.Count - 1; i++)
            {
                int colw = dg.Columns[i].Width;
                dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dg.Columns[i].Width = colw;
            }
        }

        private async void ris_Click(object sender, EventArgs e)
        {
            ProdutoIderis updatedProduct;
            var selectedRowsCount = dg.SelectedRows.Count;

            foreach (DataGridViewRow row in dg.SelectedRows)
                row.DefaultCellStyle.BackColor = Color.DarkGray;

            foreach (DataGridViewRow item in dg.SelectedRows)
            {
                ProdutoIderis productToUpdate = null;
                try
                {
                    productToUpdate = (ProdutoIderis)item.DataBoundItem;
                    updatedProduct = await IderisDataHandler.PutProduct(productToUpdate);

                    item.DefaultCellStyle.BackColor = Color.Green;

                    if (selectedRowsCount > 10)
                    {
                        await Task.Delay(6000); //Implementar uma fila para lidar com a questão do limite de 10 calls por minuto.
                    }

                }
                catch (Exception ex)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                    item.Cells[0].ToolTipText = $"Erro ao atualizar {productToUpdate.Id} - {productToUpdate.Titulo}: {ex.Message}";
                }
            }
        }
    }
}