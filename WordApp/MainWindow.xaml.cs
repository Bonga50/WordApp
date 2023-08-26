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

namespace WordApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataHandler handler = new DataHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            txtScrambled.Text= handler.selectRandomWord();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            bool iscorrect =  handler.compareWords(txtWord.Text);
            if (iscorrect)
            {
                MessageBox.Show("Correct");
            }
            else {
                MessageBox.Show("inCorrect");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtScrambled.Text =  handler.clearList();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
