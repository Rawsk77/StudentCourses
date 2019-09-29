<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblcollegesystem = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.lblcoursemgmt = New System.Windows.Forms.Label()
        Me.lblstudentdetails = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.lblcollegesystem)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 426)
        Me.Panel1.TabIndex = 0
        '
        'lblcollegesystem
        '
        Me.lblcollegesystem.AutoSize = True
        Me.lblcollegesystem.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcollegesystem.Location = New System.Drawing.Point(13, 19)
        Me.lblcollegesystem.Name = "lblcollegesystem"
        Me.lblcollegesystem.Size = New System.Drawing.Size(279, 30)
        Me.lblcollegesystem.TabIndex = 2
        Me.lblcollegesystem.Text = "College System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnCourse)
        Me.Panel2.Controls.Add(Me.btnStudent)
        Me.Panel2.Controls.Add(Me.lblcoursemgmt)
        Me.Panel2.Controls.Add(Me.lblstudentdetails)
        Me.Panel2.Location = New System.Drawing.Point(3, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 357)
        Me.Panel2.TabIndex = 1
        '
        'btnCourse
        '
        Me.btnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.Location = New System.Drawing.Point(224, 104)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(33, 34)
        Me.btnCourse.TabIndex = 3
        Me.btnCourse.Text = ">"
        Me.btnCourse.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.Location = New System.Drawing.Point(224, 48)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(33, 34)
        Me.btnStudent.TabIndex = 2
        Me.btnStudent.Text = ">"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'lblcoursemgmt
        '
        Me.lblcoursemgmt.AutoSize = True
        Me.lblcoursemgmt.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursemgmt.Location = New System.Drawing.Point(11, 112)
        Me.lblcoursemgmt.Name = "lblcoursemgmt"
        Me.lblcoursemgmt.Size = New System.Drawing.Size(196, 19)
        Me.lblcoursemgmt.TabIndex = 1
        Me.lblcoursemgmt.Text = "Course Management"
        '
        'lblstudentdetails
        '
        Me.lblstudentdetails.AutoSize = True
        Me.lblstudentdetails.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentdetails.Location = New System.Drawing.Point(33, 56)
        Me.lblstudentdetails.Name = "lblstudentdetails"
        Me.lblstudentdetails.Size = New System.Drawing.Size(174, 19)
        Me.lblstudentdetails.TabIndex = 0
        Me.lblstudentdetails.Text = "Student Details"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblcollegesystem As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents lblcoursemgmt As Label
    Friend WithEvents lblstudentdetails As Label
End Class
