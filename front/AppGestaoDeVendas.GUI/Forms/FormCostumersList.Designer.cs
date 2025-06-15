namespace AppGestaoDeVendas.GUI.Forms;

partial class FormCostumersList
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		dataGridView_Costumers = new DataGridView();
		((System.ComponentModel.ISupportInitialize)dataGridView_Costumers).BeginInit();
		SuspendLayout();
		// 
		// dataGridView_Costumers
		// 
		dataGridView_Costumers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_Costumers.Location = new Point(12, 12);
		dataGridView_Costumers.Name = "dataGridView_Costumers";
		dataGridView_Costumers.Size = new Size(427, 365);
		dataGridView_Costumers.TabIndex = 0;
		dataGridView_Costumers.CellMouseDoubleClick += DataGridView_Costumers_CellMouseDoubleClick;
		// 
		// FormCostumersList
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.SeaGreen;
		ClientSize = new Size(451, 389);
		Controls.Add(dataGridView_Costumers);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "FormCostumersList";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Nosso mercado";
		Load += FormCostumersList_Load;
		((System.ComponentModel.ISupportInitialize)dataGridView_Costumers).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private DataGridView dataGridView_Costumers;
}