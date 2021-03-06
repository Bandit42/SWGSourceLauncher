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

namespace SWGSourceLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchGameButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayGame();
        }

        private void LaunchWebsiteButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://github.com/SWG-Source/swg-main/wiki/");
        }

        private void LaunchUpdatesButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.Update();
        }
    }
}
