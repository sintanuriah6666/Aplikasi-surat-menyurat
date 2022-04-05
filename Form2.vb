Imports System.Data.OleDb
Public Class Form2
    Dim Conn As New OleDb.OleDbConnection
    Dim dbProvider As String = "Provider = Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source = db_reglogin.accdb;"
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Conn.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub Btnregister_Click(sender As System.Object, e As System.EventArgs) Handles Btnregister.Click
        Ds = New DataSet
        Da = New OleDbDataAdapter("INSERT INTO [tbl_account] ([username], [password], [Full Name], [Position]) VALUES " &
                                  "('" & TxtUser.Text & "','" & TxtPass.Text & "','" & Txtname.Text & "','" & TxtPosition.Text & "')", Conn)
        Da.Fill(Ds, "tbl_account")
        TxtUser.Text = " "
        TxtPass.Text = " "
        Txtname.Text = " "
        TxtPosition.Text = " "
        MsgBox("User Terdaftar!")
    End Sub

    Private Sub Btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles Btnlogin.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
