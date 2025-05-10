using AppGestaoDeVendas.GUI.Communication.Products.Responses;
using AppGestaoDeVendas.GUI.Communication.Sales.Requests;
using AppGestaoDeVendas.GUI.HttpClientMethods;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSales : Form
{
	private long _productId = 0;
	private ResponseProduct? _product;

	private IList<SoldProduct> _productsList = [];
	public FormSales()
	{
		InitializeComponent();
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
		_product = await HttpClientProducts.DoGetByName(TxtProduct.Text);

		if (_product is not null)
		{
			_productId = _product.Id;

			TxtProduct.Text = _product.Name;
		}
	}

	private void Btn_Add_Product_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Txt_Amount.Text) && !string.IsNullOrWhiteSpace(TxtProduct.Text))
		{
			_productsList.Add(new SoldProduct
			{
				ProductId = _productId,
				ProductAmount = (uint)Convert.ToInt32(Txt_Amount.Text)
			});

			richTextBox_ProductsList.AppendText($"{_product.Name}: {Txt_Amount.Text}\n");

		}
	}

	private void Vendas_StripMenu_Click(object sender, EventArgs e)
	{
		var form = new FormSalesList();
		form.ShowDialog();
	}
}
