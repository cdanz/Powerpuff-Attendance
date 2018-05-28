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
        public string Name { get; set; }

        /// <summary>
        /// Create the default values
        /// </summary>
        public void Initialize()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// New Avatar
        /// </summary>
        public UsernameModels()
        {
            Initialize();
        }

        /// <summary>
        /// Make an Avatar from values passed in
        /// </summary>
        /// <param name="uri">The Picture path</param>
        /// <param name="name">Avatar Name</param>
        /// <param name="description">Avatar Description</param>
        public UsernameModels(string name)
        {
            Initialize();

            Name = name;
        }

        /// <summary>
        /// Used to Update Avatar Before doing a data save
        /// Updates everything except for the ID
        /// </summary>
        /// <param name="data">Data to update</param>
        public void Update(UsernameModels data)
        {
            if (data == null)
            {
                return;
            }

            Name = data.Name;
        }
    }
}