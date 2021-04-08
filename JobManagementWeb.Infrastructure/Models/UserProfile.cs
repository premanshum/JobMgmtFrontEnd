using System.ComponentModel.DataAnnotations;

namespace JobManagementWeb.Infrastructure.Models
{
    /// <summary>
    /// UserProfile
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// User Name
        /// </summary>
        [Required(ErrorMessage = "Please enter UserID")]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}
