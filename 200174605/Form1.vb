Public Class form1
    ' create arraylist to array the value
    Dim CountAF As ArrayList = New ArrayList()
    Dim avg As ArrayList = New ArrayList()
    Dim FindName As ArrayList = New ArrayList()

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        'clear all value of  textbox,arraylist and listbox
        CountAF.Clear()
        FindName.Clear()
        avg.Clear()
        lstRecord.Items.Clear()
        txtName.Clear()
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
        txtFind.Clear()
    End Sub

    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        'check the entry value are resonable
        If txtName.Text.Trim.Length = 0 Then
            MessageBox.Show("Please input the Name")
            Return
        End If
        If Not IsNumeric(txtTextMark.Text) Or Not IsNumeric(txtQuizMark.Text) Or Not IsNumeric(txtProjectMark.Text) Or Not IsNumeric(txtExamMark.Text) Then
            MessageBox.Show("Please input the Number")
            Return
        ElseIf txtTextMark.Text > 100 Or txtQuizMark.Text > 100 Or txtProjectMark.Text > 100 Or txtExamMark.Text > 100 Then
            MessageBox.Show("Mark must be smaller than or not equal to 100")
            Return
        ElseIf txtTextMark.Text < 0 Or txtQuizMark.Text < 0 Or txtProjectMark.Text < 0 Or txtExamMark.Text < 0 Then
            MessageBox.Show("Mark must be must bigger than or not equal to 0")
            Return
        End If
        'declare and calculate the input value
        Dim Test As Double = CDbl(txtTextMark.Text)
        Dim Quizzes As Double = CDbl(txtQuizMark.Text)
        Dim Project As Double = CDbl(txtProjectMark.Text)
        Dim Exam As Double = CDbl(txtExamMark.Text)
        Dim CA_Mark As Double = Test * 0.5 + Quizzes * 0.2 + Project * 0.3
        txtCAMark.Text = CStr(CA_Mark)
        Dim Module_Mark As Double = CA_Mark * 0.4 + Exam * 0.6
        txtModuleMark.Text = CStr(Module_Mark)

        ' calculate the module grade
        Dim G As String = " "
        If CA_Mark < 40 And Exam < 40 Then
            G = "F"
        ElseIf Module_Mark >= 75 And Module_Mark <= 100 Then
            G = "A"
        ElseIf Module_Mark >= 65 Then
            G = "B"
        ElseIf Module_Mark >= 40 Then
            G = "C"
        End If
        txtModuleGrade.Text = G
        'select case of remarks
        Select Case G
            Case "A"
                txtRemarks.Text = "Pass"
            Case "B"
                txtRemarks.Text = "Pass"
            Case "C"
                txtRemarks.Text = "Pass"
            Case "F"
                If Module_Mark >= 30 Then
                    txtRemarks.Text = "Resit Exam"
                Else
                    txtRemarks.Text = "Restudy"
                End If
        End Select
        'add then name to listbox
        'Make sure that the record will not be found due to uppercase/lowercase/space
        lstRecord.Items.Add(txtName.Text.Trim.ToUpper)
        'add the calculated value into arraylist
        FindName.Add(txtName.Text.Trim.ToUpper)
        avg.Add(Module_Mark)
        CountAF.Add(G)
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'using arraylist method to find name
        Dim name As String = "name"
        For Each item As String In FindName
            If txtFind.Text.Trim.ToUpper = item Then
                Name = txtFind.Text.Trim.ToUpper
                Exit For
            End If
        Next
        If Name <> "name" Then
            MessageBox.Show(Name & " is on line" & CStr(FindName.IndexOf(Name) + 1) & " of the list")
        Else
            MessageBox.Show("student not found")
        End If
        '#alternative method of find name
        '  Dim i As Integer
        ' Dim n As Integer = -1
        ' Dim keyword As String = txtFind.Text.Trim.ToUpper
        'For i = 0 To lstRecord.Items.Count - 1 Step 1
        'If CStr(lstRecord.Items(i)) = keyword Then
        'n = i + 1
        'Select Case keyword
        'Case keyword
        'MessageBox.Show(keyword & " is on line" & i + 1 & " of the list")
        'End Select
        'End If
        'Next
        'If n = -1 Then
        ' MessageBox.Show("student not found")
        ' End If
    End Sub
    Private Sub btnShowStatisitics_Click(sender As Object, e As EventArgs) Handles btnShowStatisitics.Click
        'show and calculate all the record of module statistics
        'using arrylist method to calculate the count of A/F
        Dim countOfA As Integer = 0
        Dim countOfF As Integer = 0
        For Each item As String In CountAF
            If (item = "A") Then
                countOfA += 1
            ElseIf (item = "F") Then
                countOfF += 1
            End If
        Next
        txtCountofA.Text = countOfA
        txtCountOfF.Text = countOfF
        Dim sum As Double = 0.0
        'using arrylist method to calculate the average mark
        For Each item As Double In avg
            sum += item
        Next
        If lstRecord.Items.Count > 0 Then
            sum /= avg.Count
            txtModuleAverage.Text = sum
        Else
            txtModuleAverage.Text = 0
        End If
        txtNumberofStudents.Text = lstRecord.Items.Count
    End Sub
End Class