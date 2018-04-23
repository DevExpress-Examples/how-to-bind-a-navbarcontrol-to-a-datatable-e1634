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

Namespace NavBarBinding
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim dt As New DataTable()
			dt.Columns.Add("Group", GetType(String))
			dt.Columns.Add("Item", GetType(String))
			For i As Integer = 1 To 2
				For j As Integer = 1 To 3
					dt.Rows.Add(New Object() { "Group " & i.ToString(), "Item " & i.ToString() & "-" & j.ToString() })
				Next j
			Next i

			DataContext = dt
		End Sub
	End Class
End Namespace
