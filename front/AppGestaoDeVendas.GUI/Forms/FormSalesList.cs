using AppGestaoDeVendas.GUI.Communication.Products.Responses;
using AppGestaoDeVendas.GUI.Communication.Sales.Responses;
using AppGestaoDeVendas.GUI.HttpClientMethods;
using AppGestaoDeVendas.GUI.Communication.Enums;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSalesList : Form
{
	private List<ResponseSaleFilteredByDate> Sales { get; set; } = [];
	public FormSalesList()
	{
		InitializeComponent();
	}
	private async void Btn_Filter_Sales_Click(object sender, EventArgs e)
	{
		string valor = maskedTextBox_Period.Text;

		DateTime data;

		bool isValidDate = DateTime.TryParse(valor, out data);

		if (!isValidDate)
		{
			MessageBox.Show("Data inválida", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		DateTime period = Convert.ToDateTime(valor).Date;

		DateOnly date = new(period.Year, period.Month, period.Day);

		Sales = await HttpClient_Sales.FilterSalesByDate(date!);

		if (Sales is null)
		{
			MessageBox.Show("Vendas não encontradas.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		dataGridView_Sales.DataSource = Sales;

		Formating_Design_DataGridView();
	}

	private void DataGridView_Sales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			var sale = new ResponseSaleFilteredByDate
			{
				Salesman = dataGridView_Sales.Rows[e.RowIndex].Cells["Salesman"].Value.ToString()!,
				AddressMarket = dataGridView_Sales.Rows[e.RowIndex].Cells["AddressMarket"].Value.ToString()!,
				DateOfSale = (DateTime)dataGridView_Sales.Rows[e.RowIndex].Cells["DateOfSale"].Value,
				PaymentType = (PaymentType)dataGridView_Sales.Rows[e.RowIndex].Cells["PaymentType"].Value,
				TotalSaleAmount = (decimal)dataGridView_Sales.Rows[e.RowIndex].Cells["TotalSaleAmount"].Value,
				Address = dataGridView_Sales.Rows[e.RowIndex].Cells["Address"].Value.ToString()!,
				Email = dataGridView_Sales.Rows[e.RowIndex].Cells["Email"].Value.ToString()!,
				Name = dataGridView_Sales.Rows[e.RowIndex].Cells["Name"].Value.ToString()!,
				Telephone = dataGridView_Sales.Rows[e.RowIndex].Cells["Telephone"].Value.ToString()!,
				Id = (long)dataGridView_Sales.Rows[e.RowIndex].Cells["Id"].Value!,
			};

			sale.Products = (ICollection<ResponseProduct>)dataGridView_Sales.Rows[e.RowIndex].Cells["Products"].Value;

			var form = new FormSingleSale(sale);
			this.Opacity = 0;
			form.ShowDialog();
			this.Opacity = 1;
		}
	}

	private void Formating_Design_DataGridView()
	{
		dataGridView_Sales.Columns["Id"].Visible = false;
		dataGridView_Sales.Columns["Products"].Visible = false;

		dataGridView_Sales.Columns["Salesman"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["AddressMarket"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["DateOfSale"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["PaymentType"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["TotalSaleAmount"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["Address"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["Name"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["Email"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["Telephone"].HeaderCell.Style = GetViewCellStyle();
		dataGridView_Sales.Columns["Email"].HeaderCell.Style = GetViewCellStyle();

		dataGridView_Sales.Columns["Name"].AutoSizeMode = GetSizeColumnMode();
		dataGridView_Sales.Columns["Email"].AutoSizeMode = GetSizeColumnMode();
		dataGridView_Sales.Columns["AddressMarket"].AutoSizeMode = GetSizeColumnMode();
		dataGridView_Sales.Columns["Address"].AutoSizeMode = GetSizeColumnMode();
		dataGridView_Sales.Columns["PaymentType"].AutoSizeMode = GetSizeColumnMode();
		dataGridView_Sales.Columns["TotalSaleAmount"].AutoSizeMode = GetSizeColumnMode();

		dataGridView_Sales.Columns["PaymentType"].DefaultCellStyle = new DataGridViewCellStyle
		{
			Alignment = DataGridViewContentAlignment.MiddleCenter,
		};
		
		dataGridView_Sales.Columns["TotalSaleAmount"].DefaultCellStyle = new DataGridViewCellStyle
		{
			Alignment = DataGridViewContentAlignment.MiddleRight
		};
	}

	private static DataGridViewCellStyle GetViewCellStyle()
	{
		return new DataGridViewCellStyle
		{
			BackColor = Color.Azure,
			ForeColor = Color.Black,
			Font = new Font("Arial", 12, FontStyle.Bold),
			Alignment = DataGridViewContentAlignment.TopRight,
		};
	}

	private static DataGridViewAutoSizeColumnMode GetSizeColumnMode()
	{
		return DataGridViewAutoSizeColumnMode.AllCells;
	}

}
