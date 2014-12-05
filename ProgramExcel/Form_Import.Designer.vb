<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Import
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Import))
        Me.GridViewExcel = New System.Windows.Forms.DataGridView()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Txt_NamaTabel = New System.Windows.Forms.TextBox()
        Me.Txt_File = New System.Windows.Forms.TextBox()
        Me.Btn_View = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GridViewExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridViewExcel
        '
        Me.GridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridViewExcel.Location = New System.Drawing.Point(0, 0)
        Me.GridViewExcel.Name = "GridViewExcel"
        Me.GridViewExcel.Size = New System.Drawing.Size(658, 301)
        Me.GridViewExcel.TabIndex = 0
        '
        'Btn_Import
        '
        Me.Btn_Import.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Import.Location = New System.Drawing.Point(570, 0)
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(88, 25)
        Me.Btn_Import.TabIndex = 3
        Me.Btn_Import.Text = "Import"
        Me.Btn_Import.UseVisualStyleBackColor = True
        '
        'Txt_NamaTabel
        '
        Me.Txt_NamaTabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_NamaTabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NamaTabel.Location = New System.Drawing.Point(84, 6)
        Me.Txt_NamaTabel.Name = "Txt_NamaTabel"
        Me.Txt_NamaTabel.Size = New System.Drawing.Size(569, 20)
        Me.Txt_NamaTabel.TabIndex = 5
        '
        'Txt_File
        '
        Me.Txt_File.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_File.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_File.Location = New System.Drawing.Point(84, 29)
        Me.Txt_File.Name = "Txt_File"
        Me.Txt_File.Size = New System.Drawing.Size(537, 20)
        Me.Txt_File.TabIndex = 6
        '
        'Btn_View
        '
        Me.Btn_View.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_View.Location = New System.Drawing.Point(565, 56)
        Me.Btn_View.Name = "Btn_View"
        Me.Btn_View.Size = New System.Drawing.Size(88, 23)
        Me.Btn_View.TabIndex = 7
        Me.Btn_View.Text = "View"
        Me.Btn_View.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NAMA TABEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "FILE"
        '
        'Btn_Browse
        '
        Me.Btn_Browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Browse.Location = New System.Drawing.Point(627, 26)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(26, 23)
        Me.Btn_Browse.TabIndex = 10
        Me.Btn_Browse.Text = "..."
        Me.Btn_Browse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Btn_View)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Btn_Browse)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Txt_File)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Txt_NamaTabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(658, 414)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 11
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridViewExcel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Btn_Import)
        Me.SplitContainer2.Size = New System.Drawing.Size(658, 330)
        Me.SplitContainer2.SplitterDistance = 301
        Me.SplitContainer2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(7, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(535, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jika Program ini mau digunakan di Server Anda silahkan email ke Pamungkas Jayuda " & _
    "di yulius.jayuda@gmail.com"
        '
        'Form_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 414)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Import"
        Me.Opacity = 0.95R
        Me.Text = "Import Excel to SQL By ThinkBuntu ( Free Forever )"
        CType(Me.GridViewExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridViewExcel As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Import As System.Windows.Forms.Button
    Friend WithEvents Txt_NamaTabel As System.Windows.Forms.TextBox
    Friend WithEvents Txt_File As System.Windows.Forms.TextBox
    Friend WithEvents Btn_View As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Browse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
