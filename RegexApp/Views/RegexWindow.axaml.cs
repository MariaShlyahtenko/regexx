using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RegexApp.Views
{
    public partial class RegexWindow : Window
    {
        public delegate void Handler(string message);
        public event Handler? Notify;
        public RegexWindow()
        {

            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.FindControl<Button>("ok").Click += async delegate
            {
                Notify(this.Find<TextBox>("inputRegex").Text);
                Close();

            };
            this.FindControl<Button>("cancel").Click += delegate
            {
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}