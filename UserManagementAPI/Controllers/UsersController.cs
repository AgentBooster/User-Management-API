using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using System.Collections.Concurrent;
using System.Threading;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly ConcurrentDictionary<int, User> _users = new();
        private static int _nextId = 0;

        // GET: api/users
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_users.Values);
        }

        // GET: api/users/5
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            if (_users.TryGetValue(id, out var user))
            {
                return Ok(user);
            }
            return NotFound(new { error = "User not found." });
        }

        // POST: api/users
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            user.Id = Interlocked.Increment(ref _nextId);
            _users[user.Id] = user;

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // PUT: api/users/5
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_users.ContainsKey(id))
            {
                return NotFound(new { error = "User not found." });
            }

            user.Id = id;
            _users[id] = user;

            return NoContent();
        }

        // DELETE: api/users/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (_users.TryRemove(id, out _))
            {
                return NoContent();
            }
            return NotFound(new { error = "User not found." });
        }
    }
}
