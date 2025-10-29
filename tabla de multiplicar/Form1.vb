Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim N As Integer

    Private Sub BORRAR_Click(sender As Object, e As EventArgs) Handles BORRAR.Click
        txt1.Text = " "
        ListBox1.Items.Clear()
    End Sub

    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        ListBox1.ClearSelected()
        N = Val(txt1.Text)
        For a As Integer = 1 To 12
            Dim resultado As String = String.Format("{0} x {1} = {2}", N, a, (N * a))
            ListBox1.Items.Add(resultado)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
