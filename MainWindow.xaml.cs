using System;
using System.Windows;

namespace RPM_12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) &&
                double.TryParse(txtY.Text, out double y) &&
                int.TryParse(txtN.Text, out int N) &&
                int.TryParse(txtK.Text, out int K))
            {
                double Z = 0;
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= K; j++)
                    {
                        Z += (Math.Sin(x) * Math.Pow(x, i) + Math.Cos(y) * Math.Pow(y, j)) / (i * j);
                    }
                }
                txtResult.Text = Z.ToString("F4");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа", "Ошибка ввода",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}