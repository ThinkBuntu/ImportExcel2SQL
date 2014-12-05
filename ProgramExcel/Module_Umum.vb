Option Explicit On

Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Net.Mime.MediaTypeNames


Module Module_Umum

    Public Password_Login As String = ""
    Public NIP_Login As String = ""
    Public Auth_Login As String = ""
    Public periode As String
    Public ManaYgDiklik As String

    Public database As String = "your database"
    Public Server As String = "your server"
    Public UserId As String = "your user sql"
    Public Password As String = "your password SQL"

    Public con1 = Module_Umum.koneksi
    Public reader As SqlClient.SqlDataReader
    Public sSQL As String

    Public adapter As SqlClient.SqlDataAdapter
    Public cmd As SqlClient.SqlCommand
    Public HDD_Serial As String


    Public Function OpenExecute(ByVal sSQL1 As String)
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If

        cmd = New SqlClient.SqlCommand(sSQL1)
        cmd.Connection = con1
        con1.Open()

        cmd.ExecuteNonQuery()

    End Function


    Public Function OpenRecordSet(ByVal sSQL As String)
        If con1.State = ConnectionState.Open Then
            con1.Close()
        End If

        cmd = New SqlClient.SqlCommand(sSQL)
        cmd.Connection = con1
        con1.Open()
        reader = cmd.ExecuteReader
    End Function

    Public Function koneksi() As SqlClient.SqlConnection
        Dim kon As SqlClient.SqlConnection
        'data SQL2008
        kon = New SqlClient.SqlConnection("Data Source=" & Server & ";Initial Catalog=" & database & ";Connection Timeout=0;User id=" & UserId & ";password=" & Password & ";")
        Return kon
        kon = Nothing
    End Function

    Public Sub FillListView(ByRef MyListView As ListView, ByRef myData As SqlDataReader)
        Dim lvwColumn As ColumnHeader
        Dim itmListItem As ListViewItem
        Dim strTest As String
        Dim shtCntr As Short

        MyListView.Clear()

        For shtCntr = 0 To myData.FieldCount() - 1
            lvwColumn = New ColumnHeader()
            lvwColumn.Text = myData.GetName(shtCntr)
            MyListView.Columns.Add(lvwColumn)
        Next

        Do While myData.Read
            itmListItem = New ListViewItem()
            strTest = IIf(myData.IsDBNull(0), "", myData.GetString(0))
            itmListItem.Text = strTest

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetString(shtCntr))
                End If
            Next shtCntr

            MyListView.Items.Add(itmListItem)
        Loop

        For i As Integer = 0 To MyListView.Columns.Count - 1
            MyListView.Columns(i).Width = -5
        Next i

    End Sub


    Public Sub Listview_TambahList(ByRef ListView1 As ListView, ByRef myData As SqlDataReader)
        Dim iKolom As Integer
        Dim iBaris As Integer

        ListView1.Clear()
        ListView1.View = View.Details

        iKolom = reader.FieldCount
        iBaris = 0

        For i As Integer = 0 To iKolom - 1
            ListView1.Columns.Add("", 60, HorizontalAlignment.Left)
            ListView1.Columns(i).Text = myData.GetName(i)
        Next
        Do While myData.Read
            ListView1.Items.Add(Trim(reader(0))) 'col no. 1
            For i As Integer = 1 To iKolom - 1
                ListView1.Items(iBaris).SubItems.Add(Trim(reader(i))) 'col no. 2 - Dst
            Next
            iBaris = iBaris + 1
        Loop
        For i As Integer = 0 To iKolom - 1
            ListView1.Columns(i).Width = -2
        Next
    End Sub
    Public Sub Validasi_Input(ByVal oTextBox As TextBox)
        oTextBox.Text = Replace(Replace(Replace(Trim(oTextBox.Text), "%", ""), "'", ""), """", "")
    End Sub
    Public Sub ListView_CekCentang(ByVal ListView1 As ListView, ByRef sData As String, ByVal sItem As Integer)
        Dim i As Integer
        i = 0
        sData = "('',"
        For Each item As ListViewItem In ListView1.Items
            If item.Checked Then
                sData = sData & "'" & ListView1.Items(i).SubItems(sItem).Text & "',"
            End If
            i = i + 1
        Next
        sData = sData & "'')"
    End Sub
    Public Sub Export_SQLtoExcel(ByVal sSQL As String)


        Dim cnt As New ADODB.Connection
        Dim rst As New ADODB.Recordset

        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object


        Dim recArray As Object

        Dim fldCount As Integer
        Dim recCount As Long
        Dim iCol As Integer
        Dim iRow As Integer


        ' Open connection to the database
        cnt.ConnectionString = "provider=sqloledb;server=" & Server & ";database=" & database & ";uid=" & UserId & ";password=" & Password & ""
        cnt.Open()

        ' Open recordset based on Orders table
        rst.Open(sSQL, cnt)

        ' Create an instance of Excel and add a workbook
        xlApp = CreateObject("Excel.Application")
        xlWb = xlApp.Workbooks.add
        xlWs = xlWb.Worksheets("Sheet1")

        ' Display Excel and give user control of Excel's lifetime
        xlApp.Visible = True
        xlApp.UserControl = True

        ' Copy field names to the first row of the worksheet
        fldCount = rst.Fields.Count
        For iCol = 1 To fldCount
            xlWs.Cells(1, iCol).Value = rst.Fields(iCol - 1).Name
        Next

        ' Check version of Excel
        If Val(Mid(xlApp.Version, 1, InStr(1, xlApp.Version, ".") - 1)) > 8 Then
            'EXCEL 2000,2002,2003, or 2007: Use CopyFromRecordset

            ' Copy the recordset to the worksheet, starting in cell A2
            xlWs.Cells(2, 1).CopyFromRecordset(rst)
            'Note: CopyFromRecordset will fail if the recordset
            'contains an OLE object field or array data such
            'as hierarchical recordsets

        Else
            'EXCEL 97 or earlier: Use GetRows then copy array to Excel

            ' Copy recordset to an array
            recArray = rst.GetRows
            'Note: GetRows returns a 0-based array where the first
            'dimension contains fields and the second dimension
            'contains records. We will transpose this array so that
            'the first dimension contains records, allowing the
            'data to appears properly when copied to Excel

            ' Determine number of records

            recCount = UBound(recArray, 2) + 1 '+ 1 since 0-based array


            ' Check the array for contents that are not valid when
            ' copying the array to an Excel worksheet
            For iCol = 0 To fldCount - 1
                For iRow = 0 To recCount - 1
                    ' Take care of Date fields
                    If IsDate(recArray(iCol, iRow)) Then
                        recArray(iCol, iRow) = Format(recArray(iCol, iRow))
                        ' Take care of OLE object fields or array fields
                    ElseIf IsArray(recArray(iCol, iRow)) Then
                        recArray(iCol, iRow) = "Array Field"
                    End If
                Next iRow 'next record
            Next iCol 'next field

            ' Transpose and Copy the array to the worksheet,
            ' starting in cell A2
            xlWs.Cells(2, 1).Resize(recCount, fldCount).Value = _
                TransposeDim(recArray)
        End If

        ' Auto-fit the column widths and row heights
        xlApp.Selection.CurrentRegion.Columns.AutoFit()
        xlApp.Selection.CurrentRegion.Rows.AutoFit()

        ' Close ADO objects
        rst.Close()
        cnt.Close()
        rst = Nothing
        cnt = Nothing

        ' Release Excel references
        xlWs = Nothing
        xlWb = Nothing
        xlApp = Nothing

    End Sub


    Function TransposeDim(ByVal v As Object) As Object
        ' Custom Function to Transpose a 0-based array (v)

        Dim X As Long, Y As Long, Xupper As Long, Yupper As Long
        Dim tempArray As Object

        Xupper = UBound(v, 2)
        Yupper = UBound(v, 1)

        ReDim tempArray(Xupper, Yupper)
        For X = 0 To Xupper
            For Y = 0 To Yupper
                tempArray(X, Y) = v(Y, X)
            Next Y
        Next X

        TransposeDim = tempArray
    End Function
End Module
