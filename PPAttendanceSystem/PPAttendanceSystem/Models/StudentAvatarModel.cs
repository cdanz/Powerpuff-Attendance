using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _5051.Models
{
    /// <summary>
    /// Used when receiving what Avatar a Student should be assigned
    /// </summary>
    public class StudentAvatarModel
    {
        /// <summary>
        /// The Avatar ID to assign to the student
        /// </summary>
        [Display(Name = "AvatarId", Description = "Avatar Id")]
        [Required(ErrorMessage = "Id is required")]
        public string AvatarId { get; set; }

        /// <summary>
        /// The Student ID to receive the Avatar
        /// </summary>
        [Display(Name = "StudentId", Description = "Student Id")]
        [Required(ErrorMessage = "Id is required")]
        public string StudentId { get; set; }
    }
}