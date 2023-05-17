using System.Windows;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVM mainVM = new MainVM();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainWindow"/>.
        /// </summary>
        public MainWindow() 
        {
            InitializeComponent();
            DataContext = mainVM;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainVM.Save();
        }
    }
}
