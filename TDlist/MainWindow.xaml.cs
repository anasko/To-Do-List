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

namespace TDlist
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        TextBox[] textBox = new TextBox[5];
        
        void AddTextBox(int i, TextBox[] textBox, int h,int l){
             
            textBox[i] = new TextBox();
            textBox[i].HorizontalAlignment = HorizontalAlignment.Left;
            textBox[i].Height = 20;
            textBox[i].Width = 346;
            textBox[i].VerticalAlignment = VerticalAlignment.Top;
            textBox[i].TextWrapping = TextWrapping.Wrap;
            textBox[i].Margin = new Thickness(h, l,0,0);
            MyGrid.Children.Add(textBox[0]);

    }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            AddTextBox(0, textBox, 1, 1);
               
       }


    }
}
