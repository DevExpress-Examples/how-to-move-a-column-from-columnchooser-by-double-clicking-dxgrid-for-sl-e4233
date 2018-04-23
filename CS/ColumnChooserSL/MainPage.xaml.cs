using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Grid;

namespace ColumnChooserSL {
    public partial class MainPage : UserControl {
        ObservableCollection<Record> records;
        public MainPage() {
            InitializeComponent();
            FillData();
        }

        public void FillData() {
            records = new ObservableCollection<Record>();
            records.Add(new Record("a", "a", "a", "a", "a"));
            records.Add(new Record("b", "b", "b", "b", "b"));
            records.Add(new Record("c", "c", "c", "c", "c"));

            gridControl1.ItemsSource = records;
            ColumnChooserInit();
        }

        private void ColumnChooserInit() {
            gridControl1.Columns[1].Visible = false;
            gridControl1.Columns[2].Visible = false;
        }
    }
}
