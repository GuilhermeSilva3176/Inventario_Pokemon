namespace InventarioPokemon.Forms
{
    partial class FormAtualizarConta
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
            button1 = new Button();
            txtNomeAtualizar = new TextBox();
            txtEmailAtualizar = new TextBox();
            txtSenhaAtualizar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(158, 207);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAtualizar_Click;
            // 
            // txtNomeAtualizar
            // 
            txtNomeAtualizar.Location = new Point(78, 37);
            txtNomeAtualizar.Name = "txtNomeAtualizar";
            txtNomeAtualizar.Size = new Size(155, 23);
            txtNomeAtualizar.TabIndex = 1;
            // 
            // txtEmailAtualizar
            // 
            txtEmailAtualizar.Location = new Point(78, 92);
            txtEmailAtualizar.Name = "txtEmailAtualizar";
            txtEmailAtualizar.Size = new Size(155, 23);
            txtEmailAtualizar.TabIndex = 2;
            // 
            // txtSenhaAtualizar
            // 
            txtSenhaAtualizar.Location = new Point(78, 152);
            txtSenhaAtualizar.Name = "txtSenhaAtualizar";
            txtSenhaAtualizar.Size = new Size(155, 23);
            txtSenhaAtualizar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 42);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 155);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Senha:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 207);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancelar_Click;
            // 
            // FormAtualizarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 242);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenhaAtualizar);
            Controls.Add(txtEmailAtualizar);
            Controls.Add(txtNomeAtualizar);
            Controls.Add(button1);
            Name = "FormAtualizarConta";
            Text = "FormAtualizarConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNomeAtualizar;
        private TextBox txtEmailAtualizar;
        private TextBox txtSenhaAtualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}