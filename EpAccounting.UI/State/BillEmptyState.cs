﻿// ///////////////////////////////////
// File: BillEmptyState.cs
// Last Change: 09.05.2017  19:03
// Author: Andre Multerer
// ///////////////////////////////////



namespace EpAccounting.UI.State
{
    using System.Threading.Tasks;
    using EpAccounting.Model;
    using EpAccounting.UI.Properties;
    using EpAccounting.UI.ViewModel;
    using GalaSoft.MvvmLight.Messaging;



    public class BillEmptyState : IBillState
    {
        #region Fields

        private readonly BillEditViewModel billEditViewModel;

        #endregion



        #region Constructors / Destructor

        public BillEmptyState(BillEditViewModel billEditViewModel)
        {
            this.billEditViewModel = billEditViewModel;
        }

        #endregion



        #region IBillState Members

        public bool CanSwitchToSearchMode()
        {
            return true;
        }

        public void SwitchToSearchMode()
        {
            this.billEditViewModel.Load(new Bill() {Client = new Client()}, this.billEditViewModel.GetBillSearchState());
            Messenger.Default.Send(new NotificationMessage(Resources.Messenger_Message_LoadBillSearchViewModelMessageForBillVM));
        }

        public bool CanSwitchToEditMode()
        {
            return false;
        }

        public void SwitchToEditMode()
        {
            // do nothing
        }

        public bool CanCommit()
        {
            return false;
        }

        public Task Commit()
        {
            return Task.FromResult<object>(null);
        }

        public bool CanCancel()
        {
            return false;
        }

        public void Cancel()
        {
            // do nothing
        }

        public bool CanDelete()
        {
            return false;
        }

        public Task Delete()
        {
            return Task.FromResult<object>(null);
        }

        #endregion
    }
}