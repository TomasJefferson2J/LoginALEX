Imports System.Security.Principal

Public Class Form1
    Dim Edad As Double
    Dim Consulta As Integer



    Private Sub TextNombre_TextChanged(sender As Object, e As EventArgs) Handles TextNombre.TextChanged

    End Sub

    Private Sub TextDNI_TextChanged(sender As Object, e As EventArgs) Handles TextDNI.TextChanged

    End Sub

    Private Sub TextEdad_TextChanged(sender As Object, e As EventArgs) Handles TextEdad.TextChanged

    End Sub
    holA


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Operar()
        If Edad >= 18 Then
            MessageBox.Show("Cantidad de Sufragios: " & Consulta, "¡GRACIAS!")
        ElseIf Edad < 18 Then
            MessageBox.Show("¡Usted aun no tiene edad para sufragar!", "¡GRACIAS!")
        End If
    End Sub

    Private Sub TextDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextDNI.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("¡Ingrese los 8 dígitos de su DNI!")
        End If
    End Sub

    Private Sub TextEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEdad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("¡Ingrese su edad solo en números!")
        End If
    End Sub
    Public Sub Operar()
        Edad = Val(TextEdad.Text)
        Consulta = ((Edad - 19) / 4) + 1
    End Sub
End Class
