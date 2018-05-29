using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using _5051.Models;
namespace _5051.Backend
{
    /// <summary>
    /// Backend Mock DataSource for Avatars, to manage them
    /// </summary>
    public class AvatarDataSourceMock : IAvatarInterface
    {
        /// <summary>
        /// Make into a Singleton
        /// </summary>
        private static volatile AvatarDataSourceMock instance;
        private static object syncRoot = new Object();

        private AvatarDataSourceMock() { }

        public static AvatarDataSourceMock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new AvatarDataSourceMock();
                            instance.Initialize();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// The Avatar List
        /// </summary>
        private List<AvatarModel> avatarList = new List<AvatarModel>();

        /// <summary>
        /// Makes a new Avatar
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Avatar Passed In</returns>
        public AvatarModel Create(AvatarModel data)
        {
            avatarList.Add(data);
            return data;
        }

        /// <summary>
        /// Return the data for the id passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Null or valid data</returns>
        public AvatarModel Read(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }

            var myReturn = avatarList.Find(n => n.Id == id);
            return myReturn;
        }

        /// <summary>
        /// Update all attributes to be what is passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Null or updated data</returns>
        public AvatarModel Update(AvatarModel data)
        {
            if (data == null)
            {
                return null;
            }
            var myReturn = avatarList.Find(n => n.Id == data.Id);

            myReturn.Update(data);

            return myReturn;
        }

        /// <summary>
        /// Remove the Data item if it is in the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True for success, else false</returns>
        public bool Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                return false;
            }

            var myData = avatarList.Find(n => n.Id == Id);
            var myReturn = avatarList.Remove(myData);
            return myReturn;
        }

        /// <summary>
        /// Return the full dataset
        /// </summary>
        /// <returns>List of Avatars</returns>
        public List<AvatarModel> Index()
        {
            return avatarList;
        }

        /// <summary>
        /// Reset the Data, and reload it
        /// </summary>
        public void Reset()
        {
            Initialize();
        }

        /// <summary>
        /// Create Placeholder Initial Data
        /// </summary>
        public void Initialize()
        {
            LoadDataSet(DataSourceDataSetEnum.Default);
        }

        /// <summary>
        /// Clears the Data
        /// </summary>
        private void DataSetClear()
        {
            avatarList.Clear();
        }

        /// <summary>
        /// The Defalt Data Set
        /// </summary>
        private void DataSetDefault()
        {
            DataSetClear();
            var count = 0;
            Create(new AvatarModel("../../Content/AvatarIcons/cat-icon.png", "cat", "cat"));
            Create(new AvatarModel("../../Content/AvatarIcons/dog-icon.png", "dog", "dog"));
            Create(new AvatarModel("../../Content/AvatarIcons/elephant-icon.png", "elephant", "elephant"));
            Create(new AvatarModel("../../Content/AvatarIcons/fox-icon.png", "fox", "fox"));
            Create(new AvatarModel("../../Content/AvatarIcons/frog-icon.png", "frog", "frog"));
            Create(new AvatarModel("../../Content/AvatarIcons/rabbit-icon.png", "rabbit", "rabbit"));
            Create(new AvatarModel("../../Content/AvatarIcons/squirrel-icon.png", "squirrel", "squirrel"));
            Create(new AvatarModel("../../Content/AvatarIcons/swan-icon.png", "swan", "swan"));
        }

        /// <summary>
        /// Data set for demo
        /// </summary>
        private void DataSetDemo()
        {
            DataSetDefault();
        }

        /// <summary>
        /// Unit Test data set
        /// </summary>
        private void DataSetUnitTest()
        {
            DataSetDefault();
        }

        /// <summary>
        /// Set which data to load
        /// </summary>
        /// <param name="setEnum"></param>
        public void LoadDataSet(DataSourceDataSetEnum setEnum)
        {
            switch (setEnum)
            {
                case DataSourceDataSetEnum.Demo:
                    DataSetDemo();
                    break;

                case DataSourceDataSetEnum.UnitTest:
                    DataSetUnitTest();
                    break;

                case DataSourceDataSetEnum.Default:
                default:
                    DataSetDefault();
                    break;
            }
        }
    }
}