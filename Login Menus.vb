Imports MySql.Data.MySqlClient
Module GlobalVariables
    ' sets the Form's text property (title)
    Public global_nama As String
    Public global_id As String
    Public global_conn As String = "server=127.0.0.1;database=newservergac;uid=root"

End Module

Public Class Login_Menus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''create connection 
        Dim conakun As MySqlConnection = New MySqlConnection(global_conn)
        conakun.Open()
        Dim com = New MySqlCommand("SELECT nama FROM user WHERE username='" & TextBox1.Text & "'", conakun)
        Dim reader = com.ExecuteReader
        If reader.HasRows = True Then
            reader.Close()
            com = New MySqlCommand("SELECT nama,user_id FROM user WHERE password = '" & TextBox2.Text & "' AND username='" & TextBox1.Text & "'", conakun)
            reader = com.ExecuteReader
            If reader.Read Then
                global_nama = reader.GetString(0)
                global_id = reader.GetString(1)
            End If
            If reader.HasRows = True Then
                MenuUtama.Show()
                Me.Hide()
            Else
                MsgBox("Password Salah")
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("Username Salah")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""

        conakun.Close()
    End Sub


End Class
