using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraGrid_AllowColSizing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ultraGrid1.DataSource = GetData();

            ultraGrid1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;

            ultraGrid1.DisplayLayout.Bands[0].Columns[0].Width = 20;
            ultraGrid1.DisplayLayout.Bands[1].Columns[0].Width = 200;
        }

        public DataSet1 GetData()
        {
            DataSet1 ds = new DataSet1();

            DataTable table = ds.Tables["DataTable1"];
            for (int i = 0; i < 5; i++)
            {
                table.Rows.Add(i, "Hello " + i, i);
            }
            DataTable table2 = ds.Tables["DataTable2"];
            for (int i = 0; i < 5; i++)
            {
                table2.Rows.Add(i, "Hello " + i % 3, i % 3);
            }

            return ds;
        }
    }
}
