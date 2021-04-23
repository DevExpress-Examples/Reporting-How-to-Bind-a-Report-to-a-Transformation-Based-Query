Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
#Region "usings"
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
#End Region
#Region "usings_json"
Imports DevExpress.DataAccess.Json
#End Region
#Region "usings_federation"
Imports DevExpress.DataAccess.DataFederation
#End Region

Namespace TransformationBasedQuery
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
'			#Region "CreateJsonDataSource"
			' Create a JSON data source.
			Dim jsonDataSource As New JsonDataSource()
			Dim fileUri As New Uri("Products.json", UriKind.RelativeOrAbsolute)
			jsonDataSource.JsonSource = New UriJsonSource(fileUri)
			jsonDataSource.Fill()
'			#End Region
'			#Region "CreateFederationDataSource"
			' Create a Federation data source.
			Dim federationDataSource As New FederationDataSource()
			Dim jsonSource As New Source("json", jsonDataSource, "")
			Dim query As TransformationNode = jsonSource.Transform().TransformColumn("Products").Build("Transformation")
			federationDataSource.Queries.Add(query)
'			#End Region
'			#Region "CreateReport"
			' Create a report and bind it to the Federation data source.
			Dim report As New XtraReport1()
			report.DataSource = federationDataSource
			report.DataMember = "Transformation"
'			#End Region
'			#Region "DisplayReport"
			' Display the report in the Document Viewer.
			documentViewer1.DocumentSource = report
'			#End Region
		End Sub

		Private Sub documentViewer1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles documentViewer1.Load

		End Sub
	End Class
End Namespace
