<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtModuleMark = New System.Windows.Forms.TextBox()
        Me.txtModuleGrade = New System.Windows.Forms.TextBox()
        Me.txtCAMark = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblModuleMark = New System.Windows.Forms.Label()
        Me.lblModuleGrade = New System.Windows.Forms.Label()
        Me.lblCAMark = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamMark = New System.Windows.Forms.TextBox()
        Me.txtQuizMark = New System.Windows.Forms.TextBox()
        Me.txtProjectMark = New System.Windows.Forms.TextBox()
        Me.txtTextMark = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCountOfF = New System.Windows.Forms.TextBox()
        Me.txtModuleAverage = New System.Windows.Forms.TextBox()
        Me.txtCountofA = New System.Windows.Forms.TextBox()
        Me.txtNumberofStudents = New System.Windows.Forms.TextBox()
        Me.lblCountofF = New System.Windows.Forms.Label()
        Me.lblModuleAverage = New System.Windows.Forms.Label()
        Me.lblCountofA = New System.Windows.Forms.Label()
        Me.lblNumberofStudents = New System.Windows.Forms.Label()
        Me.btnShowStatisitics = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.lstRecord = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.btnClearAll)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(1207, 684)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marks and Grade for individual students"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(256, 54)
        Me.txtName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(697, 53)
        Me.txtName.TabIndex = 4
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(997, 54)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(171, 54)
        Me.btnClearAll.TabIndex = 3
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(54, 60)
        Me.lblName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(132, 45)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox3.Controls.Add(Me.txtRemarks)
        Me.GroupBox3.Controls.Add(Me.txtModuleMark)
        Me.GroupBox3.Controls.Add(Me.txtModuleGrade)
        Me.GroupBox3.Controls.Add(Me.txtCAMark)
        Me.GroupBox3.Controls.Add(Me.lblRemarks)
        Me.GroupBox3.Controls.Add(Me.lblModuleMark)
        Me.GroupBox3.Controls.Add(Me.lblModuleGrade)
        Me.GroupBox3.Controls.Add(Me.lblCAMark)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 428)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(1155, 244)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Module  Result (CA:40% , Exam:60%)"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Location = New System.Drawing.Point(819, 152)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(212, 53)
        Me.txtRemarks.TabIndex = 7
        '
        'txtModuleMark
        '
        Me.txtModuleMark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtModuleMark.Location = New System.Drawing.Point(819, 58)
        Me.txtModuleMark.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtModuleMark.Name = "txtModuleMark"
        Me.txtModuleMark.Size = New System.Drawing.Size(212, 53)
        Me.txtModuleMark.TabIndex = 6
        '
        'txtModuleGrade
        '
        Me.txtModuleGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtModuleGrade.Location = New System.Drawing.Point(303, 158)
        Me.txtModuleGrade.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtModuleGrade.Name = "txtModuleGrade"
        Me.txtModuleGrade.Size = New System.Drawing.Size(212, 53)
        Me.txtModuleGrade.TabIndex = 5
        '
        'txtCAMark
        '
        Me.txtCAMark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCAMark.Location = New System.Drawing.Point(301, 58)
        Me.txtCAMark.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCAMark.Name = "txtCAMark"
        Me.txtCAMark.Size = New System.Drawing.Size(212, 53)
        Me.txtCAMark.TabIndex = 4
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(613, 164)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(174, 45)
        Me.lblRemarks.TabIndex = 3
        Me.lblRemarks.Text = "Remarks"
        '
        'lblModuleMark
        '
        Me.lblModuleMark.AutoSize = True
        Me.lblModuleMark.Location = New System.Drawing.Point(531, 70)
        Me.lblModuleMark.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblModuleMark.Name = "lblModuleMark"
        Me.lblModuleMark.Size = New System.Drawing.Size(263, 45)
        Me.lblModuleMark.TabIndex = 2
        Me.lblModuleMark.Text = "Module Marks"
        '
        'lblModuleGrade
        '
        Me.lblModuleGrade.AutoSize = True
        Me.lblModuleGrade.Location = New System.Drawing.Point(4, 158)
        Me.lblModuleGrade.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblModuleGrade.Name = "lblModuleGrade"
        Me.lblModuleGrade.Size = New System.Drawing.Size(261, 45)
        Me.lblModuleGrade.TabIndex = 1
        Me.lblModuleGrade.Text = "Module Grade"
        '
        'lblCAMark
        '
        Me.lblCAMark.AutoSize = True
        Me.lblCAMark.Location = New System.Drawing.Point(87, 70)
        Me.lblCAMark.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCAMark.Name = "lblCAMark"
        Me.lblCAMark.Size = New System.Drawing.Size(188, 45)
        Me.lblCAMark.TabIndex = 0
        Me.lblCAMark.Text = "CA Marks"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnComfirm)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtExamMark)
        Me.GroupBox2.Controls.Add(Me.txtQuizMark)
        Me.GroupBox2.Controls.Add(Me.txtProjectMark)
        Me.GroupBox2.Controls.Add(Me.txtTextMark)
        Me.GroupBox2.Controls.Add(Me.lblText)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 142)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(1155, 276)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input CA and Exam Marks"
        '
        'btnComfirm
        '
        Me.btnComfirm.Location = New System.Drawing.Point(925, 144)
        Me.btnComfirm.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(217, 84)
        Me.btnComfirm.TabIndex = 9
        Me.btnComfirm.Text = "Comfirm"
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(505, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 45)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Exam:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 45)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quizzes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(865, 45)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CA Components:Text:50%,Quiz:20%,Project:30%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Project:"
        '
        'txtExamMark
        '
        Me.txtExamMark.Location = New System.Drawing.Point(659, 182)
        Me.txtExamMark.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtExamMark.Name = "txtExamMark"
        Me.txtExamMark.Size = New System.Drawing.Size(186, 53)
        Me.txtExamMark.TabIndex = 4
        '
        'txtQuizMark
        '
        Me.txtQuizMark.Location = New System.Drawing.Point(659, 108)
        Me.txtQuizMark.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtQuizMark.Name = "txtQuizMark"
        Me.txtQuizMark.Size = New System.Drawing.Size(186, 53)
        Me.txtQuizMark.TabIndex = 3
        '
        'txtProjectMark
        '
        Me.txtProjectMark.Location = New System.Drawing.Point(206, 178)
        Me.txtProjectMark.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtProjectMark.Name = "txtProjectMark"
        Me.txtProjectMark.Size = New System.Drawing.Size(242, 53)
        Me.txtProjectMark.TabIndex = 2
        '
        'txtTextMark
        '
        Me.txtTextMark.Location = New System.Drawing.Point(206, 108)
        Me.txtTextMark.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtTextMark.Name = "txtTextMark"
        Me.txtTextMark.Size = New System.Drawing.Size(242, 53)
        Me.txtTextMark.TabIndex = 1
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(30, 114)
        Me.lblText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(107, 45)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Text:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtCountOfF)
        Me.GroupBox4.Controls.Add(Me.txtModuleAverage)
        Me.GroupBox4.Controls.Add(Me.txtCountofA)
        Me.GroupBox4.Controls.Add(Me.txtNumberofStudents)
        Me.GroupBox4.Controls.Add(Me.lblCountofF)
        Me.GroupBox4.Controls.Add(Me.lblModuleAverage)
        Me.GroupBox4.Controls.Add(Me.lblCountofA)
        Me.GroupBox4.Controls.Add(Me.lblNumberofStudents)
        Me.GroupBox4.Controls.Add(Me.btnShowStatisitics)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(39, 716)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox4.Size = New System.Drawing.Size(1194, 246)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Module statistics"
        '
        'txtCountOfF
        '
        Me.txtCountOfF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCountOfF.Location = New System.Drawing.Point(852, 156)
        Me.txtCountOfF.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCountOfF.Name = "txtCountOfF"
        Me.txtCountOfF.Size = New System.Drawing.Size(212, 53)
        Me.txtCountOfF.TabIndex = 8
        '
        'txtModuleAverage
        '
        Me.txtModuleAverage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtModuleAverage.Location = New System.Drawing.Point(852, 80)
        Me.txtModuleAverage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtModuleAverage.Name = "txtModuleAverage"
        Me.txtModuleAverage.Size = New System.Drawing.Size(212, 53)
        Me.txtModuleAverage.TabIndex = 7
        '
        'txtCountofA
        '
        Me.txtCountofA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCountofA.Location = New System.Drawing.Point(303, 156)
        Me.txtCountofA.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCountofA.Name = "txtCountofA"
        Me.txtCountofA.Size = New System.Drawing.Size(212, 53)
        Me.txtCountofA.TabIndex = 6
        '
        'txtNumberofStudents
        '
        Me.txtNumberofStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumberofStudents.Location = New System.Drawing.Point(425, 72)
        Me.txtNumberofStudents.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtNumberofStudents.Name = "txtNumberofStudents"
        Me.txtNumberofStudents.Size = New System.Drawing.Size(89, 53)
        Me.txtNumberofStudents.TabIndex = 5
        '
        'lblCountofF
        '
        Me.lblCountofF.AutoSize = True
        Me.lblCountofF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCountofF.Location = New System.Drawing.Point(602, 162)
        Me.lblCountofF.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCountofF.Name = "lblCountofF"
        Me.lblCountofF.Size = New System.Drawing.Size(200, 45)
        Me.lblCountofF.TabIndex = 4
        Me.lblCountofF.Text = "Count of F"
        '
        'lblModuleAverage
        '
        Me.lblModuleAverage.AutoSize = True
        Me.lblModuleAverage.Location = New System.Drawing.Point(531, 84)
        Me.lblModuleAverage.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblModuleAverage.Name = "lblModuleAverage"
        Me.lblModuleAverage.Size = New System.Drawing.Size(288, 45)
        Me.lblModuleAverage.TabIndex = 3
        Me.lblModuleAverage.Text = "ModuleAverage"
        '
        'lblCountofA
        '
        Me.lblCountofA.AutoSize = True
        Me.lblCountofA.Location = New System.Drawing.Point(35, 162)
        Me.lblCountofA.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCountofA.Name = "lblCountofA"
        Me.lblCountofA.Size = New System.Drawing.Size(204, 45)
        Me.lblCountofA.TabIndex = 2
        Me.lblCountofA.Text = "Count of A"
        '
        'lblNumberofStudents
        '
        Me.lblNumberofStudents.AutoSize = True
        Me.lblNumberofStudents.Location = New System.Drawing.Point(4, 80)
        Me.lblNumberofStudents.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblNumberofStudents.Name = "lblNumberofStudents"
        Me.lblNumberofStudents.Size = New System.Drawing.Size(368, 45)
        Me.lblNumberofStudents.TabIndex = 1
        Me.lblNumberofStudents.Text = "Number of Students"
        '
        'btnShowStatisitics
        '
        Me.btnShowStatisitics.Location = New System.Drawing.Point(540, 12)
        Me.btnShowStatisitics.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnShowStatisitics.Name = "btnShowStatisitics"
        Me.btnShowStatisitics.Size = New System.Drawing.Size(310, 66)
        Me.btnShowStatisitics.TabIndex = 0
        Me.btnShowStatisitics.Text = "Show Statisitics"
        Me.btnShowStatisitics.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.btnFind)
        Me.GroupBox5.Controls.Add(Me.txtFind)
        Me.GroupBox5.Controls.Add(Me.lstRecord)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(1270, 22)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox5.Size = New System.Drawing.Size(574, 940)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Students Record"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(399, 846)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(163, 54)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(39, 850)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(340, 53)
        Me.txtFind.TabIndex = 1
        '
        'lstRecord
        '
        Me.lstRecord.FormattingEnabled = True
        Me.lstRecord.ItemHeight = 45
        Me.lstRecord.Location = New System.Drawing.Point(39, 48)
        Me.lstRecord.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstRecord.Name = "lstRecord"
        Me.lstRecord.Size = New System.Drawing.Size(494, 724)
        Me.lstRecord.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1870, 984)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lstRecord As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClearAll As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExamMark As TextBox
    Friend WithEvents txtQuizMark As TextBox
    Friend WithEvents txtProjectMark As TextBox
    Friend WithEvents txtTextMark As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents btnComfirm As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtModuleMark As TextBox
    Friend WithEvents txtModuleGrade As TextBox
    Friend WithEvents txtCAMark As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblModuleMark As Label
    Friend WithEvents lblModuleGrade As Label
    Friend WithEvents lblCAMark As Label
    Friend WithEvents txtCountOfF As TextBox
    Friend WithEvents txtModuleAverage As TextBox
    Friend WithEvents txtCountofA As TextBox
    Friend WithEvents txtNumberofStudents As TextBox
    Friend WithEvents lblCountofF As Label
    Friend WithEvents lblModuleAverage As Label
    Friend WithEvents lblCountofA As Label
    Friend WithEvents lblNumberofStudents As Label
    Friend WithEvents btnShowStatisitics As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents txtFind As TextBox
End Class
