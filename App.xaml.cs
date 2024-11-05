using Microsoft.Maui.Controls;

namespace PasswordManagerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();  // Ensure you instantiate AppShell here.
        }
    }
}
