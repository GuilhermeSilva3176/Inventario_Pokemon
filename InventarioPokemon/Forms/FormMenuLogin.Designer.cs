﻿namespace InventarioPokemon;

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
        txtEmailLogin = new TextBox();
        txtSenhaLogin = new TextBox();
        label2 = new Label();
        lblLogar = new Label();
        SuspendLayout();
        // 
        // btnRegistrar
        // 
        btnRegistrar.Location = new Point(12, 155);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(69, 30);
        btnRegistrar.TabIndex = 0;
        btnRegistrar.Text = "Registrar";
        btnRegistrar.UseVisualStyleBackColor = true;
        btnRegistrar.Click += btnRegistrar_Click;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(106, 155);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(69, 30);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 28);
        label1.Name = "label1";
        label1.Size = new Size(36, 15);
        label1.TabIndex = 2;
        label1.Text = "Email";
        // 
        // txtEmailLogin
        // 
        txtEmailLogin.Location = new Point(12, 46);
        txtEmailLogin.Name = "txtEmailLogin";
        txtEmailLogin.Size = new Size(163, 23);
        txtEmailLogin.TabIndex = 3;
        // 
        // txtSenhaLogin
        // 
        txtSenhaLogin.Location = new Point(12, 102);
        txtSenhaLogin.Name = "txtSenhaLogin";
        txtSenhaLogin.Size = new Size(163, 23);
        txtSenhaLogin.TabIndex = 5;
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
        // lblLogar
        // 
        lblLogar.AutoSize = true;
        lblLogar.Location = new Point(12, 191);
        lblLogar.Name = "lblLogar";
        lblLogar.Size = new Size(0, 15);
        lblLogar.TabIndex = 9;
        // 
        // FormMenuLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(193, 215);
        Controls.Add(lblLogar);
        Controls.Add(txtSenhaLogin);
        Controls.Add(label2);
        Controls.Add(txtEmailLogin);
        Controls.Add(label1);
        Controls.Add(btnLogin);
        Controls.Add(btnRegistrar);
        Name = "FormMenuLogin";
        Text = "Menu - Login";
        Load += FormMenuLogin_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnRegistrar;
    private Button btnLogin;
    private Label label1;
    private TextBox txtEmailLogin;
    private TextBox txtSenhaLogin;
    private Label label2;
    private Label lblLogar;
}