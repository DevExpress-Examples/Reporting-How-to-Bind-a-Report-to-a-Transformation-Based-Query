Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.DataAccess.Json
Imports DevExpress.DataAccess.DataFederation

Namespace TransformationBasedQuery
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			' Create a JSON data source.
			Dim jsonDataSource As New JsonDataSource()
			Dim fileUri As New Uri("Products.json", UriKind.RelativeOrAbsolute)
			jsonDataSource.JsonSource = New UriJsonSource(fileUri)
			jsonDataSource.Fill()
			' Create a Federation data source.
			Dim federationDataSource As New FederationDataSource()
			Dim jsonSource As New Source("json", jsonDataSource, "")
			Dim sourceNode As New SourceNode(jsonSource)
			Dim transformationNode As New TransformationNode(sourceNode) With {
				.Alias = "Transformation",
				.Rules = {
					New TransformationRule With {
						.ColumnName = "Products",
						.Unfold = True,
						.Flatten = True
					}
				}
			}
			federationDataSource.Queries.Add(transformationNode)
			' Create a report and bind it to the Federation data source.
			Dim report As New XtraReport1()
			report.DataSource = federationDataSource
			report.DataMember = "Transformation"
			' Display the report in the Document Viewer.
			documentViewer1.DocumentSource = report
		End Sub
	End Class
End Namespace
