using System;
using System.ComponentModel.DataAnnotations;

namespace _5051.Models
{
    public class UsernameModels
    {

        [Display(Name = "Id", Description = "User Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Display(Name = "Name", Description = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        /// <summary>
        /// Create the default values
        /// </summary>
        public void Initialize()
        {
            Id = Guid.NewGuid().ToString();
            Username = "Mystery Explorer";
        }

        /// <summary>
        /// New Username
        /// </summary>
        public UsernameModels()
        {
            Initialize();
        }

        /// <summary>
        /// Make a profile username from values passed in
        /// </summary>
        /// <param Username="name">Profile Name</param>
        public UsernameModels(string name)
        {
            Initialize();

            Username = name;
        }

        /// <summary>
        /// Used to Update Username Before doing a data save
        /// Updates everything except for the ID
        /// </summary>
        /// <param name="data">Data to update</param>
        public void Update(UsernameModels data)
        {
            if (data == null)
            {
                return;
            }

            Username = data.Username;
        }
    }
}