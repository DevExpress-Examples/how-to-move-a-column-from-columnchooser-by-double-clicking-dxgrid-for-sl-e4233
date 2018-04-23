using System;

namespace ColumnChooserSL {
    public class Record {

        public Record(string s1, string s2, string s3, string s4, string s5) {
            Field1 = s1;
            Field2 = s2;
            Field3 = s3;
            Field4 = s4;
            Field5 = s5;
        }

        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
    }
}
