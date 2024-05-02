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
using VievModels.VievModels.MainWindow;
using Vievs.Windows.MainWindow;

namespace Vievs.MainWindow
{
    public partial class MainWindow :System.Windows.Window,IMainWindow
    {
        public MainWindow(IMainWindowVievModel mainWindowVievModel)
        {
            InitializeComponent();
            DataContext=mainWindowVievModel;
        }
    }
}
