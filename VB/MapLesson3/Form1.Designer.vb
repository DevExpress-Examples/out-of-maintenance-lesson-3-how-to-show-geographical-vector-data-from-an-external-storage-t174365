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
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.pieChartDataAdapter1 = New DevExpress.XtraMap.PieChartDataAdapter()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            colorListLegend1.Header = "Medal Class"
            colorListLegend1.Layer = Me.vectorItemsLayer1
            sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
            sizeLegend1.Header = "Medal Count"
            sizeLegend1.Layer = Me.vectorItemsLayer1
            Me.mapControl1.Legends.Add(colorListLegend1)
            Me.mapControl1.Legends.Add(sizeLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(775, 454)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ToolTipController = Me.toolTipController1
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.AllowHtmlText = True
            Me.bingMapDataProvider1.BingKey = "YOUR BING MAPS KEY"
            Me.imageLayer1.DataProvider = Me.bingMapDataProvider1
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
            Me.vectorItemsLayer1.Colorizer = keyColorColorizer1
            Me.vectorItemsLayer1.Data = Me.pieChartDataAdapter1
            Me.vectorItemsLayer1.ToolTipPattern = "<b>%A%</b>" & ControlChars.CrLf & "Gold: %V0%" & ControlChars.CrLf & "Silver: %V1%" & ControlChars.CrLf & "Bronze: %V2%" & ControlChars.CrLf & "Total: %V%"
            Me.pieChartDataAdapter1.ItemMaxSize = 60
            Me.pieChartDataAdapter1.ItemMinSize = 20
            Me.pieChartDataAdapter1.Mappings.Latitude = "CapitalLat"
            Me.pieChartDataAdapter1.Mappings.Longitude = "CapitalLon"
            Me.pieChartDataAdapter1.Mappings.PieSegment = "MedalClass"
            Me.pieChartDataAdapter1.Mappings.Value = "Quantity"
            measureRules1.RangeDistribution = linearRangeDistribution1
            measureRules1.RangeStops.Add(1R)
            measureRules1.RangeStops.Add(10R)
            measureRules1.RangeStops.Add(20R)
            measureRules1.RangeStops.Add(30R)
            measureRules1.RangeStops.Add(40R)
            Me.pieChartDataAdapter1.MeasureRules = measureRules1
            Me.pieChartDataAdapter1.PieItemDataMember = "Name"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(775, 454)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private imageLayer1 As DevExpress.XtraMap.ImageLayer
        Private bingMapDataProvider1 As DevExpress.XtraMap.BingMapDataProvider
        Private WithEvents vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer
        Private pieChartDataAdapter1 As DevExpress.XtraMap.PieChartDataAdapter
        Private toolTipController1 As DevExpress.Utils.ToolTipController
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

