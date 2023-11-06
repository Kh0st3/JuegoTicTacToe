using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : IGetIn
    {
        public void Ingresar()
        {
            if (txtUserUno.Text == "" && txtUserDos.Text == "")
            {
                MessageBox.Show("El nombre de los jugadores no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtUserUno.Text == "")
                {
                    MessageBox.Show("El nombre del primer jugador no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtUserDos.Text == "")
                {
                    MessageBox.Show("El nombre del segundo jugador no debe estar vacio", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //Condiciones para los botones, el jugador al escoger simbolo se deshabilite la otra opcion
            if (txtUserUno.Text != "" && txtUserDos.Text != "")
            {
                if (rbtnUserUX.Checked && rbtnUserDO.Checked)
                {
                    jugadorX = txtUserUno.Text;
                    jugadorO = txtUserDos.Text;
                    rbtnUserUO.Enabled = false;
                    rbtnUserDX.Enabled = false;
                    PlayGame();
                }
                if (rbtnUserUO.Checked && rbtnUserDX.Checked)
                {
                    jugadorX = txtUserDos.Text;
                    jugadorO = txtUserUno.Text;
                    rbtnUserUX.Enabled = false;
                    rbtnUserDO.Enabled = false;
                    PlayGame();
                }

                //Validacion para que los jugadores Uno y Dos no escojan el mismo simbolo X.
                if (rbtnUserUX.Checked && rbtnUserDX.Checked)
                {
                    MessageBox.Show("Solo un jugador puede seleccionar la X.", "Vuelva a escoger el simbolo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Validacion para que los jugadores Uno y Dos no escojan el mismo simbolo O.
                if (rbtnUserUO.Checked && rbtnUserDO.Checked)
                {
                    MessageBox.Show("Solo un jugador puede seleccionar la O.", "Vuelva a escoger el simbolo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Validacion para que los usuarios escojan el simbolo y no quede el espacion sin seleccionar.
                if (rbtnUserUX.Checked == false && rbtnUserUO.Checked == false || rbtnUserDX.Checked == false && rbtnUserDO.Checked == false)
                {
                    MessageBox.Show("Cada jugador debe seleccionar un simbolo.", "Por favor seleccionen simbolo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
