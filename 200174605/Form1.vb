Public Class Form1

    Dim marks As ArrayList = New ArrayList()
    Dim avg As ArrayList = New ArrayList()

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtName.Clear()
        lstRecord.Items.Clear()
        marks.Clear()
        avg.Clear()
        txtTextMark.Clear()
        txtQuizMark.Clear()
        txtProjectMark.Clear()
        txtExamMark.Clear()
        txtCAMark.Clear()
        txtModuleMark.Clear()
        txtModuleGrade.Clear()
        txtRemarks.Clear()
        txtNumberofStudents.Clear()
        txtModuleAverage.Clear()
        txtCountofA.Clear()
        txtCountOfF.Clear()
    End Sub

    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If Not IsNumeric(txtTextMark.Text) Or Not IsNumeric(txtQuizMark.Text) Or Not IsNumeric(txtProjectMark.Text) Or Not IsNumeric(txtExamMark.Text) Then
            MessageBox.Show("Error")
            Return
        ElseIf (txtTextMark.Text Or txtQuizMark.Text Or txtProjectMark.Text Or txtExamMark.Text) > 100 Then
            MessageBox.Show("Error")
            Return
        ElseIf (txtTextMark.Text Or txtQuizMark.Text Or txtProjectMark.Text Or txtExamMark.Text) < 0 Then
            MessageBox.Show("Error")
            Return
        End If
        Dim Test As Double = CDbl(txtTextMark.Text)
        Dim Quizzes As Double = CDbl(txtQuizMark.Text)
        Dim Project As Double = CDbl(txtProjectMark.Text)
        Dim Exam As Double = CDbl(txtExamMark.Text)
        Dim CA_Mark As Double = Test * 0.5 + Quizzes * 0.2 + Project * 0.3


        txtCAMark.Text = CStr(CA_Mark)
        Dim Module_Mark As Double = CA_Mark * 0.4 + Exam * 0.6
        avg.Add(Module_Mark)
        txtModuleMark.Text = CStr(Module_Mark)
        Dim G As String = " "
        If CA_Mark < 40 And Exam < 40 Then
            G = "F"
        ElseIf Module_Mark >= 75 And Module_Mark <= 100 Then
            G = "A"
        ElseIf Module_Mark > 75 And Module_Mark <= 65 Then
            G = "B"
        ElseIf Module_Mark < 65 And Module_Mark >= 40 Then
            G = "C"
        End If
        marks.Add(G)
        txtModuleGrade.Text = G
        If G = "A" And G = "B" And G = "C" Then
            txtRemarks.Text = "Pass"
        ElseIf G = "F" And Module_Mark < 30 Then
            txtRemarks.Text = "Restudy"
        ElseIf G = "F" And Module_Mark >= 30 Then
            txtRemarks.Text = "Resit Exam"
        End If
        lstRecord.Items.Add(txtName.Text)
        check()

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim i As Integer
        Dim n As Integer = -1

        Dim keyword As String = txtFind.Text
        For i = 0 To lstRecord.Items.Count - 1 Step 1
            If CStr(lstRecord.Items(i)) = keyword Then
                n = i + 1
                Select Case keyword
                    Case keyword
                        MessageBox.Show(txtFind.Text & " is on line" & i + 1 & " of the list")

                End Select
            End If
        Next
        If n = -1 Then
            MessageBox.Show("student not found")
        End If
    End Sub

    Public Sub check()
        Dim countOfA As Integer = 0
        Dim countOfF As Integer = 0
        For Each item As String In marks
            If (item = "A") Then
                countOfA += 1
            ElseIf (item = "F") Then
                countOfF += 1
            End If
        Next
        txtCountofA.Text = countOfA
        txtCountOfF.Text = countOfF
        Dim sum As Double = 0.0
        For Each item As Double In avg
            sum += item
        Next
        sum /= avg.Count
        txtModuleAverage.Text = sum

    End Sub



    Private Sub btnShowStatisitics_Click(sender As Object, e As EventArgs) Handles btnShowStatisitics.Click

        check()

        txtNumberofStudents.Text = lstRecord.Items.Count

    End Sub
End Class
