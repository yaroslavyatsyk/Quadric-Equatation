using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace Quadric_Equatation
{
   
    public partial class MainWindow : Window
    {
        private QuadricEquatation equatation;
        private object results;
       
        

        public MainWindow()
        {
            InitializeComponent();

           
        }

        

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                    double a = double.Parse(ABox.Text);
                    double b = double.Parse(BBox.Text);
                    double c = double.Parse(CBox.Text);

                    equatation = new QuadricEquatation(a, b, c);

                
                
                results = equatation.CalculateEquation();

                if(results is string)
                {
                    double d = equatation.GetDiscriminate();
                    string message = (string) results;
                   
              
                    MessageBox.Show(string.Format("Discriminant = {0}, {1}", Math.Round(d,2), message), "Solutions",MessageBoxButton.OK,MessageBoxImage.Information);
                }
                else if(results is double)
                {
                    double x = (double)results;
                    double d = equatation.GetDiscriminate();
                    MessageBox.Show(string.Format("X = {0}, Discriminant = {1}", Math.Round(x,3), Math.Round(d,3), "Solution",MessageBoxButton.OK,MessageBoxImage.Information));
                    
                }
                else
                {
                    double d = equatation.GetDiscriminate();
                    Tuple<double,double> tuple = (Tuple<double,double>) results;
                    MessageBox.Show(String.Format("x1 = {0}, x2 = {1}, Discriminant = {2} ", Math.Round(tuple.Item1,3), Math.Round(tuple.Item2,3), Math.Round(d,3)),"Solutions",MessageBoxButton.OK,MessageBoxImage.Information);
                }
               
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Not assigned values", "Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

            catch(ArgumentException)
            {
MessageBox.Show("a can't be 0", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox .Show("This program solves quadric equatation", "About",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}