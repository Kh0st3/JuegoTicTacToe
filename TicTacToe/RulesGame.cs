using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Contracts;

namespace TicTacToe
{
    public partial class Form1 : IRules
    {
        public void Partida()
        {
            {
                //Determinando las reglas para ganar el juego en forma vertical.
                if ((a1.Text == a2.Text) & (a2.Text == a3.Text) && (!a1.Enabled))
                {
                    Validacion(a1);
                }
                else if ((b1.Text == b2.Text) & (b2.Text == b3.Text) && (!b1.Enabled))
                {
                    Validacion(b1);
                }
                else if ((c1.Text == c2.Text) & (c2.Text == c3.Text) && (!c1.Enabled))
                {
                    Validacion(c1);
                }

                //Determinando las reglas para ganar el juego en forma horizontal.
                if ((a1.Text == b1.Text) & (b1.Text == c1.Text) && (!a1.Enabled))
                {
                    Validacion(a1);
                }
                else if ((a2.Text == b2.Text) & (b2.Text == c2.Text) && (!a2.Enabled))
                {
                    Validacion(a2);

                }
                else if ((a3.Text == b3.Text) & (b3.Text == c3.Text) && (!a3.Enabled))
                {
                    Validacion(a3);

                }

                //Determinando las reglas para ganar el juego en forma cruzada.
                if ((a1.Text == b2.Text) & (b2.Text == c3.Text) && (!a1.Enabled))
                {
                    Validacion(a1);
                }
                else if ((a3.Text == b2.Text) & (b2.Text == c1.Text) && (!a3.Enabled))
                {
                    Validacion(a3);
                }

                //Determinando la regla para un empate en el juego.
                empate++;

                if (empate == 9)
                {
                    MessageBox.Show("Es un empate.", "Empate!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    OnOffBtn(true);
                    empate = 0;
                }
            }

        }
    }
}
