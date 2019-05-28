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

namespace DomainHomeWork
{
    public partial class MainWindow : Window
    {
        private int countClick;
        private AppDomain currentDomain;
        public MainWindow()
        {
            InitializeComponent();
            currentDomain = AppDomain.CurrentDomain;
            countClick = 0;
        }

        private void Download(object sender, RoutedEventArgs e)
        {
            countClick++;
            if (countClick == 1)
            {
                Domain("Download");
            }
        }

        private void Operation(object sender, RoutedEventArgs e)
        {
            countClick++;
            if (countClick == 1)
            {
                Domain("Operation");
            }
        }

        public void Domain(string name)
        {
            var exampleDomain = AppDomain.CreateDomain(name);

            string assemblyForExampleDomain = currentDomain.BaseDirectory + name + ".exe";
            exampleDomain.ExecuteAssembly(assemblyForExampleDomain);

            AppDomain.Unload(exampleDomain);
            countClick = 0;
        }
    }
}
