<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadvancedtaxsystem
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
        Me.lblvumiliataxsystem = New System.Windows.Forms.Label()
        Me.lblemployeeno = New System.Windows.Forms.Label()
        Me.lblemployeename = New System.Windows.Forms.Label()
        Me.lblgross = New System.Windows.Forms.Label()
        Me.lblpaye = New System.Windows.Forms.Label()
        Me.lblotherdeductions = New System.Windows.Forms.Label()
        Me.lblhelb = New System.Windows.Forms.Label()
        Me.lblsacco = New System.Windows.Forms.Label()
        Me.lblnetpay = New System.Windows.Forms.Label()
        Me.rdbfemale = New System.Windows.Forms.RadioButton()
        Me.rdbmale = New System.Windows.Forms.RadioButton()
        Me.txtemployeeno = New System.Windows.Forms.TextBox()
        Me.txtEmployeename = New System.Windows.Forms.TextBox()
        Me.txtgrosspay = New System.Windows.Forms.TextBox()
        Me.txtpaye = New System.Windows.Forms.TextBox()
        Me.txthelb = New System.Windows.Forms.TextBox()
        Me.txtsacco = New System.Windows.Forms.TextBox()
        Me.txtnetpay = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.grpgender = New System.Windows.Forms.GroupBox()
        Me.grpgender.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblvumiliataxsystem
        '
        Me.lblvumiliataxsystem.AutoSize = True
        Me.lblvumiliataxsystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvumiliataxsystem.Location = New System.Drawing.Point(66, 9)
        Me.lblvumiliataxsystem.Name = "lblvumiliataxsystem"
        Me.lblvumiliataxsystem.Size = New System.Drawing.Size(260, 31)
        Me.lblvumiliataxsystem.TabIndex = 0
        Me.lblvumiliataxsystem.Text = "Vumilia TAX System"
        '
        'lblemployeeno
        '
        Me.lblemployeeno.AutoSize = True
        Me.lblemployeeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployeeno.Location = New System.Drawing.Point(42, 62)
        Me.lblemployeeno.Name = "lblemployeeno"
        Me.lblemployeeno.Size = New System.Drawing.Size(108, 13)
        Me.lblemployeeno.TabIndex = 1
        Me.lblemployeeno.Text = "Employee Number"
        '
        'lblemployeename
        '
        Me.lblemployeename.AutoSize = True
        Me.lblemployeename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployeename.Location = New System.Drawing.Point(42, 117)
        Me.lblemployeename.Name = "lblemployeename"
        Me.lblemployeename.Size = New System.Drawing.Size(97, 13)
        Me.lblemployeename.TabIndex = 2
        Me.lblemployeename.Text = "Employee Name"
        '
        'lblgross
        '
        Me.lblgross.AutoSize = True
        Me.lblgross.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgross.Location = New System.Drawing.Point(42, 181)
        Me.lblgross.Name = "lblgross"
        Me.lblgross.Size = New System.Drawing.Size(64, 13)
        Me.lblgross.TabIndex = 3
        Me.lblgross.Text = "Gross Pay"
        '
        'lblpaye
        '
        Me.lblpaye.AutoSize = True
        Me.lblpaye.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaye.Location = New System.Drawing.Point(42, 251)
        Me.lblpaye.Name = "lblpaye"
        Me.lblpaye.Size = New System.Drawing.Size(51, 13)
        Me.lblpaye.TabIndex = 4
        Me.lblpaye.Text = "P.A.Y.E"
        '
        'lblotherdeductions
        '
        Me.lblotherdeductions.AutoSize = True
        Me.lblotherdeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblotherdeductions.Location = New System.Drawing.Point(187, 307)
        Me.lblotherdeductions.Name = "lblotherdeductions"
        Me.lblotherdeductions.Size = New System.Drawing.Size(127, 16)
        Me.lblotherdeductions.TabIndex = 5
        Me.lblotherdeductions.Text = "Other Deductions"
        '
        'lblhelb
        '
        Me.lblhelb.AutoSize = True
        Me.lblhelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhelb.Location = New System.Drawing.Point(42, 354)
        Me.lblhelb.Name = "lblhelb"
        Me.lblhelb.Size = New System.Drawing.Size(71, 13)
        Me.lblhelb.TabIndex = 6
        Me.lblhelb.Text = "HELB Loan"
        '
        'lblsacco
        '
        Me.lblsacco.AutoSize = True
        Me.lblsacco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsacco.Location = New System.Drawing.Point(42, 390)
        Me.lblsacco.Name = "lblsacco"
        Me.lblsacco.Size = New System.Drawing.Size(48, 13)
        Me.lblsacco.TabIndex = 7
        Me.lblsacco.Text = "SACCO"
        '
        'lblnetpay
        '
        Me.lblnetpay.AutoSize = True
        Me.lblnetpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnetpay.Location = New System.Drawing.Point(132, 440)
        Me.lblnetpay.Name = "lblnetpay"
        Me.lblnetpay.Size = New System.Drawing.Size(52, 13)
        Me.lblnetpay.TabIndex = 8
        Me.lblnetpay.Text = "Net Pay"
        '
        'rdbfemale
        '
        Me.rdbfemale.AutoSize = True
        Me.rdbfemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbfemale.Location = New System.Drawing.Point(22, 26)
        Me.rdbfemale.Name = "rdbfemale"
        Me.rdbfemale.Size = New System.Drawing.Size(65, 17)
        Me.rdbfemale.TabIndex = 9
        Me.rdbfemale.TabStop = True
        Me.rdbfemale.Text = "Female"
        Me.rdbfemale.UseVisualStyleBackColor = True
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbmale.Location = New System.Drawing.Point(127, 26)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(52, 17)
        Me.rdbmale.TabIndex = 10
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "Male"
        Me.rdbmale.UseVisualStyleBackColor = True
        '
        'txtemployeeno
        '
        Me.txtemployeeno.Location = New System.Drawing.Point(383, 59)
        Me.txtemployeeno.Name = "txtemployeeno"
        Me.txtemployeeno.Size = New System.Drawing.Size(116, 20)
        Me.txtemployeeno.TabIndex = 11
        '
        'txtEmployeename
        '
        Me.txtEmployeename.Location = New System.Drawing.Point(383, 114)
        Me.txtEmployeename.Name = "txtEmployeename"
        Me.txtEmployeename.Size = New System.Drawing.Size(116, 20)
        Me.txtEmployeename.TabIndex = 12
        '
        'txtgrosspay
        '
        Me.txtgrosspay.Location = New System.Drawing.Point(383, 178)
        Me.txtgrosspay.Name = "txtgrosspay"
        Me.txtgrosspay.Size = New System.Drawing.Size(116, 20)
        Me.txtgrosspay.TabIndex = 13
        '
        'txtpaye
        '
        Me.txtpaye.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtpaye.Location = New System.Drawing.Point(383, 248)
        Me.txtpaye.Name = "txtpaye"
        Me.txtpaye.ReadOnly = True
        Me.txtpaye.Size = New System.Drawing.Size(116, 20)
        Me.txtpaye.TabIndex = 14
        '
        'txthelb
        '
        Me.txthelb.Location = New System.Drawing.Point(383, 344)
        Me.txthelb.Name = "txthelb"
        Me.txthelb.ReadOnly = True
        Me.txthelb.Size = New System.Drawing.Size(116, 20)
        Me.txthelb.TabIndex = 15
        '
        'txtsacco
        '
        Me.txtsacco.Location = New System.Drawing.Point(382, 387)
        Me.txtsacco.Name = "txtsacco"
        Me.txtsacco.Size = New System.Drawing.Size(116, 20)
        Me.txtsacco.TabIndex = 16
        '
        'txtnetpay
        '
        Me.txtnetpay.BackColor = System.Drawing.SystemColors.Info
        Me.txtnetpay.Location = New System.Drawing.Point(382, 433)
        Me.txtnetpay.Name = "txtnetpay"
        Me.txtnetpay.ReadOnly = True
        Me.txtnetpay.Size = New System.Drawing.Size(116, 20)
        Me.txtnetpay.TabIndex = 17
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.SystemColors.Info
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(146, 540)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(87, 23)
        Me.btncalculate.TabIndex = 18
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.Info
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(239, 540)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(87, 23)
        Me.btnnext.TabIndex = 19
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnquit
        '
        Me.btnquit.BackColor = System.Drawing.SystemColors.Info
        Me.btnquit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnquit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit.Location = New System.Drawing.Point(331, 540)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(87, 23)
        Me.btnquit.TabIndex = 20
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = False
        '
        'grpgender
        '
        Me.grpgender.Controls.Add(Me.rdbfemale)
        Me.grpgender.Controls.Add(Me.rdbmale)
        Me.grpgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpgender.Location = New System.Drawing.Point(204, 464)
        Me.grpgender.Name = "grpgender"
        Me.grpgender.Size = New System.Drawing.Size(191, 70)
        Me.grpgender.TabIndex = 21
        Me.grpgender.TabStop = False
        Me.grpgender.Text = "Gender"
        '
        'frmadvancedtaxsystem
        '
        Me.AcceptButton = Me.btncalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.CancelButton = Me.btnquit
        Me.ClientSize = New System.Drawing.Size(525, 584)
        Me.Controls.Add(Me.grpgender)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtnetpay)
        Me.Controls.Add(Me.txtsacco)
        Me.Controls.Add(Me.txthelb)
        Me.Controls.Add(Me.txtpaye)
        Me.Controls.Add(Me.txtgrosspay)
        Me.Controls.Add(Me.txtEmployeename)
        Me.Controls.Add(Me.txtemployeeno)
        Me.Controls.Add(Me.lblnetpay)
        Me.Controls.Add(Me.lblsacco)
        Me.Controls.Add(Me.lblhelb)
        Me.Controls.Add(Me.lblotherdeductions)
        Me.Controls.Add(Me.lblpaye)
        Me.Controls.Add(Me.lblgross)
        Me.Controls.Add(Me.lblemployeename)
        Me.Controls.Add(Me.lblemployeeno)
        Me.Controls.Add(Me.lblvumiliataxsystem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmadvancedtaxsystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Tax System"
        Me.grpgender.ResumeLayout(False)
        Me.grpgender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblvumiliataxsystem As System.Windows.Forms.Label
    Friend WithEvents lblemployeeno As System.Windows.Forms.Label
    Friend WithEvents lblemployeename As System.Windows.Forms.Label
    Friend WithEvents lblgross As System.Windows.Forms.Label
    Friend WithEvents lblpaye As System.Windows.Forms.Label
    Friend WithEvents lblotherdeductions As System.Windows.Forms.Label
    Friend WithEvents lblhelb As System.Windows.Forms.Label
    Friend WithEvents lblsacco As System.Windows.Forms.Label
    Friend WithEvents lblnetpay As System.Windows.Forms.Label
    Friend WithEvents rdbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmale As System.Windows.Forms.RadioButton
    Friend WithEvents txtemployeeno As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeename As System.Windows.Forms.TextBox
    Friend WithEvents txtgrosspay As System.Windows.Forms.TextBox
    Friend WithEvents txtpaye As System.Windows.Forms.TextBox
    Friend WithEvents txthelb As System.Windows.Forms.TextBox
    Friend WithEvents txtsacco As System.Windows.Forms.TextBox
    Friend WithEvents txtnetpay As System.Windows.Forms.TextBox
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnquit As System.Windows.Forms.Button
    Friend WithEvents grpgender As System.Windows.Forms.GroupBox

End Class
