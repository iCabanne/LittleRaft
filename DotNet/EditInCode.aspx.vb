'
' In this example, the user may elect to put a row into an alternate mode, 
' such as editing or adding, which has different contents. 
' In this scenario only 1 row may be placed into each alternate mode, but it
' would be easy to modify it to place multiple rows into the alternate mode.
' by storing the row number in an array.
'
' Mode 1 = Selected row is in mode 1 and can switch to default or otehr modes. All other rows in default mode, with mode buttons enabled.
' Mode 2 = Selected row is in mode 2 and can only switch to default. All other rows in default mode, with mode buttons enabled.
' Mode 3 = Selected row is in mode 3 and can only switch to default. All other rows in default mode, with mode buttons disabled.
' Mode 4 = Like mode 2, except that the number of columns is reduced, noted with the change of background color.
'
Partial Class EditInCode
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            '
            ' These variables indicate the rownumbers for mode switches.
            ' Row numbers are zero based, so the initial value of this is -1.
            ' Start with all rows in default mode.
            Session("nMode1Row") = -1
            Session("nMode2Row") = -1
            Session("nMode3Row") = -1
            Session("nMode4Row") = -1
        End If
        BuildEditGrid()
    End Sub
    '
    Protected Sub BuildEditGrid()
        '
        ' Create a Table and set its properties 
        Dim tbl As New Table
        tbl.CssClass = "mytable"
        '
        ' Create the row variable & row number variable
        Dim tr As New TableRow
        Dim nRowNumber As Integer = 0
        '
        ' Header Row
        tbl.Rows.Add(New TableRow)
        tr = tbl.Rows(0)
        For lnCnt = 1 To 5
            tr.Cells.Add(New TableHeaderCell)
        Next
        '
        tr.Cells(0).Text = "Text"
        tr.Cells(1).Text = "Mode 1"
        tr.Cells(2).Text = "Mode 2"
        tr.Cells(3).Text = "Mode 3"
        tr.Cells(4).Text = "Mode 4"
        '
        ' Creat a series of rows
        For nCnt = 1 To 5
            '
            ' Add a row to the table and get its number by retrieving the last row number.
            tbl.Rows.Add(New TableRow)
            nRowNumber = tbl.Rows.Count - 1
            tr = tbl.Rows(nRowNumber)
            '
            If nRowNumber = Session("nMode1Row") Then
                '
                For lnCnt = 1 To 5
                    tr.Cells.Add(New TableCell)
                Next
                '
                tr.Cells(0).Text = "In Mode 1"
                '
                Dim btn1 As New Button
                With btn1
                    .ID = "rd" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Default"
                    AddHandler .Click, AddressOf SwitchToDefault
                End With
                tr.Cells(1).Controls.Add(btn1)
                '
                Dim btn2 As New Button
                With btn2
                    .ID = "r2" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 2"
                    AddHandler .Click, AddressOf SwitchToMode2
                End With
                tr.Cells(2).Controls.Add(btn2)
                '
                Dim btn3 As New Button
                With btn3
                    .ID = "r3" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 3"
                    AddHandler .Click, AddressOf SwitchToMode3
                End With
                tr.Cells(3).Controls.Add(btn3)
                '
                Dim btn4 As New Button
                With btn4
                    .ID = "r4" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 4"
                    AddHandler .Click, AddressOf SwitchToMode4
                End With
                tr.Cells(4).Controls.Add(btn4)
                '
            ElseIf nRowNumber = Session("nMode2Row") Then
                '
                For lnCnt = 1 To 5
                    tr.Cells.Add(New TableCell)
                Next
                '
                tr.Cells(0).Text = "In Mode 2"
                '
                Dim btn1 As New Button
                With btn1
                    .ID = "dr" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Default"
                    AddHandler .Click, AddressOf SwitchToDefault
                End With
                tr.Cells(2).Controls.Add(btn1)
                '
            ElseIf nRowNumber = Session("nMode3Row") Then
                '
                For lnCnt = 1 To 5
                    tr.Cells.Add(New TableCell)
                Next
                '
                tr.Cells(0).Text = "In Mode 3"
                '
                Dim btn1 As New Button
                With btn1
                    .ID = "dr" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Default"
                    AddHandler .Click, AddressOf SwitchToDefault
                End With
                tr.Cells(3).Controls.Add(btn1)
                '
            ElseIf nRowNumber = Session("nMode4Row") Then
                '
                For lnCnt = 1 To 2
                    tr.Cells.Add(New TableCell)
                Next
                '
                tr.Cells(0).Text = "In Mode 4"
                '
                tr.Cells(1).Attributes.Add("colspan", "4")
                tr.Cells(1).CssClass = "collapsed"
                Dim btn1 As New Button
                With btn1
                    .ID = "dr" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Default"
                    AddHandler .Click, AddressOf SwitchToDefault
                End With
                tr.Cells(1).Controls.Add(btn1)
            Else
                '
                For lnCnt = 1 To 5
                    tr.Cells.Add(New TableCell)
                Next
                '
                tr.Cells(0).Text = "In Default Mode"
                Dim bEnabled = (Session("nMode3Row") = -1)
                '
                Dim btn1 As New Button
                With btn1
                    .ID = "r1" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 1"
                    .Enabled = bEnabled
                    AddHandler .Click, AddressOf SwitchToMode1
                End With
                tr.Cells(1).Controls.Add(btn1)
                '
                Dim btn2 As New Button
                With btn2
                    .ID = "r2" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 2"
                    .Enabled = bEnabled
                    AddHandler .Click, AddressOf SwitchToMode2
                End With
                tr.Cells(2).Controls.Add(btn2)
                '
                Dim btn3 As New Button
                With btn3
                    .ID = "r3" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 3"
                    .Enabled = bEnabled
                    AddHandler .Click, AddressOf SwitchToMode3
                End With
                tr.Cells(3).Controls.Add(btn3)
                '
                Dim btn4 As New Button
                With btn4
                    .ID = "r4" & Right("0000" & nRowNumber.ToString, 4)
                    .Text = "Mode 4"
                    .Enabled = bEnabled
                    AddHandler .Click, AddressOf SwitchToMode4
                End With
                tr.Cells(4).Controls.Add(btn4)
                '
            End If
        Next
        '
        ' Place the table in the placeholder.
        PlaceHolder1.Controls.Clear()
        PlaceHolder1.Controls.Add(tbl)
    End Sub
    '
    Protected Sub SwitchToDefault(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("nMode1Row") = -1
        Session("nMode2Row") = -1
        Session("nMode3Row") = -1
        Session("nMode4Row") = -1
        BuildEditGrid()
    End Sub
    '
    Protected Sub SwitchToMode1(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("nMode1Row") = CInt(Right(sender.ID, 4))
        Session("nMode2Row") = -1
        Session("nMode3Row") = -1
        Session("nMode4Row") = -1
        BuildEditGrid()
    End Sub
    '
    Protected Sub SwitchToMode2(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("nMode1Row") = -1
        Session("nMode2Row") = CInt(Right(sender.ID, 4))
        Session("nMode3Row") = -1
        Session("nMode4Row") = -1
        BuildEditGrid()
    End Sub
    '
    Protected Sub SwitchToMode3(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("nMode1Row") = -1
        Session("nMode2Row") = -1
        Session("nMode3Row") = CInt(Right(sender.ID, 4))
        Session("nMode4Row") = -1
        BuildEditGrid()
    End Sub
    '
    Protected Sub SwitchToMode4(ByVal sender As Object, ByVal e As System.EventArgs)
        Session("nMode1Row") = -1
        Session("nMode2Row") = -1
        Session("nMode3Row") = -1
        Session("nMode4Row") = CInt(Right(sender.ID, 4))
        BuildEditGrid()
    End Sub
End Class
