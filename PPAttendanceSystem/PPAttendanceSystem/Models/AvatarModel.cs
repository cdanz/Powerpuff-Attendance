using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace _5051.Models
{
    /// <summary>
    /// Avatars for the system
    /// </summary>
    public class AvatarModel
    {
        [Display(Name = "Id", Description = "Avatar Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        [Display(Name = "Uri", Description = "Picture to Show")]
        [Required(ErrorMessage = "Picture is required")]
        public string Uri { get; set; }

        [Display(Name = "Name", Description = "Avatar Name")]
        [Required(ErrorMessage = "Avatar Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description", Description = "Avatar Description")]
        [Required(ErrorMessage = "Avatar Description is required")]
        public string Description { get; set; }

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
        public AvatarModel()
        {
            Initialize();
        }

        /// <summary>
        /// Make an Avatar from values passed in
        /// </summary>
        /// <param name="uri">The Picture path</param>
        /// <param name="name">Avatar Name</param>
        /// <param name="description">Avatar Description</param>
        public AvatarModel(string uri, string name, string description)
        {
            Initialize();

            Uri = uri;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Used to Update Avatar Before doing a data save
        /// Updates everything except for the ID
        /// </summary>
        /// <param name="data">Data to update</param>
        public void Update(AvatarModel data)
        {
            if (data == null)
            {
                return;
            }

            Uri = data.Uri;
            Name = data.Name;
            Description = data.Description;
        }
    }
}