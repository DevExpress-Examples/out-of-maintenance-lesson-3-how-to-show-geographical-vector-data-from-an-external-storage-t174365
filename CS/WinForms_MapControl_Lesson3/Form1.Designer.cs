namespace WinForms_MapControl_Lesson3 {
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
            if (disposing && (components != null)) {
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
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem1 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem2 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem3 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.PieChartDataAdapter pieChartDataAdapter1 = new DevExpress.XtraMap.PieChartDataAdapter();
            DevExpress.XtraMap.MeasureRules measureRules1 = new DevExpress.XtraMap.MeasureRules();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.ChartItemValueProvider chartItemValueProvider1 = new DevExpress.XtraMap.ChartItemValueProvider();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            bingMapDataProvider1.BingKey = "YOUR_BING_MAPS_KEY_HERE";
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
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
            vectorItemsLayer1.Colorizer = keyColorColorizer1;
            pieChartDataAdapter1.ItemMaxSize = 60;
            pieChartDataAdapter1.ItemMinSize = 20;
            pieChartDataAdapter1.Mappings.Latitude = "CapitalLat";
            pieChartDataAdapter1.Mappings.Longitude = "CapitalLon";
            pieChartDataAdapter1.Mappings.PieSegment = "MedalClass";
            pieChartDataAdapter1.Mappings.Value = "Quantity";
            measureRules1.RangeDistribution = linearRangeDistribution1;
            measureRules1.RangeStops.Add(1D);
            measureRules1.RangeStops.Add(10D);
            measureRules1.RangeStops.Add(20D);
            measureRules1.RangeStops.Add(30D);
            measureRules1.RangeStops.Add(40D);
            measureRules1.ValueProvider = chartItemValueProvider1;
            pieChartDataAdapter1.MeasureRules = measureRules1;
            pieChartDataAdapter1.PieItemDataMember = "Name";
            vectorItemsLayer1.Data = pieChartDataAdapter1;
            vectorItemsLayer1.Name = "PieLayer";
            vectorItemsLayer1.ToolTipPattern = "<b>%A%</b>\r\nGold: %V0%\r\nSilver: %V1%\r\nBrionze: %V2%\r\nTotal: %V%";
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Layers.Add(vectorItemsLayer1);
            colorListLegend1.Header = "Medal Class";
            colorListLegend1.Layer = vectorItemsLayer1;
            sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            sizeLegend1.Header = "Medal Count";
            sizeLegend1.Layer = vectorItemsLayer1;
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Legends.Add(sizeLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(647, 451);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 451);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}

