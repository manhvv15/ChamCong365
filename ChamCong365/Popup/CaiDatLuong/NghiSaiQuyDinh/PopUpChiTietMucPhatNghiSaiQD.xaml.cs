﻿using System;
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

namespace ChamCong365.Popup.CaiDatLuong.NghiSaiQuyDinh
{
    /// <summary>
    /// Interaction logic for PopUpChiTietMucPhatNghiSaiQD.xaml
    /// </summary>
    public partial class PopUpChiTietMucPhatNghiSaiQD : UserControl
    {
        public PopUpChiTietMucPhatNghiSaiQD()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
