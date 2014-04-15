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

namespace ChopWaveChop
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class VersionInfoWindow : Window
    {
        public VersionInfoWindow()
        {
            InitializeComponent();
        }

        private void CloseVersionInfo(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadedVersionInfo(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.FileVersionInfo fileVersionInfo=
                System.Diagnostics.FileVersionInfo.GetVersionInfo(
                System.Reflection.Assembly.GetExecutingAssembly().Location);

            InfoTextBlock.Inlines.Add(Environment.NewLine);
            InfoTextBlock.Inlines.Add("バージョン番号: ");
            InfoTextBlock.Inlines.Add(fileVersionInfo.FileVersion);
            //InfoTextBlock.Inlines.Add(Environment.NewLine);
            //InfoTextBlock.Inlines.Add("ビルド番号: ");
            //InfoTextBlock.Inlines.Add(fileVersionInfo.FileBuildPart.ToString());
        }
    }
}
