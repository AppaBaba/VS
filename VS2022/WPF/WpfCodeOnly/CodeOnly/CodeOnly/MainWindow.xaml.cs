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

namespace CodeOnly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock textBlock;
        private TextBox textBox;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.Height = 350;
            this.Width = 520;
            this.Title = "Code Only";

            Grid grid = new Grid();
            StackPanel stackPanel = new StackPanel();
            grid.Children.Add(stackPanel);
            this.AddChild(grid);

            textBlock = new TextBlock();
            textBlock.Margin = new Thickness(5);
            textBlock.Height = 30;
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.Text = "Hello WPF Baba";
            stackPanel.Children.Add(textBlock);

            textBox = new TextBox();
            textBox.Margin = new Thickness(5);
            textBox.Width = 200;
            textBox.TextAlignment = TextAlignment.Center;
            textBox.TextChanged += OnTextChanged;
            stackPanel.Children.Add(textBox);
        }

        private void OnTextChanged(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text;
        }


    }
}
