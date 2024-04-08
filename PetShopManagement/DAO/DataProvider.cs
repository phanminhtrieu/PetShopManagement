using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        internal static DataProvider Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set => instance = value; 
        }

        private DataProvider() { }

        public List<T> Query<T>(string query, object[] inputParameter = null)
        {
            List<T> listObject = new List<T>();

            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();
                string[] subQuery = query.Split(' ');
                int index = 0;
                if (inputParameter != null)
                {
                    DynamicParameters sqlParameter = new DynamicParameters();
                    foreach (string item in subQuery)
                    {
                        bool isSqlParameter = item.Contains('@');
                        if (isSqlParameter)
                        {
                            sqlParameter.Add(item, inputParameter[index]);
                            index++;
                        }
                    }
                }
                listObject = connection.Query<T>(query, inputParameter).ToList();
                connection.Close();
            }
            return listObject;
        }
        public int Execute(string query, object[] inputParameter = null)
        {
            int numberOfRowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();

                string[] subQuery = query.Split(' ');
                int index = 0;
                if (inputParameter != null)
                {
                    DynamicParameters sqlParameter = new DynamicParameters();
                    foreach (string item in subQuery)
                    {
                        bool isSqlParameter = item.Contains('@');
                        if (isSqlParameter)
                        {
                            sqlParameter.Add(item, inputParameter[index]);
                            index++;
                        }
                    }
                }
                numberOfRowsAffected = connection.Execute(query, inputParameter);
                connection.Close();
            }
            return numberOfRowsAffected;
        }
        public object ExecuteScalar(string query, object[] inputParameter = null)
        {
            object result = null;

            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();

                string[] subQuery = query.Split(' ');
                int index = 0;
                if (inputParameter != null)
                {
                    DynamicParameters sqlParameter = new DynamicParameters();
                    foreach (string item in subQuery)
                    {
                        bool isSqlParameter = item.Contains('@');
                        if (isSqlParameter)
                        {
                            sqlParameter.Add(item, inputParameter[index]);
                            index++;
                        }
                    }
                }
                result = connection.ExecuteScalar(query, inputParameter);
                connection.Close();
            }
            return result;
        }


        // OVERLOADING
        public List<T> Query<T>(string query, object inputParameter)
        {
            List<T> listObject = new List<T>();

            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();
                string[] subQuery = query.Split(' ');
                if (inputParameter != null)
                {
                    DynamicParameters sqlParameter = new DynamicParameters();
                    foreach (string item in subQuery)
                    {
                        bool isSqlParameter = item.Contains('@');

                        if (isSqlParameter)
                        {
                            sqlParameter.Add(item, inputParameter);
                        }
                    }
                }
                listObject = connection.Query<T>(query, inputParameter).ToList();
                connection.Close();
            }
            return listObject;
        }
        public int Execute(string query, object inputParameter)
        {
            int numberOfRowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();

                string[] subQuery = query.Split(' ');
                if (inputParameter != null)
                {
                    DynamicParameters sqlParameter = new DynamicParameters();
                    foreach (string item in subQuery)
                    {
                        bool isSqlParameter = item.Contains('@');
                        if (isSqlParameter)
                        {
                            sqlParameter.Add(item, inputParameter);
                        }
                    }
                }
                numberOfRowsAffected = connection.Execute(query, inputParameter);
                connection.Close();
            }
            return numberOfRowsAffected;
        }
        public object ExecuteScalar(string query, object inputParameter)
        {
            object result = null;

            using (SqlConnection connection = new SqlConnection(ConnectToDatabase.connectionString))
            {
                connection.Open();

                string[] subQuery = query.Split(' ');
                if (inputParameter != null)
                {
                    DynamicParameters sqlParameter = new DynamicParameters();
                    foreach (string item in subQuery)
                    {
                        bool isSqlParameter = item.Contains('@');
                        if (isSqlParameter)
                        {
                            sqlParameter.Add(item, inputParameter);
                        }
                    }
                }
                result = connection.ExecuteScalar(query, inputParameter);
                connection.Close();
            }
            return result;
        }


    }
}
