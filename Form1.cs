using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace holamundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Expresion regular
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*\\W).+$");

            if (string.IsNullOrEmpty(txtContrasenauno.Text) &&
                 string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos estan vacios");
                    return;
            }
            //Condicional que valida 
            //si no son iguales los textos contenidos
            //el signo de excalamacion indica negacion
            if (!txtContrasenauno.Text.Equals(txtContrasenaDos.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }
            if(validacion.IsMatch(txtContrasenauno.Text))
            {
                MessageBox.Show("Contraseña Valida");
            }
            else
            {
                MessageBox.Show("Contraseña No Valida");
            }
        }
    }
}