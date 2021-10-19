using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using Telerik.Charting;
//using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls; 
namespace Presentacion
{
    public partial class Graficos : Telerik.WinControls.UI.RadForm
    {
        public Graficos()
        {
            InitializeComponent();
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            CategoricalAxis horizontalAxis = new CategoricalAxis();
            Ventas venta = new Ventas();
            BarSeries barSeries;
            barSeries = new BarSeries("monto", "nombreCategoria"); 
            //barSeries.Name = "Q" + (i + 1); 
            barSeries.Name = "Test";
            barSeries.HorizontalAxis = horizontalAxis;
            barSeries.VerticalAxis = verticalAxis;
            barSeries.DataSource = venta.listaVentas();
            this.radChartView1.Series.Add(barSeries);
            barSeries = new BarSeries("monto", "nombreCategoria");
            barSeries.Name = "Test1";
            barSeries.HorizontalAxis = horizontalAxis;
            barSeries.VerticalAxis = verticalAxis;
            barSeries.DataSource = venta.listaVentas2016();
            this.radChartView1.Series.Add(barSeries);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowToolTip = true;
            //this.radChartView1.GetArea<Ventas>().
        }
    }
}
