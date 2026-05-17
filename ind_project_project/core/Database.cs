using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using ind_project_project.core;
using ind_project_project.models;
using Microsoft.Data.Sqlite;

namespace ind_project_project.core {

    internal class Database
    {
        private string _connectionString = "Data Source=storage.db";
        public static Database Instance { get; } = new Database();
        public event EventHandler<EventArgs>? DatabaseWiped;
        public Database()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = """
                CREATE TABLE IF NOT EXISTS `work_records` (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    amount FLOAT,
                    hours INTEGER,
                    minutes INTEGER,
                    price_per_hour FLOAT
                );
            """;
            cmd.ExecuteNonQuery();
        }

        public void AddRecord(TimeWorkSession session)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO `work_records` (amount, hours, minutes, price_per_hour)
                VALUES($amount, $hours, $minutes, $price_per_hour)
                """;
            command.Parameters.AddWithValue("$amount", session.GetGrossIncome());
            command.Parameters.AddWithValue("$hours", session.Hours);
            command.Parameters.AddWithValue("$minutes", session.Minutes);
            command.Parameters.AddWithValue("$price_per_hour", session.HourRate);
            command.ExecuteNonQuery();
        }

        public void AddRecord(FixedPriceWork session)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO `work_records` (amount)
                VALUES($amount)
                """;
            command.Parameters.AddWithValue("$amount", session.GetGrossIncome());
            command.ExecuteNonQuery();
        }

        public void DeleteRecord(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = """
                DELETE FROM `work_records`
                WHERE id = $id
                """;
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public void EditRecord(int recordID, string field, object newValue)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = $"""
                UPDATE `work_records`
                SET {field} = $newValue
                WHERE id = $id
                """;
            command.Parameters.AddWithValue("$newValue", newValue);
            command.Parameters.AddWithValue("$id", recordID);
            command.ExecuteNonQuery();
        }

        public void WipeRecords()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = """
                DELETE FROM `work_records`
                """;

            command.ExecuteNonQuery();
            DatabaseWiped?.Invoke(this, new EventArgs());
        }

        public List<BaseRecord> GetRecords()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT 
                    id, 
                    date, 
                    amount, 
                    hours, 
                    minutes,
                    price_per_hour
                    FROM `work_records`
                """;
            using var reader = command.ExecuteReader();

            List<BaseRecord> records = new List<BaseRecord>();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                DateTime date = reader.GetDateTime(1);
                float sum = reader.GetFloat(2);

                if (reader.IsDBNull(3))
                {
                    FixedPriceWork record = new FixedPriceWork(sum);
                    record.ID = id;
                    record.Date = date;
                    records.Add(record);
                } else
                {
                    int hours = reader.GetInt32(3);
                    int minutes = reader.GetInt32(4);
                    int hourRate = reader.GetInt32(5);

                    TimeWorkSession record = new TimeWorkSession(hours, minutes, hourRate);
                    record.ID = id;
                    record.Date = date;
                    records.Add(record);
                }
            }

            return records;
        }
    }
}
