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

namespace Costea_Ioan_Lab2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lstSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private DoughnutMachine myDoughnutMachine;

        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            myDoughnutMachine = new DoughnutMachine();
        }

        private int mRaisedGlazed;
        private int mRaisedSugar;
        private int mFilledLemon;
        private int mFilledChocolate;
        private int mFilledVanilla;

    }
}
