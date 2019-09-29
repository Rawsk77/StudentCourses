Module ModMain
    Public Sub newStudent()

        Dim FileName As String = IO.Path.Combine(Application.StartupPath, "student.txt")
        If IO.File.Exists(FileName) Then
            Dim text As String = System.IO.File.ReadAllText("student.txt")
            If text.Length = 0 Then
                frmStudent.lblStudIDShow.Text = 1
            Else
                Dim Lines = IO.File.ReadAllLines(FileName)
                Dim LastLine = Lines.Last
                If Not String.IsNullOrWhiteSpace(LastLine) Then
                    Dim tm As String() = LastLine.Split(",")
                    frmStudent.lblStudIDShow.Text = tm(0) + 1
                End If
            End If

            frmStudent.txtFirstName.Text = ""
            frmStudent.txtSurname.Text = ""
            frmStudent.txtPostcode.Text = ""
            frmStudent.DatDOB.Value = Date.Now
            frmStudent.txtStuIDSearch.Text = ""

        End If
    End Sub
End Module
