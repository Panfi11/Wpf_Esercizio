using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_Esercizio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Line { get; private set; }

        private void BtnGen_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int a = int.Parse(TxbNum.Text);
            int[] array = new int[a];
            for(i =0; i < array.Length; i++)
            {
                array[i] = random.Next(1,7);
                

            }

            LblArr.Content = "[";
            for (i = 0; i < array.Length; i++)
            {
                LblArr.Content += $"{array[i]}";
                if (i < array.Length-1)
                {
                    LblArr.Content += $","; 
                }
            }
            LblArr.Content += $"]";

            StreamWriter sw = new StreamWriter("array.txt");
            sw.WriteLine(array.Length);
            for(i =0; i< array.Length; i++)
            {
                sw.WriteLine(array[i]);
            }
            sw.Close();
            using (StreamReader sr = new StreamReader("array.txt"))
            {
                while ((Line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(Line);
                }
            }
        }
    }
}  
