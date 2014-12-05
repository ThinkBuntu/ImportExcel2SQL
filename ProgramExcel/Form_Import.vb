Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form_Import

    Private Sub Btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Browse.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Txt_File.Text = OpenFileDialog.FileName

        End If
    End Sub

    Private Sub Btn_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim strCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Txt_File.Text & ";Extended Properties=Excel 8.0;"
            Dim conStr As String
            Dim objConn As New System.Data.OleDb.OleDbConnection(strCon)
            Dim daSuresh As New OleDbDataAdapter("Select * From [Sheet1$]", strCon)
            Dim dsSuresh As New DataSet
            Dim dvSuresh As New DataView

            objConn.Open()
            daSuresh.Fill(dsSuresh, "Sheet1")

            dvSuresh = New DataView(dsSuresh.Tables("Sheet1"))
            GridViewExcel.DataSource = dsSuresh
            GridViewExcel.DataMember = dsSuresh.Tables("Sheet1").ToString
            objConn.Close()

    

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Information, "Peringatan : Mohon Save As File dengan Nama Sheet : Sheet1, Type File : .xls (Excel 97-2003)")

        End Try
    End Sub

    Private Sub Btn_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Import.Click
        sSQL = "If EXISTS(Select * From " + database + ".dbo.Sysobjects Where Name Like 'Import_" & Trim(Txt_NamaTabel.Text) & "') Drop Table " + database + ".dbo.Import_" & Trim(Txt_NamaTabel.Text) & "" & vbCrLf
        OpenExecute(sSQL)

        Dim ExceCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Txt_File.Text & ";Extended Properties=Excel 8.0;"
        Dim excelConnection As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection(ExceCon)
        excelConnection.Open()

        Dim OleStr As String = "SELECT * INTO [ODBC; Driver={SQL Server};Server=" + Server + ";Database=" + database + ";Uid=" + UserId + ";Pwd=" + Password + ";].[Import_" & Trim(Txt_NamaTabel.Text) & "] FROM [Sheet1$];"
        Dim excelCommand As New System.Data.OleDb.OleDbCommand(OleStr, excelConnection)
        excelCommand.ExecuteNonQuery()
        excelConnection.Close()

        MsgBox("Data Sudah Berhasil Tersimpan Di " + database + ".dbo.Import_" & Trim(Txt_NamaTabel.Text) & "")

    End Sub

    Private Sub Form_Import_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
