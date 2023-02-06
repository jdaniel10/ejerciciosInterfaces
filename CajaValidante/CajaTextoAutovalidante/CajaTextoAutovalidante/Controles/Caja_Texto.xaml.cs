using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CajaTextoAutovalidante.Controles
{
    /// <summary>
    /// Lógica de interacción para Caja_Texto.xaml
    /// </summary>
    public partial class Caja_Texto : UserControl
    {

        public Caja_Texto()
        {
            InitializeComponent();
        }
        public String tipoValidacion { get; set; }


  


        private void Validar(object sender, RoutedEventArgs e)
        {
            if (tipoValidacion == "TLF") {
                if (TextBoxClasica.Text.Length != 9) { labelError.Content = "Error al validar dni"; }
            }
            else if(tipoValidacion == "DNI") { 
                if(TextBoxClasica.Text.Length != 9) { labelError.Content = "Error al validar DNI"; }
            }
            else if (tipoValidacion == "CP")
            {
                if (TextBoxClasica.Text.Length != 5) { labelError.Content = "Error al validar CP "; }
            }
        }
    }
    
}
