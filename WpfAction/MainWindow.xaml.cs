﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAction
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public const string licenseKey = "LICENSE_KEY_PLACEHOLDER";
    public MainWindow()
    {
      InitializeComponent();
      //string license = "LICENSE_KEY_PLACEHOLDER";
    }

    private void Button_Click( object sender, RoutedEventArgs e )
    {
      MessageBox.Show(licenseKey);
    }
  }
}