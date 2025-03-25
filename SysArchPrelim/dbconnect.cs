﻿using System;
using System.Data.OleDb;

namespace SysArchPrelim
{
    public class DBConnect
    {
        private OleDbConnection connection;

        public DBConnect()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Joshua Therence\\Desktop\\SysArchPrelim\\SysArchPrelim\\Database.mdb\"");
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public OleDbDataReader ExecuteQuery(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, connection);
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, connection);
            return cmd.ExecuteNonQuery();
        }
    }
}