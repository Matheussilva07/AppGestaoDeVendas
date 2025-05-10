namespace AppGestaoDeVendas.GUI.Forms;

partial class FormSingleSale
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
		Txt_Salesman = new TextBox();
		Txt_DateOfSale = new TextBox();
		Txt_TotalAmount = new TextBox();
		Txt_MarketAddress = new TextBox();
		richTextBox_Sales_List = new RichTextBox();
		SuspendLayout();
		// 
		// Txt_Salesman
		// 
		Txt_Salesman.Location = new Point(139, 100);
		Txt_Salesman.Name = "Txt_Salesman";
		Txt_Salesman.Size = new Size(362, 23);
		Txt_Salesman.TabIndex = 0;
		// 
		// Txt_DateOfSale
		// 
		Txt_DateOfSale.Location = new Point(139, 168);
		Txt_DateOfSale.Name = "Txt_DateOfSale";
		Txt_DateOfSale.Size = new Size(362, 23);
		Txt_DateOfSale.TabIndex = 1;
		// 
		// Txt_TotalAmount
		// 
		Txt_TotalAmount.Location = new Point(139, 197);
		Txt_TotalAmount.Name = "Txt_TotalAmount";
		Txt_TotalAmount.Size = new Size(362, 23);
		Txt_TotalAmount.TabIndex = 2;
		// 
		// Txt_MarketAddress
		// 
		Txt_MarketAddress.Location = new Point(139, 129);
		Txt_MarketAddress.Name = "Txt_MarketAddress";
		Txt_MarketAddress.Size = new Size(362, 23);
		Txt_MarketAddress.TabIndex = 3;
		// 
		// richTextBox_Sales_List
		// 
		richTextBox_Sales_List.Location = new Point(519, 105);
		richTextBox_Sales_List.Name = "richTextBox_Sales_List";
		richTextBox_Sales_List.Size = new Size(269, 300);
		richTextBox_Sales_List.TabIndex = 4;
		richTextBox_Sales_List.Text = "";
		// 
		// FormSingleSale
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(richTextBox_Sales_List);
		Controls.Add(Txt_MarketAddress);
		Controls.Add(Txt_TotalAmount);
		Controls.Add(Txt_DateOfSale);
		Controls.Add(Txt_Salesman);
		Name = "FormSingleSale";
		Text = "FormSingleSale";
		Load += FormSingleSale_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private TextBox Txt_Salesman;
	private TextBox Txt_DateOfSale;
	private TextBox Txt_TotalAmount;
	private TextBox Txt_MarketAddress;
	private RichTextBox richTextBox_Sales_List;
}