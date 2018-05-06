using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora
{
    public partial class Principal : Form
    {
        Profesor newProfesor;

        public Principal()
        {
            InitializeComponent();
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(Actividad_Integradora.Properties.Resources.default_profile, typeof(byte[]));

            newProfesor = new Profesor("Juan", "Martinez", "Punguato", "118", "Independencia", "Guadalajara", "33123454", "pilar.izquierdo@alumnos.udg.mx", xByte, "ale1004", "123");
        }



        private void button1_Click(object sender, EventArgs e)
        {

            PrincipalMenuForm principalMenuForm = new PrincipalMenuForm(newProfesor);
            principalMenuForm.ShowDialog();
        }
    }
}
