<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTittle = New Label()
        txtAdd = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        txtRemove = New TextBox()
        btnAddIndex = New Button()
        textAddIndex = New TextBox()
        btnRemoveIndex = New Button()
        txtRemoveIndex = New TextBox()
        nmcAdd = New NumericUpDown()
        nmcRemove = New NumericUpDown()
        txt1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txt2 = New TextBox()
        Label3 = New Label()
        txt3 = New TextBox()
        Label4 = New Label()
        txt4 = New TextBox()
        Label5 = New Label()
        txt5 = New TextBox()
        Label6 = New Label()
        txt10 = New TextBox()
        Label7 = New Label()
        txt9 = New TextBox()
        Label8 = New Label()
        txt8 = New TextBox()
        Label9 = New Label()
        txt7 = New TextBox()
        Label10 = New Label()
        txt6 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        CType(nmcAdd, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmcRemove, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTittle
        ' 
        lblTittle.AutoSize = True
        lblTittle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTittle.Location = New Point(315, 24)
        lblTittle.Name = "lblTittle"
        lblTittle.Size = New Size(169, 48)
        lblTittle.TabIndex = 0
        lblTittle.Text = "ArrayList"
        ' 
        ' txtAdd
        ' 
        txtAdd.Location = New Point(133, 117)
        txtAdd.Name = "txtAdd"
        txtAdd.Size = New Size(106, 31)
        txtAdd.TabIndex = 1
        txtAdd.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.GradientActiveCaption
        btnAdd.Location = New Point(260, 101)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(86, 63)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = SystemColors.GradientActiveCaption
        btnRemove.Location = New Point(260, 192)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(86, 63)
        btnRemove.TabIndex = 4
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' txtRemove
        ' 
        txtRemove.Location = New Point(133, 208)
        txtRemove.Name = "txtRemove"
        txtRemove.Size = New Size(106, 31)
        txtRemove.TabIndex = 3
        txtRemove.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAddIndex
        ' 
        btnAddIndex.BackColor = SystemColors.GradientActiveCaption
        btnAddIndex.Location = New Point(260, 271)
        btnAddIndex.Name = "btnAddIndex"
        btnAddIndex.Size = New Size(86, 63)
        btnAddIndex.TabIndex = 6
        btnAddIndex.Text = "Add Index"
        btnAddIndex.UseVisualStyleBackColor = False
        ' 
        ' textAddIndex
        ' 
        textAddIndex.Location = New Point(133, 287)
        textAddIndex.Name = "textAddIndex"
        textAddIndex.Size = New Size(106, 31)
        textAddIndex.TabIndex = 5
        textAddIndex.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnRemoveIndex
        ' 
        btnRemoveIndex.BackColor = SystemColors.GradientActiveCaption
        btnRemoveIndex.Location = New Point(260, 356)
        btnRemoveIndex.Name = "btnRemoveIndex"
        btnRemoveIndex.Size = New Size(86, 63)
        btnRemoveIndex.TabIndex = 8
        btnRemoveIndex.Text = "Remove Index"
        btnRemoveIndex.UseVisualStyleBackColor = False
        ' 
        ' txtRemoveIndex
        ' 
        txtRemoveIndex.Location = New Point(133, 372)
        txtRemoveIndex.Name = "txtRemoveIndex"
        txtRemoveIndex.Size = New Size(106, 31)
        txtRemoveIndex.TabIndex = 7
        txtRemoveIndex.TextAlign = HorizontalAlignment.Center
        ' 
        ' nmcAdd
        ' 
        nmcAdd.Location = New Point(369, 292)
        nmcAdd.Name = "nmcAdd"
        nmcAdd.Size = New Size(58, 31)
        nmcAdd.TabIndex = 9
        ' 
        ' nmcRemove
        ' 
        nmcRemove.Location = New Point(371, 370)
        nmcRemove.Name = "nmcRemove"
        nmcRemove.Size = New Size(56, 31)
        nmcRemove.TabIndex = 10
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(558, 384)
        txt1.Name = "txt1"
        txt1.Size = New Size(135, 31)
        txt1.TabIndex = 11
        txt1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(526, 389)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 30)
        Label1.TabIndex = 12
        Label1.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(526, 356)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 30)
        Label2.TabIndex = 14
        Label2.Text = "1"
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(558, 347)
        txt2.Name = "txt2"
        txt2.Size = New Size(135, 31)
        txt2.TabIndex = 13
        txt2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(526, 311)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 30)
        Label3.TabIndex = 16
        Label3.Text = "2"
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(558, 310)
        txt3.Name = "txt3"
        txt3.Size = New Size(135, 31)
        txt3.TabIndex = 15
        txt3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(526, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 30)
        Label4.TabIndex = 18
        Label4.Text = "3"
        ' 
        ' txt4
        ' 
        txt4.Location = New Point(558, 273)
        txt4.Name = "txt4"
        txt4.Size = New Size(135, 31)
        txt4.TabIndex = 17
        txt4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(526, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(26, 30)
        Label5.TabIndex = 20
        Label5.Text = "4"
        ' 
        ' txt5
        ' 
        txt5.Location = New Point(558, 236)
        txt5.Name = "txt5"
        txt5.Size = New Size(135, 31)
        txt5.TabIndex = 19
        txt5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(526, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(26, 30)
        Label6.TabIndex = 30
        Label6.Text = "9"
        ' 
        ' txt10
        ' 
        txt10.Location = New Point(558, 50)
        txt10.Name = "txt10"
        txt10.Size = New Size(135, 31)
        txt10.TabIndex = 29
        txt10.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(526, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 30)
        Label7.TabIndex = 28
        Label7.Text = "8"
        ' 
        ' txt9
        ' 
        txt9.Location = New Point(558, 87)
        txt9.Name = "txt9"
        txt9.Size = New Size(135, 31)
        txt9.TabIndex = 27
        txt9.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(526, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 30)
        Label8.TabIndex = 26
        Label8.Text = "7"
        ' 
        ' txt8
        ' 
        txt8.Location = New Point(558, 124)
        txt8.Name = "txt8"
        txt8.Size = New Size(135, 31)
        txt8.TabIndex = 25
        txt8.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(526, 160)
        Label9.Name = "Label9"
        Label9.Size = New Size(26, 30)
        Label9.TabIndex = 24
        Label9.Text = "6"
        ' 
        ' txt7
        ' 
        txt7.Location = New Point(558, 161)
        txt7.Name = "txt7"
        txt7.Size = New Size(135, 31)
        txt7.TabIndex = 23
        txt7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(526, 201)
        Label10.Name = "Label10"
        Label10.Size = New Size(26, 30)
        Label10.TabIndex = 22
        Label10.Text = "5"
        ' 
        ' txt6
        ' 
        txt6.Location = New Point(558, 198)
        txt6.Name = "txt6"
        txt6.Size = New Size(135, 31)
        txt6.TabIndex = 21
        txt6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(506, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 28)
        Label11.TabIndex = 31
        Label11.Text = "Index"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(606, 9)
        Label12.Name = "Label12"
        Label12.Size = New Size(63, 28)
        Label12.TabIndex = 32
        Label12.Text = "Value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label6)
        Controls.Add(txt10)
        Controls.Add(Label7)
        Controls.Add(txt9)
        Controls.Add(Label8)
        Controls.Add(txt8)
        Controls.Add(Label9)
        Controls.Add(txt7)
        Controls.Add(Label10)
        Controls.Add(txt6)
        Controls.Add(Label5)
        Controls.Add(txt5)
        Controls.Add(Label4)
        Controls.Add(txt4)
        Controls.Add(Label3)
        Controls.Add(txt3)
        Controls.Add(Label2)
        Controls.Add(txt2)
        Controls.Add(Label1)
        Controls.Add(txt1)
        Controls.Add(nmcRemove)
        Controls.Add(nmcAdd)
        Controls.Add(btnRemoveIndex)
        Controls.Add(txtRemoveIndex)
        Controls.Add(btnAddIndex)
        Controls.Add(textAddIndex)
        Controls.Add(btnRemove)
        Controls.Add(txtRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtAdd)
        Controls.Add(lblTittle)
        Name = "Form1"
        Text = "Form1"
        CType(nmcAdd, ComponentModel.ISupportInitialize).EndInit()
        CType(nmcRemove, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTittle As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtRemove As TextBox
    Friend WithEvents btnAddIndex As Button
    Friend WithEvents textAddIndex As TextBox
    Friend WithEvents btnRemoveIndex As Button
    Friend WithEvents txtRemoveIndex As TextBox
    Friend WithEvents nmcAdd As NumericUpDown
    Friend WithEvents nmcRemove As NumericUpDown
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt10 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt9 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
