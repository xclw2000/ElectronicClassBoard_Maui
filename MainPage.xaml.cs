using Microsoft.Maui.Controls.Platform;

namespace ElectronicClassBoard_Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = "http://class-board-demo.iwisesoft.com/welcome" };
        }
    }
}