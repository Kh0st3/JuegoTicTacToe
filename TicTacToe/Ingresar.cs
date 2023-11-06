using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Ingresar : Form1
    {

        public static void Ingresar()
        {
            if (txtUserUno.Text == "" && txtUserDos.Text == "")
            {
                MessageBox.Show("El nombre de los jugadores no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textUserFirst.Text == "")
                {
                    MessageBox.Show("El nombre del primer jugador no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (textUserSecond.Text == "")
                {
                    MessageBox.Show("El nombre del segundo jugador no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
}
