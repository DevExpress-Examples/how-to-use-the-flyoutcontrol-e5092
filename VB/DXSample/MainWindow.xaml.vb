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

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
			flyout.IsOpen = False
			flyout.PlacementTarget = TryCast(sender, UIElement)
			flyout.IsOpen = True
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)

		End Sub
	End Class
End Namespace
