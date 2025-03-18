using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label.Visibility=Visibility.Hidden;
            textbox.Visibility=Visibility.Hidden;
            combobox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Visible;
            textbox.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Hidden;
            textbox.Visibility = Visibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(name.Text);
            StreamWriter writer = new StreamWriter("adatok.txt", false, Encoding.UTF8);
            if (checkbox.IsChecked == false || textbox.Text=="")
            {
                writer.WriteLine(name.Text+";"+kezd.Text+";"+veg.Text+";"+combobox.Text+";"+"0");
            }
            else
            {
                writer.WriteLine(name.Text + ";" + kezd.Text + ";" + veg.Text + ";" + combobox.Text + ";" + textbox.Text);
            }
            name.Text = "";
            kezd.Text = "";
            veg.Text = "";
            combobox.SelectedIndex = 0;
            textbox.Text = "";
            

            writer.Close();
        }
    }
}