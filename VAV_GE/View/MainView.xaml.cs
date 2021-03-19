using System.Windows;


namespace VAV_GE.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_Click_Lastik(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void Authors_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Владимир Тихоцкий\nАнжелика Васильева\nВладимир Сидоренко\nМы молодцы!");
        }
    }
}
