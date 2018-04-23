using System;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;
using DevExpress.Xpf.Core.Native;

namespace ColumnChooserSL {
    public class CustomColumnChooserFactory : IColumnChooserFactory {
        public CustomColumnChooserFactory() {
          
        }

        public IColumnChooser Create(DevExpress.Xpf.Core.WPFCompatibility.SLControl owner) {
            DefaultColumnChooser chooser = new DefaultColumnChooser((DataViewBase)owner);
            chooser.TopContainer.AddHandler(UIElement.MouseLeftButtonDownEvent, new MouseButtonEventHandler(GridColumnHeader_MouseLeftButtonDown), true);
            return chooser;
        }

        private void GridColumnHeader_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount == 2) {

                GridColumnHeader header = LayoutHelper.FindParentObject<GridColumnHeader>((DependencyObject)e.OriginalSource);
                GridColumn gc = (GridColumn)header.DataContext;

                List<ColumnBase> lst = new List<ColumnBase>(gc.View.ColumnChooserColumns);
                for (int i = 0; i < lst.Count; i++) {
                    if (gc.ActualColumnChooserHeaderCaption == lst[i].ActualColumnChooserHeaderCaption) {
                        lst[i].Visible = true;
                        break;
                    }
                }
            }
        }
    }
}
