using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            PrimerEscenario.MapaCargar();
        }
        
        int stepX = 0, stepY = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {       
            pictureBox1.Image = Graficos.Dibujar();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                stepX =-10;
            }
            if(e.KeyCode==Keys.Right)
            {
                stepX = +10;
            }
            if (e.KeyCode==Keys.Up)
            {
                stepY = -10;
                
            }
            if (e.KeyCode == Keys.Down)
            {
                stepY = +10;
            }
            if (e.KeyCode == Keys.S)
            {
                //Disparos del Jugador
                Jugador.CrearDisparo();                
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            stepX = 0;
            stepY = 0;
        }
        
        private void tmrMoverJugador_Tick(object sender, EventArgs e)
        {
            Jugador.Mover(stepX, stepY);
        }
        
        private void tmrDisparosJug_Tick(object sender, EventArgs e)
        {
            Jugador.MoverDisparos();
        }

        private void tmrEnemigos_Tick(object sender, EventArgs e)
        {
            PrimerEscenario.Mover();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Jugador.Vidas().ToString());
        }


    }
}
