using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Reglas
    {
        public bool cambio = true;
        public int empate = 0;
        public int ganadasX = 0;
        public int ganadasO = 0;

        public bool Cambio { get; set; }
        public int Empate { get; set; }
        public int GanadasX { get; set; }
        public int GanadasO { get; set; }

    }
}
