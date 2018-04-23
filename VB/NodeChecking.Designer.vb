Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Partial Public Class NodeChecking
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(NodeChecking))
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.label3 = New System.Windows.Forms.Label()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(4, 27)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(543, 269)
			Me.treeList1.StateImageList = Me.imageList1
			Me.treeList1.TabIndex = 6
'			Me.treeList1.GetStateImage += New DevExpress.XtraTreeList.GetStateImageEventHandler(Me.treeList1_GetStateImage);
'			Me.treeList1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseDown);
'			Me.treeList1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.treeList1_KeyDown);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label3.Location = New System.Drawing.Point(4, 4)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(543, 23)
			Me.label3.TabIndex = 7
			Me.label3.Text = "Press the space key or click a state image to check a node."
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' NodeChecking
			' 
			Me.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.Appearance.Options.UseBackColor = True
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.label3)
			Me.Name = "NodeChecking"
			Me.Size = New System.Drawing.Size(551, 300)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private imageList1 As System.Windows.Forms.ImageList
		Private label3 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
