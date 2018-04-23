Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Editors

Namespace WpfApplication5
	Public Class MyComboBox
		Inherits ComboBoxEdit
        Protected Overrides Function ProcessPopupPreviewKeyDown(ByVal e As KeyEventArgs) As Boolean
            If e.Key = Key.Tab Then
                If IsPopupOpen Then
                    ClosePopup(PopupCloseMode.Normal)
                End If
            End If
            Return MyBase.ProcessPopupPreviewKeyDown(e)
        End Function
	End Class
End Namespace