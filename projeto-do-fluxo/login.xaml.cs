using System.Windows;

namespace projeto_do_fluxo_1;

    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Click(object sender, projeto_do_fluxo e)
        {
            MessageBox.Show("Função de recuperação de senha não implementada.");
        }

        private void HaveAccount_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Redirecionando para a página de login.");
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            MessageBox.Show($"Registrando com Email: {email}, Senha: {password}");
        }

        private void GoogleSignUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Função de cadastro com Google não implementada.");
        }

        private void FacebookSignUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Função de cadastro com Facebook não implementada.");
        }
    }

