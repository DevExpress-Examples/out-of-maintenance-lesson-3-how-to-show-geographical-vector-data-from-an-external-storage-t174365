namespace MapLesson3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem1 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem2 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem3 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.MeasureRules measureRules1 = new DevExpress.XtraMap.MeasureRules();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.analyticalDataLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.pieChartDataAdapter = new DevExpress.XtraMap.PieChartDataAdapter();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer);
            this.mapControl1.Layers.Add(this.analyticalDataLayer);
            colorListLegend1.Header = "Medal Class";
            colorListLegend1.Layer = this.analyticalDataLayer;
            sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            sizeLegend1.Layer = this.analyticalDataLayer;
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Legends.Add(sizeLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(798, 418);
            this.mapControl1.TabIndex = 0;
            // 
            // imageLayer
            // 
            this.imageLayer.DataProvider = this.bingMapDataProvider;
            // 
            // analyticalDataLayer
            // 
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(98))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(188))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(152)))), ((int)(((byte)(118))))));
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            colorizerKeyItem1.Key = 1;
            colorizerKeyItem1.Name = "Gold";
            colorizerKeyItem2.Key = 2;
            colorizerKeyItem2.Name = "Silver";
            colorizerKeyItem3.Key = 3;
            colorizerKeyItem3.Name = "Bronze";
            keyColorColorizer1.Keys.Add(colorizerKeyItem1);
            keyColorColorizer1.Keys.Add(colorizerKeyItem2);
            keyColorColorizer1.Keys.Add(colorizerKeyItem3);
            this.analyticalDataLayer.Colorizer = keyColorColorizer1;
            this.analyticalDataLayer.Data = this.pieChartDataAdapter;
            this.analyticalDataLayer.Name = "AnalyticalDataLayer";
            this.analyticalDataLayer.ToolTipPattern = "<b>%A%</b>\r\nGold: %V0%\r\nSilver: %V1%\r\nGold: %V2%\r\nTotal: %V%";
            this.analyticalDataLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.OnDataLoaded);
            // 
            // pieChartDataAdapter
            // 
            this.pieChartDataAdapter.ItemMaxSize = 60;
            this.pieChartDataAdapter.ItemMinSize = 20;
            this.pieChartDataAdapter.Mappings.Latitude = "CapitalLat";
            this.pieChartDataAdapter.Mappings.Longitude = "CapitalLon";
            this.pieChartDataAdapter.Mappings.PieSegment = "MedalClass";
            this.pieChartDataAdapter.Mappings.Value = "Quantity";
            measureRules1.RangeDistribution = linearRangeDistribution1;
            measureRules1.RangeStops.Add(1D);
            measureRules1.RangeStops.Add(10D);
            measureRules1.RangeStops.Add(20D);
            measureRules1.RangeStops.Add(30D);
            measureRules1.RangeStops.Add(40D);
            this.pieChartDataAdapter.MeasureRules = measureRules1;
            this.pieChartDataAdapter.PieItemDataMember = "Name";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 418);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider;
        private DevExpress.XtraMap.VectorItemsLayer analyticalDataLayer;
        private DevExpress.XtraMap.PieChartDataAdapter pieChartDataAdapter;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

