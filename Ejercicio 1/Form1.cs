using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Analizar analiza;
        public Form1()
        {
            InitializeComponent();
        }
        List<string> lista = new List<string>
        {
            "OXY333",
            "OYZ 013",
            "AAA 123",
            "BCD 456",
            "AB 123 CD",
            "YZ5432EF",
            "QW 3456 AB",
            "EW 234 QWR"

    };
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            

            if (rbtnRegex.Checked)
            {
                analiza = new Analizar();
                foreach (string j in lista)
                {
                    string descripcion = analiza.Analizador(j, out string patente);
                    tbVer.Text += "Patente: " + patente + ", Descripcion: " + descripcion + "\r\n";
                }
            }

        }
    }
}
