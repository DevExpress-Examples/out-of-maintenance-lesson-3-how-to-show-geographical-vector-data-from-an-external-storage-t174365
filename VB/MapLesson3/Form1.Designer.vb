Namespace MapLesson3
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim colorListLegend1 As New DevExpress.XtraMap.ColorListLegend()
            Dim sizeLegend1 As New DevExpress.XtraMap.SizeLegend()
            Dim keyColorColorizer1 As New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim colorizerKeyItem1 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem2 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem3 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim measureRules1 As New DevExpress.XtraMap.MeasureRules()
            Dim linearRangeDistribution1 As New DevExpress.XtraMap.LinearRangeDistribution()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.analyticalDataLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.pieChartDataAdapter = New DevExpress.XtraMap.PieChartDataAdapter()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.imageLayer)
            Me.mapControl1.Layers.Add(Me.analyticalDataLayer)
            colorListLegend1.Header = "Medal Class"
            colorListLegend1.Layer = Me.analyticalDataLayer
            sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
            sizeLegend1.Layer = Me.analyticalDataLayer
            Me.mapControl1.Legends.Add(colorListLegend1)
            Me.mapControl1.Legends.Add(sizeLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(798, 418)
            Me.mapControl1.TabIndex = 0
            ' 
            ' imageLayer
            ' 
            Me.imageLayer.DataProvider = Me.bingMapDataProvider
            ' 
            ' analyticalDataLayer
            ' 
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(207)))), (CInt((CByte(98))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(181)))), (CInt((CByte(188))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt((CByte(233)))), (CInt((CByte(152)))), (CInt((CByte(118))))))
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            colorizerKeyItem1.Key = 1
            colorizerKeyItem1.Name = "Gold"
            colorizerKeyItem2.Key = 2
            colorizerKeyItem2.Name = "Silver"
            colorizerKeyItem3.Key = 3
            colorizerKeyItem3.Name = "Bronze"
            keyColorColorizer1.Keys.Add(colorizerKeyItem1)
            keyColorColorizer1.Keys.Add(colorizerKeyItem2)
            keyColorColorizer1.Keys.Add(colorizerKeyItem3)
            Me.analyticalDataLayer.Colorizer = keyColorColorizer1
            Me.analyticalDataLayer.Data = Me.pieChartDataAdapter
            Me.analyticalDataLayer.Name = "AnalyticalDataLayer"
            Me.analyticalDataLayer.ToolTipPattern = "<b>%A%</b>" & ControlChars.CrLf & "Gold: %V0%" & ControlChars.CrLf & "Silver: %V1%" & ControlChars.CrLf & "Gold: %V2%" & ControlChars.CrLf & "Total: %V%"
            ' 
            ' pieChartDataAdapter
            ' 
            Me.pieChartDataAdapter.ItemMaxSize = 60
            Me.pieChartDataAdapter.ItemMinSize = 20
            Me.pieChartDataAdapter.Mappings.Latitude = "CapitalLat"
            Me.pieChartDataAdapter.Mappings.Longitude = "CapitalLon"
            Me.pieChartDataAdapter.Mappings.PieSegment = "MedalClass"
            Me.pieChartDataAdapter.Mappings.Value = "Quantity"
            measureRules1.RangeDistribution = linearRangeDistribution1
            measureRules1.RangeStops.Add(1R)
            measureRules1.RangeStops.Add(10R)
            measureRules1.RangeStops.Add(20R)
            measureRules1.RangeStops.Add(30R)
            measureRules1.RangeStops.Add(40R)
            Me.pieChartDataAdapter.MeasureRules = measureRules1
            Me.pieChartDataAdapter.PieItemDataMember = "Name"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(798, 418)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private imageLayer As DevExpress.XtraMap.ImageLayer
        Private bingMapDataProvider As DevExpress.XtraMap.BingMapDataProvider
        Private WithEvents analyticalDataLayer As DevExpress.XtraMap.VectorItemsLayer
        Private pieChartDataAdapter As DevExpress.XtraMap.PieChartDataAdapter
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

