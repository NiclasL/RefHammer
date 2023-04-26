using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RefHammer.Model;
using System.Data.SqlClient;

namespace RefHammer.Controllers
{
    [ApiController]
    // Allow CORS for all origins. (Caution!)
    [EnableCors()]
    [Route("factions")]
    public class FactionController : ControllerBase
    {
        private string connectionString = "Data Source=DESKTOP-NEHSRM7;Initial Catalog=RefHammer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly ILogger<StratagemController> _logger;

        public FactionController(ILogger<StratagemController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFactions")]
        public IEnumerable<Factions> GetFactions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Execute a query to get data from the database
                string query = "SELECT * FROM Factions;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Process the data and return it to the view
                        // For example, you could create a list of objects from the data
                        List<Factions> factions = new List<Factions>();
                        while (reader.Read())
                        {
                            Factions faction = new Factions
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Abbreviation = Convert.ToString(reader["short"]),
                                Name = Convert.ToString(reader["name"]),
                                Link = Convert.ToString(reader["link"]),
                                IsSubfaction = Convert.ToString(reader["is_subfaction"]),
                                ParentId = Convert.ToString(reader["parent_id"]),

                            };
                            factions.Add(faction);
                        }

                        return factions;
                    }
                }
            }
        }
    }
}