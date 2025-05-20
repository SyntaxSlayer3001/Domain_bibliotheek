using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_bibliotheek.Business;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace Domain_bibliotheek.Persistence
{
    public class Boekmapper
    {
        private readonly string _connectionString;

        public Boekmapper(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task InsertBoekAsync(string titel, string genre, string auteur, string uitgever, string taal, int boekenId, int graad, string isbn)
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                await connection.OpenAsync();
                using var command = new MySqlCommand(
                    "INSERT INTO boeken (Titel, GenreId, Auteur, Uitgever, Taal, BoekenId, Graad, ISBN) VALUES (@titel, @genre, @auteur, @uitgever, @taal, @boekenId, @graad, @isbn)",
                    connection);
                command.Parameters.AddWithValue("@Titel", titel ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Genreid", genre ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Auteur", auteur ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Uitgever", uitgever ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Taal", taal ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@BoekenId", boekenId);
                command.Parameters.AddWithValue("@Graad", graad);
                command.Parameters.AddWithValue("@ISBN", isbn ?? (object)DBNull.Value);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                // Log exception or rethrow as needed
                throw new ApplicationException("Error inserting book.", ex);
            }
        }

        public async Task<List<Boek>> GetBoekenAsync()
        {
            var boekenlijst = new List<Boek>();
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                await connection.OpenAsync();
                using var command = new MySqlCommand("SELECT * FROM boeken", connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var boek = new Boek
                    {
                        Titel = reader["titel"]?.ToString(),
                        Genre = reader["genre"]?.ToString(),
                        Auteur = reader["auteur"]?.ToString(),
                        Uitgever = reader["uitgever"]?.ToString(),
                        Taal = reader["taal"]?.ToString(),
                        BoekenId = Convert.ToInt32(reader["boekenId"]),
                        Graad = Convert.ToInt32(reader["graad"]),
                        Isbn = reader["isbn"]?.ToString()
                    };
                    boekenlijst.Add(boek);
                }
            }
            catch (Exception ex)
            {
                // Log exception or rethrow as needed
                throw new ApplicationException("Error retrieving books.", ex);
            }
            return boekenlijst;
        }
    }
}
