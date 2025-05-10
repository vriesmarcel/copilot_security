using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GloboTicket.Frontend.Controllers
{
    public class LoginController(SqlConnection connection) : Controller
    {
        private readonly SqlConnection _connection = connection;
        [HttpGet("login")]
        public IActionResult Login(string username, string password) 
        {

        string query = 
        "SELECT * FROM Users WHERE Username = @username AND Password = @password";

        using var command = new SqlCommand(query, _connection);
        command.Parameters.Add(new SqlParameter("@username", username));
        command.Parameters.Add(new SqlParameter("@password", password));

        using var reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            return Ok("Login successful");
        }

        return Unauthorized("Invalid credentials");
        }
    }
}
