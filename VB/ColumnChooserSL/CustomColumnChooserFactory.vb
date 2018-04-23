Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports System.Collections.Generic
Imports DevExpress.Xpf.Core.Native

Namespace ColumnChooserSL
	Public Class CustomColumnChooserFactory
		Implements IColumnChooserFactory
		Public Sub New()

		End Sub

        Public Function Create(ByVal owner As DevExpress.Xpf.Core.WPFCompatibility.SLControl) As IColumnChooser Implements IColumnChooserFactory.Create
            Dim chooser As New DefaultColumnChooser(CType(owner, DataViewBase))
            chooser.TopContainer.AddHandler(UIElement.MouseLeftButtonDownEvent, New MouseButtonEventHandler(AddressOf GridColumnHeader_MouseLeftButtonDown), True)
            Return chooser
        End Function

        Private Sub GridColumnHeader_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            If e.ClickCount = 2 Then

                Dim header As GridColumnHeader = LayoutHelper.FindParentObject(Of GridColumnHeader)(CType(e.OriginalSource, DependencyObject))
                Dim gc As GridColumn = CType(header.DataContext, GridColumn)

                Dim lst As New List(Of ColumnBase)(gc.View.ColumnChooserColumns)
                For i As Integer = 0 To lst.Count - 1
                    If gc.ActualColumnChooserHeaderCaption = lst(i).ActualColumnChooserHeaderCaption Then
                        lst(i).Visible = True
                        Exit For
                    End If
                Next i
            End If
        End Sub
    End Class
End Namespace
