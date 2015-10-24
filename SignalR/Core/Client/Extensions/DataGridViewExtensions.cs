using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SignalR.Core.Model;

namespace SignalR.Core.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void AddCheckBoxColumn(this DataGridView dgv)
        {
            DataGridViewColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selected";
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.Width = 100;
            checkBoxColumn.Visible = true;
            checkBoxColumn.ReadOnly = false;
            dgv.Columns.Add(checkBoxColumn);
        }

        public static void SetColumns(this DataGridView dgv, bool isReadOnly)
        {
            var nonStaticProperties =
                typeof(IUser).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty);

            foreach (var property in nonStaticProperties)
            {
                if (dgv.Columns[property.Name] != null)
                {
                    dgv.Columns[property.Name].ReadOnly = isReadOnly;
                    dgv.Columns[property.Name].HeaderText = GetHeaderName(property.Name);
                }
            }
        }

        /// <summary>
        /// Split string on uppercase only if next character is lowercase.
        /// example: "MyFavoriteChocIsDARKChocolate" ---[return]---> "My Favorite Choc Is DARK Chocolate"
        /// </summary>
        /// <param name="colName">Name of the col.</param>
        /// <returns></returns>
        private static string GetHeaderName(string colName)
        {
            var output = Regex.Replace(colName, "(((?<!^)[A-Z](?=[a-z]))|((?<=[a-z])[A-Z]))", " $1");

            return output;
        }
    }
}
