﻿using P2_AP1_Ismarlin2018_0846.UI.Consultas;
using P2_AP1_Ismarlin2018_0846.UI.Registros;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P2_AP1_Ismarlin2018_0846
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

        private void rProyectos_Click(object sender, RoutedEventArgs e)
        {
            rProyectos rProyecto = new rProyectos();
            rProyecto.Show();
        }

        private void cProyectos_Click(object sender, RoutedEventArgs e)
        {
            cProyectos cProyecto = new cProyectos();
            cProyecto.Show();
        }
    }
}
