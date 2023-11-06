using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class Form1 : Form
    {
        //Definicion variables que se usaran en lo largo del codigo.
        string jugadorX = "";
        string jugadorO = "";
        bool cambio = true;
        int empate = 0;
        int ganadasX = 0;
        int ganadasO = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            OnOffBtn(false);
            
        }
       // Cuando el formulario carga se ejecute un metodo para se desactiven los botones se desactiven.
        public void OnOffBtn(bool onoff)
        {
            a1.Enabled = onoff;
            a2.Enabled = onoff;
            a3.Enabled = onoff;
            b1.Enabled = onoff;
            b2.Enabled = onoff;
            b3.Enabled = onoff;
            c1.Enabled = onoff;
            c2.Enabled = onoff;
            c3.Enabled = onoff;
        }

        public void btnIniciar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }      

        //Metodo para declarar las acciones del panel de juego
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (cambio) 
            {
                b.Text = "X";
            }
            else 
            {
                b.Text = "O";
            }
            cambio = !cambio;
            b.Enabled = false;
            Partida();
        }

        public void Validacion(Button b) 
        {
            empate = -1;

            if (b.Text == "X")
            {
                MessageBox.Show("Gana " + jugadorX, "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ganadasX++;
            }
            else if (b.Text == "X")
            {
                MessageBox.Show("Gana " + jugadorO, "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ganadasO++;
            }
            if (rbtnUserUX.Checked && rbtnUserDO.Checked)
            {
                lblUserPuntosFirst.Text = ganadasX.ToString();
                lblUserPuntosSecond.Text = ganadasO.ToString();
            }
            if (rbtnUserUO.Checked && rbtnUserDX.Checked)
            {
                lblUserPuntosSecond.Text = ganadasX.ToString();
                lblUserPuntosFirst.Text = ganadasO.ToString();
            }
            Limpiar();
            OnOffBtn(true);
        }

        private void Limpiar()
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
        }

        //Metodo para limpiar las casilla una vez terminado el juego.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            OnOffBtn(true);
            empate = 0;
        }

        private void btnReinciar_Click(object sender, EventArgs e)
        {
            Limpiar();
            OnOffBtn(false);
            btnLimpiar.Visible = false;
            btnReinciar.Visible = false;

            btnIniciar.Visible = true;
            txtUserUno.Visible = true;
            txtUserDos.Visible = true;

            jugadorX = "";
            jugadorO = "";
            ganadasX = 0;
            ganadasO = 0;
            cambio = true;

            lblUserPuntosFirst.Text = 0.ToString();
            lblUserPuntosSecond.Text = 0.ToString();

            lblUserUno.Text = "";
            lblUserDos.Text = "";

            rbtnUserUO.Enabled = true;
            rbtnUserDX.Enabled = true;
            rbtnUserUX.Enabled = true;
            rbtnUserDO.Enabled = true;

            rbtnUserUX.Checked = false;
            rbtnUserDO.Checked = false;
            rbtnUserUO.Checked = false;
            rbtnUserDX.Checked = false;

            lblUserPuntosFirst.Visible = false;
            lblUserPuntosSecond.Visible = false;

            groupBox1.Text = "Introduzca los nombres de los jugadores.";
        }
    }
}
