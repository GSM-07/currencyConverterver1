<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.ddlFromCurrency = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ddlToCurrency = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRateUsed = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Converter"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(115, 157)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(196, 20)
        Me.txtAmount.TabIndex = 2
        '
        'ddlFromCurrency
        '
        Me.ddlFromCurrency.FormattingEnabled = True
        Me.ddlFromCurrency.Location = New System.Drawing.Point(56, 96)
        Me.ddlFromCurrency.Name = "ddlFromCurrency"
        Me.ddlFromCurrency.Size = New System.Drawing.Size(121, 21)
        Me.ddlFromCurrency.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Amount "
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(133, 268)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(163, 23)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(7, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(112, 202)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(39, 13)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Label5"
        '
        'ddlToCurrency
        '
        Me.ddlToCurrency.FormattingEnabled = True
        Me.ddlToCurrency.Location = New System.Drawing.Point(229, 96)
        Me.ddlToCurrency.Name = "ddlToCurrency"
        Me.ddlToCurrency.Size = New System.Drawing.Size(121, 21)
        Me.ddlToCurrency.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "From:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To:"
        '
        'lblRateUsed
        '
        Me.lblRateUsed.AutoSize = True
        Me.lblRateUsed.Location = New System.Drawing.Point(112, 230)
        Me.lblRateUsed.Name = "lblRateUsed"
        Me.lblRateUsed.Size = New System.Drawing.Size(39, 13)
        Me.lblRateUsed.TabIndex = 11
        Me.lblRateUsed.Text = "Label6"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 574)
        Me.Controls.Add(Me.lblRateUsed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlToCurrency)
        Me.Controls.Add(Me.ddlFromCurrency)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents ddlFromCurrency As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents ddlToCurrency As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRateUsed As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
