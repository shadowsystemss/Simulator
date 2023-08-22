using System.Windows;

namespace Simulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void Title_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
            => DragMove();
    }
}
