using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Contracts;

namespace TicTacToe
{
    public partial class Form1 : IGame
    {
        public void PlayGame()
        {
            //metodo para que el sistema tome el nombre ingresado por el usuario y lo remplace.
            lblUserUno.Text = txtUserUno.Text;
            lblUserDos.Text = txtUserDos.Text;

            lblUserPuntosFirst.Visible = true;
            lblUserPuntosSecond.Visible = true;

            groupBox1.Text = "Marcador";

            //Metodo para que cuando inicie el juego aparezcan los botones de Limpiar y Reiniciar. Ademas de que el boton de Iniciar el label de nombre jugador Uno y Dos se oculte.
            btnLimpiar.Visible = true;
            btnReinciar.Visible = true;

            btnIniciar.Visible = false;
            txtUserUno.Visible = false;
            txtUserDos.Visible = false;

            MessageBox.Show("Empieza " + jugadorX, "Informacion.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OnOffBtn(true);
        }
    }
}
