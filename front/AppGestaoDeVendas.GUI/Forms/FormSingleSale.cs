using AppGestaoDeVendas.GUI.Communication.Sales.Responses;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSingleSale : Form
{
	private string _saleman;
	private string _marketAddress;
	private DateTime _dateOfSale;
	private decimal _totalAmount;
	public FormSingleSale()
	{
		InitializeComponent();
	}
	public FormSingleSale(ResponseSaleFilteredByDate sale)
	{
		_saleman = sale.Salesman;
		_marketAddress = sale.AddressMarket;
		_dateOfSale = sale.DateOfSale;
		_totalAmount = sale.TotalSaleAmount;

		InitializeComponent();
	}

	private void FormSingleSale_Load(object sender, EventArgs e)
	{
		Txt_Salesman.Text = _saleman;
		Txt_DateOfSale.Text = _dateOfSale.ToString();
		Txt_MarketAddress.Text = _marketAddress;
		Txt_TotalAmount.Text = _totalAmount.ToString();
	}
}
