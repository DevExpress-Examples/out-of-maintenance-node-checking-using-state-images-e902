Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication69
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim c As Control = New DevExpress.XtraTreeList.Demos.Tutorials.NodeChecking()
			c.Dock = DockStyle.Fill
			Me.Controls.Add(c)
		End Sub
	End Class
End Namespace