using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GSP3SL
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            HtmlPage.RegisterScriptableObject("mySLapp", new HTMLWorker(this));
        }

    }


    public class HTMLWorker
    {
        MainPage _ctl = null;
        public HTMLWorker(MainPage ctl)
        {
            _ctl = ctl;
        }

        [ScriptableMember()]
        public void ChangeTabbis()
        {
            if (_ctl.Tabbis.SelectedIndex == 0)
                _ctl.Tabbis.SelectedIndex = 1;
            else
                _ctl.Tabbis.SelectedIndex = 0;
        }
    }
}
