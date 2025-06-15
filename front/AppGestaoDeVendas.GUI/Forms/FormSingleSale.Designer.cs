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
		Txt_TotalAmount = new TextBox();
		Txt_MarketAddress = new TextBox();
		richTextBox_Sales_List = new RichTextBox();
		label1 = new Label();
		label2 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		Txt_Client_PhoneNumber = new MaskedTextBox();
		groupBox1 = new GroupBox();
		Txt_Client_Address = new TextBox();
		Txt_Client_Email = new TextBox();
		Txt_Client_Name = new TextBox();
		groupBox2 = new GroupBox();
		maskedTextBox_SaleDate = new MaskedTextBox();
		label8 = new Label();
		label7 = new Label();
		label3 = new Label();
		Btn_Update = new Button();
		Btn_Delete = new Button();
		label9 = new Label();
		Lbl_Id = new Label();
		label10 = new Label();
		Txt_Payment = new TextBox();
		groupBox1.SuspendLayout();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// Txt_Salesman
		// 
		Txt_Salesman.Font = new Font("Tahoma", 12F);
		Txt_Salesman.Location = new Point(105, 27);
		Txt_Salesman.Name = "Txt_Salesman";
		Txt_Salesman.Size = new Size(335, 27);
		Txt_Salesman.TabIndex = 0;
		// 
		// Txt_TotalAmount
		// 
		Txt_TotalAmount.Font = new Font("Tahoma", 12F);
		Txt_TotalAmount.Location = new Point(121, 219);
		Txt_TotalAmount.Name = "Txt_TotalAmount";
		Txt_TotalAmount.Size = new Size(156, 27);
		Txt_TotalAmount.TabIndex = 2;
		// 
		// Txt_MarketAddress
		// 
		Txt_MarketAddress.Font = new Font("Tahoma", 12F);
		Txt_MarketAddress.Location = new Point(105, 78);
		Txt_MarketAddress.Name = "Txt_MarketAddress";
		Txt_MarketAddress.Size = new Size(335, 27);
		Txt_MarketAddress.TabIndex = 3;
		// 
		// richTextBox_Sales_List
		// 
		richTextBox_Sales_List.Location = new Point(474, 19);
		richTextBox_Sales_List.Name = "richTextBox_Sales_List";
		richTextBox_Sales_List.Size = new Size(269, 503);
		richTextBox_Sales_List.TabIndex = 4;
		richTextBox_Sales_List.Text = "";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label1.Location = new Point(6, 30);
		label1.Name = "label1";
		label1.Size = new Size(93, 19);
		label1.TabIndex = 5;
		label1.Text = "Vendedor:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label2.Location = new Point(6, 27);
		label2.Name = "label2";
		label2.Size = new Size(62, 19);
		label2.TabIndex = 6;
		label2.Text = "Nome:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label4.Location = new Point(6, 141);
		label4.Name = "label4";
		label4.Size = new Size(73, 19);
		label4.TabIndex = 8;
		label4.Text = "Celular:";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label5.Location = new Point(8, 198);
		label5.Name = "label5";
		label5.Size = new Size(90, 19);
		label5.TabIndex = 9;
		label5.Text = "Endereço:";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label6.Location = new Point(8, 84);
		label6.Name = "label6";
		label6.Size = new Size(60, 19);
		label6.TabIndex = 10;
		label6.Text = "Email:";
		// 
		// Txt_Client_PhoneNumber
		// 
		Txt_Client_PhoneNumber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Client_PhoneNumber.Location = new Point(89, 138);
		Txt_Client_PhoneNumber.Mask = "(00) 0 0000-0000";
		Txt_Client_PhoneNumber.Name = "Txt_Client_PhoneNumber";
		Txt_Client_PhoneNumber.Size = new Size(171, 27);
		Txt_Client_PhoneNumber.TabIndex = 11;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(Txt_Client_Address);
		groupBox1.Controls.Add(Txt_Client_Email);
		groupBox1.Controls.Add(label5);
		groupBox1.Controls.Add(Txt_Client_PhoneNumber);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(Txt_Client_Name);
		groupBox1.Controls.Add(label4);
		groupBox1.Controls.Add(label6);
		groupBox1.Location = new Point(12, 12);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(456, 252);
		groupBox1.TabIndex = 12;
		groupBox1.TabStop = false;
		groupBox1.Text = "Cliente";
		// 
		// Txt_Client_Address
		// 
		Txt_Client_Address.Font = new Font("Tahoma", 12F);
		Txt_Client_Address.Location = new Point(104, 195);
		Txt_Client_Address.Name = "Txt_Client_Address";
		Txt_Client_Address.Size = new Size(332, 27);
		Txt_Client_Address.TabIndex = 15;
		// 
		// Txt_Client_Email
		// 
		Txt_Client_Email.Font = new Font("Tahoma", 12F);
		Txt_Client_Email.Location = new Point(74, 81);
		Txt_Client_Email.Name = "Txt_Client_Email";
		Txt_Client_Email.Size = new Size(362, 27);
		Txt_Client_Email.TabIndex = 14;
		// 
		// Txt_Client_Name
		// 
		Txt_Client_Name.Font = new Font("Tahoma", 12F);
		Txt_Client_Name.Location = new Point(74, 24);
		Txt_Client_Name.Name = "Txt_Client_Name";
		Txt_Client_Name.Size = new Size(362, 27);
		Txt_Client_Name.TabIndex = 13;
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(label10);
		groupBox2.Controls.Add(Txt_Payment);
		groupBox2.Controls.Add(maskedTextBox_SaleDate);
		groupBox2.Controls.Add(label8);
		groupBox2.Controls.Add(label7);
		groupBox2.Controls.Add(label3);
		groupBox2.Controls.Add(Txt_MarketAddress);
		groupBox2.Controls.Add(label1);
		groupBox2.Controls.Add(Txt_TotalAmount);
		groupBox2.Controls.Add(Txt_Salesman);
		groupBox2.Location = new Point(12, 270);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(456, 252);
		groupBox2.TabIndex = 13;
		groupBox2.TabStop = false;
		groupBox2.Text = "Venda";
		// 
		// maskedTextBox_SaleDate
		// 
		maskedTextBox_SaleDate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		maskedTextBox_SaleDate.Location = new Point(121, 129);
		maskedTextBox_SaleDate.Mask = "00/00/0000";
		maskedTextBox_SaleDate.Name = "maskedTextBox_SaleDate";
		maskedTextBox_SaleDate.Size = new Size(156, 27);
		maskedTextBox_SaleDate.TabIndex = 20;
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label8.Location = new Point(8, 222);
		label8.Name = "label8";
		label8.Size = new Size(58, 19);
		label8.TabIndex = 19;
		label8.Text = "Total:";
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(9, 132);
		label7.Name = "label7";
		label7.Size = new Size(54, 19);
		label7.TabIndex = 18;
		label7.Text = "Data:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(9, 81);
		label3.Name = "label3";
		label3.Size = new Size(90, 19);
		label3.TabIndex = 16;
		label3.Text = "Endereço:";
		// 
		// Btn_Update
		// 
		Btn_Update.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Update.Location = new Point(12, 551);
		Btn_Update.Name = "Btn_Update";
		Btn_Update.Size = new Size(105, 45);
		Btn_Update.TabIndex = 14;
		Btn_Update.Text = "Editar";
		Btn_Update.UseVisualStyleBackColor = true;
		// 
		// Btn_Delete
		// 
		Btn_Delete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Delete.Location = new Point(123, 551);
		Btn_Delete.Name = "Btn_Delete";
		Btn_Delete.Size = new Size(105, 45);
		Btn_Delete.TabIndex = 15;
		Btn_Delete.Text = "Excluir";
		Btn_Delete.UseVisualStyleBackColor = true;
		Btn_Delete.Click += Btn_Delete_Click;
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.Location = new Point(764, 12);
		label9.Name = "label9";
		label9.Size = new Size(18, 14);
		label9.TabIndex = 16;
		label9.Text = "Id:";
		// 
		// Lbl_Id
		// 
		Lbl_Id.AutoSize = true;
		Lbl_Id.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Lbl_Id.Location = new Point(764, 44);
		Lbl_Id.Name = "Lbl_Id";
		Lbl_Id.Size = new Size(43, 14);
		Lbl_Id.TabIndex = 17;
		Lbl_Id.Text = "stringID";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label10.Location = new Point(10, 176);
		label10.Name = "label10";
		label10.Size = new Size(108, 19);
		label10.TabIndex = 22;
		label10.Text = "Pagamento:";
		// 
		// Txt_Payment
		// 
		Txt_Payment.Font = new Font("Tahoma", 12F);
		Txt_Payment.Location = new Point(121, 173);
		Txt_Payment.Name = "Txt_Payment";
		Txt_Payment.Size = new Size(156, 27);
		Txt_Payment.TabIndex = 21;
		// 
		// FormSingleSale
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(753, 608);
		Controls.Add(Lbl_Id);
		Controls.Add(label9);
		Controls.Add(Btn_Delete);
		Controls.Add(Btn_Update);
		Controls.Add(groupBox2);
		Controls.Add(groupBox1);
		Controls.Add(richTextBox_Sales_List);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "FormSingleSale";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormSingleSale";
		Load += FormSingleSale_Load;
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private TextBox Txt_Salesman;
	private TextBox Txt_DateOfSale;
	private TextBox Txt_TotalAmount;
	private TextBox Txt_MarketAddress;
	private RichTextBox richTextBox_Sales_List;
	private Label label1;
	private Label label2;
	private Label label4;
	private Label label5;
	private Label label6;
	private MaskedTextBox Txt_Client_PhoneNumber;
	private GroupBox groupBox1;
	private TextBox Txt_Client_Email;
	private TextBox Txt_Client_Name;
	private TextBox Txt_Client_Address;
	private GroupBox groupBox2;
	private Label label3;
	private Label label7;
	private Label label8;
	private Button Btn_Update;
	private Button Btn_Delete;
	private MaskedTextBox maskedTextBox_SaleDate;
	private Label label9;
	private Label Lbl_Id;
	private Label label10;
	private TextBox Txt_Payment;
}