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
		this.Opacity = 0;
		form.ShowDialog();
		this.Opacity = 1;
	}
	private void Btn_Vendas_Click(object sender, EventArgs e)
	{
		var form = new FormSales();
		this.Opacity = 0;
		form.ShowDialog();
		this.Opacity = 1;

	}
	private void Btn_Costumers_Click(object sender, EventArgs e)
	{
		var form = new FormCostumers();
		this.Opacity = 0;
		form.ShowDialog();
		this.Opacity = 1;
	}
}
