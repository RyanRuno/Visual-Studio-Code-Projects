'Solution Name:        ProjJuarez Solution
'Project Name:         ClassAnalysis Project
'Programmer Name:      Ryan Rodriguez
'Date Created:         11/11/23
'Project Description:  Display the grades of the class based on 
Public Class frmMain
    ' Arrays for names, letter grades, and numerical grades
    Dim names() As String = {"Helen", "Peter", "Yolanda", "Carl", "Jennifer", "Charles", "Addison", "Aiden", "Treyson", "Sydney", "Jacob", "Nancy", "George", "Ursula", "Jack"}
    Dim letterGrades() As String = {"A", "B", "B", "A", "D", "F", "A", "B", "A", "B", "F", "C", "C", "B", "D"}
    Dim numericalGrades() As Integer = {93, 87, 83, 91, 66, 57, 95, 81, 92, 85, 55, 73, 77, 82, 63}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoArrays()
        DisplayInitialData()
    End Sub

    Private Sub GradesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradesListBox.SelectedIndexChanged
        ' Clear the gradelist when an index is changed.
        ClearListBoxesAndLabels()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display the grades and average when button is clicked.
        DisplaySelectedGrades()
    End Sub

    Private Sub btnClassStatistics_Click(sender As Object, e As EventArgs) Handles btnClassStatistics.Click
        ' Display Class Statistics when button is clicked.
        DisplayClassStats()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close application when button is clicked.
        ExitApplication()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Form closing.
        ConfirmExit(e)
    End Sub

    Private Sub LoadDataIntoArrays()
        ' Load data into arrays as needed
    End Sub

    Private Sub DisplayInitialData()
        ' Populate grades list box with unique letter grades
        Dim uniqueGrades = letterGrades.Distinct().OrderBy(Function(grade) grade)
        GradesListBox.Items.AddRange(uniqueGrades.ToArray())

        ' Set default selection to index 0
        GradesListBox.SelectedIndex = 0
    End Sub

    Private Sub ClearListBoxesAndLabels()
        ' Clear list boxes and labels as needed
        StudentsListBox.Items.Clear()
        lblStudentNum.Text = ""
        lblAverage.Text = ""
        lblAverageLetter.Text = ""
    End Sub

    Private Sub DisplaySelectedGrades()
        ' Clear previous data
        ClearListBoxesAndLabels()

        ' Get the selected letter grade
        Dim selectedGrade As String = GradesListBox.SelectedItem.ToString()

        ' Display students, count, and average for the selected grade
        For i As Integer = 0 To letterGrades.Length - 1
            If letterGrades(i) = selectedGrade Then
                StudentsListBox.Items.Add(names(i))
            End If
        Next

        ' Sort the StudentsListBox
        StudentsListBox.Sorted = True

        ' Display the number of students
        lblStudentNum.Text = StudentsListBox.Items.Count.ToString()

        ' Display the average grade for the selected letter grade
        Dim averageGrade As Double = CalculateAverageGrade(selectedGrade)
        lblAverage.Text = averageGrade.ToString("F2")

        ' Display the average letter grade for the selected grade
        lblAverageLetter.Text = ConvertToLetterGrade(averageGrade)
    End Sub

    Private Function ConvertToLetterGrade(grade As Double) As String
        If grade >= 90 Then
            Return "Average A:"
        ElseIf grade >= 80 Then
            Return "Average B:"
        ElseIf grade >= 70 Then
            Return "Average C:"
        ElseIf grade >= 60 Then
            Return "Average D:"
        Else
            Return "Average F:"
        End If
    End Function

    Private Function CalculateAverageGrade(selectedGrade As String) As Double
        Dim totalGrade As Integer = 0
        Dim count As Integer = 0

        For i As Integer = 0 To letterGrades.Length - 1
            If letterGrades(i) = selectedGrade Then
                totalGrade += numericalGrades(i)
                count += 1
            End If
        Next

        If count > 0 Then
            Return totalGrade / count
        Else
            Return 0
        End If
    End Function

    Private Sub DisplayClassStats()
        ' Calculate and display average, highest, and lowest for the entire class
        Dim averageClassGrade As Double = numericalGrades.Average()
        Dim highestClassGrade As Integer = numericalGrades.Max()
        Dim lowestClassGrade As Integer = numericalGrades.Min()

        ' Display class statistics in labels
        lblGradeAverage.Text = averageClassGrade.ToString("F2")
        lblHighestGrade.Text = highestClassGrade.ToString()
        lblLowestGrade.Text = lowestClassGrade.ToString()
    End Sub

    Private Sub ExitApplication()
        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Professor Juarez", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' If the user clicks "Yes," close the form
            Me.Close()
        End If
    End Sub

    Private Sub ConfirmExit(e As FormClosingEventArgs)
        ' Check if the user wants to exit
        If MessageBox.Show("Do you want to exit?", "Professor Juarez", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            ' If the user clicks "No," cancel the form closing event
            e.Cancel = True
        End If
    End Sub
End Class