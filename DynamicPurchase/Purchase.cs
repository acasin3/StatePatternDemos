using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DynamicPurchase
{
    public class Purchase : INotifyPropertyChanged
    {
        private Supplier _supplier;
        private string _supplierTIN;
        private string _supplierName;
        private string _registrationType;
        private string _docNo;

        private int _vat = 0;
        private int _percentageTax;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Supplier Supplier
        {
            get
            {
                return _supplier;
            }
            set
            {
                _supplier = value;
                // update fields that depend on the new supplier
                _registrationType = _supplier.RegistrationType;
            }
        }

        public string SupplierTIN 
        { 
            get
            {
                return _supplierTIN;
            }
            set
            {
                _supplierTIN = value;
                // For now, we'll just use a simple logic to identify VAT-Registered and
                // Non-VAT-Registered suppliers. Same for the computation of VAT and
                // percentage tax. In reality, this should come from a database or an
                // API call.
                if ( _supplierTIN.EndsWith("0") )
                {
                    _supplierName = "Non-VAT Supplier Din";
                    _registrationType = "Non-VAT";
                    _vat = 0;
                    _percentageTax = 7;
                }
                else
                {
                    _supplierName = "VAT Supplier Din";
                    _registrationType = "VAT";
                    _vat = 10;
                    _percentageTax = 0;
                }
                // Get details from data store and update supplier fields
                NotifyPropertyChanged();
            }
        }

        public string SupplierName
        {
            get
            {
                return _supplierName;
            }
            set
            {
                _supplierName = value;
                NotifyPropertyChanged();
            }
        }

        public string RegistrationType => _registrationType;

        public string DocNo
        {
            get
            {
                return _docNo;
            }
            set
            {
                _docNo = value;
                NotifyPropertyChanged();
            }
        }

        public decimal PercentageTax
        {
            get {
                if (_registrationType == "VAT")
                    throw new InvalidOperationException("Invalid. Supplier is VAT-registered.");

                return _percentageTax; 
            }
        }

        public decimal VAT
        {
            get
            {
                if (_registrationType == "Non-VAT")
                    throw new InvalidOperationException("Invalid. Supplier is Non-VAT-registered.");

                return _vat;
            }
        }

        public void Load(int DocEntry)
        {
            // Load purchase from data store
            // Assume the values below are from the data store.
            switch (DocEntry)
            {
                case 1:
                    _supplierTIN = "111-111-111-000";
                    _supplierName = "VAT Supplier";
                    _docNo = "123";
                    _registrationType = "VAT";
                    _vat = 20;
                    _percentageTax = 0;
                    break;
                case 2:
                    _supplierTIN = "222-222-222-000";
                    _supplierName = "Non-VAT Supplier";
                    _docNo = "654";
                    _registrationType = "Non-VAT";
                    _vat = 0;
                    _percentageTax = 4;
                    break;
            }
        }
    }
}
