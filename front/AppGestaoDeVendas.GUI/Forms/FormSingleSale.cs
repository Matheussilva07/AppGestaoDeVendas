using AppGestaoDeVendas.GUI.Communication.Sales.Responses;
using AppGestaoDeVendas.GUI.HttpClientMethods;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormSingleSale : Form
{
	private ResponseSaleFilteredByDate Sale { get; set; }

	private FormSingleSale()
	{
		InitializeComponent();
	}
	public FormSingleSale(ResponseSaleFilteredByDate sale)
	{
		Sale = new()
		{
			Id = sale.Id,

			Salesman = sale.Salesman,
			AddressMarket = sale.AddressMarket,
			DateOfSale = sale.DateOfSale,
			TotalSaleAmount = sale.TotalSaleAmount,
			PaymentType = sale.PaymentType,
			Products = sale.Products,

			Name = sale.Name,
			Email = sale.Email,
			Telephone = sale.Telephone,
			Address = sale.Address
		};


		InitializeComponent();
	}

	private void FormSingleSale_Load(object sender, EventArgs e)
	{
		Lbl_Id.Text = Sale.Id.ToString();
		Txt_Client_Name.Text = Sale.Name;
		Txt_Client_Email.Text = Sale.Email;
		Txt_Client_Address.Text = Sale.Address;
		Txt_Client_PhoneNumber.Text = Sale.Telephone;

		Txt_Salesman.Text = Sale.Salesman;
		Txt_MarketAddress.Text = Sale.AddressMarket;
		maskedTextBox_SaleDate.Text = Sale.DateOfSale.ToString();
		Txt_Payment.Text = Sale.PaymentType.ToString();
		Txt_TotalAmount.Text = Sale.TotalSaleAmount.ToString();


		foreach (var item in Sale.Products)
		{
			richTextBox_Sales_List.AppendText
				($"Produto: {item.Name.ToUpper()}" +
				$"\nCódigo: {item.Code.ToUpper()}" +
				$"\nPreço: {item.Price.ToString().ToUpper()}" +
				$"\nQuantidade: {item.Amount.ToString().ToUpper()}\n\n");
		}
	}

	private async void Btn_Delete_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Deseja realmente deletar?","Nosso mercado",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
		{
			bool isSuccessful = await HttpClient_Sales.DoDelete(Sale.Id);

			if (!isSuccessful)
			{
				MessageBox.Show("Erro ao deletar.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			MessageBox.Show("Deletado com sucesso.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}	
	}
}

					 

