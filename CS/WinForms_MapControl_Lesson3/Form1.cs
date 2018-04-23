using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace WinForms_MapControl_Lesson3 {
    public partial class Form1 : Form {
        const String filepath = @"..\..\sochi2014.xml";
        VectorItemsLayer PieLayer { get { return (VectorItemsLayer)(mapControl1.Layers["PieLayer"]); } }
        PieChartDataAdapter PieAdapter { get { return (PieChartDataAdapter)PieLayer.Data; } }

        public Form1() {
            InitializeComponent();

            // Assign loaded data as data source for pie chart data adapter.
            PieAdapter.DataSource = LoadData(filepath);
        }

        // Loads data from XML.
        private DataTable LoadData(string path) {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
    }
}
