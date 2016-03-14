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

namespace WpfApplication1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add("+");
            comboBox.Items.Add("-");
            comboBox.Items.Add("X");
            comboBox.Items.Add("/");
            comboBox.SelectedIndex = 0;

            comboBox_Copy.Items.Add("2a");
            comboBox_Copy.Items.Add("3a");
            comboBox_Copy.Items.Add("4a");
            comboBox_Copy.SelectedIndex = 0;
        }

        

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:         //+
                    {
                        Result.Text = ((Int32.Parse(Num1.Text)) + (Int32.Parse(Num2.Text))).ToString();
                        break;
                    }
                case 1:         //-
                    {
                        Result.Text = ((Int32.Parse(Num1.Text)) - (Int32.Parse(Num2.Text))).ToString();
                        break;
                    }
                case 2:         //*
                    {
                        Result.Text = ((Int32.Parse(Num1.Text)) * (Int32.Parse(Num2.Text))).ToString();
                        break;
                    }
                case 3:         //diviso
                    {
                        Result.Text = ((float.Parse(Num1.Text)) / (float.Parse(Num2.Text))).ToString();
                        break;
                    }
            }
        }

        private void CheckButton2_Click(object sender, RoutedEventArgs e)
        {
            switch(comboBox_Copy.SelectedIndex)
            {
                case 0:
                    {
                        Result_Copy.Text = Math.Pow((Int32.Parse(Num1_Copy.Text)), 2).ToString();
                        break;
                    }
                case 1:
                    {
                        Result_Copy.Text = Math.Pow((Int32.Parse(Num1_Copy.Text)), 3).ToString();
                        break;
                    }
                case 2:
                    {
                        Result_Copy.Text = Math.Pow((Int32.Parse(Num1_Copy.Text)), 4).ToString();
                        break;
                    }
            }
        }
        

        private void randomCheck(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            RandomResult.Text = rnd.Next(Int32.Parse(random1.Text), Int32.Parse(random2.Text)).ToString();
        }
    }
}
