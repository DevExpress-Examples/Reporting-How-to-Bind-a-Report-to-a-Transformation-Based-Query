Namespace TransformationBasedQuery
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' xrTable2
			' 
			Me.xrTable2.Font = New System.Drawing.Font("Arial", 9F)
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(902F, 25F)
			Me.xrTable2.StylePriority.UseFont = False
			Me.xrTable2.StylePriority.UsePadding = False
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12})
			Me.xrTableRow2.EvenStyleName = "xrControlStyle1"
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryId]")})
			Me.xrTableCell7.Multiline = True
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.StylePriority.UseTextAlignment = False
			Me.xrTableCell7.Text = "xrTableCell7"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell7.Weight = 1.0104165649414063R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
			Me.xrTableCell8.Multiline = True
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "xrTableCell8"
			Me.xrTableCell8.Weight = 1.5R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
			Me.xrTableCell9.Multiline = True
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Text = "xrTableCell9"
			Me.xrTableCell9.Weight = 2.9895834350585937R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Products_ProductId]")})
			Me.xrTableCell10.Multiline = True
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.StylePriority.UseTextAlignment = False
			Me.xrTableCell10.Text = "xrTableCell10"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell10.Weight = 1R
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Products_ProductName]")})
			Me.xrTableCell11.Multiline = True
			Me.xrTableCell11.Name = "xrTableCell11"
			Me.xrTableCell11.Text = "xrTableCell11"
			Me.xrTableCell11.Weight = 1.5R
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Products_UnitPrice]")})
			Me.xrTableCell12.Multiline = True
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.StylePriority.UseTextAlignment = False
			Me.xrTableCell12.Text = "xrTableCell12"
			Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell12.TextFormatString = "{0:c2}"
			Me.xrTableCell12.Weight = 1.0199999999999996R
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.ReportHeader.HeightF = 25F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrTable1
			' 
			Me.xrTable1.BackColor = System.Drawing.Color.DimGray
			Me.xrTable1.ForeColor = System.Drawing.Color.White
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(900F, 25F)
			Me.xrTable1.StylePriority.UseBackColor = False
			Me.xrTable1.StylePriority.UseForeColor = False
			Me.xrTable1.StylePriority.UsePadding = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Multiline = True
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.StylePriority.UseTextAlignment = False
			Me.xrTableCell1.Text = "Category ID"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell1.Weight = 1.0104166412353517R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Multiline = True
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Category Name"
			Me.xrTableCell2.Weight = 1.5R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Multiline = True
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Description"
			Me.xrTableCell3.Weight = 2.9895833587646483R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Multiline = True
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.Text = "Product ID"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell4.Weight = 1R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Multiline = True
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "Product Name"
			Me.xrTableCell5.Weight = 1.5R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Multiline = True
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "Unit Price"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell6.Weight = 1R
			' 
			' xrControlStyle1
			' 
			Me.xrControlStyle1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(224)))), (CInt((CByte(224)))))
			Me.xrControlStyle1.Name = "xrControlStyle1"
			Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader})
			Me.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold)
			Me.Landscape = True
			Me.Margins = New System.Drawing.Printing.Margins(98, 100, 100, 100)
			Me.PageHeight = 850
			Me.PageWidth = 1100
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1})
			Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.Version = "20.2"
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
