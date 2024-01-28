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

namespace NE555WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double C1, R1, R2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calFreq_Click(object sender, RoutedEventArgs e)
        {
            double T1, T2, Fr;
            string freq, chargeTime, dischargeTime;
            string[] an = new string[3];


            R1 = Convert.ToInt32(slR1.Value);
            R2 = Convert.ToInt32(slR2.Value);

            T1 = (R1 + R2) * C1 * 0.693;
            T2 = R1 * C1 * 0.693;
            Fr = 1 / ((R1 + (2 * R2)) * C1 * 0.693);

            chargeTime = T1.ToString("F6");
            dischargeTime = T2.ToString("F6");
            freq = Fr.ToString("F3");

            an[0] = "T1 = " + chargeTime + Environment.NewLine;
            an[1] = "T2 = " + dischargeTime + Environment.NewLine;
            an[2] = "Frequency = " + freq;
            tbOut.Text = an[0] + an[1] + an[2];
        }

        private void cbC1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbC1.SelectedIndex)
            {
                case 0:
                    C1 = 0.000000001;
                    break;
                case 1:
                    C1 = 0.00000001;
                    break;
                case 2:
                    C1 = 0.0000001;
                    break;
                case 3:
                    C1 = 0.000001;
                    break;
                case 4:
                    C1 = 0.00001;
                    break;
            }
        }

        private void cbR2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbR2.SelectedIndex)
            {
                case 0:
                    R2 = 10000;
                    slR2.Value = Convert.ToInt32(R2);
                    R1 = 1000;
                    slR1.Value = Convert.ToInt32(R1);
                    break;
                case 1:
                    R2 = 100000;
                    slR2.Value = Convert.ToInt32(R2);
                    R1 = 10000;
                    slR1.Value = Convert.ToInt32(R1);
                    break;
                case 2:
                    R2 = 1000000;
                    slR2.Value = Convert.ToInt32(R2);
                    R1 = 100000;
                    slR1.Value = Convert.ToInt32(R1);
                    break;
            }
        }
    }
}
