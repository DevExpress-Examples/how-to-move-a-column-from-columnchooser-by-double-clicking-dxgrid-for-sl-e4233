# How to move a column from ColumnChooser by double-clicking DXGrid for SL


<p>By default, ColumnChooser allows you to drag hidden columns back into the grid.</p><p>This example demonstrates how to enable similar behavior by restoring hidden columns from ColumnChooser on a double-click.</p><p>First, it is necessary to create a CustomColumnChooserFactory class that implements the IColumnChooserFactory interface.</p><p>In the IColumnChooserFactory.Create method, create your own DefaultColumnChooser and add the MouseLeftButtonDown event handler to the DefaultColumnChooser's TopContainer property.</p>

<br/>


