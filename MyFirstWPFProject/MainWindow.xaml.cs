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

namespace MyFirstWPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //#region MainWindow
    //#EndRegion

    //#region 2Window
    //#EndRegion

    //#region 3Window
    //#endregion

    //#region 4Window
    //#endregion
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //WrappedText.Text = "Hello from code behind";
            //Main.Content = new ContactPage();
            var c = new Car();
            c.Name = "SachinCar";
            c.Speed = 100;
        }

        //int count = 0;

        //private void CounterButton_Click(object sender, RoutedEventArgs e)
        //{
        //    count++;
        //    CounterButton.Content = $"You clicked {count} time(s)!!!";
        //}

        //private void ButtonClickPage1(object sender, RoutedEventArgs e)
        //{
        //    Main.Content = new Page_1();
        //}

        //private void ButtonClickPage2(object sender, RoutedEventArgs e)
        //{
        //    Main.Content = new Page2();
        //}
    }
}
