namespace AppGestaoDeVendas.GUI.Forms;

partial class FormSalesList
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
		dataGridView_Sales = new DataGridView();
		maskedTextBox_Period = new MaskedTextBox();
		Btn_Filter_Sales = new Button();
		((System.ComponentModel.ISupportInitialize)dataGridView_Sales).BeginInit();
		SuspendLayout();
		// 
		// dataGridView_Sales
		// 
		dataGridView_Sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_Sales.Location = new Point(12, 36);
		dataGridView_Sales.Name = "dataGridView_Sales";
		dataGridView_Sales.Size = new Size(776, 462);
		dataGridView_Sales.TabIndex = 0;
		dataGridView_Sales.CellMouseDoubleClick += DataGridView_Sales_CellMouseDoubleClick;
		// 
		// maskedTextBox_Period
		// 
		maskedTextBox_Period.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		maskedTextBox_Period.Location = new Point(607, 3);
		maskedTextBox_Period.Mask = "00/0000";
		maskedTextBox_Period.Name = "maskedTextBox_Period";
		maskedTextBox_Period.Size = new Size(100, 27);
		maskedTextBox_Period.TabIndex = 1;
		// 
		// Btn_Filter_Sales
		// 
		Btn_Filter_Sales.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Filter_Sales.Location = new Point(713, 3);
		Btn_Filter_Sales.Name = "Btn_Filter_Sales";
		Btn_Filter_Sales.Size = new Size(75, 23);
		Btn_Filter_Sales.TabIndex = 2;
		Btn_Filter_Sales.Text = "Filtrar";
		Btn_Filter_Sales.UseVisualStyleBackColor = true;
		Btn_Filter_Sales.Click += Btn_Filter_Sales_Click;
		// 
		// FormSalesList
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 510);
		Controls.Add(Btn_Filter_Sales);
		Controls.Add(maskedTextBox_Period);
		Controls.Add(dataGridView_Sales);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "FormSalesList";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormSalesList";
		((System.ComponentModel.ISupportInitialize)dataGridView_Sales).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private DataGridView dataGridView_Sales;
	private MaskedTextBox maskedTextBox_Period;
	private Button Btn_Filter_Sales;
}