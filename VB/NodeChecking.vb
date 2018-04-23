Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for NodeChecking.
	''' </summary>
	Partial Public Class NodeChecking
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim xv As New DevExpress.XtraTreeList.Design.XViews(treeList1)
			treeList1.SelectImageList = Nothing
			Try
				SetCheckedNode(treeList1.Nodes(0).Nodes(0))
			Catch
			End Try
		End Sub

		Private Function GetCheckState(ByVal obj As Object) As CheckState
			If obj IsNot Nothing Then
				Return CType(obj, CheckState)
			End If
			Return CheckState.Unchecked
		End Function
		'<treeList1>
		Private Sub SetCheckedNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
			Dim check As CheckState = GetCheckState(node.Tag)
			If check = CheckState.Indeterminate OrElse check = CheckState.Unchecked Then
				check = CheckState.Checked
			Else
				check = CheckState.Unchecked
			End If
			treeList1.BeginUpdate()
			node.Tag = check
			SetCheckedChildNodes(node, check)
			SetCheckedParentNodes(node, check)
			treeList1.EndUpdate()
		End Sub
		'</treeList1>

		Private Sub SetCheckedChildNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As CheckState)
			For i As Integer = 0 To node.Nodes.Count - 1
				node.Nodes(i).Tag = check
				SetCheckedChildNodes(node.Nodes(i), check)
			Next i
		End Sub
		Private Sub SetCheckedParentNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As CheckState)
			If node.ParentNode IsNot Nothing Then
				Dim b As Boolean = False
				Dim state As CheckState
				For i As Integer = 0 To node.ParentNode.Nodes.Count - 1
					If node.ParentNode.Nodes(i).Tag Is Nothing Then
						state = CheckState.Unchecked
					Else
						state = CType(node.ParentNode.Nodes(i).Tag, CheckState)
					End If
					If (Not check.Equals(state)) Then
						b = Not b
						Exit For
					End If
				Next i
				If b Then
					node.ParentNode.Tag = CheckState.Indeterminate
				Else
					node.ParentNode.Tag = check
				End If
				SetCheckedParentNodes(node.ParentNode, check)
			End If
		End Sub

		'<treeList1>
		Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles treeList1.GetStateImage
			Dim check As CheckState = GetCheckState(e.Node.Tag)
			If check = CheckState.Unchecked Then
				e.NodeImageIndex = 0
			ElseIf check = CheckState.Checked Then
				e.NodeImageIndex = 1
			Else
				e.NodeImageIndex = 2
			End If
		End Sub

		Private Sub treeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles treeList1.KeyDown
			If e.KeyData = Keys.Space Then
				SetCheckedNode(treeList1.FocusedNode)
			End If
		End Sub

		Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeList1.MouseDown
			If e.Button = MouseButtons.Left Then
				Dim hInfo As DevExpress.XtraTreeList.TreeListHitInfo = treeList1.CalcHitInfo(New Point(e.X, e.Y))
				If hInfo.HitInfoType = HitInfoType.StateImage Then
					SetCheckedNode(hInfo.Node)
				End If
			End If
		End Sub
		'</treeList1>
	End Class
End Namespace
