using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int Tam = 10;
        string[] vNombre = new string[Tam];
        string[] vTlf = new string[Tam];

        void LeerNombre(string[] v, string[] vTelefono)
        {
            for (int i = 0; i < vNombre.Length; i++)
            {
                v[i] = Interaction.InputBox("Introduzca un nombre: ");
                vTelefono[i] = Interaction.InputBox("Introduzca un Telefono: ");
            }
        }
        void EliminarContacto(string[] vNombre, string[] vTlf)
        {

            string Nombre = Interaction.InputBox("Introduzca un nombre del contacto que desea borrar: ");
            for (int i = 0; i < vNombre.Length; i++)
            {
                if (Nombre == vNombre[i])
                {
                    vNombre[i] = "";
                    vTlf[i] = "";
                }

            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            LeerNombre(vNombre, vTlf);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarContacto(vNombre, vTlf);
        }
    }
}
