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
using DevExpress.Wpf.NavBar;


namespace DataBinding_DataTable
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window{
        public Window1(){
            InitializeComponent();

            NavBarControl navBar = new NavBarControl();
            dockPanel.Children.Add(navBar);
            DataBindingHelper.BuildContent(navBar, GetData(), "Group", null, new NavBarImageContentBindingParameters(null, new NavBarBindingParameters("Item", null, null))); 
        }

        public DataView GetData(){
            DataTable dt = new DataTable();
            dt.Columns.Add("Group", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            for (int i = 1; i <= 2; i++){
                for (int j = 1; j <= 3; j++)
                    dt.Rows.Add(new object[] { "Group " + i.ToString(), "Item " + i.ToString() + "-" + j.ToString() });
            }
            return dt.DefaultView;
        }
    }
}
