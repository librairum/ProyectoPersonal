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
    public partial class frmConsultas : Form
    {
        //private string archivo = @"C:\Users\pc_sistemas2020\OneDrive\Documentos\Visual Studio 2010\Projects\ProyectoPersonal\Presentacion\facturasunat.XML";

        //private string archivo = @"C:\Users\pc_sistemas2020\OneDrive\Documentos\Visual Studio 2010\Projects\ProyectoPersonal\Presentacion\archivo.XML";
        private string XlmNodo_Ruc = "cac:Signature/cac:SignatoryParty/cac:PartyIdentification";
        private string XlmNodo_CodFactura = "cbc:ID";
        private string XlmNodo_RazSocialEmisor = "cac:Signature/cac:SignatoryParty/cac:PartyName";
        private string XlmNodo_DirecEmisor = "cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine";
        private string XlmNodo_DistritoEmi = "cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:District";
        private string XlmNodo_DepartamentoEmi = "cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:CityName";
        private string XlmNodo_IdReceptor = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:ID";
        private string XlmNodo_RazSociReceptor = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cbc:RegistrationName";
        private string XlmNodo_DirecRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine/cbc:Line";
        private string XlmNodo_RucRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification";
        private string XlmNodo_DistritoRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:District";
        private string XlmNodo_DeparRecep = "cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cbc:CityName";
        private string XlmNodo_FechaEmision = "cbc:IssueDate";
        private string XlmNodo_HoraEmision = "cbc:IssueTime";
        private string XlmNodo_FormaPago = "cac:PaymentTerms/cbc:PaymentMeansID";
        private string XlmNodo_Item = "cac:InvoiceLine/cac:Item/cbc:Description";
        private string XlmNodo_CodigoProduc = "cac:InvoiceLine/cac:Item/cac:SellersItemIdentification";
        private string XlmNodo_CantProduc = "cac:InvoiceLine/cbc:InvoicedQuantity";
        private string XlmNodo_ValorUniProduc = "cac:InvoiceLine/cac:Price";
        private string XlmNodo_PrecioUniProduc = "cac:InvoiceLine/cac:PricingReference";
        private string XlmNodo_ValorVenta = "cac:InvoiceLine/cac:Price";
        private string XlmNodo_OPCGravada = "cac:LegalMonetaryTotal/cbc:LineExtensionAmount";
        private string XlmNodo_IGV = "TaxTotal/cbc:TaxAmount";
        private string XlmNodo_ImporteTotal = "cac:LegalMonetaryTotal/cbc:PayableAmount";
        private string XlmNodo_FechaVencimiento = "cac:PaymentTerms/cbc:PaymentDueDate";
        private string XlmNodo_MontoCuota = "cac:PaymentTerms/cbc:Amount";
        private string archivo = @"C:\Users\pc_sistemas2020\OneDrive\Documentos\Visual Studio 2010\Projects\ProyectoPersonal\Presentacion\factura_deisi.XML";
        public frmConsultas()
        {
            InitializeComponent();
        }

        private string LeerNodo(string valorNodo) {
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
                if (valorNodo != "") {                    
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
        private void Leer() {
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
                
                //XmlNodeList nodos =  doc.SelectNodes(txtnodo.Text.Trim(), prefijos);
                //var nodos = doc.SelectNodes(txtnodo.Text.Trim(), prefijos);
                var nodos = doc.DocumentElement.SelectNodes(txtnodo.Text.Trim(), prefijos);
                XmlNode nodo = doc.DocumentElement.SelectSingleNode(txtnodo.Text.Trim(), prefijos);
                
                if (nodos.Count > 0) {
                    textBox1.Text = nodos[0].InnerText;
                    //nodos[0].Value
                    //System.Console.WriteLine("Encontro registros");
                }else{
                    //System.Console.WriteLine("No encontro registros");
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error al leer documento");
            }
        }
        private void Leer2() {
            try
            {
                //XmlDocument doc = new XmlDocument();
                //doc.Load(archivo);
                XPathDocument xdoc = new XPathDocument(archivo);
                XPathNavigator xnav = xdoc.CreateNavigator();

                XmlNamespaceManager prefijos = new XmlNamespaceManager(xnav.NameTable);

                prefijos.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                prefijos.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                prefijos.AddNamespace("ccts", "urn:oasis:names:specification:ubl:schema:xsd:CoreComponentParameters-2");
                prefijos.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
                prefijos.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                prefijos.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                prefijos.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1");
                prefijos.AddNamespace("stat", "urn:oasis:names:specification:ubl:schema:xsd:DocumentStatusCode-1.0");
                prefijos.AddNamespace("udt", "urn:un:unece:uncefact:data:draft:UnqualifiedDataTypesSchemaModule:2");
                //XmlNamespaceManager prefijocbc = new XmlNamespaceManager(xnav.NameTable);
                //prefijocbc.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                string nodotexto = txtnodo.Text.Trim();

                XPathNavigator elemento = xnav.SelectSingleNode(nodotexto, prefijos);
                XPathNodeIterator nodos = xnav.Select(nodotexto, prefijos);

                //XPathNavigator elementocbc = xnav.SelectSingleNode(nodotexto, prefijos);
                //XPathNodeIterator nodoscbc = xnav.Select(nodotexto, prefijos);

                System.Console.WriteLine(elemento.OuterXml);
                string mensaje = "";

                txtnodo.Text = "";
                if (nodos.Count > 0)
                {

                    mensaje += "Nodos lista cac:" + nodos.Count.ToString() + Environment.NewLine;
                    //textBox1.Text = 
                }
                if (elemento != null)
                {
                    mensaje += "Elementos de cac " + Environment.NewLine;
                }

                //if (elementocbc != null) {
                //    mensaje += "tiene elementos  cbc" + Environment.NewLine;
                //}

                //if (nodoscbc.Count > 0)
                //{
                //    mensaje += "Nodos lista cbc:" + nodoscbc.Count.ToString() + Environment.NewLine; 
                //}

                txtnodo.Text = mensaje;
                //doc.SelectNodes("Signature");
                //XmlNodeList nodos =  doc.SelectNodes("/cac:Signature", prefijocac);

                //XmlNode nodo = doc.SelectSingleNode("/cac:Signature", prefijocac);

                //nsmgr.AddNamespace("bk", "http://www.contoso.com/books");

                //textBox1.Text = sb.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar operacion");
            }
        }
        private void LeerDetalle() {
            try
            {
                //"cac:InvoiceLine/cac:Item/cbc:Description"

            }
            catch (Exception ex) { 
                
            }
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {

            Leer();
            
        }
    }
}
