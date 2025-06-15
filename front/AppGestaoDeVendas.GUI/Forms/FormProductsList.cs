using AppGestaoDeVendas.GUI.Communication.Products.Responses;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormProductsList : Form
{
	public FormProductsList()
	{
		InitializeComponent();
	}

	private async void FormProductsList_Load(object sender, EventArgs e)
	{
		try
		{
			var produtsList = await HttpClient_Products.DoGetProductsList();

			dataGridView_Products_List.DataSource = produtsList;
			FormattingDataGridViewProducts();
		}
		catch (Exception)
		{
			throw;
		}
	}

	private void FormattingDataGridViewProducts()
	{
		dataGridView_Products_List.Columns["Name"].HeaderText = "Nome";
		dataGridView_Products_List.Columns["Amount"].HeaderText = "Quantidade";
		dataGridView_Products_List.Columns["Price"].HeaderText = "Preço";

		dataGridView_Products_List.Columns["Id"].Visible = false;
		dataGridView_Products_List.Columns["Discription"].Visible = false;
		dataGridView_Products_List.Columns["Code"].Visible = false;
	}

	private void DataGridView_Products_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			long productId = (long)dataGridView_Products_List.Rows[e.RowIndex].Cells["Id"].Value;

			var form = new FormProducts(productId);

			this.Opacity = 0;
			form.ShowDialog();
			this.Opacity = 1;
		}
	}
}
