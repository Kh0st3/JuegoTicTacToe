using System.Windows.Forms;

namespace TicTacToe
{
    public class IngresarBase
    {
        public void Ingresar()
        {
            if (textUserFirst.Text == "" && textUserSecond.Text == "")
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
}