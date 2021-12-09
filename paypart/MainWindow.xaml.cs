using System;
using System.Collections.Generic;
using System.Linq;
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

namespace paypart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonShowDialog_Click(object sender, RoutedEventArgs e)
        {


            paypart.listpop list_pop = new paypart.listpop();

            list_pop.Top = this.Top + (this.ActualHeight - list_pop.Height) / 2;
            list_pop.Left = this.Left + (this.ActualWidth - list_pop.Width) / 2;

            list_pop.ShowDialog();
        }

     }


 }

