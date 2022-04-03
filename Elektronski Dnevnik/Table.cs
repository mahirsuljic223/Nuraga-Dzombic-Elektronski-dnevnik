using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    class Table
    {
        #region LoadFromFile
        public static DataTable LoadFromFile(string tableName, string orderRow = "ID", bool ASC = true)
        {
            DataTable result;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM [{0}]", tableName), conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            result = new DataTable("[" + tableName + "]");
                            adapter.Fill(result);

                            DataView dataView = result.DefaultView;

                            orderRow = orderRow.Replace(" ", String.Empty);

                            if (ASC)
                                dataView.Sort = orderRow + " ASC";
                            else
                                dataView.Sort = orderRow + " DESC";

                            result.TableName = tableName;
                            result = dataView.ToTable();
                        }
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public static DataTable LoadFromFile(string SQL, string tableName, string orderRow = "ID", bool ASC = true)
        {
            DataTable result;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(SQL, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            result = new DataTable("[" + SQL + "]");
                            adapter.Fill(result);

                            DataView dataView = result.DefaultView;

                            orderRow = orderRow.Replace(" ", String.Empty);

                            if (ASC)
                                dataView.Sort = orderRow + " ASC";
                            else
                                dataView.Sort = orderRow + " DESC";

                            result.TableName = tableName;
                            result = dataView.ToTable();
                        }
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        #endregion

        #region Insert
        // no auto-cols
        public static void Insert(string tableName, List<string> cols, List<string> values)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString);

                string SQL = "INSERT INTO " + tableName + " (";

                foreach (string col in cols)
                    SQL += col + ",";

                SQL = SQL.Substring(0, SQL.Length - 1);

                SQL += ") VALUES (";

                for (int i = 0; i < values.Count; i++)
                    SQL += "@value" + i + ",";

                SQL = SQL.Substring(0, SQL.Length - 1);

                SQL += ")";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQL;
                cmd.Connection = conn;

                for (int i = 0; i < values.Count; i++)
                    cmd.Parameters.AddWithValue("@value" + i, values[i]);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // with auto-cols
        public static void Insert(string tableName, DataTable table, List<string> values)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString);
                List<string> cols = new List<string>();

                for (int i = 1; i < 11 && i < table.Columns.Count; i++)
                    cols.Add(table.Columns[i].ColumnName);

                string SQL = "INSERT INTO " + tableName + " (";

                foreach (string col in cols)
                    SQL += col + ",";

                SQL = SQL.Substring(0, SQL.Length - 1);

                SQL += ") VALUES (";

                for (int i = 0; i < values.Count; i++)
                    SQL += "@value" + i + ",";

                SQL = SQL.Substring(0, SQL.Length - 1);

                SQL += ")";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQL;
                cmd.Connection = conn;

                for (int i = 0; i < values.Count; i++)
                    cmd.Parameters.AddWithValue("@value" + i, values[i]);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Update
        // multi
        public static void Update(string tableName, List<string> cols, List<string> values, string ID)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString);

                string SQL = "UPDATE " + tableName + " SET ";

                for (int i = 0; i < values.Count; i++)
                    SQL += cols[i] + "=" + "@value" + i + ",";

                SQL = SQL.Substring(0, SQL.Length - 1);

                SQL += " WHERE ID=@ID";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQL;
                cmd.Connection = conn;

                for (int i = 0; i < values.Count; i++)
                    cmd.Parameters.AddWithValue("@value" + i, values[i]);

                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // single
        public static void Update(string tableName, string column, string value, string ID)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString);

                string SQL = "UPDATE " + tableName + " SET " + column + "=@value WHERE ID=@ID";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQL;
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region AddColumn
        public static void AddColumn(string tableName, string columnName, string columnType = "TEXT")
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseString);

                string SQL = "ALTER TABLE " + tableName + " ADD " + columnName + " " + columnType + " NULL";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQL;
                cmd.Connection = conn;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        #endregion

        #region SubMethods
        public static void LoadTables()
        {
            try
            {
                List<DataTable> dataTables = new List<DataTable>();

                dataTables.Add(LoadFromFile("Predmeti"));
                dataTables.Add(LoadFromFile("Ucenici"));

                Properties.Settings.Default.Tables = dataTables;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Other
        public static void DisplayDataToGrid(DataTable dataTable, DataGridView dataGridView)
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = dataTable;
            dataGridView.DataSource = bind;
        }
        #endregion
    }
}