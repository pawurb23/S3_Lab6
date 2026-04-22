using System.Windows;
using S3_Lab6.ViewModel;

namespace S3_Lab6
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}