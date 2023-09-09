﻿using InventarioPokemon.Models.UsuarioLoginERegistrar;

namespace InventarioPokemon.Services.ServicoDeAutenticacao;

internal class AutenticacaoService
{
    private readonly string _conexaoString;

    public AutenticacaoService(string conexaoString) => _conexaoString = conexaoString;  

    public void AutenticarUsuario(string email, string senha, Form form)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
        {
            ExibirErro(form, "Preencha os campos", Color.Red);
            return;
        }

        try
        {
            LogarConta logarConta = new LogarConta(_conexaoString);
            int usuarioId = logarConta.LogarUsuario(email, senha);
            
            if (usuarioId > 0)
            {
                MessageBox.Show("Autenticação bem-sucedida!");
                ExibirTelaUsuario(form);
            }
            else if (usuarioId == -1)
            {
                ExibirErro(form, "Email ou Senha incorretos", Color.Red);
            }
            else
            {
                ExibirErro(form, "Erro durante a autenticação.", Color.Red);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
        }
    }

    private void ExibirErro(Form form, string mensagem, Color cor)
    {
        Label lblLogar = form.Controls.Find("lblLogar", true).FirstOrDefault() as Label;
        lblLogar.Text = mensagem;
        lblLogar.ForeColor = cor;
    }

    private void ExibirTelaUsuario(Form form)
    {
        FormTelaUsuario telaUsuario = new FormTelaUsuario();      
        form.Hide();
        telaUsuario.ShowDialog();
    }
}