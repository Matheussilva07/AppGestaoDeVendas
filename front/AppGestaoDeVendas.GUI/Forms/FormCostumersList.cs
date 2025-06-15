using AppGestaoDeVendas.GUI.Communication.Customers.Responses;
using AppGestaoDeVendas.GUI.HttpClientMethods;
using System.Windows.Forms;

namespace AppGestaoDeVendas.GUI.Forms;
public partial class FormCostumersList : Form
{
	public FormCostumersList()
	{
		InitializeComponent();
	}

	private async void FormCostumersList_Load(object sender, EventArgs e)
	{
		var response = await HttpClient_Customers.DoGet();

		dataGridView_Costumers.DataSource = response;

		DataGridViewFormatter();
	}

	private void DataGridView_Costumers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if(e.RowIndex >= 0)
		{
			var costumer = new ResponseCostumerJson
			{
					Id = (long)dataGridView_Costumers.Rows[e.RowIndex].Cells["Id"].Value,
					Name = dataGridView_Costumers.Rows[e.RowIndex].Cells["Name"].Value.ToString()!,
					Email = dataGridView_Costumers.Rows[e.RowIndex].Cells["Email"].Value.ToString()!,
			};

			var form = new FormCostumers(costumer);
			this.Opacity = 0;
			form.ShowDialog();
			this.Opacity = 1;
		}
	}
	private void DataGridViewFormatter()
	{
		dataGridView_Costumers.Columns["Name"].HeaderCell.Style.Font = new Font("arial" , 10, FontStyle.Bold);
		dataGridView_Costumers.Columns["Email"].HeaderCell.Style.Font = new Font("arial", 10, FontStyle.Bold);

		dataGridView_Costumers.Columns["Id"].Visible = false;
		dataGridView_Costumers.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridView_Costumers.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridView_Costumers.Columns["Name"].DefaultCellStyle.Padding = new Padding { Bottom = 2 , Top = 2, Right = 10, Left = 10};
		dataGridView_Costumers.Columns["Email"].DefaultCellStyle.Padding = new Padding { Bottom = 2 , Top = 2, Right = 10, Left = 10};
	}
}
