Imports System.IO
Public Class frmCourse

    Dim TempCourseID As Integer

    Structure Course
        Dim CourseID As Integer
        Dim CourseTitle, HeadOfCourse As String
    End Structure

    Private Sub formreload()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FrmCourse_Load(Me, Nothing) 'Load everything in your form load event aga
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim AddCourse As Course

        MessageBox.Show(TempCourseID)
        AddCourse.CourseID = TempCourseID
        AddCourse.CourseTitle = txtCourse.Text
        AddCourse.HeadOfCourse = txtHead.Text



        Try

            Dim write As StreamWriter
            write = New StreamWriter("Course.txt", True)
            write.WriteLine(String.Format("{0},{1},{2}", AddCourse.CourseID, AddCourse.CourseTitle, AddCourse.HeadOfCourse))
            write.Close()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        MessageBox.Show("Course has been saved successfully")
        formreload()

    End Sub


    Private Sub FrmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileName As String = IO.Path.Combine(Application.StartupPath, "Course.txt")
        If IO.File.Exists(FileName) Then
            Dim text As String = System.IO.File.ReadAllText("Course.txt")
            If text.Length = 0 Then
                TempCourseID = 1
            Else
                Dim Lines = IO.File.ReadAllLines(FileName)
                Dim LastLine = Lines.Last
                If Not String.IsNullOrWhiteSpace(LastLine) Then
                    Dim tm As String() = LastLine.Split(",")
                    TempCourseID = tm(0) + 1
                End If
            End If

        End If
    End Sub



End Class