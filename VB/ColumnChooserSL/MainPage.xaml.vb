Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid

Namespace ColumnChooserSL
	Partial Public Class MainPage
		Inherits UserControl
		Private records As ObservableCollection(Of Record)
		Public Sub New()
			InitializeComponent()
			FillData()
		End Sub

		Public Sub FillData()
			records = New ObservableCollection(Of Record)()
			records.Add(New Record("a", "a", "a", "a", "a"))
			records.Add(New Record("b", "b", "b", "b", "b"))
			records.Add(New Record("c", "c", "c", "c", "c"))

			gridControl1.ItemsSource = records
			ColumnChooserInit()
		End Sub

		Private Sub ColumnChooserInit()
			gridControl1.Columns(1).Visible = False
			gridControl1.Columns(2).Visible = False
		End Sub
	End Class
End Namespace
