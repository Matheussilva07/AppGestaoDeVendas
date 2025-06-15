using AppGestaoDeVendas.GUI.Communication.Customers.Requests;
using AppGestaoDeVendas.GUI.Communication.Customers.Responses;
using AppGestaoDeVendas.GUI.HttpClientMethods;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormCostumers : Form
{
    public long CostumerId { get; set; }
	public string CostumerName { get; set; } = string.Empty;
    public FormCostumers()
	{
		InitializeComponent();
	}

	public FormCostumers(ResponseCostumerJson response)
	{
		InitializeComponent();
		lbl_ID.Text = response.Id.ToString();
		txt_Name.Text = response.Name;
		Txt_Email.Text = response.Email;
	}

	private async void Btn_Register_Customer_Click(object sender, EventArgs e)
	{
		var request = new RequestCostumerJson()
		{
			Name = txt_Name.Text,
			Address = Txt_Adress.Text,
			Email = Txt_Email.Text,
			Telephone = Txt_Telephone.Text,
		};

		bool isSuccessful = await HttpClient_Customers.DoPost(request);

		if (isSuccessful)
			MessageBox.Show("Cliente cadastrado com sucesso.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		MessageBox.Show("Erro ao cadastrar..", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	}

	private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var form = new FormCostumersList();
		this.Opacity = 0;
		form.ShowDialog();
		this.Opacity = 1;
	}

	private async void FormCostumers_Load(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(lbl_ID.Text))
		{
			var costumer = await HttpClient_Customers.DoGetById(Convert.ToInt64(lbl_ID.Text));

			txt_Name.Text = costumer!.Name;
			Txt_Email.Text = costumer.Email;
			Txt_Adress.Text = costumer.Address;
			Txt_Telephone.Text = costumer.Telephone;
		}
	}

	private async void Btn_Pesquisar_Click(object sender, EventArgs e)
	{
		try
		{
			if (string.IsNullOrEmpty(txt_Name.Text))
			{
				MessageBox.Show("Informe o nome do cliente.", "Nosso merdado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			string nameCostumer = txt_Name.Text;

			var costumer = await HttpClient_Customers.DoGetByName(nameCostumer);

			CostumerId = costumer.Id;
			CostumerName = costumer.Name;
			lbl_ID.Text = costumer.Id.ToString();
			txt_Name.Text = costumer.Name;
			Txt_Email.Text = costumer.Email;
			Txt_Telephone.Text = costumer.Telephone;
			Txt_Adress.Text = costumer.Address;
		}
		catch
		{
			MessageBox.Show("Cliente não encontrado","Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}

	private async void Btn_Update_Click(object sender, EventArgs e)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(lbl_ID.Text))
			{
				MessageBox.Show("Pesquise um cliente primeiro.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			long id = Convert.ToInt64(lbl_ID.Text);

			var request = new RequestCostumerJson
			{
				Name = txt_Name.Text,
				Email = Txt_Email.Text,
				Address = Txt_Adress.Text,
				Telephone = Txt_Telephone.Text
			};

			Validate(request);

			bool isSuccessful = await HttpClient_Customers.DoPut(request, id);

			if (!isSuccessful)
			{
				MessageBox.Show("Erro ao atualizar", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			MessageBox.Show("Atualizado com sucesso.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}

	private static void Validate(RequestCostumerJson request)
	{
		List<string> errors = [];

		if (string.IsNullOrWhiteSpace(request.Name))
		{
			errors.Add("O nome não pode ser vazio.");

		}
		if (string.IsNullOrWhiteSpace(request.Email))
		{
			errors.Add("O email não pode ser vazio.");
		}

		if (errors.Count > 0)
		{
			throw new Exception(string.Join(Environment.NewLine, errors));
		}
	}

	private async void Btn_Delete_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(lbl_ID.Text))
		{
			MessageBox.Show("Pesquise um cliente primeiro.", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		long id = Convert.ToInt64(lbl_ID.Text);

		if (MessageBox.Show("Deseja realmente deletar?","Nosso mercado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			bool isSuccessful = await HttpClient_Customers.DoDelete(id);

			if (!isSuccessful)
			{
				MessageBox.Show("Erro ao deletar", "Nosso mercado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			MessageBox.Show("Deletado com sucesso.");
		}		
	}
}
