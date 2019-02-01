Public Class frmadvancedtaxsystem

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblotherdeductions.Click

    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeename.TextChanged
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpaye.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpgender.Enter

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbfemale.Click
        BackColor = Color.DeepPink
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbmale.Click
        BackColor = Color.Blue
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        txtemployeeno.Clear()
        txtEmployeename.Clear()
        txtgrosspay.Clear()
        txthelb.Clear()
        txtsacco.Clear()
        txtnetpay.Clear()
        txtpaye.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        ' If Not IsNumeric(txtgrosspay.Text) Then
        ' MessageBox.Show("Invalid")
        'End If
        'If Not IsNumeric(txtgrosspay.Text) Then
        'MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok
        'Application.Exit()
        'End If

        Dim bal As Double
        txthelb.Text = 3500
        If txtgrosspay.Text <= 10000 Then
            txtpaye.Text = 0
        ElseIf txtgrosspay.Text > 10000 Then
            bal = txtgrosspay.Text - 10000
            Select Case bal
                Case Is <= 12298
                    txtpaye.Text = bal * 0.1
                Case Is < 23885
                    txtpaye.Text = (bal - 12298) * 0.15 + 12298 * 0.1
                Case Is <= 35472
                    txtpaye.Text = (bal - 23885) * 0.2 + 11587 * 0.15 + 12298 * 0.1
                Case Is <= 47059
                    txtpaye.Text = (bal - 35472) * 0.25 + 11587 * 0.2 + 11587 * 0.15 + 12298 * 0.1
                Case Is > 47059
                    txtpaye.Text = (bal - 47059) * 0.3 + 11587 * 0.25 + 11587 * 0.2 + 11587 * 0.15 + 12298 * 0.1
            End Select
        End If


        Dim Net As Decimal = txtgrosspay.Text - (Val(txtpaye.Text) + Val(txthelb.Text) + Val(txtsacco.Text))
        txthelb.Text = 3500
        txtpaye.Text = Format(txtpaye.Text)
        txtnetpay.Text = (Net)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblemployeeno.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnetpay.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsacco.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhelb.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgross.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblemployeename.Click
    Dim Val(txtemployeeno.Text) As String
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemployeeno.TextChanged
    End Sub

    Private Sub lblvumiliataxsystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvumiliataxsystem.Click

    End Sub

    Private Sub txtgrosspay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrosspay.TextChanged
    End Sub

    Private Sub txthelb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthelb.TextChanged

    End Sub

    Private Sub txtpaye_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaye.TextChanged
    End Sub

    Private Sub txtsacco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsacco.TextChanged
    End Sub

    Private Sub rdbfemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbfemale.CheckedChanged

    End Sub
End Class
