
Partial Class DrawDesign_DrawDesign
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        BuildDraw()
    End Sub
    Protected Sub BuildDraw()
        Dim tbl As New HtmlTable
        Dim nRow As Integer = 0
        Dim nCell As Integer = 0
        Dim ntxtnum As Integer = 0
        Dim sClass As String = ""
        With tbl
            For nRowCnt As Integer = 0 To 63
                .Rows.Add(New HtmlTableRow)
                nRow = .Rows.Count - 1
                With .Rows(nRow)
                    For nCellCnt As Integer = 0 To 20
                        .Cells.Add(New HtmlTableCell)
                        nCell = .Cells.Count - 1
                        With .Cells(nCell)
                            If nCell = 0 Then
                                .InnerText = IIf(((nRow + 1) / 2) = Int((nRow + 1) / 2), _
                                                 ((nRow + 1) / 2).ToString, _
                                                 ".")
                            Else
                                '.InnerText = (Int((nCell - 1) / 4)).ToString
                                '.InnerText = Int((nRow + 7) / 16)
                            End If
                            If nRow > 0 Then
                                sClass = ""
                                '
                                ' Border bottom & round
                                If nCell < 5 Then
                                    If ((nRow + 0) / 2) <> Int((nRow + 0) / 2) Then
                                        sClass = sClass & "bb r" & Int((nCell + 3) / 4).ToString
                                    End If
                                    If ((nRow + 0) / 2) <> Int((nRow + 0) / 2) Then
                                    End If
                                ElseIf nCell < 9 Then
                                    If ((nRow + 2) / 4) = Int((nRow + 2) / 4) Then
                                        sClass = sClass & "bb r" & Int((nCell + 3) / 4).ToString
                                    End If
                                    If ((nRow + 2) / 4) = Int((nRow + 2) / 4) Then
                                    End If
                                ElseIf nCell < 13 Then
                                    If ((nRow + 4) / 8) = Int((nRow + 4) / 8) Then
                                        sClass = sClass & "bb r" & Int((nCell + 3) / 4).ToString
                                    End If
                                    If ((nRow + 4) / 8) = Int((nRow + 4) / 8) Then
                                    End If
                                ElseIf nCell < 17 Then
                                    If ((nRow + 8) / 16) = Int((nRow + 8) / 16) Then
                                        sClass = sClass & "bb r" & Int((nCell + 3) / 4).ToString & " "
                                    End If
                                ElseIf nCell < 21 Then
                                    If ((nRow + 16) / 32) = Int((nRow + 16) / 32) Then
                                        sClass = sClass & "bb r" & Int((nCell + 3) / 4).ToString & " "
                                    End If
                                End If
                                '
                                ' Border Right
                                If ((nCell / 4) = Int(nCell / 4)) Then
                                    If Int(nCell / 4) = 1 Then
                                        If ((Int((nRow + 0) / 2)) / 2) <> Int((Int((nRow + 0) / 2)) / 2) Then
                                            sClass = sClass & " br"
                                        End If
                                    ElseIf Int(nCell / 4) = 2 Then
                                        If ((Int((nRow + 1) / 4)) / 2) <> Int((Int((nRow + 1) / 4)) / 2) Then
                                            sClass = sClass & " br"
                                        End If
                                    ElseIf Int(nCell / 4) = 3 Then
                                        If ((Int((nRow + 3) / 8)) / 2) <> Int((Int((nRow + 3) / 8)) / 2) Then
                                            sClass = sClass & " br"
                                        End If
                                    ElseIf Int(nCell / 4) = 4 Then
                                        If ((Int((nRow + 7) / 16)) / 2) <> Int((Int((nRow + 7) / 16)) / 2) Then
                                            sClass = sClass & " br"
                                        End If
                                    ElseIf Int(nCell / 4) = 5 Then
                                        If ((Int((nRow + 15) / 32)) / 2) <> Int((Int((nRow + 15) / 32)) / 2) Then
                                            sClass = sClass & " br"
                                        End If
                                    End If
                                End If
                                '
                                sClass = Trim(sClass)
                                If Len(sClass) > 0 Then
                                    .Attributes.Add("class", sClass)
                                End If
                            End If
                        End With
                    Next
                End With
            Next
        End With
        phDraw.Controls.Add(tbl)
    End Sub
End Class
