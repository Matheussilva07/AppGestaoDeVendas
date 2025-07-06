using AppGestaoDeVendas.GUI.Communication.Enums;
using AppGestaoDeVendas.GUI.Communication.Products.Responses;
using AppGestaoDeVendas.GUI.Communication.Sales.Requests;
using AppGestaoDeVendas.GUI.HttpClientMethods;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSales : Form
{
	private long _productId = 0;
	private ResponseProduct? _product;
	private IList<SoldProduct> _productsList = [];
	private long _costumerId;

	public FormSales()
	{
		InitializeComponent();
	}
	private async void Btn_Register_Click(object sender, EventArgs e)
	{

		if (!string.IsNullOrWhiteSpace(Txt_Salesman.Text) && !string.IsNullOrWhiteSpace(Txt_Customer.Text) && !string.IsNullOrWhiteSpace(Txt_Amount.Text))
		{
			PaymentType paymentType = comboBox_PaymentType.Text switch
			{
				"Cartão" => PaymentType.Card,
				"Pix" => PaymentType.Pix,
				"Boleto" => PaymentType.Boleto,
				_ => throw new NotImplementedException()
			};

			var request = new RequestRegisterSale
			{
				Salesman = Txt_Salesman.Text,
				AddressMarket = comboBox_MarketAddress.Text,
				PaymentType = paymentType,
				CostumerId = _costumerId,
				Products = _productsList
			};

			bool isSuccessfull = await HttpClient_Sales.DoPost(request);

			if (!isSuccessfull)
			{
				MessageBox.Show("Erro ao cadastrar a venda.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			MessageBox.Show("Venda cadastrada.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		MessageBox.Show("Preencha todos os campos.","Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	}

	private async void Btn_Pesquisar_Produto_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(TxtProduct.Text))
		{
			_product = await HttpClient_Products.DoGetProductByName(TxtProduct.Text);
		}		

		if (_product is not null)
		{
			_productId = (long)_product.Id;

			TxtProduct.Text = _product.Name;
		}
	}

	private void Btn_Add_Product_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(TxtProduct.Text) && !string.IsNullOrEmpty(Txt_Amount.Text))
		{
			_productsList.Add(new SoldProduct
			{
				ProductId = _productId,
				ProductAmount = (uint)Convert.ToInt32(Txt_Amount.Text)
			});

			richTextBox_ProductsList.AppendText($"{_product!.Name}: {Txt_Amount.Text}\n");
		}
	}

	private void Vendas_StripMenu_Click(object sender, EventArgs e)
	{
		var form = new FormSalesList();
		this.Opacity = 0;
		form.ShowDialog();
		this.Opacity = 1;
	}

	private void Btn_Search_Costumers_Click(object sender, EventArgs e)
	{
		var form = new FormCostumers();
		this.Opacity = 0;
		form.ShowDialog();
		_costumerId = form.CostumerId;
		Txt_Customer.Text = form.CostumerName;
		this.Opacity = 1;
	}
}
