using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ReactiveDemo
{
    /// <summary>
    /// Interaction logic for TestMemoryLeakWindow.xaml
    /// </summary>
    public partial class TestMemoryLeakWindow : Window
    {
        public TestMemoryLeakWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.ShowDialog();
        }

        private void ButtonForceGC_Click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
        }
    }
}
