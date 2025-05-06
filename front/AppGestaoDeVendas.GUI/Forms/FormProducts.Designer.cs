namespace AppGestaoDeVendas.GUI.Forms;

partial class FormProducts
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
		Btn_Cadastrar_Produto = new Button();
		txt_Name = new TextBox();
		label1 = new Label();
		button2 = new Button();
		button3 = new Button();
		Btn_Pesquisar = new Button();
		label2 = new Label();
		txt_Price = new TextBox();
		label3 = new Label();
		txt_Amount = new TextBox();
		label4 = new Label();
		txt_Code = new TextBox();
		label5 = new Label();
		txt_Description = new TextBox();
		txt_Id = new TextBox();
		SuspendLayout();
		// 
		// Btn_Cadastrar_Produto
		// 
		Btn_Cadastrar_Produto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Cadastrar_Produto.Location = new Point(13, 270);
		Btn_Cadastrar_Produto.Name = "Btn_Cadastrar_Produto";
		Btn_Cadastrar_Produto.Size = new Size(109, 44);
		Btn_Cadastrar_Produto.TabIndex = 1;
		Btn_Cadastrar_Produto.Text = "Cadastrar";
		Btn_Cadastrar_Produto.UseVisualStyleBackColor = true;
		Btn_Cadastrar_Produto.Click += Btn_Cadastrar_Produto_Click;
		// 
		// txt_Name
		// 
		txt_Name.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Name.Location = new Point(111, 16);
		txt_Name.Name = "txt_Name";
		txt_Name.Size = new Size(345, 27);
		txt_Name.TabIndex = 2;
		txt_Name.Tag = "";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label1.Location = new Point(12, 19);
		label1.Name = "label1";
		label1.Size = new Size(62, 19);
		label1.TabIndex = 3;
		label1.Text = "Nome:";
		// 
		// button2
		// 
		button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(358, 270);
		button2.Name = "button2";
		button2.Size = new Size(109, 44);
		button2.TabIndex = 4;
		button2.Text = "Deletar";
		button2.UseVisualStyleBackColor = true;
		button2.Click += Btn_Deletar_Click;
		// 
		// button3
		// 
		button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(243, 270);
		button3.Name = "button3";
		button3.Size = new Size(109, 44);
		button3.TabIndex = 5;
		button3.Text = "Editar";
		button3.UseVisualStyleBackColor = true;
		button3.Click += Btn_Editar_Click;
		// 
		// Btn_Pesquisar
		// 
		Btn_Pesquisar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Pesquisar.Location = new Point(128, 270);
		Btn_Pesquisar.Name = "Btn_Pesquisar";
		Btn_Pesquisar.Size = new Size(109, 44);
		Btn_Pesquisar.TabIndex = 6;
		Btn_Pesquisar.Text = "Pesquisar";
		Btn_Pesquisar.UseVisualStyleBackColor = true;
		Btn_Pesquisar.Click += Btn_Pesquisar_Click;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label2.Location = new Point(12, 203);
		label2.Name = "label2";
		label2.Size = new Size(61, 19);
		label2.TabIndex = 8;
		label2.Text = "Preço:";
		// 
		// txt_Price
		// 
		txt_Price.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Price.Location = new Point(111, 200);
		txt_Price.Name = "txt_Price";
		txt_Price.Size = new Size(172, 27);
		txt_Price.TabIndex = 7;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(12, 157);
		label3.Name = "label3";
		label3.Size = new Size(109, 19);
		label3.TabIndex = 10;
		label3.Text = "Quantidade:";
		// 
		// txt_Amount
		// 
		txt_Amount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Amount.Location = new Point(127, 154);
		txt_Amount.Name = "txt_Amount";
		txt_Amount.Size = new Size(156, 27);
		txt_Amount.TabIndex = 9;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label4.Location = new Point(12, 111);
		label4.Name = "label4";
		label4.Size = new Size(71, 19);
		label4.TabIndex = 12;
		label4.Text = "Código:";
		// 
		// txt_Code
		// 
		txt_Code.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Code.Location = new Point(111, 108);
		txt_Code.Name = "txt_Code";
		txt_Code.Size = new Size(345, 27);
		txt_Code.TabIndex = 11;
		txt_Code.Tag = "";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label5.Location = new Point(12, 65);
		label5.Name = "label5";
		label5.Size = new Size(93, 19);
		label5.TabIndex = 14;
		label5.Text = "Descrição:";
		// 
		// txt_Description
		// 
		txt_Description.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Description.Location = new Point(111, 62);
		txt_Description.Name = "txt_Description";
		txt_Description.Size = new Size(345, 27);
		txt_Description.TabIndex = 13;
		// 
		// txt_Id
		// 
		txt_Id.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Id.Location = new Point(507, 19);
		txt_Id.Name = "txt_Id";
		txt_Id.Size = new Size(40, 27);
		txt_Id.TabIndex = 15;
		// 
		// FormProducts
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(594, 344);
		Controls.Add(txt_Id);
		Controls.Add(label5);
		Controls.Add(txt_Description);
		Controls.Add(label4);
		Controls.Add(txt_Code);
		Controls.Add(label3);
		Controls.Add(txt_Amount);
		Controls.Add(label2);
		Controls.Add(txt_Price);
		Controls.Add(Btn_Pesquisar);
		Controls.Add(button3);
		Controls.Add(button2);
		Controls.Add(label1);
		Controls.Add(txt_Name);
		Controls.Add(Btn_Cadastrar_Produto);
		Name = "FormProducts";
		Text = "FormProducts";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button Btn_Cadastrar_Produto;
	private TextBox txt_Name;
	private Label label1;
	private Button button2;
	private Button button3;
	private Button Btn_Pesquisar;
	private Label label2;
	private TextBox txt_Price;
	private Label label3;
	private TextBox txt_Amount;
	private Label label4;
	private TextBox txt_Code;
	private Label label5;
	private TextBox txt_Description;
	private TextBox txt_Id;
}