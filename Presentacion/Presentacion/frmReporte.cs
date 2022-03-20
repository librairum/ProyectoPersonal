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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }


        void imprimir() { }

        void cargar() { }


        void validar() { }


        void procesar() { }
        //public static bool ShowQuestion(string mensaje)
        //{
        //    bool processOK = false;


            

        //    if (RadMessageBox.Show(mensaje, "Sistema", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
        //    {
        //        processOK = true;
        //    }
        //    else
        //    {
        //        processOK = false;
        //    }

        //    return processOK;
        //}

        private void frmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    bool respuesta = Util.ShowQuestion("¿Desea salir de la aplicacion?");
            //    if (respuesta == false)
            //    {
            //        e.Cancel = true;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Util.ShowError(ex.Message);
            //}
        }

        
        
    }
}
