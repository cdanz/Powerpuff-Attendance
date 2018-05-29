using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5051.Models
{
    /// <summary>
    /// View Model for the Avatar Views to have the list of Avatars
    /// </summary>
    public class AvatarViewModel
    {
        /// <summary>
        /// The List of Avatars
        /// </summary>
        public List<AvatarModel> AvatarList = new List<AvatarModel>();
    }

    /// <summary>
    /// Adds a list of Avatar Lists per Level, making it easier to select
    /// </summary>
    public class AvatarListViewModel : AvatarViewModel
    {
        public List<AvatarViewModel> AvatarLevelList;
        public int MaxLevel;
    }

    /// <summary>
    /// Returns the selected Avatar and the Avatar List
    /// </summary>
    public class SelectedAvatarViewModel : AvatarListViewModel
    {
        public AvatarModel SelectedAvatar;
    }

    /// <summary>
    /// Adds the Student Information to the View Model for the Avatars availble for the student to select
    /// </summary>
    public class SelectedAvatarForStudentViewModel : SelectedAvatarViewModel
    {
        public StudentModel Student;
    }
}