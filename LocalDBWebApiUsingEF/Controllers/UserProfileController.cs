using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataTierWebServer.Models;
using DataTierWebServer.Data;
using Microsoft.CodeAnalysis.Scripting;
using System.Xml.Linq;
using DataTierWebServer.Models.Exceptions;

namespace DataTierWebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly DBManager _context;

        public UserProfileController(DBManager context)
        {
            _context = context;
        }

        // GET: api/userprofile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfile>>> GetUserProfile()
        {
            if (_context.UserProfiles == null)
            {
                var ex = new DataGenerationFailException("UserProfiles");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }
            return await _context.UserProfiles.ToListAsync();
        }

        [HttpGet("image/{id}")]
        public async Task<IActionResult> GetUserProfileImage(int id)
        {
            if (_context.UserProfiles == null)
            {
                var ex = new DataGenerationFailException("UserProfiles");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }

            var userProfile = await _context.UserProfiles.FindAsync(id);

            if (userProfile == null || userProfile.ProfileImage == null)
            {
                var ex = new MissingProfileException($"'{id}'");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }

            // Return the image as a file
            return File(userProfile.ProfileImage, "image/jpeg"); // Adjust the content type based on your image format
        }

        // GET: api/userprofile/Mike
        [HttpGet("byname/{name}")]
        public async Task<ActionResult<UserProfile>> GetUserProfileByName(string name)
        {
            if (_context.UserProfiles == null)
            {
                var ex = new DataGenerationFailException("UserProfiles");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(up => up.FName == name);

            if (userProfile == null)
            {
                var ex = new MissingProfileException($"'{name}'");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }

            return userProfile;
        }


        // GET: api/userprofile/5
        [HttpGet("byemail/{email}")]
        public async Task<ActionResult<UserProfile>> GetUserProfileByEmail(string email)
        {
            if (_context.UserProfiles == null)
            {
                var ex = new DataGenerationFailException("UserProfiles");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(up => up.Email == email);

            if (userProfile == null)
            {
                var ex = new MissingProfileException($"'{email}'");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }

            return userProfile;
        }

        // PUT: api/userprofile/1
        /* BODY -> row -> Enter new updated userprofile for the id
         * {
            "id": 1, 
            "name": "Sajib Updated",
            "email": "sajib_updated@email.com",
            "address": "1 Street Suburb Updated",
            "phoneNumber": 9876543,
            "profilePictureUrl": "UpdatedImageUrl",
            "password": "UpdatedPassword"
        }
        */
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserProfile(int id, UserProfile userProfile)
        {
            if (id != userProfile.Id)
            {
                var ex = new MismatchIdException($"'{id}' vs '{userProfile.Id}'");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return BadRequest(errorResponse);
            }

            _context.Entry(userProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserProfileExists(id))
                {
                    var ex = new MissingProfileException($"'{id}'");
                    var errorResponse = new
                    {
                        ErrorType = ex.GetType().Name.ToString(),
                        ErrorMessage = ex.Message,
                    };
                    return NotFound(errorResponse);
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/userprofile
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserProfile>> PostUserProfile(UserProfile userProfile)
        {
            if (_context.UserProfiles == null)
            {
                var ex = new DataGenerationFailException("UserProfiles");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }
            
            _context.UserProfiles.Add(userProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserProfile", new { id = userProfile.Id }, userProfile);
        }

        // DELETE: api/userprofile/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserProfile(int id)
        {
            if (_context.UserProfiles == null)
            {
                var ex = new DataGenerationFailException("UserProfiles");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }
            var userProfile = await _context.UserProfiles.FindAsync(id);
            if (userProfile == null)
            {
                var ex = new MissingProfileException($"'{id}'");
                var errorResponse = new
                {
                    ErrorType = ex.GetType().Name.ToString(),
                    ErrorMessage = ex.Message,
                };
                return NotFound(errorResponse);
            }

            _context.UserProfiles.Remove(userProfile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserProfileExists(int id)
        {
            return (_context.UserProfiles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
