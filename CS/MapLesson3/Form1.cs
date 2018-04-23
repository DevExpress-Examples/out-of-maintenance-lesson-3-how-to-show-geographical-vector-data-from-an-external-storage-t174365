using DevExpress.XtraMap;
using System;
using System.Data;

namespace MapLesson3 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        const string bingKey = "Your Bing Key Here";
        const string filepath = @"../../Data/sochi2014.xml";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            bingMapDataProvider.BingKey = bingKey;
            // Assign loaded data as data source for pie chart data adapter.
            pieChartDataAdapter.DataSource = LoadData(filepath);
        }

        // Loads data from XML.
        private DataTable LoadData(string path) {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }

        private void OnDataLoaded(object sender, DataLoadedEventArgs e) {
            mapControl1.ZoomToFitLayerItems();
        }
    }
}
