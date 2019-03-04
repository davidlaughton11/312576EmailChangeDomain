/* David Laughton
 *  March 4 2019
 *  josh helped email program change domain
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JoshTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string text;
        // Creates Array of strings (multiple)
        string[] splittext;
        string output;
        string address = "@hotmail.com";

        int location;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text = txt_input.Text;
            location = text.IndexOf("@");

            //At the @ symbol, splits into splittext[0] and splittext[1]
            splittext = text.Split('@');

            txt_output.Text = splittext[0] + address;
        }
    }
}
