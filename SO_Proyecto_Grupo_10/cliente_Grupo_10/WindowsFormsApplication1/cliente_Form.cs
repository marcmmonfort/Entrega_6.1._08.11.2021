using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class cliente_Form : Form
    {
        Socket server;
        public cliente_Form()
        {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - PARÁMETROS - - - - - - - - - - - - - - - - - - - -

        // 1. Identificación del usuario que está usando el programa de cliente.
        string user = "Marc.";
        string password = "pingpong";

        // 2. Fecha de partida que está usando el programa de cliente.
        string fecha = "10/10/2021";

        // - - - - - - - - - - - - - - - - - - - - BOTÓN CONECTAR - - - - - - - - - - - - - - - - - - - -

        private void Conectar_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9015);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("[!] Conectado! [!]");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("[!] No se ha podido conectar con el servidor! [!]");
                return;
            }
        }

        // - - - - - - - - - - - - - - - - - - - - BOTÓN DESCONECTAR - - - - - - - - - - - - - - - - - - - -

        private void Desconectar_Click(object sender, EventArgs e)
        {
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        // - - - - - - - - - - - - - - - - - - - - BOTÓN ENVIAR PETICIÓN - - - - - - - - - - - - - - - - - - - -

        private void button2_Click(object sender, EventArgs e) // Botón Enviar.
        {

            // ---> PETICIÓN DE ALBA A LA BASE DE DATOS (Radio Button): - - - - - - - - - -

            if (Petición_Alba.Checked)
            {
                string mensaje = "1/" + user + "/" + fechaPartida.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
  

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(user + " tiene " + mensaje + " puntos después de ganar el día " + fecha);
            }

            // ---> PETICIÓN DE MARC A LA BASE DE DATOS (Radio Button): - - - - - - - - - -

            else if (Petición_Marc.Checked)
            {
                string mensaje = "2/" + user;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(user + " ha jugado " + mensaje + " partidas.");
            }

            // ---> PETICIÓN DE ELOI A LA BASE DE DATOS (Radio Button): - - - - - - - - - -

            else if (Petición_Eloi.Checked)
            {
                // NO ESTÀ FET.
                string mensaje = "3/" + user;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(user + " ha ganado a: " + mensaje);
            }

            // ---> PETICIÓN DE LOGUEARSE EN LA BASE DE DATOS (Radio Button): - - - - - - - - - -

            else if (Login.Checked)
            {
                string mensaje = "4/" + userLogin.Text + "/" + contraLogin.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                if (mensaje != "-1")
                {
                    MessageBox.Show("[!] Logueado Satisfactoriamente. [!]");
                    // Guarda el nombre del usuario y la contraseña en esta simulación.
                    user = userLogin.Text;
                    password = contraLogin.Text;
                    userLogin.Text = "";
                    contraLogin.Text = "";
                }
                else
                {
                    MessageBox.Show("[!] ERROR en el Logueo. [!]");
                }
            }

            // ---> PETICIÓN DE REGISTRARSE EN LA BASE DE DATOS (Radio Button): - - - - - - - - - -

            else if (Register.Checked)
            {
                string mensaje = "5/" + userRegister.Text + "/" + contraRegister.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                
                if (mensaje != "-1")
                {
                    MessageBox.Show("[!] Registrado Satisfactoriamente. [!]");
                    userRegister.Text = "";
                    contraRegister.Text = "";
                }
                else
                {
                    MessageBox.Show("[!] ERROR en el Registro. [!]");
                }
            }
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        }
    }
}
