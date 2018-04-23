Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace WinForms_MapControl_Lesson3
    Partial Public Class Form1
        Inherits Form

        Private Const filepath As String = "..\..\sochi2014.xml"
        Private ReadOnly Property PieLayer() As VectorItemsLayer
            Get
                Return CType(mapControl1.Layers("PieLayer"), VectorItemsLayer)
            End Get
        End Property
        Private ReadOnly Property PieAdapter() As PieChartDataAdapter
            Get
                Return CType(PieLayer.Data, PieChartDataAdapter)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            ' Assign loaded data as data source for pie chart data adapter.
            PieAdapter.DataSource = LoadData(filepath)
        End Sub

        ' Loads data from XML.
        Private Function LoadData(ByVal path As String) As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(path)
            Dim table As DataTable = ds.Tables(0)
            Return table
        End Function
    End Class
End Namespace
