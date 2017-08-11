using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Library
{
    public class DataRenderer
    {
        private readonly IDbDataAdapter _dataAdapter;

        public DataRenderer()
        {
        }

        public DataRenderer(IDbDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Rendering...");
            var myDataSet = new DataSet();
            _dataAdapter.Fill(myDataSet);

            foreach (DataTable table in myDataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write($"{column.ColumnName.PadRight(20)} ");
                }
                writer.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        writer.Write($"{row[i].ToString().PadRight(20)} ");
                    }
                }
                writer.WriteLine();
            }
        }
    }
}
