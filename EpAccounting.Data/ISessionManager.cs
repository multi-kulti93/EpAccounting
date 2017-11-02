﻿// ///////////////////////////////////
// File: ISessionManager.cs
// Last Change: 28.10.2017  12:25
// Author: Andre Multerer
// ///////////////////////////////////



namespace EpAccounting.Data
{
    using NHibernate;



    public interface ISessionManager
    {
        #region Properties

        bool IsConnected { get; }

        string FilePath { get; }

        #endregion



        void CreateDatabase(string folderPath);

        void LoadDatabase(string filePath);

        void CloseDatabase();

        ISession OpenSession();
    }
}