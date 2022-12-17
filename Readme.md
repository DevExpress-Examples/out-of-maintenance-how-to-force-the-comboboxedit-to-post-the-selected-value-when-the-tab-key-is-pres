<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644819/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2899)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication5/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication5/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication5/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication5/MainWindow.xaml.vb))
* [MyComboBox.cs](./CS/WpfApplication5/MyComboBox.cs) (VB: [MyComboBox.vb](./VB/WpfApplication5/MyComboBox.vb))
<!-- default file list end -->
# How to force the ComboBoxEdit to post the selected value when the Tab key is pressed


<p>This example demonstrates how to create a <strong>ComboBoxEdit </strong>that posts a value selected in the popup when the Tab key is pressed.</p>
<p>To enable this feature, we have created a <strong>ComboBoxEdit </strong>class descendant and overridden its ProcessPopupKeyDown method. In this method, we check which key was pressed by a user (we obtain it from the <a href="http://msdn.microsoft.com/en-us/library/system.windows.input.keyeventargs.key%28v=vs.110%29.aspx"><u>KeyEventArgs.Key</u></a> property). If it's "Tab", we forcibly close the popup by using the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfEditorsPopupBaseEdit_ClosePopuptopic"><u>ClosePopup</u></a> method:</p>


```cs
protected override bool ProcessPopupKeyDown(KeyEventArgs e) {
    if(e.Key == Key.Tab) {
        if(IsPopupOpen)
            ClosePopup(PopupCloseMode.Normal);
    }
    return base.ProcessPopupKeyDown(e);
}
```


<p><strong>Starting with version 16.1.7</strong>, you need to use the <strong>ProcessPopupPreviewKeyDown</strong> method instead.</p>

<br/>


