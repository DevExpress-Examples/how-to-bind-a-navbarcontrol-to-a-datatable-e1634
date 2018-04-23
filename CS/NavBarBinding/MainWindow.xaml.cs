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
using System.Data;

namespace NavBarBinding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("Group", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            for(int i = 1; i <= 2; i++) {
                for(int j = 1; j <= 3; j++)
                    dt.Rows.Add(new object[] { "Group " + i.ToString(), 
                        "Item " + i.ToString() + "-" + j.ToString() });
            }

            DataContext = dt;
        }
    }
}
