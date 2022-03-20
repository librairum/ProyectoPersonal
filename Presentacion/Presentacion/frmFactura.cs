using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;
namespace Presentacion
{
    public partial class frmFactura : Form
    {

        private string xmlNodo_Ruc = "cac:Signature/cac:SignatoryParty/cac:PartyIdentification";
        private string xmlNodo_CodFactura = "cbc:ID";
        private string xmlNodo_RazSocialEmisor = "cac:Signature/cac:SignatoryParty/cac:PartyName";
        private string xmlNodo_DirecEmisor = "cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine";
        private string xmlNodo_DistritoEmi = "cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:District";
        private string xmlNodo_DepartamentoEmi = "cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:CityName";
        private string xmlNodo_IdReceptor = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:ID";
        private string xmlNodo_RazSociReceptor = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cbc:RegistrationName";
        private string xmlNodo_DirecRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine/cbc:Line";
        private string xmlNodo_RucRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification";
        private string xmlNodo_DistritoRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:District";
        private string xmlNodo_DeparRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:CityName";
        private string xmlNodo_FechaEmision = "cbc:IssueDate";
        private string xmlNodo_HoraEmision = "cbc:IssueTime";
        private string xmlNodo_FormaPago = "cac:PaymentTerms/cbc:PaymentMeansID";

        private string xmlNodo_Item = "cac:InvoiceLine/cac:Item/cbc:Description";
        private string xmlNodo_CodigoProduc = "cac:InvoiceLine/cac:Item/cac:SellersItemIdentification";
        private string xmlNodo_CantProduc = "cac:InvoiceLine/cbc:InvoicedQuantity";
        private string xmlNodo_ValorUniProduc = "cac:InvoiceLine/cac:Price";
        private string xmlNodo_PrecioUniProduc = "cac:InvoiceLine/cac:PricingReference";

        private string xmlNodo_ValorVenta = "cac:InvoiceLine/cac:Price";

        private string xmlNodo_OPCGravada = "cac:LegalMonetaryTotal/cbc:LineExtensionAmount";
        private string xmlNodo_IGV = "TaxTotal/cbc:TaxAmount";
        private string xmlNodo_ImporteTotal = "cac:LegalMonetaryTotal/cbc:PayableAmount";
        private string xmlNodo_FechaVencimiento = "cac:PaymentTerms/cbc:PaymentDueDate";
        private string xmlNodo_MontoCuota = "cac:PaymentTerms/cbc:Amount";
        private string archivo = @"C:\Users\pc_sistemas2020\OneDrive\Documentos\Visual Studio 2010\Projects\ProyectoPersonal\Presentacion\factura_deisi.XML";

     
        private string LeerNodo(string valorNodo)
        {
            string respuesta = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(archivo);

                XmlNamespaceManager prefijos = new XmlNamespaceManager(doc.NameTable);

                prefijos.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                prefijos.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                prefijos.AddNamespace("ccts", "urn:oasis:names:specification:ubl:schema:xsd:CoreComponentParameters-2");
                prefijos.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
                prefijos.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                prefijos.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                prefijos.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1");
                prefijos.AddNamespace("stat", "urn:oasis:names:specification:ubl:schema:xsd:DocumentStatusCode-1.0");
                prefijos.AddNamespace("udt", "urn:un:unece:uncefact:data:draft:UnqualifiedDataTypesSchemaModule:2");

                XmlNodeList nodos;
                XmlNode nodo;
                if (valorNodo != "")
                {
                    nodos = doc.DocumentElement.SelectNodes(valorNodo.Trim(), prefijos);
                    nodo = doc.DocumentElement.SelectSingleNode(valorNodo.Trim(), prefijos);

                    if (nodos.Count > 0)
                    {
                        //textBox1.Text = nodos[0].InnerText;
                        respuesta = nodos[0].InnerText;
                        //nodos[0].Value
                        //System.Console.WriteLine("Encontro registros");
                    }
                    else
                    {
                        //System.Console.WriteLine("No encontro registros");
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer documento");
            }
            return respuesta;
        }

        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

            //armaar grilla
            //this.dgvdetalle.AutoGenerateColumns = false;
            
            //this.dgvdetalle.Columns.Add("Item", "Item");
            //this.dgvdetalle.Columns.Add("codigoproducto", "codigoproducto");
            //this.dgvdetalle.Columns.Add("descripcionproducto", "descripcionproducto");
            //this.dgvdetalle.Columns.Add("unidadmedida", "unidadmedida");
            //this.dgvdetalle.Columns.Add("cantidad", "cantidad");
            //this.dgvdetalle.Columns.Add("preciounitario", "preciounitario");
            //this.dgvdetalle.Columns.Add("valorunitario", "valorunitario");


            //lblnombrempresa.Text = LeerNodo(xmlNodo_RazSocialEmisor);
            //lblcorrelativo.Text = LeerNodo(xmlNodo_CodFactura);
            //lblRucEmpresa.Text = LeerNodo(xmlNodo_Ruc);
            //lbldireccionemisor.Text = LeerNodo(xmlNodo_DirecEmisor);
            //txtMoneda.Text = "Soles";
            //txtNombreCliente.Text = LeerNodo(xmlNodo_RazSociReceptor);
            //txtdireccion.Text = LeerNodo(xmlNodo_DirecRecep);

            
            
            
            //agregar filas a la grilla

            //this.dgvdetalle.Rows.Add(
        }


