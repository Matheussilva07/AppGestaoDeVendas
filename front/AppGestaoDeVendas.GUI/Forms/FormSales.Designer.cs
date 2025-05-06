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
		comboBox_Products = new ComboBox();
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
		SuspendLayout();
		// 
		// comboBox_Products
		// 
		comboBox_Products.FormattingEnabled = true;
		comboBox_Products.Location = new Point(446, 22);
		comboBox_Products.Name = "comboBox_Products";
		comboBox_Products.Size = new Size(240, 23);
		comboBox_Products.TabIndex = 0;
		// 
		// Txt_Salesman
		// 
		Txt_Salesman.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Salesman.Location = new Point(111, 23);
		Txt_Salesman.Name = "Txt_Salesman";
		Txt_Salesman.Size = new Size(318, 27);
		Txt_Salesman.TabIndex = 1;
		// 
		// Txt_Amount
		// 
		Txt_Amount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Amount.Location = new Point(111, 181);
		Txt_Amount.Name = "Txt_Amount";
		Txt_Amount.Size = new Size(318, 27);
		Txt_Amount.TabIndex = 2;
		// 
		// comboBox_MarketAddress
		// 
		comboBox_MarketAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		comboBox_MarketAddress.FormattingEnabled = true;
		comboBox_MarketAddress.Items.AddRange(new object[] { "Av Maruim", "Av São Paulo", "Av Rio de Janeiro", "Rodovia dos Naufrágos" });
		comboBox_MarketAddress.Location = new Point(111, 73);
		comboBox_MarketAddress.Name = "comboBox_MarketAddress";
		comboBox_MarketAddress.Size = new Size(206, 27);
		comboBox_MarketAddress.TabIndex = 3;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(9, 26);
		label1.Name = "label1";
		label1.Size = new Size(83, 19);
		label1.TabIndex = 4;
		label1.Text = "Vendedor:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(12, 76);
		label2.Name = "label2";
		label2.Size = new Size(45, 19);
		label2.TabIndex = 5;
		label2.Text = "Loja:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(9, 184);
		label3.Name = "label3";
		label3.Size = new Size(96, 19);
		label3.TabIndex = 6;
		label3.Text = "Quantidade:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(12, 129);
		label4.Name = "label4";
		label4.Size = new Size(63, 19);
		label4.TabIndex = 8;
		label4.Text = "Cliente:";
		// 
		// Txt_Customer
		// 
		Txt_Customer.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Customer.Location = new Point(111, 126);
		Txt_Customer.Name = "Txt_Customer";
		Txt_Customer.Size = new Size(307, 27);
		Txt_Customer.TabIndex = 7;
		// 
		// Btn_Register
		// 
		Btn_Register.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Register.Location = new Point(9, 276);
		Btn_Register.Name = "Btn_Register";
		Btn_Register.Size = new Size(110, 48);
		Btn_Register.TabIndex = 9;
		Btn_Register.Text = "Cadastrar";
		Btn_Register.UseVisualStyleBackColor = true;
		Btn_Register.Click += Btn_Register_Click;
		// 
		// TxtProduct
		// 
		TxtProduct.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		TxtProduct.Location = new Point(479, 211);
		TxtProduct.Name = "TxtProduct";
		TxtProduct.PlaceholderText = "Pesquise o produto aqui";
		TxtProduct.Size = new Size(207, 27);
		TxtProduct.TabIndex = 10;
		// 
		// Btn_Pesquisar_Produto
		// 
		Btn_Pesquisar_Produto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Pesquisar_Produto.Location = new Point(539, 265);
		Btn_Pesquisar_Produto.Name = "Btn_Pesquisar_Produto";
		Btn_Pesquisar_Produto.Size = new Size(110, 48);
		Btn_Pesquisar_Produto.TabIndex = 11;
		Btn_Pesquisar_Produto.Text = "Pesquisar";
		Btn_Pesquisar_Produto.UseVisualStyleBackColor = true;
		Btn_Pesquisar_Produto.Click += Btn_Pesquisar_Produto_Click;
		// 
		// Btn_Add_Product
		// 
		Btn_Add_Product.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Add_Product.Location = new Point(467, 126);
		Btn_Add_Product.Name = "Btn_Add_Product";
		Btn_Add_Product.Size = new Size(110, 48);
		Btn_Add_Product.TabIndex = 12;
		Btn_Add_Product.Text = "Adicionar ";
		Btn_Add_Product.UseVisualStyleBackColor = true;
		Btn_Add_Product.Click += Btn_Add_Product_Click;
		// 
		// FormSales
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(718, 341);
		Controls.Add(Btn_Add_Product);
		Controls.Add(Btn_Pesquisar_Produto);
		Controls.Add(TxtProduct);
		Controls.Add(Btn_Register);
		Controls.Add(label4);
		Controls.Add(Txt_Customer);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(comboBox_MarketAddress);
		Controls.Add(Txt_Amount);
		Controls.Add(Txt_Salesman);
		Controls.Add(comboBox_Products);
		Name = "FormSales";
		Text = "FormSales";
		Load += FormSales_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private ComboBox comboBox_Products;
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
}