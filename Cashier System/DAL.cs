using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Cashier_System
{
    class DAL
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        
        public bool Add(string table, List<string> keys, List<string> values)
        { 
            int KeyIndex = 0;
            con.Open();
            string sql = "INSERT INTO " + table + " (";
            foreach (string key in keys) { sql += key + ","; };
            sql = sql.Remove(sql.Length - 1);
            sql += ") VALUES (";
            foreach (string value in values)
            {
                if(KeyIndex == 3 || KeyIndex == 4)    
                        sql +=  value  + ",";
                else
                    sql+= value+ ",";
                KeyIndex++;
            };
            sql = sql.Remove(sql.Length - 1);
            sql += ")";
            SqlCommand command = new SqlCommand(sql, con);
            int affectedRows = command.ExecuteNonQuery();
            Boolean IsConnectedDB = (con.State == ConnectionState.Open);

            con.Close();
            if (affectedRows == 1)
                return true;
            return false;
            
        }
        public bool Delete(string table, int id)
        {
            con.Open();
            string sql = "DELETE FROM " + table + " WHERE id = " + id;

            SqlCommand command = new SqlCommand(sql, con);
            int affectedRows = command.ExecuteNonQuery();
            con.Close();
            if (affectedRows == 1)
                return true;
            return false;
        }
        public bool Update(string table, List<string> keys, List<string> values, string refr, string id)
        {
            con.Open();
            string sql = "UPDATE " + table + " SET ";
            int i = 0;
            foreach (string key in keys)
            {

                sql += key + " = " + "'" + values[i] + "'" + " , ";

                i++;
            };
            sql = sql.Remove(sql.Length - 2);
            sql += " WHERE " + refr + "=" + id;
            SqlCommand command = new SqlCommand(sql, con);
            int affectedRows = command.ExecuteNonQuery();
            con.Close();
            if (affectedRows == 1)
                return true;
            return false;
        }




        public DataSet find(string table, string key, string value)
        {
            con.Open();
            string sql = "SELECT * FROM " + table + " WHERE " + key + "=" + value;
            SqlDataAdapter DA = new SqlDataAdapter(sql, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            return DS;
        }



        public DataSet finds(string table, string key, string value)
        {
            con.Open();
            string sql = "SELECT * FROM " + table + " WHERE " + key + "=" + "'" + value + "'";
            SqlDataAdapter DA = new SqlDataAdapter(sql, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            return DS;
        }




        public DataSet search(string table)
        {
            con.Open();
            string sql = "SELECT * FROM " + table;
            SqlDataAdapter DA = new SqlDataAdapter(sql, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            return DS;
        }


        public void close()
        {
            con.Close();
        }
    }
}
