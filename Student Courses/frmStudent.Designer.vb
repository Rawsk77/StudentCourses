<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblcollegesystem = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.DatDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblStudIDShow = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lblsurname = New System.Windows.Forms.Label()
        Me.lblstudentid = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtStuIDSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.lblcollegesystem)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(39, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 306)
        Me.Panel1.TabIndex = 0
        '
        'lblcollegesystem
        '
        Me.lblcollegesystem.AutoSize = True
        Me.lblcollegesystem.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcollegesystem.Location = New System.Drawing.Point(12, 11)
        Me.lblcollegesystem.Name = "lblcollegesystem"
        Me.lblcollegesystem.Size = New System.Drawing.Size(298, 30)
        Me.lblcollegesystem.TabIndex = 3
        Me.lblcollegesystem.Text = "Student Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.DatDOB)
        Me.Panel2.Controls.Add(Me.txtPostcode)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.txtSurname)
        Me.Panel2.Controls.Add(Me.lblStudIDShow)
        Me.Panel2.Controls.Add(Me.lblPostcode)
        Me.Panel2.Controls.Add(Me.lblDoB)
        Me.Panel2.Controls.Add(Me.lblfname)
        Me.Panel2.Controls.Add(Me.lblsurname)
        Me.Panel2.Controls.Add(Me.lblstudentid)
        Me.Panel2.Location = New System.Drawing.Point(12, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 243)
        Me.Panel2.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(131, 189)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(116, 32)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit and Save"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(265, 189)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 32)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(21, 189)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(94, 32)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "New..."
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'DatDOB
        '
        Me.DatDOB.Location = New System.Drawing.Point(153, 117)
        Me.DatDOB.Name = "DatDOB"
        Me.DatDOB.Size = New System.Drawing.Size(164, 22)
        Me.DatDOB.TabIndex = 11
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(153, 142)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(112, 22)
        Me.txtPostcode.TabIndex = 10
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(153, 90)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(202, 22)
        Me.txtFirstName.TabIndex = 8
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(153, 62)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(202, 22)
        Me.txtSurname.TabIndex = 7
        '
        'lblStudIDShow
        '
        Me.lblStudIDShow.AutoSize = True
        Me.lblStudIDShow.Location = New System.Drawing.Point(150, 36)
        Me.lblStudIDShow.Name = "lblStudIDShow"
        Me.lblStudIDShow.Size = New System.Drawing.Size(209, 17)
        Me.lblStudIDShow.TabIndex = 6
        Me.lblStudIDShow.Text = "<ID is automatically Generated>"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostcode.Location = New System.Drawing.Point(63, 146)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(88, 15)
        Me.lblPostcode.TabIndex = 5
        Me.lblPostcode.Text = "Postcode:"
        '
        'lblDoB
        '
        Me.lblDoB.AutoSize = True
        Me.lblDoB.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoB.Location = New System.Drawing.Point(18, 119)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(133, 15)
        Me.lblDoB.TabIndex = 4
        Me.lblDoB.Text = "Date Of Birth:"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(36, 93)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(115, 15)
        Me.lblfname.TabIndex = 3
        Me.lblfname.Text = "First Names:"
        '
        'lblsurname
        '
        Me.lblsurname.AutoSize = True
        Me.lblsurname.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsurname.Location = New System.Drawing.Point(72, 66)
        Me.lblsurname.Name = "lblsurname"
        Me.lblsurname.Size = New System.Drawing.Size(79, 15)
        Me.lblsurname.TabIndex = 2
        Me.lblsurname.Text = "Surname:"
        '
        'lblstudentid
        '
        Me.lblstudentid.AutoSize = True
        Me.lblstudentid.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentid.Location = New System.Drawing.Point(45, 38)
        Me.lblstudentid.Name = "lblstudentid"
        Me.lblstudentid.Size = New System.Drawing.Size(106, 15)
        Me.lblstudentid.TabIndex = 1
        Me.lblstudentid.Text = "Student ID:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(812, 367)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 32)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(487, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(409, 228)
        Me.Panel3.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student Details"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.btnClear)
        Me.Panel4.Controls.Add(Me.btnSearch)
        Me.Panel4.Controls.Add(Me.txtStuIDSearch)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(12, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(385, 164)
        Me.Panel4.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(267, 110)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 32)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(267, 62)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 32)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtStuIDSearch
        '
        Me.txtStuIDSearch.Location = New System.Drawing.Point(183, 27)
        Me.txtStuIDSearch.Name = "txtStuIDSearch"
        Me.txtStuIDSearch.Size = New System.Drawing.Size(112, 22)
        Me.txtStuIDSearch.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Student ID:"
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 411)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblcollegesystem As Label
    Friend WithEvents lblPostcode As Label
    Friend WithEvents lblDoB As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents lblsurname As Label
    Friend WithEvents lblstudentid As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents DatDOB As DateTimePicker
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblStudIDShow As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtStuIDSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEdit As Button
End Class
