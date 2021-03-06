﻿// ///////////////////////////////////
// File: DatabaseFactory.cs
// Last Change: 17.02.2018, 14:28
// Author: Andre Multerer
// ///////////////////////////////////

namespace EpAccounting.UI
{
    using System.IO;
    using Properties;


    public static class DatabaseFactory
    {
        #region Fields

        private const string DirectoryDesktop = @"D:\Downloads";
        private const string DirectorySurface = @"C:\Users\andre\Desktop";
        private const string DirectoryFoldername = "TestFolder";

        #endregion



        #region Properties, Indexers

        public static string TestFolderPath
        {
            get
            {
                if (Directory.Exists(DirectoryDesktop))
                {
                    return Path.Combine(DirectoryDesktop, DirectoryFoldername);
                }

                return Path.Combine(DirectorySurface, DirectoryFoldername);
            }
        }

        public static string TestFilePath
        {
            get { return Path.Combine(TestFolderPath, Resources.Database_NameWithExtension); }
        }

        #endregion



        public static void CreateTestFolder()
        {
            if (Directory.Exists(TestFolderPath))
            {
                return;
            }

            Directory.CreateDirectory(TestFolderPath);
        }

        public static void CreateTestFile()
        {
            CreateTestFolder();

            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }

            FileStream fileStream = File.Create(TestFilePath);
            fileStream.Close();
        }

        public static void DeleteTestFolderAndFile()
        {
            if (Directory.Exists(TestFolderPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(TestFolderPath);
                directoryInfo.Delete(true);
            }
        }

        public static void SetSavedFilePath()
        {
            Settings.Default.DatabaseFilePath = TestFilePath;
            Settings.Default.Save();
        }

        public static void ClearSavedFilePath()
        {
            Settings.Default.DatabaseFilePath = string.Empty;
            Settings.Default.Save();
        }
    }
}