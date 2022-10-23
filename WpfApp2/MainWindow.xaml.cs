using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Net.Mime.MediaTypeNames;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            Textbox1.IsEnabled = false;            
        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            string content;
            
            if(sender is Button b)
            {
                int index= Textbox1.Text.Length;
                content = b.Content.ToString();

                switch (content)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "0":
                        Textbox1.Text += content;                        
                        break;
                    case "1/x":
                        if (index == 0)
                            break;
                        Textbox1.Text = (1.0f / (float.Parse(Textbox1.Text))).ToString();
                        break;
                    case "CE":
                        Textbox1.Clear();
                        break;
                    case "C":
                        Textbox1.Clear();
                        break;
                    case "=":
                        Textbox1.Text = new DataTable().Compute(Textbox1.Text, null).ToString();
                        break;
                    case "±":
                        if (index == 0)
                            break;
                        Textbox1.Text = (-float.Parse(Textbox1.Text)).ToString();
                        break;
                    case "X":
                        {
                        if (index == 0)
                            break;
                        else
                            Textbox1.Text = Textbox1.Text.Substring(0,Textbox1.Text.Length - 1);
                            break;
                        }
                    case "x²":
                        {
                            if (index == 0)
                                break;
                            Textbox1.Text = ((float.Parse(Textbox1.Text))* (float.Parse(Textbox1.Text))).ToString();
                        }
                        break;
                    case "√":
                        {
                            if (index == 0)
                                break;
                            else
                            {
                                double a = Math.Sqrt(Double.Parse(Textbox1.Text));
                                Textbox1.Text = a.ToString();
                                break;
                            }
                        }
                    case "%":
                        {
                            if (index == 0)
                                break;
                            else if (char.IsDigit(Textbox1.Text[index - 1]) || Textbox1.Text[index - 1] == '%' && b.Content.ToString() != "%")
                            {
                                Textbox1.Text += content;
                            }
                            break;
                        }
                    case "/":
                        {
                            if (index == 0)
                                break;
                            else if (char.IsDigit(Textbox1.Text[index - 1]) || Textbox1.Text[index - 1] == '/' && b.Content.ToString() != "/" )
                            {
                                Textbox1.Text += content;
                            }
                            break;
                        }
                    case "*":
                        {
                            if (index == 0)
                                break;
                            else if (char.IsDigit(Textbox1.Text[index - 1]) || Textbox1.Text[index - 1] == '*' && b.Content.ToString() != "*" && b.Content.ToString() != "*")
                            {
                                Textbox1.Text += content;
                            }
                            break;
                        }
                    case "-":
                        {
                            if (index == 0)
                                break;
                            else if (char.IsDigit(Textbox1.Text[index - 1]) || Textbox1.Text[index - 1] == '-' && b.Content.ToString() != "-" )
                            {
                                Textbox1.Text += content;
                            }
                            break;
                        }
                    case ".":
                        {
                            if (index == 0)
                                break;
                            else if (char.IsDigit(Textbox1.Text[index - 1]) || Textbox1.Text[index - 1] == '.' && b.Content.ToString() != "." )
                            {
                                Textbox1.Text += content;
                            }
                            break;
                        }
                    case "+":
                        {
                            if (index == 0)
                                break;
                            else if (char.IsDigit(Textbox1.Text[index - 1]) || Textbox1.Text[index - 1] == '+' && b.Content.ToString() != "+" )
                            {
                                Textbox1.Text += content;
                            }
                            break;
                        }                        
                }

            }
        }



    }
}
