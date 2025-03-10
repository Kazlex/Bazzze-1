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

namespace Bazzze
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Editor()
        {
            InitializeComponent();
            BindingGroup = new();
            DataContext = new Osoba();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            if (BindingGroup.UpdateSources())
            {
                Close();
            }
        }

        private void Otkazi(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}