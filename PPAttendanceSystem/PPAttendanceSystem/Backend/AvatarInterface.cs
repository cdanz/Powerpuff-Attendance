using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _5051.Models;

namespace _5051.Backend
{

    /// <summary>
    /// Datasource Interface for Avatars
    /// </summary>
    public interface IAvatarInterface
    {
        AvatarModel Create(AvatarModel data);
        AvatarModel Read(string id);
        AvatarModel Update(AvatarModel data);
        bool Delete(string id);
        List<AvatarModel> Index();
        void Reset();
        void LoadDataSet(DataSourceDataSetEnum setEnum);
    }
}