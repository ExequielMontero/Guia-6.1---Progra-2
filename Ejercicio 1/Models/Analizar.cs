using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    class Analizar:IAnalizador
    {
        public string Analizador(string texto, out string patente)
        {
            patente = "";
            Match ana = Regex.Match(texto,@"^[A-Z]{3}\s{0,1}?\d{3}$");
            if (ana.Success)
            {
                patente = ana.Value;
                return "Automóviles y camionetas hasta 2016";
            }
            else
           {
                ana = Regex.Match(texto, @"^[A-Z]{2}\s{1}?\d{3}\s{1}?[A-Z]{2}$");
           }
           
            if(ana.Success)
            {
                patente = ana.Value;
                return "Automóviles y camionetas desde 2016";
            }
            else
            {
                ana = Regex.Match(texto, @"^[A-Z]{2}\s{1}\d{3}\s{1}[A-Z]{3}$");
            }
            
            if (ana.Success)
            {
                patente = ana.Value;
                return "Motocicleta";
            }
            else
            {
                ana = Regex.Match(texto, @"^[A-Z]{2}\d{4}$");
            }
            
            if (ana.Success)
            {
                patente = ana.Value;
                return "Acoplado";
            }
            patente = "NN";
            return "No reconocido";
        }


    }
}
