using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System.Windows;
using WpfApp1.DB;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddDbContextFactory<ProductContext>();
            serviceCollection.AddMudServices();
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}