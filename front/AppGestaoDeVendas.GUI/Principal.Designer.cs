namespace AppGestaoDeVendas.GUI;

partial class Principal
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		button1 = new Button();
		panel1 = new Panel();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		// 
		// button1
		// 
		button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button1.Location = new Point(43, 43);
		button1.Name = "button1";
		button1.Size = new Size(109, 44);
		button1.TabIndex = 0;
		button1.Text = "Vendas";
		button1.UseVisualStyleBackColor = true;
		button1.Click += Btn_Vendas_Click;
		// 
		// panel1
		// 
		panel1.BackColor = Color.SeaGreen;
		panel1.Controls.Add(button4);
		panel1.Controls.Add(button3);
		panel1.Controls.Add(button2);
		panel1.Controls.Add(button1);
		panel1.Location = new Point(2, 3);
		panel1.Name = "panel1";
		panel1.Size = new Size(200, 379);
		panel1.TabIndex = 1;
		// 
		// button4
		// 
		button4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(43, 93);
		button4.Name = "button4";
		button4.Size = new Size(109, 44);
		button4.TabIndex = 3;
		button4.Text = "Produtos";
		button4.UseVisualStyleBackColor = true;
		button4.Click += Btn_Products_Click;
		// 
		// button3
		// 
		button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(43, 143);
		button3.Name = "button3";
		button3.Size = new Size(109, 44);
		button3.TabIndex = 2;
		button3.Text = "Clientes";
		button3.UseVisualStyleBackColor = true;
		// 
		// button2
		// 
		button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(46, 211);
		button2.Name = "button2";
		button2.Size = new Size(109, 44);
		button2.TabIndex = 1;
		button2.Text = "Relatórios";
		button2.UseVisualStyleBackColor = true;
		// 
		// pictureBox1
		// 
		pictureBox1.Image = Properties.Resources.ChatGPT_Image_30_de_mar__de_2025__11_30_37;
		pictureBox1.Location = new Point(200, 3);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(476, 379);
		pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox1.TabIndex = 2;
		pictureBox1.TabStop = false;
		// 
		// Principal
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(681, 386);
		Controls.Add(pictureBox1);
		Controls.Add(panel1);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "Principal";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Supermarket";
		panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Button button1;
	private Panel panel1;
	private Button button4;
	private Button button3;
	private Button button2;
	private PictureBox pictureBox1;
}
