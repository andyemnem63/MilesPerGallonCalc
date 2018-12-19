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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of gas the car can hold:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(288, 61)
        Me.txtGallons.MinimumSize = New System.Drawing.Size(4, 25)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(146, 22)
        Me.txtGallons.TabIndex = 2
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(288, 160)
        Me.txtMiles.MinimumSize = New System.Drawing.Size(4, 25)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(190, 22)
        Me.txtMiles.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Miles per gallon:"
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(290, 239)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(188, 32)
        Me.lblMilesPerGallon.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(71, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 52)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(244, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 52)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(427, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 52)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 439)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMilesPerGallon As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
