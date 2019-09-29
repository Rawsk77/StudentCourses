Imports System.IO


Structure Person
    Dim StudentID As Integer
    Dim FirstName, Surname, postcode As String
    Dim dateofbirth As Date
End Structure
Public Class frmStudent
    Private Sub formreload()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FrmStudent_Load(Me, Nothing) 'Load everything in your form load event aga
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim student As Person


        student.StudentID = lblStudIDShow.Text
        student.FirstName = txtFirstName.Text
        student.Surname = txtSurname.Text
        student.postcode = txtPostcode.Text
        student.dateofbirth = DatDOB.Value



        Try

            Dim write As StreamWriter
            write = New StreamWriter("student.txt", True)
            write.WriteLine(String.Format("{0},{1},{2},{3},{4}", student.StudentID, student.FirstName, student.Surname, student.dateofbirth.ToShortDateString(), student.postcode))
            write.Close()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        MessageBox.Show("Student has been saved successfully")
        formreload()

    End Sub

    Private Sub FrmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        newStudent()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Using reader As New StreamReader("Student.txt")
            Dim record As String
            Dim Students(20) As String
            Dim z As Integer = 0
            Dim found As Boolean

            Do Until reader.Peek = -1

                record = reader.ReadLine()
                Students(z) = record
                z += 1

            Loop



            Dim Stroutput As String = ""
            For count = 0 To z - 1
                Stroutput &= Students(count) & vbNewLine
            Next


            If txtStuIDSearch.Text > z Or txtStuIDSearch.Text <= 0 Then
                MessageBox.Show("Sorry there is no student with the id " & txtStuIDSearch.Text)
            Else
                Dim result As String = Array.Find(Students, Function(x) (x.StartsWith(txtStuIDSearch.Text)))

                found = False


                Dim resultarray() As String = result.Split(",")
                Dim resultlist As List(Of String) = resultarray.ToList()



                txtSurname.Text = resultlist(1)
                txtFirstName.Text = resultlist(2)
                txtPostcode.Text = resultlist(4)
                lblStudIDShow.Text = resultlist(0)

            End If


        End Using

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        newStudent()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        newStudent()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim newstring As String = ""
        Dim lines As New List(Of String)
        Using sr As New StreamReader("student.txt")
            While Not sr.EndOfStream
                lines.Add(sr.ReadLine)
            End While
        End Using
        Using sw As New StreamWriter("student.txt")
            For Each line As String In lines
                If line.Contains(lblStudIDShow.Text) Then
                    Dim student As Person


                    student.StudentID = lblStudIDShow.Text
                    student.FirstName = txtFirstName.Text
                    student.Surname = txtSurname.Text
                    student.postcode = txtPostcode.Text
                    student.dateofbirth = DatDOB.Value

                    line = line.Replace(line, String.Format("{0},{1},{2},{3},{4}", student.StudentID, student.FirstName, student.Surname, student.dateofbirth.ToShortDateString(), student.postcode))
                End If
                If newstring = "" Then
                    newstring = line
                Else
                    newstring = newstring + vbNewLine + line
                End If
            Next
            sw.WriteLine(newstring)
        End Using

    End Sub
End Class
