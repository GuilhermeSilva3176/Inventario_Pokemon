﻿namespace InventarioPokemon
{
    partial class FormTelaUsuario
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
            label1 = new Label();
            lblUsuario = new Label();
            btnDelete = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(115, 19);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(29, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "N/A";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(390, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(49, 22);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 182);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 3;
            label2.Text = "Clique aqui para deletar sua conta:";
            // 
            // FormTelaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 206);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Name = "FormTelaUsuario";
            Text = "Tela Usuario - Configuração";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private Button btnDelete;
        private Label label2;
    }
}