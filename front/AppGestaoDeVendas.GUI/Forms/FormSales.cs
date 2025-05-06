using AppGestaoDeVendas.GUI.Communication.Sales.Requests;
using AppGestaoDeVendas.GUI.HttpClientMethods;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSales : Form
{
	private long productId = 0;

	private IList<SoldProduct> _productsList = [];
	public FormSales()
	{
		InitializeComponent();
	}

	private async void FormSales_Load(object sender, EventArgs e)
	{
		var products = await HttpClientProducts.DoGetProductsList();

		comboBox_Products.DataSource = products.Select(p => p.Name).ToList();
	}

	private async void Btn_Register_Click(object sender, EventArgs e)
	{

		var request = new RequestRegisterSale
		{
			Salesman = Txt_Salesman.Text,
			AddressMarket = comboBox_MarketAddress.Text,
			CostumerId = 3,
			Products = _productsList

		};

		bool isSuccessfull = await HttpClientSales.DoPost(request);


		if (isSuccessfull)
		{
			MessageBox.Show("Venda cadastrada.");
		}
		else
		{
			MessageBox.Show("Erro ao cadastrar a venda.");
		}
	}

	private async void Btn_Pesquisar_Produto_Click(object sender, EventArgs e)
	{
		var product = await HttpClientProducts.DoGetByName(TxtProduct.Text);

		if(product is not null)
		{
			productId = product.Id;
		}
	}

	private void Btn_Add_Product_Click(object sender, EventArgs e)
	{
		_productsList.Add(new SoldProduct
		{
			ProductId = productId,	
			ProductAmount = (uint)Convert.ToInt32(Txt_Amount.Text)
		});
	}
}
