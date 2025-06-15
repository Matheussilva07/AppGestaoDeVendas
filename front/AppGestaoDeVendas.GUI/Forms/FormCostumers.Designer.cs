namespace AppGestaoDeVendas.GUI.Forms;

partial class FormCostumers
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
		label5 = new Label();
		label4 = new Label();
		label2 = new Label();
		Txt_Adress = new TextBox();
		Btn_Pesquisar = new Button();
		button3 = new Button();
		button2 = new Button();
		label1 = new Label();
		txt_Name = new TextBox();
		Btn_Cadastrar_Produto = new Button();
		menuStrip1 = new MenuStrip();
		clientesToolStripMenuItem = new ToolStripMenuItem();
		Txt_Telephone = new TextBox();
		Txt_Email = new TextBox();
		label6 = new Label();
		lbl_ID = new Label();
		menuStrip1.SuspendLayout();
		SuspendLayout();
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label5.Location = new Point(10, 103);
		label5.Name = "label5";
		label5.Size = new Size(60, 19);
		label5.TabIndex = 28;
		label5.Text = "Email:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label4.Location = new Point(10, 152);
		label4.Name = "label4";
		label4.Size = new Size(87, 19);
		label4.TabIndex = 26;
		label4.Text = "Telefone:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label2.Location = new Point(10, 201);
		label2.Name = "label2";
		label2.Size = new Size(90, 19);
		label2.TabIndex = 22;
		label2.Text = "Endereço:";
		// 
		// Txt_Adress
		// 
		Txt_Adress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Adress.Location = new Point(109, 198);
		Txt_Adress.Name = "Txt_Adress";
		Txt_Adress.Size = new Size(415, 27);
		Txt_Adress.TabIndex = 21;
		// 
		// Btn_Pesquisar
		// 
		Btn_Pesquisar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Pesquisar.Location = new Point(156, 260);
		Btn_Pesquisar.Name = "Btn_Pesquisar";
		Btn_Pesquisar.Size = new Size(109, 44);
		Btn_Pesquisar.TabIndex = 20;
		Btn_Pesquisar.Text = "Pesquisar";
		Btn_Pesquisar.UseVisualStyleBackColor = true;
		Btn_Pesquisar.Click += Btn_Pesquisar_Click;
		// 
		// button3
		// 
		button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(271, 260);
		button3.Name = "button3";
		button3.Size = new Size(109, 44);
		button3.TabIndex = 19;
		button3.Text = "Editar";
		button3.UseVisualStyleBackColor = true;
		button3.Click += Btn_Update_Click;
		// 
		// button2
		// 
		button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(386, 260);
		button2.Name = "button2";
		button2.Size = new Size(109, 44);
		button2.TabIndex = 18;
		button2.Text = "Deletar";
		button2.UseVisualStyleBackColor = true;
		button2.Click += Btn_Delete_Click;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label1.Location = new Point(10, 54);
		label1.Name = "label1";
		label1.Size = new Size(62, 19);
		label1.TabIndex = 17;
		label1.Text = "Nome:";
		// 
		// txt_Name
		// 
		txt_Name.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txt_Name.Location = new Point(109, 51);
		txt_Name.Name = "txt_Name";
		txt_Name.Size = new Size(415, 27);
		txt_Name.TabIndex = 16;
		txt_Name.Tag = "";
		// 
		// Btn_Cadastrar_Produto
		// 
		Btn_Cadastrar_Produto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Cadastrar_Produto.Location = new Point(41, 260);
		Btn_Cadastrar_Produto.Name = "Btn_Cadastrar_Produto";
		Btn_Cadastrar_Produto.Size = new Size(109, 44);
		Btn_Cadastrar_Produto.TabIndex = 15;
		Btn_Cadastrar_Produto.Text = "Cadastrar";
		Btn_Cadastrar_Produto.UseVisualStyleBackColor = true;
		Btn_Cadastrar_Produto.Click += Btn_Register_Customer_Click;
		// 
		// menuStrip1
		// 
		menuStrip1.BackColor = Color.SeaGreen;
		menuStrip1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
		menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
		menuStrip1.Location = new Point(0, 0);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.Size = new Size(542, 24);
		menuStrip1.TabIndex = 29;
		menuStrip1.Text = "menuStrip1";
		// 
		// clientesToolStripMenuItem
		// 
		clientesToolStripMenuItem.ForeColor = Color.White;
		clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
		clientesToolStripMenuItem.Size = new Size(67, 20);
		clientesToolStripMenuItem.Text = "Clientes";
		clientesToolStripMenuItem.Click += ClientesToolStripMenuItem_Click;
		// 
		// Txt_Telephone
		// 
		Txt_Telephone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Telephone.Location = new Point(109, 149);
		Txt_Telephone.Name = "Txt_Telephone";
		Txt_Telephone.Size = new Size(415, 27);
		Txt_Telephone.TabIndex = 30;
		Txt_Telephone.Tag = "";
		// 
		// Txt_Email
		// 
		Txt_Email.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Email.Location = new Point(109, 100);
		Txt_Email.Name = "Txt_Email";
		Txt_Email.Size = new Size(415, 27);
		Txt_Email.TabIndex = 31;
		Txt_Email.Tag = "";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(546, 41);
		label6.Name = "label6";
		label6.Size = new Size(21, 15);
		label6.TabIndex = 32;
		label6.Text = "ID:";
		// 
		// lbl_ID
		// 
		lbl_ID.AutoSize = true;
		lbl_ID.Location = new Point(591, 41);
		lbl_ID.Name = "lbl_ID";
		lbl_ID.Size = new Size(0, 15);
		lbl_ID.TabIndex = 33;
		// 
		// FormCostumers
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(542, 323);
		Controls.Add(lbl_ID);
		Controls.Add(label6);
		Controls.Add(Txt_Email);
		Controls.Add(Txt_Telephone);
		Controls.Add(label5);
		Controls.Add(label4);
		Controls.Add(label2);
		Controls.Add(Txt_Adress);
		Controls.Add(Btn_Pesquisar);
		Controls.Add(button3);
		Controls.Add(button2);
		Controls.Add(label1);
		Controls.Add(txt_Name);
		Controls.Add(Btn_Cadastrar_Produto);
		Controls.Add(menuStrip1);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MainMenuStrip = menuStrip1;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "FormCostumers";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormCostumers";
		Load += FormCostumers_Load;
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label label5;
	private Label label4;
	private Label label3;
	private Label label2;
	private TextBox Txt_Adress;
	private Button Btn_Pesquisar;
	private Button button3;
	private Button button2;
	private Label label1;
	private TextBox txt_Name;
	private Button Btn_Cadastrar_Produto;
	private MenuStrip menuStrip1;
	private ToolStripMenuItem clientesToolStripMenuItem;
	private TextBox Txt_Telephone;
	private TextBox Txt_Email;
	private Label label6;
	private Label lbl_ID;
}