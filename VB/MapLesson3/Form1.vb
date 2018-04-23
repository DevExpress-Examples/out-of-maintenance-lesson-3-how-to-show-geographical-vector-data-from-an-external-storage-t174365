Imports DevExpress.XtraMap
Imports System
Imports System.Data

Namespace MapLesson3
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private Const bingKey As String = "Your Bing Key Here"
        Private Const filepath As String = "../../Data/sochi2014.xml"

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            bingMapDataProvider.BingKey = bingKey
            ' Assign loaded data as data source for pie chart data adapter.
            pieChartDataAdapter.DataSource = LoadData(filepath)
        End Sub

        ' Loads data from XML.
        Private Function LoadData(ByVal path As String) As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(path)
            Dim table As DataTable = ds.Tables(0)
            Return table
        End Function

        Private Sub OnDataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles analyticalDataLayer.DataLoaded
            mapControl1.ZoomToFitLayerItems()
        End Sub
    End Class
End Namespace
