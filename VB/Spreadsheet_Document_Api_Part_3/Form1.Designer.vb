Namespace Spreadsheet_Document_Api_Part_3

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.verticalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.horisontalSplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.richEditControlCS = New DevExpress.XtraRichEdit.RichEditControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.richEditControlVB = New DevExpress.XtraRichEdit.RichEditControl()
            Me.codeExampleNameLbl = New DevExpress.XtraEditors.LabelControl()
            Me.btnOpenExcel = New DevExpress.XtraEditors.SimpleButton()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            CType((Me.verticalSplitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.verticalSplitContainerControl1.SuspendLayout()
            CType((Me.horisontalSplitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.horisontalSplitContainerControl1.SuspendLayout()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' verticalSplitContainerControl1
            ' 
            Me.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.verticalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.verticalSplitContainerControl1.Margin = New System.Windows.Forms.Padding(6)
            Me.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1"
            Me.verticalSplitContainerControl1.Panel1.Controls.Add(Me.horisontalSplitContainerControl1)
            Me.verticalSplitContainerControl1.Panel1.Text = "Panel1"
            Me.verticalSplitContainerControl1.Panel2.Controls.Add(Me.treeList1)
            Me.verticalSplitContainerControl1.Panel2.Text = "Panel2"
            Me.verticalSplitContainerControl1.Size = New System.Drawing.Size(2424, 1260)
            Me.verticalSplitContainerControl1.SplitterPosition = 1898
            Me.verticalSplitContainerControl1.TabIndex = 0
            Me.verticalSplitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' horisontalSplitContainerControl1
            ' 
            Me.horisontalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.horisontalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.horisontalSplitContainerControl1.Horizontal = False
            Me.horisontalSplitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.horisontalSplitContainerControl1.Margin = New System.Windows.Forms.Padding(6)
            Me.horisontalSplitContainerControl1.Name = "horisontalSplitContainerControl1"
            Me.horisontalSplitContainerControl1.Panel1.Controls.Add(Me.xtraTabControl1)
            Me.horisontalSplitContainerControl1.Panel1.Controls.Add(Me.codeExampleNameLbl)
            Me.horisontalSplitContainerControl1.Panel1.Text = "Panel1"
            Me.horisontalSplitContainerControl1.Panel2.Controls.Add(Me.btnOpenExcel)
            Me.horisontalSplitContainerControl1.Panel2.Text = "Panel2"
            Me.horisontalSplitContainerControl1.Size = New System.Drawing.Size(1898, 1260)
            Me.horisontalSplitContainerControl1.SplitterPosition = 137
            Me.horisontalSplitContainerControl1.TabIndex = 0
            Me.horisontalSplitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.Color.Transparent
            Me.xtraTabControl1.AppearancePage.PageClient.BackColor2 = System.Drawing.Color.Transparent
            Me.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Transparent
            Me.xtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = True
            Me.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = True
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 84)
            Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(6)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(1898, 1019)
            Me.xtraTabControl1.TabIndex = 1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
            Me.xtraTabPage1.Controls.Add(Me.richEditControlCS)
            Me.xtraTabPage1.Margin = New System.Windows.Forms.Padding(6)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(1894, 968)
            Me.xtraTabPage1.Text = "C#"
            ' 
            ' richEditControlCS
            ' 
            Me.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControlCS.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControlCS.Location = New System.Drawing.Point(0, 0)
            Me.richEditControlCS.Margin = New System.Windows.Forms.Padding(6)
            Me.richEditControlCS.Name = "richEditControlCS"
            Me.richEditControlCS.Options.Annotations.ShowAllAuthors = False
            Me.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControlCS.Size = New System.Drawing.Size(1894, 968)
            Me.richEditControlCS.TabIndex = 0
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
            Me.xtraTabPage2.Controls.Add(Me.richEditControlVB)
            Me.xtraTabPage2.Margin = New System.Windows.Forms.Padding(6)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(1894, 968)
            Me.xtraTabPage2.Text = "VB"
            ' 
            ' richEditControlVB
            ' 
            Me.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControlVB.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControlVB.Location = New System.Drawing.Point(0, 0)
            Me.richEditControlVB.Margin = New System.Windows.Forms.Padding(6)
            Me.richEditControlVB.Name = "richEditControlVB"
            Me.richEditControlVB.Options.Annotations.ShowAllAuthors = False
            Me.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControlVB.Size = New System.Drawing.Size(1894, 968)
            Me.richEditControlVB.TabIndex = 0
            ' 
            ' codeExampleNameLbl
            ' 
            Me.codeExampleNameLbl.Appearance.Font = New System.Drawing.Font("Arial", 20.25F)
            Me.codeExampleNameLbl.Appearance.Options.UseFont = True
            Me.codeExampleNameLbl.Dock = System.Windows.Forms.DockStyle.Top
            Me.codeExampleNameLbl.Location = New System.Drawing.Point(0, 0)
            Me.codeExampleNameLbl.Margin = New System.Windows.Forms.Padding(6, 10, 6, 10)
            Me.codeExampleNameLbl.Name = "codeExampleNameLbl"
            Me.codeExampleNameLbl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 23)
            Me.codeExampleNameLbl.Size = New System.Drawing.Size(146, 84)
            Me.codeExampleNameLbl.TabIndex = 0
            Me.codeExampleNameLbl.Text = "label1"
            ' 
            ' btnOpenExcel
            ' 
            Me.btnOpenExcel.Location = New System.Drawing.Point(24, 15)
            Me.btnOpenExcel.Margin = New System.Windows.Forms.Padding(6)
            Me.btnOpenExcel.Name = "btnOpenExcel"
            Me.btnOpenExcel.Size = New System.Drawing.Size(364, 87)
            Me.btnOpenExcel.TabIndex = 0
            Me.btnOpenExcel.Text = "Open in Microsoft Excel"
            AddHandler Me.btnOpenExcel.Click, New System.EventHandler(AddressOf Me.btnOpenExcel_Click)
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Margin = New System.Windows.Forms.Padding(6)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(506, 1260)
            Me.treeList1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(2424, 1260)
            Me.Controls.Add(Me.verticalSplitContainerControl1)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "Form1"
            CType((Me.verticalSplitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.verticalSplitContainerControl1.ResumeLayout(False)
            CType((Me.horisontalSplitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.horisontalSplitContainerControl1.ResumeLayout(False)
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private verticalSplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private horisontalSplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage

        Private codeExampleNameLbl As DevExpress.XtraEditors.LabelControl

        Private richEditControlCS As DevExpress.XtraRichEdit.RichEditControl

        Private richEditControlVB As DevExpress.XtraRichEdit.RichEditControl

        Private btnOpenExcel As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
