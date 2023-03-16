using Microsoft.AspNetCore.Mvc;
using RefHammer.Model;
using System.Data.SqlClient;

namespace RefHammer.Controllers
{
    [ApiController]
    [Route("stratagems")]
    public class StratagemController : ControllerBase
    {
        private string connectionString = "Data Source=DESKTOP-NEHSRM7;Initial Catalog=RefHammer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly ILogger<StratagemController> _logger;

        public StratagemController(ILogger<StratagemController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetStratagems")]
        public IEnumerable<Stratagems> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Execute a query to get data from the database
                string query = "SELECT * FROM Stratagems;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Process the data and return it to the view
                        // For example, you could create a list of objects from the data
                        List<Stratagems> myObjects = new List<Stratagems>();
                        while (reader.Read())
                        {
                            Stratagems myObject = new Stratagems
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                faction_id = Convert.ToString(reader["faction_id"]),
                                Name = Convert.ToString(reader["Name"]),
                                Type = Convert.ToString(reader["Type"]),
                                cp_cost = Convert.ToString(reader["cp_cost"]),
                                legend = Convert.ToString(reader["legend"]),
                                source_id = Convert.ToString(reader["source_id"]),
                                description = Convert.ToString(reader["description"]),
                                subfaction_id = Convert.ToString(reader["subfaction_id"]),

                            };
                            myObjects.Add(myObject);
                        }

                        return myObjects;
                    }
                }
            }
        }
    }
}