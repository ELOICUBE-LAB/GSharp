﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GSharpSample.Pages
{
    /// <summary>
    /// LayoutWindows.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LayoutWindows : UserControl
    {
        public LayoutWindows()
        {
            InitializeComponent();
        }

        private void BtnMinimize_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void BtnMaximize_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }

        private void BtnClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }


        private void BtnDebug_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pageWorkspace.Build();
        }

        private void BtnConfig_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pageWorkspace.ShowConfig();
        }
    }
}
