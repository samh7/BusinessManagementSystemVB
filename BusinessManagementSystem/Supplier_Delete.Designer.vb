﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier_Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier_Delete))
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.DeleteSupplierTitlelbl = New System.Windows.Forms.Label()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.SuppIDlbl = New System.Windows.Forms.Label()
        Me.SuppNamelbl = New System.Windows.Forms.Label()
        Me.SuppIDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.SuppNameSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(194, 131)
        Me.SearchInstructlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(357, 20)
        Me.SearchInstructlbl.TabIndex = 24
        Me.SearchInstructlbl.Text = "Search for the supplier that you want to delete:"
        '
        'DeleteSupplierTitlelbl
        '
        Me.DeleteSupplierTitlelbl.AutoSize = True
        Me.DeleteSupplierTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSupplierTitlelbl.Location = New System.Drawing.Point(230, 34)
        Me.DeleteSupplierTitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeleteSupplierTitlelbl.Name = "DeleteSupplierTitlelbl"
        Me.DeleteSupplierTitlelbl.Size = New System.Drawing.Size(292, 46)
        Me.DeleteSupplierTitlelbl.TabIndex = 23
        Me.DeleteSupplierTitlelbl.Text = "Delete Supplier"
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(27, 351)
        Me.Backbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(260, 54)
        Me.Backbtn.TabIndex = 22
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'SuppIDlbl
        '
        Me.SuppIDlbl.AutoSize = True
        Me.SuppIDlbl.Location = New System.Drawing.Point(441, 212)
        Me.SuppIDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SuppIDlbl.Name = "SuppIDlbl"
        Me.SuppIDlbl.Size = New System.Drawing.Size(92, 20)
        Me.SuppIDlbl.TabIndex = 21
        Me.SuppIDlbl.Text = "Supplier ID:"
        '
        'SuppNamelbl
        '
        Me.SuppNamelbl.AutoSize = True
        Me.SuppNamelbl.Location = New System.Drawing.Point(22, 212)
        Me.SuppNamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SuppNamelbl.Name = "SuppNamelbl"
        Me.SuppNamelbl.Size = New System.Drawing.Size(117, 20)
        Me.SuppNamelbl.TabIndex = 20
        Me.SuppNamelbl.Text = "Supplier Name:"
        '
        'SuppIDSrchtxtbx
        '
        Me.SuppIDSrchtxtbx.Location = New System.Drawing.Point(542, 211)
        Me.SuppIDSrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SuppIDSrchtxtbx.Name = "SuppIDSrchtxtbx"
        Me.SuppIDSrchtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.SuppIDSrchtxtbx.TabIndex = 19
        '
        'SuppNameSrchtxtbx
        '
        Me.SuppNameSrchtxtbx.Location = New System.Drawing.Point(148, 212)
        Me.SuppNameSrchtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SuppNameSrchtxtbx.Name = "SuppNameSrchtxtbx"
        Me.SuppNameSrchtxtbx.Size = New System.Drawing.Size(148, 26)
        Me.SuppNameSrchtxtbx.TabIndex = 18
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(470, 351)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(260, 54)
        Me.Searchbtn.TabIndex = 17
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Supplier_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 463)
        Me.Controls.Add(Me.SearchInstructlbl)
        Me.Controls.Add(Me.DeleteSupplierTitlelbl)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.SuppIDlbl)
        Me.Controls.Add(Me.SuppNamelbl)
        Me.Controls.Add(Me.SuppIDSrchtxtbx)
        Me.Controls.Add(Me.SuppNameSrchtxtbx)
        Me.Controls.Add(Me.Searchbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Supplier_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier_Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
    Friend WithEvents DeleteSupplierTitlelbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents SuppIDlbl As System.Windows.Forms.Label
    Friend WithEvents SuppNamelbl As System.Windows.Forms.Label
    Friend WithEvents SuppIDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents SuppNameSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
End Class
