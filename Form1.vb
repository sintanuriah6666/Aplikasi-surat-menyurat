Imports System.Data.OleDb
Public Class Form1
    Dim Conn As New OleDb.OleDbConnection
    Dim dbProvider As String = "Provider = Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source = db_reglogin.accdb;"
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet

    Private Sub Btnsignup_Click(sender As System.Object, e As System.EventArgs) Handles Btnsignup.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Conn.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub Btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles Btnlogin.Click
        Ds = New DataSet
        Da = New OleDbDataAdapter("SELECT * FROM [tbl_account] WHERE [username] = '" & TxtUser.Text &
                                  "' AND [password] = '" & TxtPass.Text & "'", Conn)
        Da.Fill(Ds, "tbl_account")
        If Ds.Tables("tbl_account").Rows.Count > 0 Then
            MsgBox("Login Success!", MsgBoxStyle.MsgBoxRight, "Informasi")
            TxtUser.Clear()
            TxtPass.Clear()
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Username and Password is wrong!", MsgBoxStyle.Critical, "Informasi")
            TxtUser.Clear()
            TxtPass.Clear()
        End If
    End Sub
End Class