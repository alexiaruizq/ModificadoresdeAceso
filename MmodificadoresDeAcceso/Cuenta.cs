using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmodificadoresDeAcceso
{
    class Cuenta
    {
        public string Numero de cuenta { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Saldo { get; set; }

        public string  { get; set; }

        private string _curp;
        public string Curp {
            get {
                return _curp;
            }
            set {
                if (value.Length == 18)
                {
                    _curp = value;
                }
                else
                {
                    throw new Exception("No es de 18 caracteres");
                }
            }
        }

    }
}
