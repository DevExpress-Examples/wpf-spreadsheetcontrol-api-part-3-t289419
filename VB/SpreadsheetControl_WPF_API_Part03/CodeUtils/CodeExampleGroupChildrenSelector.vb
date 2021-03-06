﻿Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SpreadsheetControl_WPF_API_Part03
	Public Class CodeExampleGroupChildrenSelector
		Implements IChildNodesSelector

		Private Function IChildNodesSelector_SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
			If TypeOf item Is CodeExampleGroup Then
				Return DirectCast(item, CodeExampleGroup).Examples
			End If
			Return Nothing
		End Function
	End Class
End Namespace
