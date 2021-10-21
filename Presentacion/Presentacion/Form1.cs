using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string CreateRandomPassword(int PasswordLength) 
{ 
//string _allowedChars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789!@$?";
string _allowedChars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789"; 
Byte[] randomBytes = new Byte[PasswordLength]; 
char[] chars = new char[PasswordLength]; 
int allowedCharCount = _allowedChars.Length; 
            //ciclo para recorrer el objeto random
        for(int i = 0;i<PasswordLength;i++) 
        { 
            Random randomObj = new Random(); 
            randomObj.NextBytes(randomBytes); 
            chars[i] = _allowedChars[(int)randomBytes[i] % allowedCharCount]; 
        } 

return new string(chars); 
}

        private void btnGenera_Click(object sender, EventArgs e)
        {
        /*reemplazar el uso de if por switch*/
            if (rbUno.Checked) {
                txtclave1.Text = CreateRandomPassword(8).ToLower();          
            }
            if (rbDos.Checked) {
                txtclave2.Text = CreateRandomPassword(8).ToLower();
            }
            
        }

        private void btnGuardarClave1_Click(object sender, EventArgs e)
        {
            var miAplicacion = Presentacion.Properties.Settings.Default;
            
            if (rbUno.Checked) {
                DialogResult result = MessageBox.Show("Desea guardar la clave knightlibra ", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    miAplicacion.consClave1 = txtclave1.Text;
                    miAplicacion.Save();
                }
                
                
            }
            if (rbDos.Checked) {
                miAplicacion.consClave2 = txtclave2.Text;
                DialogResult result = MessageBox.Show("Desea guardar la clave libraa ", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    miAplicacion.consClave2 = txtclave2.Text;
                    miAplicacion.Save();
                }
            }
            
            
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            var miAplicacion = Presentacion.Properties.Settings.Default;
            if (rbUno.Checked) {
                txtclave1.Text = miAplicacion.consClave1;
            }
            if (rbDos.Checked) {
                txtclave2.Text = miAplicacion.consClave2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void PruebaMetodos()
        {
        }

        public void PruebaMetodos2()
        {
        }

//        public string GenerarPass(int LongPassMin, int LongPassMax)
//{
//Random ram = new Random();
//int LogitudPass = ram.Next(LongPassMin, LongPassMax);
//string Password = String.Empty;

//for (int i = 0; i < LogitudPass; i++)
//{
//int rm = ram.Next(0, 2);

//if (rm == 0)
//{
//Password += ram.Next(0, 10);
//}
//else
//{
//    ValueAlfanumeric
//Password += ValueAfanumeric[ram.Next(0, 59)];
//}
//}

//return Password;
//}
        //metodo para validar los valores de entrada
        void Validacion()
        {
            string valor = "";
            if (valor == "") { 
                //hacer algo
            }
        }


        void validarExpresion() { 
        
        }

        void verificarProceso() { 
        
        }
}
    
    }

