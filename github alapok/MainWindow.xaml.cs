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

namespace github_alapok
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

        List<int> lista = new List<int>();
        public void Gomb_Click(object sender, RoutedEventArgs e)
        {
            int szam = Convert.ToInt32(Mezo.Text);
            lista.Add(szam);
            Mezo.Clear();
        }

        public void Kiiras_Click(object sender, RoutedEventArgs e)
        {
            Listahelye.Clear();
            Listahelye.Text = lista;
        }

        public void Legnagyobb_Click(object sender, RoutedEventArgs e)
        {
            Listahelye.Clear();
            Listahelye.Text = lista.Max();
        }
    }
}
