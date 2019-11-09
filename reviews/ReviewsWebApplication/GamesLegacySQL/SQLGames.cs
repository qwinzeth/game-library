using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace GamesLegacySQL
{
    public class SQLGames
    {
        public IEnumerable<LegacyDTOGame> GetGames()
        {
            List<LegacyDTOGame> games = new List<LegacyDTOGame>();
            using(var connection = new SqlConnection(ConfigurationManager.AppSettings["SQLConnectionString"]))
            {
                using (var command = new SqlCommand("SELECT * FROM games", connection))
                {
                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // TODO: Map with Dapper or something
                                games.Add(new LegacyDTOGame()
                                {
                                    GameID = Convert.ToInt64(reader["game_id"]),
                                    Description = Convert.ToString(reader["description"]),
                                    Title = Convert.ToString(reader["title"])
                                });
                            }

                            return games;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        // TODO: Proper logging
                        throw;
                    }
                }
            }
        }
    }
}
