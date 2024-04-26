using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcajisacaExamen
{
    public class Datos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Fecha { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string MontoInicial { get; set; }
        public string PagoMensual { get; set; }
        public double PagoTotal { get; set; }

        public Datos() { }

        public Datos(string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string montoInicial, string pagoMensual, double pagoTotal)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Fecha = fecha;
            Ciudad = ciudad;
            Pais = pais;
            MontoInicial = montoInicial;
            PagoMensual = pagoMensual;
            PagoTotal = pagoTotal;
        }
    }

}
