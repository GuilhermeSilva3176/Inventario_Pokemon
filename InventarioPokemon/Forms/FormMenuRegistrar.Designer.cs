namespace InventarioPokemon.Forms
{
    partial class FormMenuRegistrar
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
            txtNomeRegistrar = new TextBox();
            label2 = new Label();
            txtEmailRegistrar = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            label3 = new Label();
            txtSenhaRegistrar = new TextBox();
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // txtNomeRegistrar
            // 
            txtNomeRegistrar.Location = new Point(12, 27);
            txtNomeRegistrar.Name = "txtNomeRegistrar";
            txtNomeRegistrar.Size = new Size(153, 23);
            txtNomeRegistrar.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // txtEmailRegistrar
            // 
            txtEmailRegistrar.Location = new Point(12, 85);
            txtEmailRegistrar.Name = "txtEmailRegistrar";
            txtEmailRegistrar.Size = new Size(153, 23);
            txtEmailRegistrar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 188);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 30);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Criar Conta";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Senha";
            // 
            // txtSenhaRegistrar
            // 
            txtSenhaRegistrar.Location = new Point(12, 144);
            txtSenhaRegistrar.Name = "txtSenhaRegistrar";
            txtSenhaRegistrar.Size = new Size(153, 23);
            txtSenhaRegistrar.TabIndex = 12;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(110, 196);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(0, 15);
            lblRegistro.TabIndex = 13;
            // 
            // FormMenuRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 239);
            Controls.Add(lblRegistro);
            Controls.Add(txtSenhaRegistrar);
            Controls.Add(label3);
            Controls.Add(txtNomeRegistrar);
            Controls.Add(label2);
            Controls.Add(txtEmailRegistrar);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Name = "FormMenuRegistrar";
            Text = "Menu - Registrar";
            Load += FormMenuRegistrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeRegistrar;
        private Label label2;
        private TextBox txtEmailRegistrar;
        private Label label1;
        private Button btnRegistrar;
        private Label label3;
        private TextBox txtSenhaRegistrar;
        private Label lblRegistro;
    }
}