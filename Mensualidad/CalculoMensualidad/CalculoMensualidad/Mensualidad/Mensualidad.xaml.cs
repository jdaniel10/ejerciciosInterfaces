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

namespace CalculoMensualidad.Mensualidad
{
    /// <summary>
    /// Lógica de interacción para Mensualidad.xaml
    /// </summary>
    public partial class Mensualidad : UserControl
    {
        public Mensualidad()
        {
            InitializeComponent();
            meses.Add(12);
            meses.Add(24);
            meses.Add(33);


        }
        public static bool escliente { get; set;}
        public static List<int> meses { get; set;}


    }
}
