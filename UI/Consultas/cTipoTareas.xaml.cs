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
using P2_AP1_Ismarlin2018_0846.BLL;
using P2_AP1_Ismarlin2018_0846.Entidades;

namespace P2_AP1_Ismarlin2018_0846.UI.Consultas
{
    /// <summary>
    /// Lógica de interacción para cTipoTareas.xaml
    /// </summary>
    public partial class cTipoTareas : Window
    {
        public cTipoTareas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<TipoTareas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //TareasId
                        int.TryParse(CriterioTextBox.Text, out int TipoId);
                        listado = TipoTareasBLL.GetList(a => a.TipoId == TipoId);
                        break;

                    case 1: //TipoTareas                       
                        listado = TipoTareasBLL.GetList(a => a.TipoTarea.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = TipoTareasBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDataPicker.SelectedDate).ToList();

            if (HastaDatePicker.SelectedDate != null)
                listado = listado.Where(c => c.FechaIngreso.Date <= HastaDatePicker.SelectedDate).ToList();

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
