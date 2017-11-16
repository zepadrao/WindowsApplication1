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
        Me.B6 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.point = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'B6
        '
        Me.B6.BackColor = System.Drawing.Color.Transparent
        Me.B6.FlatAppearance.BorderSize = 0
        Me.B6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.B6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B6.Location = New System.Drawing.Point(338, 603)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(116, 60)
        Me.B6.TabIndex = 2
        Me.B6.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.Transparent
        Me.B2.FlatAppearance.BorderSize = 0
        Me.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.Location = New System.Drawing.Point(186, 533)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(116, 60)
        Me.B2.TabIndex = 3
        Me.B2.UseVisualStyleBackColor = False
        '
        'B4
        '
        Me.B4.BackColor = System.Drawing.Color.Transparent
        Me.B4.FlatAppearance.BorderSize = 0
        Me.B4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.B4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B4.Location = New System.Drawing.Point(37, 603)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(116, 60)
        Me.B4.TabIndex = 4
        Me.B4.UseVisualStyleBackColor = False
        '
        'B8
        '
        Me.B8.BackColor = System.Drawing.Color.Transparent
        Me.B8.FlatAppearance.BorderSize = 0
        Me.B8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.B8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B8.Location = New System.Drawing.Point(186, 715)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(116, 60)
        Me.B8.TabIndex = 5
        Me.B8.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.point})
        Me.ShapeContainer1.Size = New System.Drawing.Size(477, 774)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'point
        '
        Me.point.BackColor = System.Drawing.Color.RosyBrown
        Me.point.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.point.BorderWidth = 4
        Me.point.Location = New System.Drawing.Point(397, 137)
        Me.point.Name = "point"
        Me.point.Size = New System.Drawing.Size(15, 15)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 64
        Me.LineShape1.X2 = 63
        Me.LineShape1.Y1 = 35
        Me.LineShape1.Y2 = 271
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 64
        Me.LineShape2.X2 = 416
        Me.LineShape2.Y1 = 270
        Me.LineShape2.Y2 = 268
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 414
        Me.LineShape3.X2 = 414
        Me.LineShape3.Y1 = 36
        Me.LineShape3.Y2 = 269
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 64
        Me.LineShape4.X2 = 416
        Me.LineShape4.Y1 = 36
        Me.LineShape4.Y2 = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.snake1
        Me.ClientSize = New System.Drawing.Size(477, 774)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "ZZZ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B6 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button
    Friend WithEvents B8 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents point As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
