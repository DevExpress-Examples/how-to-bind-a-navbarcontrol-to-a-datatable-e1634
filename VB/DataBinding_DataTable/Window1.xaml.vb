Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Data
Imports DevExpress.Wpf.NavBar


Namespace DataBinding_DataTable
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim navBar As New NavBarControl()
			dockPanel.Children.Add(navBar)
			DataBindingHelper.BuildContent(navBar, GetData(), "Group", Nothing, New NavBarImageContentBindingParameters(Nothing, New NavBarBindingParameters("Item", Nothing, Nothing)))
		End Sub

		Public Function GetData() As DataView
			Dim dt As New DataTable()
			dt.Columns.Add("Group", GetType(String))
			dt.Columns.Add("Item", GetType(String))
			For i As Integer = 1 To 2
				For j As Integer = 1 To 3
					dt.Rows.Add(New Object() { "Group " & i.ToString(), "Item " & i.ToString() & "-" & j.ToString() })
				Next j
			Next i
			Return dt.DefaultView
		End Function
	End Class
End Namespace
