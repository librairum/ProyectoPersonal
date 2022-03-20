using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace Presentacion
{
    public class Conexion
    {

        SqlConnection cn = new SqlConnection("Data Source=(local);Initial catalog=Traver_MineraDeisi;Integrated Security=false; user id=sa;password=sasasa;");

        private void abrir() {
            try
            {
                if(cn.State == System.Data.ConnectionState.Closed){
                    cn.Open(); 
                }
               
            }
            catch (Exception ex) { 
            
            }
        }

        private void cerrar() {
            try
            {
                if (cn.State == System.Data.ConnectionState.Open) {
                    cn.Close();
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        internal DataTable Leerdatos(string consultax) {
            DataTable dt = new DataTable();
            try
            {
                dt = new DataTable();
                
                SqlDataAdapter da = new SqlDataAdapter(consultax, cn);
                da.Fill(dt);
            }
            catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
            return dt;
        }
        internal bool InsertarCabecera(string @serie, string @correlativo, DateTime @fechaemision,
            string @formaPago, string @montoenletras, string @tipoMoneda, double @gravado, 
            double @importeigv,double @infaecta,
            double @exonerada, double @exportacion,  double @total, string @rucEmpresa,
            string @direccionEmisor, string @razonSocialEmisor, string @rucCliente, string @razonCliente,
            string @direccionCliente)
        {

            bool respuesta = false;
            try
            {

                SqlCommand cmd = new SqlCommand("Spu_Ins_FactCab", cn);
                cmd.Parameters.AddWithValue("@serie", @serie);
                cmd.Parameters.AddWithValue("@correlativo", @correlativo);
                cmd.Parameters.AddWithValue("@fechaemision", @fechaemision);
                cmd.Parameters.AddWithValue("@formaPago", @formaPago);
                cmd.Parameters.AddWithValue("@montoenletras", @montoenletras);
                cmd.Parameters.AddWithValue("@tipoMoneda", @tipoMoneda);
                cmd.Parameters.AddWithValue("@gravado", @gravado);
                cmd.Parameters.AddWithValue("@importeigv", @importeigv);
                cmd.Parameters.AddWithValue("@infaecta", @infaecta);
                cmd.Parameters.AddWithValue("@exonerada", @exonerada);
                cmd.Parameters.AddWithValue("@exportacion", @exportacion);                
                cmd.Parameters.AddWithValue("@total", @total);
                cmd.Parameters.AddWithValue("@rucEmpresa", @rucEmpresa);
                cmd.Parameters.AddWithValue("@direccionEmisor", @direccionEmisor);
                cmd.Parameters.AddWithValue("@razonSocialEmisor", @razonSocialEmisor);
                cmd.Parameters.AddWithValue("@rucCliente", @rucCliente);
                cmd.Parameters.AddWithValue("@razonCliente", @razonCliente);
                cmd.Parameters.AddWithValue("@direccionCliente", @direccionCliente);
                cmd.CommandType = CommandType.StoredProcedure;
                abrir();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
                cerrar();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error al insertar cabecera");
            }


            return respuesta;
        }


        internal bool InsertarDetalle(int @item, string @serie, string @correlativo,
        string @codigoproducto , string @descripcion , string @unidad ,
        double @cantidad , double @valorUnitario, double @precioUnitario,
        double @descuento, double @valorVenta)
        {

            bool respuesta = false;
            try
            {

                SqlCommand cmd = new SqlCommand("Spu_Ins_FactDet", cn);
                cmd.Parameters.AddWithValue("@item", @item);
                cmd.Parameters.AddWithValue("@serie", @serie);
                cmd.Parameters.AddWithValue("@correlativo", @correlativo);
                cmd.Parameters.AddWithValue("@codigoproducto", @codigoproducto);
                cmd.Parameters.AddWithValue("@descripcion", @descripcion);
                cmd.Parameters.AddWithValue("@unidad", @unidad);
                cmd.Parameters.AddWithValue("@cantidad", @cantidad);
                cmd.Parameters.AddWithValue("@valorUnitario", @valorUnitario);
                cmd.Parameters.AddWithValue("@precioUnitario", @precioUnitario);
                cmd.Parameters.AddWithValue("@descuento", @descuento);
                cmd.Parameters.AddWithValue("@valorVenta", @valorVenta);

                cmd.CommandType = CommandType.StoredProcedure;
                abrir();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
                cerrar();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error al insertar cabecera");
            }
            


            return respuesta;
        }

    }
}
