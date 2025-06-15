namespace AppGestaoDeVendas.GUI.Forms;

partial class FormProductsList
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
		dataGridView_Products_List = new DataGridView();
		((System.ComponentModel.ISupportInitialize)dataGridView_Products_List).BeginInit();
		SuspendLayout();
		// 
		// dataGridView_Products_List
		// 
		dataGridView_Products_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_Products_List.Dock = DockStyle.Fill;
		dataGridView_Products_List.Location = new Point(0, 0);
		dataGridView_Products_List.Name = "dataGridView_Products_List";
		dataGridView_Products_List.Size = new Size(374, 324);
		dataGridView_Products_List.TabIndex = 0;
		dataGridView_Products_List.CellDoubleClick += DataGridView_Products_List_CellDoubleClick;
		// 
		// FormProductsList
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(374, 324);
		Controls.Add(dataGridView_Products_List);
		Name = "FormProductsList";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Nosso mercado";
		Load += FormProductsList_Load;
		((System.ComponentModel.ISupportInitialize)dataGridView_Products_List).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private DataGridView dataGridView_Products_List;
}