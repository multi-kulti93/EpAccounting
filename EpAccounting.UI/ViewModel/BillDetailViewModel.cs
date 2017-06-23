﻿// ///////////////////////////////////
// File: BillDetailViewModel.cs
// Last Change: 19.06.2017  19:46
// Author: Andre Multerer
// ///////////////////////////////////



namespace EpAccounting.UI.ViewModel
{
    using EpAccounting.Model;



    public class BillDetailViewModel : BindableViewModelBase
    {
        #region Fields

        private readonly Bill bill;

        #endregion



        #region Constructors / Destructor

        public BillDetailViewModel(Bill bill)
        {
            this.bill = bill;
        }

        #endregion



        #region Properties

        public int BillId
        {
            get { return this.bill.BillId; }
            set { this.SetProperty(this.bill.BillId, value, () => this.bill.BillId = value); }
        }

        public string KindOfBill
        {
            get { return this.bill.KindOfBill; }
            set { this.SetProperty(this.bill.KindOfBill, value, () => this.bill.KindOfBill = value); }
        }

        public string KindOfVat
        {
            get { return this.bill.KindOfVat; }
            set { this.SetProperty(this.bill.KindOfVat, value, () => this.bill.KindOfVat = value); }
        }

        public double VatPercentage
        {
            get { return this.bill.VatPercentage; }
            set { this.SetProperty(this.bill.VatPercentage, value, () => this.bill.VatPercentage = value); }
        }

        public string Date
        {
            get { return this.bill.Date; }
            set { this.SetProperty(this.bill.Date, value, () => this.bill.Date = value); }
        }

        public int ClientId
        {
            get { return this.bill.Client.ClientId; }
            set { this.SetProperty(this.bill.Client.ClientId, value, () => this.bill.Client.ClientId = value); }
        }

        public string Title
        {
            get { return this.bill.Client.Title; }
            set { this.SetProperty(this.bill.Client.Title, value, () => this.bill.Client.Title = value); }
        }

        public string FirstName
        {
            get { return this.bill.Client.FirstName; }
            set { this.SetProperty(this.bill.Client.FirstName, value, () => this.bill.Client.FirstName = value); }
        }

        public string LastName
        {
            get { return this.bill.Client.LastName; }
            set { this.SetProperty(this.bill.Client.LastName, value, () => this.bill.Client.LastName = value); }
        }

        public string Street
        {
            get { return this.bill.Client.Street; }
            set { this.SetProperty(this.bill.Client.Street, value, () => this.bill.Client.Street = value); }
        }

        public string HouseNumber
        {
            get { return this.bill.Client.HouseNumber; }
            set { this.SetProperty(this.bill.Client.HouseNumber, value, () => this.bill.Client.HouseNumber = value); }
        }

        public string PostalCode
        {
            get { return this.bill.Client.PostalCode; }
            set { this.SetProperty(this.bill.Client.PostalCode, value, () => this.bill.Client.PostalCode = value); }
        }

        public string City
        {
            get { return this.bill.Client.City; }
            set { this.SetProperty(this.bill.Client.City, value, () => this.bill.Client.City = value); }
        }

        #endregion
    }
}