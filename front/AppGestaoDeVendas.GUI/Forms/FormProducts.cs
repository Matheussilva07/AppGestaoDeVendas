using AppGestaoDeVendas.GUI.Communication.Products.Requests;
using AppGestaoDeVendas.GUI.Communication.Products.Responses;
using System.Linq;
using System.Net;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormProducts : Form
{
	public long? ProductId { get; set; }
	public FormProducts()
	{
		InitializeComponent();
	}
	public FormProducts(long productId)
	{
		InitializeComponent();
		this.ProductId = productId;
	}

	private async void Btn_Cadastrar_Produto_Click(object sender, EventArgs e)
	{
		List<string> errorFields = [];

		if (string.IsNullOrWhiteSpace(txt_Name.Text))
		{
			errorFields.Add(ErrorMessages.TXT_NAME_EMPTY);
		}
		if (string.IsNullOrWhiteSpace(txt_Code.Text))
		{
			errorFields.Add(ErrorMessages.TXT_CODIDO_EMPTY);
		}
		if (string.IsNullOrWhiteSpace(txt_Price.Text))
		{
			errorFields.Add(ErrorMessages.TXT_PRICE_EMPTY);
		}
		if (errorFields.Count > 0)
		{
			MessageBox.Show(string.Join(Environment.NewLine, errorFields));
		}
		else
		{
			var request = new RequestRegisterProduct
			{
				Name = txt_Name.Text,
				Discription = txt_Description.Text,
				Code = txt_Code.Text,
				Amount = Convert.ToInt32(txt_Amount.Text),
				Price = Convert.ToDecimal(txt_Price.Text)
			};

			HttpResponseMessage? httpResponse = await HttpClient_Products.DoPost(request);

			if (httpResponse!.StatusCode == HttpStatusCode.Created)
			{
				MessageBox.Show("Produto cadastrado.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				var errorMessages = await httpResponse.Content.ReadAsStringAsync();

				var message = errorMessages.Replace("ErrorMessages", "");

				MessageBox.Show(message);
			}
		}
	}

	private async void Btn_Pesquisar_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(txt_Name.Text))
		{
			ResponseProduct? productResponse = await HttpClient_Products.DoGetProductByName(txt_Name.Text);

			if (productResponse is not null)
			{
				txt_Id.Text = productResponse.Id.ToString();
				txt_Name.Text = productResponse.Name;
				txt_Description.Text = productResponse.Discription;
				txt_Code.Text = productResponse.Code;
				txt_Amount.Text = productResponse.Amount.ToString();
				txt_Price.Text = productResponse.Price.ToString();
			}
		}
		else
		{
			MessageBox.Show("Infome o nome do produto.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	private async void Btn_Editar_Click(object sender, EventArgs e)
	{
		int id = int.Parse(txt_Id.Text);

		var request = new RequestUpdateProduct
		{
			Name = txt_Name.Text,
			Discription = txt_Description.Text,
			Code = txt_Code.Text,
			Amount = Convert.ToInt32(txt_Amount.Text),
			Price = Convert.ToDecimal(txt_Price.Text)
		};

		bool isSuccessfull = await HttpClient_Products.DoPut(id, request);

		if (isSuccessfull)
		{
			MessageBox.Show("Atualizado com sucesso.");
		}
		else
		{
			MessageBox.Show("Erro ao atualizar.");
		}
	}

	private async void Btn_Deletar_Click(object sender, EventArgs e)
	{
		int id = int.Parse(txt_Id.Text);

		if (id != 0)
		{
			string message = await HttpClient_Products.DoDelete(id);

			MessageBox.Show(message);
		}
	}

	private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var form = new FormProductsList();
		this.Opacity = 0;
		form.ShowDialog();
		this.Opacity = 1;
	}

	private async void FormProducts_Load(object sender, EventArgs e)
	{
		if(this.ProductId is not null)
		{
			var product = await HttpClient_Products.DoGetProductById((long)ProductId);

			txt_Id.Text = product!.Id.ToString();
			txt_Name.Text = product.Name;
			txt_Description.Text = product.Discription;
			txt_Code.Text = product.Code;
			txt_Amount.Text = product.Amount.ToString();
			txt_Price.Text = product.Price.ToString();
		}
	}
}
