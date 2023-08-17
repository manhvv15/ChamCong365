
using ChamCong365.TimeKeeping;
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
using System.Windows.Shapes;

namespace ChamCong365.NhanVien
{
    /// <summary>
    /// Interaction logic for MainChamCong.xaml
    /// </summary>
    public partial class MainChamCong : Window
    {
        List<Saff> saffs = new List<Saff>();
        BrushConverter bcMain = new BrushConverter();
        public int Test = 0;
        public MainChamCong()
        {
            InitializeComponent();
            ChamCongBangQR ucbodyhome = new ChamCongBangQR(this);
            dopBody.Children.Clear();
            object Content = ucbodyhome.Content;
            ucbodyhome.Content = null;
            dopBody.Children.Add(Content as UIElement);

        }
        private int i = 0;
        private void Window_SizeChangedChamCong(object sender, SizeChangedEventArgs e)
        {
            if (i == 0)
            {
                if (MainWindowChamCong.Width <= 1024)
                {

                    HearderColesspa.Visibility = Visibility.Visible;
                    HearderVisibility.Visibility = Visibility.Collapsed;

                }
                else
                {

                    HearderColesspa.Visibility = Visibility.Collapsed;
                    HearderVisibility.Visibility = Visibility.Visible;
                    MenuCollapsed.Visibility = Visibility.Collapsed;

                }
            }
        }

        private void MainWindows_StateChangedChamcong(object sender, EventArgs e)
        {

        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ChamCongBangQR ucbodyhome = new ChamCongBangQR(this);
            dopBody.Children.Clear();
            object Content = ucbodyhome.Content;
            ucbodyhome.Content = null;
            dopBody.Children.Add(Content as UIElement);
        }
    }
}
