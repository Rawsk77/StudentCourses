<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtHead = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblheadofcourse = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.lblcollegesystem)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(29, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 291)
        Me.Panel1.TabIndex = 1
        '
        'lblcollegesystem
        '
        Me.lblcollegesystem.AutoSize = True
        Me.lblcollegesystem.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcollegesystem.Location = New System.Drawing.Point(3, 17)
        Me.lblcollegesystem.Name = "lblcollegesystem"
        Me.lblcollegesystem.Size = New System.Drawing.Size(355, 30)
        Me.lblcollegesystem.TabIndex = 2
        Me.lblcollegesystem.Text = "Course Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.txtHead)
        Me.Panel2.Controls.Add(Me.txtCourse)
        Me.Panel2.Controls.Add(Me.lblheadofcourse)
        Me.Panel2.Controls.Add(Me.lblcourse)
        Me.Panel2.Location = New System.Drawing.Point(3, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 222)
        Me.Panel2.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(416, 166)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 32)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(304, 166)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(94, 32)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New..."
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtHead
        '
        Me.txtHead.Location = New System.Drawing.Point(204, 57)
        Me.txtHead.Name = "txtHead"
        Me.txtHead.Size = New System.Drawing.Size(258, 22)
        Me.txtHead.TabIndex = 3
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(204, 23)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(258, 22)
        Me.txtCourse.TabIndex = 2
        '
        'lblheadofcourse
        '
        Me.lblheadofcourse.AutoSize = True
        Me.lblheadofcourse.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheadofcourse.Location = New System.Drawing.Point(17, 59)
        Me.lblheadofcourse.Name = "lblheadofcourse"
        Me.lblheadofcourse.Size = New System.Drawing.Size(174, 19)
        Me.lblheadofcourse.TabIndex = 1
        Me.lblheadofcourse.Text = "Head Of Course:"
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.Location = New System.Drawing.Point(105, 26)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(86, 19)
        Me.lblcourse.TabIndex = 0
        Me.lblcourse.Text = "Course:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(473, 313)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 32)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 357)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblcollegesystem As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtHead As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblheadofcourse As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClose As Button
End Class
