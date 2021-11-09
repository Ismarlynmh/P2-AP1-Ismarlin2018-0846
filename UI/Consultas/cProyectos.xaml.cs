﻿using P2_AP1_Ismarlin2018_0846.BLL;
using P2_AP1_Ismarlin2018_0846.DAL;
using P2_AP1_Ismarlin2018_0846.Entidades;
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

namespace P2_AP1_Ismarlin2018_0846.UI.Consultas
{
    /// <summary>
    /// Lógica de interacción para cProyectos.xaml
    /// </summary>
    public partial class cProyectos : Window
    {
        public cProyectos()
        {
            InitializeComponent();
        }

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<Proyectos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.GetList(p => p.Tiempo == Convert.ToInt32(CriterioTextBox.Text));
                        break;

                    case 1:
                        lista = ProyectosBLL.GetList(p => p.ProyectoId == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                    case 2:
                        lista = ProyectosBLL.GetList(p => p.Descripcion == CriterioTextBox.Text);
                        break;
                }
            }
            else
            {
                lista = ProyectosBLL.GetList(c => true);
            }
            if(lista == null)
            {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = lista;
        }

    }
}
