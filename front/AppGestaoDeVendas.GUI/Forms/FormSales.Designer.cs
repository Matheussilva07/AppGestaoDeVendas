namespace AppGestaoDeVendas.GUI.Forms;

partial class FormSales
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
		Txt_Amount = new TextBox();
		comboBox_MarketAddress = new ComboBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		Txt_Customer = new TextBox();
		Btn_Register = new Button();
		TxtProduct = new TextBox();
		Btn_Pesquisar_Produto = new Button();
		Btn_Add_Product = new Button();
		richTextBox_ProductsList = new RichTextBox();
		groupBox1 = new GroupBox();
		menuStrip1 = new MenuStrip();
		vendas_StripMenu = new ToolStripMenuItem();
		groupBox1.SuspendLayout();
		menuStrip1.SuspendLayout();
		SuspendLayout();
		// 
		// Txt_Salesman
		// 
		Txt_Salesman.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Salesman.Location = new Point(126, 44);
		Txt_Salesman.Name = "Txt_Salesman";
		Txt_Salesman.Size = new Size(376, 27);
		Txt_Salesman.TabIndex = 1;
		// 
		// Txt_Amount
		// 
		Txt_Amount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Amount.Location = new Point(126, 202);
		Txt_Amount.Name = "Txt_Amount";
		Txt_Amount.Size = new Size(376, 27);
		Txt_Amount.TabIndex = 2;
		// 
		// comboBox_MarketAddress
		// 
		comboBox_MarketAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		comboBox_MarketAddress.FormattingEnabled = true;
		comboBox_MarketAddress.Items.AddRange(new object[] { "Av Maruim", "Av São Paulo", "Av Rio de Janeiro", "Rodovia dos Naufrágos" });
		comboBox_MarketAddress.Location = new Point(126, 94);
		comboBox_MarketAddress.Name = "comboBox_MarketAddress";
		comboBox_MarketAddress.Size = new Size(376, 27);
		comboBox_MarketAddress.TabIndex = 3;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(24, 47);
		label1.Name = "label1";
		label1.Size = new Size(83, 19);
		label1.TabIndex = 4;
		label1.Text = "Vendedor:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(27, 97);
		label2.Name = "label2";
		label2.Size = new Size(45, 19);
		label2.TabIndex = 5;
		label2.Text = "Loja:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(24, 205);
		label3.Name = "label3";
		label3.Size = new Size(96, 19);
		label3.TabIndex = 6;
		label3.Text = "Quantidade:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(27, 150);
		label4.Name = "label4";
		label4.Size = new Size(63, 19);
		label4.TabIndex = 8;
		label4.Text = "Cliente:";
		// 
		// Txt_Customer
		// 
		Txt_Customer.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Customer.Location = new Point(126, 147);
		Txt_Customer.Name = "Txt_Customer";
		Txt_Customer.Size = new Size(376, 27);
		Txt_Customer.TabIndex = 7;
		// 
		// Btn_Register
		// 
		Btn_Register.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Register.Location = new Point(12, 647);
		Btn_Register.Name = "Btn_Register";
		Btn_Register.Size = new Size(80, 38);
		Btn_Register.TabIndex = 9;
		Btn_Register.Text = "Cadastrar";
		Btn_Register.UseVisualStyleBackColor = true;
		Btn_Register.Click += Btn_Register_Click;
		// 
		// TxtProduct
		// 
		TxtProduct.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		TxtProduct.Location = new Point(6, 22);
		TxtProduct.Name = "TxtProduct";
		TxtProduct.PlaceholderText = "Pesquise o produto aqui";
		TxtProduct.Size = new Size(364, 27);
		TxtProduct.TabIndex = 10;
		// 
		// Btn_Pesquisar_Produto
		// 
		Btn_Pesquisar_Produto.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Pesquisar_Produto.Location = new Point(6, 55);
		Btn_Pesquisar_Produto.Name = "Btn_Pesquisar_Produto";
		Btn_Pesquisar_Produto.Size = new Size(86, 42);
		Btn_Pesquisar_Produto.TabIndex = 11;
		Btn_Pesquisar_Produto.Text = "Pesquisar";
		Btn_Pesquisar_Produto.UseVisualStyleBackColor = true;
		Btn_Pesquisar_Produto.Click += Btn_Pesquisar_Produto_Click;
		// 
		// Btn_Add_Product
		// 
		Btn_Add_Product.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Add_Product.Image = Properties.Resources.adicionar;
		Btn_Add_Product.Location = new Point(335, 55);
		Btn_Add_Product.Name = "Btn_Add_Product";
		Btn_Add_Product.Size = new Size(35, 33);
		Btn_Add_Product.TabIndex = 12;
		Btn_Add_Product.UseVisualStyleBackColor = true;
		Btn_Add_Product.Click += Btn_Add_Product_Click;
		// 
		// richTextBox_ProductsList
		// 
		richTextBox_ProductsList.BorderStyle = BorderStyle.None;
		richTextBox_ProductsList.Location = new Point(6, 103);
		richTextBox_ProductsList.Name = "richTextBox_ProductsList";
		richTextBox_ProductsList.Size = new Size(364, 280);
		richTextBox_ProductsList.TabIndex = 13;
		richTextBox_ProductsList.Text = "";
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(TxtProduct);
		groupBox1.Controls.Add(richTextBox_ProductsList);
		groupBox1.Controls.Add(Btn_Pesquisar_Produto);
		groupBox1.Controls.Add(Btn_Add_Product);
		groupBox1.Location = new Point(126, 252);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(376, 389);
		groupBox1.TabIndex = 15;
		groupBox1.TabStop = false;
		groupBox1.Text = "Produtos";
		// 
		// menuStrip1
		// 
		menuStrip1.Items.AddRange(new ToolStripItem[] { vendas_StripMenu });
		menuStrip1.Location = new Point(0, 0);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.Size = new Size(527, 24);
		menuStrip1.TabIndex = 16;
		menuStrip1.Text = "menuStrip1";
		// 
		// vendas_StripMenu
		// 
		vendas_StripMenu.Name = "vendas_StripMenu";
		vendas_StripMenu.Size = new Size(56, 20);
		vendas_StripMenu.Text = "Vendas";
		vendas_StripMenu.Click += Vendas_StripMenu_Click;
		// 
		// FormSales
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(527, 703);
		Controls.Add(groupBox1);
		Controls.Add(Btn_Register);
		Controls.Add(label4);
		Controls.Add(Txt_Customer);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(comboBox_MarketAddress);
		Controls.Add(Txt_Amount);
		Controls.Add(Txt_Salesman);
		Controls.Add(menuStrip1);
		MainMenuStrip = menuStrip1;
		Name = "FormSales";
		Text = "FormSales";
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
	private TextBox Txt_Salesman;
	private TextBox Txt_Amount;
	private ComboBox comboBox_MarketAddress;
	private Label label1;
	private Label label2;
	private Label label3;
	private Label label4;
	private TextBox Txt_Customer;
	private Button Btn_Register;
	private TextBox TxtProduct;
	private Button Btn_Pesquisar_Produto;
	private Button Btn_Add_Product;
	private RichTextBox richTextBox_ProductsList;
	private GroupBox groupBox1;
	private MenuStrip menuStrip1;
	private ToolStripMenuItem vendas_StripMenu;
}