        private void LeerDetalle()
        {

            string[,] datos = new string[10, 10];
            try
            {
                string nodo = "cac:InvoiceLine/cac:Item";
                XmlDocument doc = new XmlDocument();
                doc.Load(archivo);
                XmlNamespaceManager prefijos = new XmlNamespaceManager(doc.NameTable);

                prefijos.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                prefijos.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                prefijos.AddNamespace("ccts", "urn:oasis:names:specification:ubl:schema:xsd:CoreComponentParameters-2");
                prefijos.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
                prefijos.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                prefijos.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                prefijos.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1");
                prefijos.AddNamespace("stat", "urn:oasis:names:specification:ubl:schema:xsd:DocumentStatusCode-1.0");
                prefijos.AddNamespace("udt", "urn:un:unece:uncefact:data:draft:UnqualifiedDataTypesSchemaModule:2");

                XmlNodeList datosProducto = doc.DocumentElement.SelectNodes("cac:InvoiceLine/cac:Item", prefijos);
                XmlNodeList datosPrecio = doc.DocumentElement.SelectNodes("cac:InvoiceLine/cac:Price", prefijos);
                XmlNodeList datosUnidad = doc.DocumentElement.SelectNodes("cac:InvoiceLine/cbc:InvoicedQuantity", prefijos);
                XmlNodeList datosDetalleBoleta = doc.DocumentElement.SelectNodes("cac:InvoiceLine", prefijos);
                XmlNodeList datosValorVenta = doc.DocumentElement.SelectNodes("cac:InvoiceLine/cbc:LineExtensionAmount", prefijos);

                //armar la grilla 


                if (datosProducto.Count > 0)
                {
                    for (int x = 0; x < datosProducto.Count; x++)
                    {
                        XmlNode fila = datosProducto[x];


                        XmlNode filaPrecio = datosPrecio[x];


                        XmlNode filadetalle = datosDetalleBoleta[x];

                        int idDetalle = Convert.ToInt32(filadetalle.ChildNodes[0].InnerText);
                        string codigoProducto = fila.ChildNodes[1].InnerText;
                        string descripcionProducto = fila.ChildNodes[0].InnerText;
                        string unidadmedida = filadetalle.ChildNodes[2].InnerText;
                        double cantidad = Convert.ToDouble(filadetalle.ChildNodes[3].InnerText);

                        double valorUnitario = Convert.ToDouble(filaPrecio.ChildNodes[0].InnerText);
                        double precioUnitario = Convert.ToDouble(filadetalle.ChildNodes[5].ChildNodes[0].ChildNodes[0].InnerText);

                        double descuento = 0;
                        double valorVenta = valorUnitario - descuento;

                        Conexion obj = new Conexion();
                        //leer serie y correlativo
                        string serie = LeerNodo(xmlNodo_CodFactura).Split('-')[0];
                        string correlativo = LeerNodo(xmlNodo_CodFactura).Split('-')[1];
                        bool flag = obj.InsertarDetalle(idDetalle, serie, correlativo, codigoProducto, descripcionProducto, unidadmedida,
                        cantidad, valorUnitario, precioUnitario, descuento, valorVenta);
                        if (flag == false)
                        {
                            MessageBox.Show("Error al insertar detalle");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer y guardar el detalle");
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conexion obj = new Conexion();
            string serie = LeerNodo(xmlNodo_CodFactura).Split('-')[0];
            string correlativo = LeerNodo(xmlNodo_CodFactura).Split('-')[1];

            string fechaemision = LeerNodo(xmlNodo_FechaEmision);
            string formapago = LeerNodo(xmlNodo_FormaPago);
            string montoletras = "";
            montoletras = LeerNodo("Invoice/cbc:Note");
            string tipomoneda = "SOL";
            double gravado = Convert.ToDouble(LeerNodo(xmlNodo_OPCGravada));
            double importeInafecta = 0; 
            double importeExonerada = 0;
            double importeExportacion = 0;

           double importeigv = 0;
           importeigv = Convert.ToDouble(LeerNodo("cac:TaxTotal/cbc:TaxAmount"));
            
            

            double importeTotal = 0;
            importeTotal = Convert.ToDouble(LeerNodo("cac:LegalMonetaryTotal/cbc:PayableAmount"));
            string rucempresa = LeerNodo(xmlNodo_Ruc);
            string direccEmisor = LeerNodo(xmlNodo_DirecEmisor);
            string razonsocialEmisor = LeerNodo(xmlNodo_RazSocialEmisor);
            string rucCliente = LeerNodo(xmlNodo_RucRecep);
            string razonCliente = LeerNodo(xmlNodo_RazSociReceptor);
            string direccionCliente = LeerNodo(xmlNodo_DirecRecep);
            

           bool flag =  obj.InsertarCabecera(serie, correlativo, Convert.ToDateTime(fechaemision), formapago, montoletras, tipomoneda, gravado, importeigv,
                importeInafecta, importeExonerada, importeExportacion,  importeTotal, rucempresa, 
                direccEmisor, razonsocialEmisor, rucCliente, razonCliente, direccionCliente);
           if (flag == false) {
               MessageBox.Show("Error al guardar cabecera");

           }

           LeerDetalle();
        }


    }
}
