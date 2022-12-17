Imports System.Windows
Imports System.Windows.Controls

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.flyout.IsOpen = False
            Me.flyout.PlacementTarget = TryCast(sender, UIElement)
            Me.flyout.IsOpen = True
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        End Sub
    End Class
End Namespace
