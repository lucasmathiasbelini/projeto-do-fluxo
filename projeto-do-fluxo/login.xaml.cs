using System.Windows;
using Microsoft.Maui.Controls;

namespace projeto_do_fluxo;

    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Função de recuperação de senha não implementada.");
        }

        private void HaveAccount_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Redirecionando para a página de login.");
        }

        private void Register_Click(object sender, EventArgs e)
        {
          //  string email = EmailTextBox.Text;
           // string password = PasswordTextBox.Text;

          //  MessageBox.Show($"Registrando com Email: {email}, Senha: {password}");
        }

        private void GoogleSignUp_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Função de cadastro com Google não implementada.");
        }

        private void FacebookSignUp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Função de cadastro com Facebook não implementada.");
        }
    }

