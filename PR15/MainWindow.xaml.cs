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

namespace PR15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbArifm.SelectedIndex = 0;
            Model.tb = tbSimb;
            Model.result = tbRes;
        }

        private void cmbArifm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Position = cmbArifm.SelectedIndex;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(tbOne.Text);
            int b = Convert.ToInt32(tbTwo.Text);
            int c =0;
            switch(cmbArifm.SelectedIndex)
            {
                case 0:
                    c = a + b;
                    break;
                case 1:
                    c = a - b;
                    break;
                case 2:
                    c = a * b;
                    break;
                case 3:
                    c = a / b;
                    break;
            }
            Model.Calculation = c;
        }
    }
}
