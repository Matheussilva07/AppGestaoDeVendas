using AppGestaoDeVendas.GUI.Forms;

namespace AppGestaoDeVendas.GUI;

public partial class Principal : Form
{
	public Principal()
	{
		InitializeComponent();
	}

	private void Btn_Products_Click(object sender, EventArgs e)
	{
		var form = new FormProducts();
		form.ShowDialog();
	}

	private void Btn_Vendas_Click(object sender, EventArgs e)
	{
		var form = new FormSales();
		form.ShowDialog();
	}
}
