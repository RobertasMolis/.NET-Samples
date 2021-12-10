using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;

namespace ZooApp.Services
{
    public class ZooService
    {
        private readonly ILogger<ZooService> _logger;
        private SqlConnection _connection;

        public ZooService(ILogger<ZooService> logger, SqlConnection connection)
        {
            _logger = logger;
            _connection = connection;
        }

        public List<ZooModel> GetAll()
        {
            List<ZooModel> animals = new List<ZooModel>();

            _connection.Open();
            using var command = new SqlCommand("SELECT * FROM dbo.Zoo;", _connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
               ZooModel animal = new ZooModel();
                animal.Name = reader.GetString(0);
                animal.Gender = reader.GetString(1);
                animal.Age = reader.GetInt32(2);

                animals.Add(animal);
            }

            _connection.Close();
            return animals;
        }
    }
}
