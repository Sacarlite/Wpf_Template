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
using System.Windows.Shapes;
using VievModel.VievModels.AutorizationVievModel;

namespace Vievs.Windows.AutorizationWindow
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : System.Windows.Window, IAutorizationWindow
    {
        public AutorizationWindow(IAutorizationVievModel autorizationVievModel)
        {
            InitializeComponent();
            DataContext = autorizationVievModel;
        }
    }
}
