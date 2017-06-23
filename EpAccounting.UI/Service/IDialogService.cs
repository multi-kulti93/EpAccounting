﻿// ///////////////////////////////////
// File: IDialogService.cs
// Last Change: 13.03.2017  21:01
// Author: Andre Multerer
// ///////////////////////////////////



namespace EpAccounting.UI.Service
{
    using System.Threading.Tasks;



    public interface IDialogService
    {
        Task ShowMessage(string title, string message);

        Task<bool> ShowDialogYesNo(string title, string message);

        Task<bool> ShowCustomDialog(string title, string message, string button1, string button2);

        string ShowDatabaseFileDialog();

        string ShowFolderDialog();
    }
}