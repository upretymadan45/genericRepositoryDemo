using System;
using System.Collections.Generic;
using genericRepoDemo.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace genericRepoDemo.Repository
{
    public class StockRepository
    {
        private string _connString;

        public StockRepository(IConfiguration configuration)
        {
            _connString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Stock> GetAllStocks()
        {
            var stocks = new List<Stock>();

            using (var conn = new MySqlConnection(_connString))
            {
                conn.Open();

                var selectQuery = "select * from stock";

                var command = new MySqlCommand(selectQuery, conn);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var stock = new Stock();

                    stock.Id = Convert.ToInt32(reader["Id"]);
                    stock.ProductName = reader["ProductName"].ToString();
                    stock.Quantity = Convert.ToInt32(reader["Quantity"]);

                    stocks.Add(stock);
                }
            }

            return stocks;
        }
    }
}