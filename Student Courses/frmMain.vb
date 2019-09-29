Public Class frmMain
    Private Sub BtnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        frmStudent.Show()
        Me.Close()
    End Sub

    Private Sub BtnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        frmCourse.Show()
        Me.Close()
    End Sub
End Class