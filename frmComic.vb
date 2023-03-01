Public Class frmComic
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' When this button is clicked, the input from txtGroupSize should be validated
        ' If it is an integer between 1 and 20, the cost for that group size should be calculated and placed in lblCostOutput

        ' variable declarations
        Const cdecCostConvention = 209D
        Const cdecCostAutographs = 275D
        Const cdecCostExperience = 380D
        Dim intEnterGroupSize As Integer
        Dim decTotalCostOfGroup As Decimal


        'verify input type
        If IsNumeric(txtGroupSize.Text) Then
            ' input is a number
            intEnterGroupSize = Convert.ToInt32(txtGroupSize.Text)

            ' verify input in range
            If intEnterGroupSize > 0 And intEnterGroupSize < 21 Then
                ' calculations go here
                If radExperience.Checked Then
                    ' superhero experience badge is chosen
                    decTotalCostOfGroup = intEnterGroupSize * cdecCostExperience
                ElseIf radAutographs.Checked Then
                    ' autograph badge is chosen
                    decTotalCostOfGroup = intEnterGroupSize * cdecCostAutographs
                ElseIf radConvention.Checked Then
                    ' basic convention badge is chosen
                    decTotalCostOfGroup = intEnterGroupSize * cdecCostConvention
                End If

                ' clear both labels, to avoid error labels remaining after a proper input has been received
                lblErrorNumber.Visible = False
                lblErrorLimit.Visible = False

                ' set result label to calculation result
                lblCostOutput.Text = decTotalCostOfGroup.ToString("C")
            Else
                    ' input is out of range
                    ' lblErrorLimit is made visible, informing user of the error
                    lblErrorLimit.Visible = True
                ' lblErrorNumber is cleared, to avoid booth labels being visible at once
                lblErrorNumber.Visible = False
            End If
        Else
            ' input is not a number
            ' lblErrorNumber is made visible, informing user of the error
            lblErrorNumber.Visible = True
            ' lblErrorLimit is cleared, to avoid both labels being visible at once
            lblErrorLimit.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' on button click, this should clear the relevant labels and text boxes
        ' should also set all error messages to invisible, and select the topmost radio button
        txtGroupSize.Text = ""
        lblCostOutput.Text = "$0.00"
        radExperience.Checked = True
        lblErrorLimit.Visible = False
        lblErrorNumber.Visible = False
    End Sub

    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' on form load, everything done when btnClear is clicked should be done
        ' this will be done by calling btnClear's click event handler instead of retyping code
        btnClear.PerformClick()
    End Sub
End Class
