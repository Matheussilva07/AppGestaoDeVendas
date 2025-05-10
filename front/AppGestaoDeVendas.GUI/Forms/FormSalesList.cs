using AppGestaoDeVendas.GUI.Communication.Sales.Responses;
using AppGestaoDeVendas.GUI.HttpClientMethods;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSalesList : Form
{
	public FormSalesList()
	{
		InitializeComponent();
	}

	private async void Btn_Filter_Sales_Click(object sender, EventArgs e)
	{
		DateTime period = Convert.ToDateTime(maskedTextBox_Period.Text).Date;

		DateOnly date = new(period.Year, period.Month, period.Day);

		var sales = await HttpClientSales.FilterSalesByDate(date);

		dataGridView_Sales.DataSource = sales;
	}

	private void DataGridView_Sales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		

		if(e.RowIndex >= 0)
		{
			var sale = new ResponseSaleFilteredByDate
			{
				Salesman = dataGridView_Sales.Rows[e.RowIndex].Cells["Salesman"].Value.ToString()!,
				AddressMarket = dataGridView_Sales.Rows[e.RowIndex].Cells["AddressMarket"].Value.ToString()!,
				DateOfSale = (DateTime)dataGridView_Sales.Rows[e.RowIndex].Cells["DateOfSale"].Value,
				TotalSaleAmount = (decimal)dataGridView_Sales.Rows[e.RowIndex].Cells["TotalSaleAmount"].Value
			};

			var form = new FormSingleSale(sale);
			form.ShowDialog();
		}
	}
}
