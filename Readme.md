<!-- default file list -->
*Files to look at*:

* [CustomColumnChooserFactory.cs](./CS/ColumnChooserSL/CustomColumnChooserFactory.cs) (VB: [CustomColumnChooserFactory.vb](./VB/ColumnChooserSL/CustomColumnChooserFactory.vb))
* [MainPage.xaml](./CS/ColumnChooserSL/MainPage.xaml) (VB: [MainPage.xaml](./VB/ColumnChooserSL/MainPage.xaml))
* [MainPage.xaml.cs](./CS/ColumnChooserSL/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/ColumnChooserSL/MainPage.xaml))
* [Record.cs](./CS/ColumnChooserSL/Record.cs) (VB: [Record.vb](./VB/ColumnChooserSL/Record.vb))
<!-- default file list end -->
# How to move a column from ColumnChooser by double-clicking DXGrid for SL


<p>By default, ColumnChooser allows you to drag hidden columns back into the grid.</p><p>This example demonstrates how to enable similar behavior by restoring hidden columns from ColumnChooser on a double-click.</p><p>First, it is necessary to create a CustomColumnChooserFactory class that implements the IColumnChooserFactory interface.</p><p>In the IColumnChooserFactory.Create method, create your own DefaultColumnChooser and add the MouseLeftButtonDown event handler to the DefaultColumnChooser's TopContainer property.</p>

<br/>


