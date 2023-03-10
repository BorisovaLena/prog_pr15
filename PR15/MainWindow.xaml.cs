using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        }

        private void cmbArifm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.tb = tbSimb;
            Model.result = tbRes;
            Model.Position = cmbArifm.SelectedIndex;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            if(tbOne.Text==""|| tbTwo.Text=="")
            {
                MessageBox.Show("Есть незаполненные поля!!!");
            }
            else
            {
                Regex r1 = new Regex("^[0-9]+$");
                if (r1.IsMatch(tbOne.Text)&& r1.IsMatch(tbTwo.Text))
                {
                    int a = Convert.ToInt32(tbOne.Text);
                    int b = Convert.ToInt32(tbTwo.Text);
                    int c = 0;
                    if(b==0 && cmbArifm.SelectedIndex == 3)
                    {
                        MessageBox.Show("Делить на 0 нельзя!!!");
                    }
                    else
                    {
                        switch (cmbArifm.SelectedIndex)
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
                else
                {
                    MessageBox.Show("Введены данные неправильного формата!!! Введите только натуральные числа!!!");
                }
               
            }
        }
    }
}
