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
	''' <summary>
	''' Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
	'''
	''' Step 1a) Using this custom control in a XAML file that exists in the current project.
	''' Add this XmlNamespace attribute to the root element of the markup file where it is 
	''' to be used:
	'''
	'''     xmlns:MyNamespace="clr-namespace:WpfApplication5"
	'''
	'''
	''' Step 1b) Using this custom control in a XAML file that exists in a different project.
	''' Add this XmlNamespace attribute to the root element of the markup file where it is 
	''' to be used:
	'''
	'''     xmlns:MyNamespace="clr-namespace:WpfApplication5;assembly=WpfApplication5"
	'''
	''' You will also need to add a project reference from the project where the XAML file lives
	''' to this project and Rebuild to avoid compilation errors:
	'''
	'''     Right click on the target project in the Solution Explorer and
	'''     "Add Reference"->"Projects"->[Browse to and select this project]
	'''
	'''
	''' Step 2)
	''' Go ahead and use your control in the XAML file.
	'''
	'''     <MyNamespace:MyComboBox/>
	'''
	''' </summary>
	Public Class MyComboBox
		Inherits ComboBoxEdit
		Shared Sub New()
			'DefaultStyleKeyProperty.OverrideMetadata(typeof(MyComboBox), new FrameworkPropertyMetadata(typeof(MyComboBox)));
		End Sub

		Protected Overrides Function ProcessKeyDown(ByVal e As KeyEventArgs) As Boolean
			If e.Key = Key.Tab Then
				If IsPopupOpen Then
					ClosePopup(PopupCloseMode.Normal)
				End If
			End If
			Return MyBase.ProcessKeyDown(e)
		End Function

	End Class
End Namespace
