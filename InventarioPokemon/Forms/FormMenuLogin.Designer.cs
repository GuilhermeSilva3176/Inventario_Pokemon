namespace InventarioPokemon;

partial class FormMenuLogin
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
        btnRegistrar = new Button();
        btnLogin = new Button();
        label1 = new Label();
        txtEmail = new TextBox();
        txtSenha = new TextBox();
        label2 = new Label();
        btnTestarConexao = new Button();
        label3 = new Label();
        SuspendLayout();
        // 
        // btnRegistrar
        // 
        btnRegistrar.Location = new Point(12, 195);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(90, 30);
        btnRegistrar.TabIndex = 0;
        btnRegistrar.Text = "Registrar";
        btnRegistrar.UseVisualStyleBackColor = true;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(12, 159);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(90, 30);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += button2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 28);
        label1.Name = "label1";
        label1.Size = new Size(36, 15);
        label1.TabIndex = 2;
        label1.Text = "Email";
        label1.Click += label1_Click;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(12, 46);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(163, 23);
        txtEmail.TabIndex = 3;
        // 
        // txtSenha
        // 
        txtSenha.Location = new Point(12, 102);
        txtSenha.Name = "txtSenha";
        txtSenha.Size = new Size(163, 23);
        txtSenha.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 84);
        label2.Name = "label2";
        label2.Size = new Size(39, 15);
        label2.TabIndex = 4;
        label2.Text = "Senha";
        // 
        // btnTestarConexao
        // 
        btnTestarConexao.Location = new Point(308, 229);
        btnTestarConexao.Name = "btnTestarConexao";
        btnTestarConexao.Size = new Size(78, 25);
        btnTestarConexao.TabIndex = 6;
        btnTestarConexao.Text = "Conexão";
        btnTestarConexao.UseVisualStyleBackColor = true;
        btnTestarConexao.Click += btnTestarConexao_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(217, 234);
        label3.Name = "label3";
        label3.Size = new Size(88, 15);
        label3.TabIndex = 7;
        label3.Text = "Testar conexão:";
        // 
        // FormMenuLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(398, 261);
        Controls.Add(label3);
        Controls.Add(btnTestarConexao);
        Controls.Add(txtSenha);
        Controls.Add(label2);
        Controls.Add(txtEmail);
        Controls.Add(label1);
        Controls.Add(btnLogin);
        Controls.Add(btnRegistrar);
        Name = "FormMenuLogin";
        Text = "Menu - Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnRegistrar;
    private Button btnLogin;
    private Label label1;
    private TextBox txtEmail;
    private TextBox txtSenha;
    private Label label2;
    private Button btnTestarConexao;
    private Label label3;
}