Namespace Spreadsheet_Document_Api_Part_3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.SidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.SidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.btnOpenExcel = New DevExpress.XtraEditors.SimpleButton()
            Me.SidePanel3 = New DevExpress.XtraEditors.SidePanel()
            Me.codeExampleNameLbl = New DevExpress.XtraEditors.LabelControl()
            Me.SidePanel4 = New DevExpress.XtraEditors.SidePanel()
            Me.SidePanel5 = New DevExpress.XtraEditors.SidePanel()
            Me.SidePanel6 = New DevExpress.XtraEditors.SidePanel()
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.richEditControlCS = New DevExpress.XtraRichEdit.RichEditControl()
            Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.richEditControlVB = New DevExpress.XtraRichEdit.RichEditControl()
            Me.SidePanel1.SuspendLayout()
            CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SidePanel2.SuspendLayout()
            Me.SidePanel3.SuspendLayout()
            Me.SidePanel6.SuspendLayout()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage1.SuspendLayout()
            Me.XtraTabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'SidePanel1
            '
            Me.SidePanel1.Controls.Add(Me.TreeList1)
            Me.SidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.SidePanel1.Location = New System.Drawing.Point(827, 0)
            Me.SidePanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.SidePanel1.MinimumSize = New System.Drawing.Size(100, 600)
            Me.SidePanel1.Name = "SidePanel1"
            Me.SidePanel1.Size = New System.Drawing.Size(257, 615)
            Me.SidePanel1.TabIndex = 0
            Me.SidePanel1.Text = "SidePanel1"
            '
            'TreeList1
            '
            Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeList1.FixedLineWidth = 1
            Me.TreeList1.HorzScrollStep = 1
            Me.TreeList1.Location = New System.Drawing.Point(1, 0)
            Me.TreeList1.Margin = New System.Windows.Forms.Padding(2)
            Me.TreeList1.MinWidth = 16
            Me.TreeList1.Name = "TreeList1"
            Me.TreeList1.Size = New System.Drawing.Size(256, 615)
            Me.TreeList1.TabIndex = 0
            Me.TreeList1.TreeLevelWidth = 12
            '
            'SidePanel2
            '
            Me.SidePanel2.Controls.Add(Me.btnOpenExcel)
            Me.SidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.SidePanel2.Location = New System.Drawing.Point(0, 532)
            Me.SidePanel2.Margin = New System.Windows.Forms.Padding(2)
            Me.SidePanel2.Name = "SidePanel2"
            Me.SidePanel2.Size = New System.Drawing.Size(827, 83)
            Me.SidePanel2.TabIndex = 1
            Me.SidePanel2.Text = "SidePanel2"
            '
            'btnOpenExcel
            '
            Me.btnOpenExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOpenExcel.Location = New System.Drawing.Point(635, 24)
            Me.btnOpenExcel.Margin = New System.Windows.Forms.Padding(2)
            Me.btnOpenExcel.Name = "btnOpenExcel"
            Me.btnOpenExcel.Size = New System.Drawing.Size(171, 37)
            Me.btnOpenExcel.TabIndex = 0
            Me.btnOpenExcel.Text = "Open in Microsoft Excel"
            '
            'SidePanel3
            '
            Me.SidePanel3.Controls.Add(Me.codeExampleNameLbl)
            Me.SidePanel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.SidePanel3.Location = New System.Drawing.Point(0, 0)
            Me.SidePanel3.Margin = New System.Windows.Forms.Padding(2)
            Me.SidePanel3.Name = "SidePanel3"
            Me.SidePanel3.Size = New System.Drawing.Size(827, 70)
            Me.SidePanel3.TabIndex = 2
            Me.SidePanel3.Text = "SidePanel3"
            '
            'codeExampleNameLbl
            '
            Me.codeExampleNameLbl.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
            Me.codeExampleNameLbl.Appearance.Options.UseFont = True
            Me.codeExampleNameLbl.Location = New System.Drawing.Point(21, 23)
            Me.codeExampleNameLbl.Margin = New System.Windows.Forms.Padding(2)
            Me.codeExampleNameLbl.Name = "codeExampleNameLbl"
            Me.codeExampleNameLbl.Size = New System.Drawing.Size(215, 25)
            Me.codeExampleNameLbl.TabIndex = 0
            Me.codeExampleNameLbl.Text = "Examples Not Found"
            '
            'SidePanel4
            '
            Me.SidePanel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.SidePanel4.Location = New System.Drawing.Point(807, 70)
            Me.SidePanel4.Margin = New System.Windows.Forms.Padding(2)
            Me.SidePanel4.Name = "SidePanel4"
            Me.SidePanel4.Size = New System.Drawing.Size(20, 462)
            Me.SidePanel4.TabIndex = 3
            Me.SidePanel4.Text = "SidePanel4"
            '
            'SidePanel5
            '
            Me.SidePanel5.Dock = System.Windows.Forms.DockStyle.Left
            Me.SidePanel5.Location = New System.Drawing.Point(0, 70)
            Me.SidePanel5.Margin = New System.Windows.Forms.Padding(2)
            Me.SidePanel5.Name = "SidePanel5"
            Me.SidePanel5.Size = New System.Drawing.Size(20, 462)
            Me.SidePanel5.TabIndex = 4
            Me.SidePanel5.Text = "SidePanel5"
            '
            'SidePanel6
            '
            Me.SidePanel6.Controls.Add(Me.XtraTabControl1)
            Me.SidePanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SidePanel6.Location = New System.Drawing.Point(20, 70)
            Me.SidePanel6.Margin = New System.Windows.Forms.Padding(2)
            Me.SidePanel6.Name = "SidePanel6"
            Me.SidePanel6.Size = New System.Drawing.Size(787, 462)
            Me.SidePanel6.TabIndex = 5
            Me.SidePanel6.Text = "SidePanel6"
            '
            'XtraTabControl1
            '
            Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.XtraTabControl1.Name = "XtraTabControl1"
            Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
            Me.XtraTabControl1.Size = New System.Drawing.Size(787, 462)
            Me.XtraTabControl1.TabIndex = 0
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
            '
            'XtraTabPage1
            '
            Me.XtraTabPage1.Controls.Add(Me.richEditControlCS)
            Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(2)
            Me.XtraTabPage1.Name = "XtraTabPage1"
            Me.XtraTabPage1.Size = New System.Drawing.Size(785, 437)
            Me.XtraTabPage1.Text = "C#"
            '
            'richEditControlCS
            '
            Me.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControlCS.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControlCS.Location = New System.Drawing.Point(0, 0)
            Me.richEditControlCS.Margin = New System.Windows.Forms.Padding(2)
            Me.richEditControlCS.Name = "richEditControlCS"
            Me.richEditControlCS.Options.Annotations.ShowAllAuthors = False
            Me.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControlCS.Size = New System.Drawing.Size(785, 437)
            Me.richEditControlCS.TabIndex = 0
            '
            'XtraTabPage2
            '
            Me.XtraTabPage2.Controls.Add(Me.richEditControlVB)
            Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(2)
            Me.XtraTabPage2.Name = "XtraTabPage2"
            Me.XtraTabPage2.Size = New System.Drawing.Size(785, 437)
            Me.XtraTabPage2.Text = "VB"
            '
            'richEditControlVB
            '
            Me.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControlVB.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControlVB.Location = New System.Drawing.Point(0, 0)
            Me.richEditControlVB.Margin = New System.Windows.Forms.Padding(2)
            Me.richEditControlVB.Name = "richEditControlVB"
            Me.richEditControlVB.Options.Annotations.ShowAllAuthors = False
            Me.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControlVB.Size = New System.Drawing.Size(785, 437)
            Me.richEditControlVB.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1084, 615)
            Me.Controls.Add(Me.SidePanel6)
            Me.Controls.Add(Me.SidePanel5)
            Me.Controls.Add(Me.SidePanel4)
            Me.Controls.Add(Me.SidePanel3)
            Me.Controls.Add(Me.SidePanel2)
            Me.Controls.Add(Me.SidePanel1)
            Me.MinimumSize = New System.Drawing.Size(765, 575)
            Me.Name = "Form1"
            Me.Text = "Spreadsheet API, Sample 3"
            Me.SidePanel1.ResumeLayout(False)
            CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SidePanel2.ResumeLayout(False)
            Me.SidePanel3.ResumeLayout(False)
            Me.SidePanel3.PerformLayout()
            Me.SidePanel6.ResumeLayout(False)
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage1.ResumeLayout(False)
            Me.XtraTabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents SidePanel1 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents SidePanel2 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
        Friend WithEvents btnOpenExcel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SidePanel3 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents codeExampleNameLbl As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SidePanel4 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents SidePanel5 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents SidePanel6 As DevExpress.XtraEditors.SidePanel
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents richEditControlCS As DevExpress.XtraRichEdit.RichEditControl
        Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents richEditControlVB As DevExpress.XtraRichEdit.RichEditControl

#End Region
    End Class
End Namespace

