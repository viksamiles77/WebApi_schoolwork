﻿using Microsoft.Data.SqlClient;
using Qinshift.EShop.DataAccess.Interface;
using Qinshift.EShop.DomainModels;

namespace Qinshift.EShop.DataAccess.AdonetImplementation
{
    public class CategoryAdoRepository : IRepository<Category>
    {
        private readonly string _connString;

        public CategoryAdoRepository(string connString)
        {
            _connString = connString;
        }

        public IEnumerable<Category> GetAll()
        {
            // 1. Create new connection to SQL db
            SqlConnection connection = new SqlConnection(_connString);

            // 2. Open the connection
            connection.Open();

            // 3. Create SQL command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM dbo.Categories";

            List<Category> categories = new List<Category>();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // FIRST APPROACH FROM GETTING VALUES FROM DB
                //categories.Add(new Category
                //{
                //    Id = reader.GetInt32(0),
                //    Name = reader.GetString(1),
                //    Description = reader.GetString(2),

                //});

                // SECOND APPROACH FROM GETTING VALUES FROM DB
                //categories.Add(new Category()
                //{
                //    Id = reader.GetFieldValue<int>(0),
                //    Name = reader.GetFieldValue<string>(1),
                //    Description = reader.GetFieldValue<string>(2),
                //    CreatedOn = reader.GetFieldValue<DateTime>(3),
                //});

                // THIRD APPROACH FROM GETTING VALUES FROM DB
                categories.Add(new Category()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                    CreatedOn = (DateTime)reader["CreatedOn"]
                });
            }
            connection.Close();
            return categories;
        }

        public Category GetById(int id)
        {
            SqlConnection connection = new SqlConnection(_connString);
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            // bad approach. Use method to add paramaters
            // cmd.CommandText = $"SELECT * FROM dbo.Categories WHERE Id = {id}";
            cmd.CommandText = "SELECT * FROM dbo.Categories WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            List<Category> categories = new List<Category>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categories.Add(new Category()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                    CreatedOn = (DateTime)reader["CreatedOn"]
                });
            }
            connection.Close();

            return categories.FirstOrDefault();
        }

        public int Add(Category entity)
        {
            SqlConnection connection = new SqlConnection(_connString);
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO dbo.Categories(Name, Description)" +
                "VALUES(@name, @description)";

            cmd.Parameters.AddWithValue("@name", entity.Name);
            cmd.Parameters.AddWithValue("@description", entity.Description);

            int rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }

        public int Update(Category entity)
        {
            SqlConnection connection = new SqlConnection(_connString);
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE dbo.Categories " +
                              "SET Name = @name, Description = @description" +
                              "WHERE Id = @id";

            cmd.Parameters.AddWithValue("@id", entity.Id);
            cmd.Parameters.AddWithValue("@name", entity.Name);
            cmd.Parameters.AddWithValue("@description", entity.Description);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public int Remove(int id)
        {

            SqlConnection connection = new SqlConnection(_connString);
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE * FROM dbo.Categories WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
    }
}
