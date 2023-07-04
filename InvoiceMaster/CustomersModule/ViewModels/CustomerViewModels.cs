using DynamicData;
using DynamicData.Binding;
using InvoiceGeniusDB;
using InvoiceGeniusDB.Models;
using InvoiceMaster.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace InvoiceMaster.CustomersModule.ViewModels
{
    public class CustomerViewModels : ObserveObject
    {
        #region Commands
        public ICommand AddCustomerCommand { get; }
        public ICommand RemoveCustomerCommand { get; }
        public ICommand EditCustomerCommand { get; }
        #endregion 
        #region Properties
        private List<Customers> _customersList = new List<Customers>();
        public List<Customers> CustomersList { get => _customersList; set { _customersList = value; SetProperty(ref _customersList, value); } }
        private bool _isEditButtonEnabled = false;
        public bool IsEditButtonEnabled
        {
            get => _isEditButtonEnabled;
            set
            {
                _isEditButtonEnabled = value;
                SetProperty(ref _isEditButtonEnabled, value);
            }
        }
        private bool _isRemoveButtonEnabled = false;
        public bool IsRemoveButtonEnabled
        {
            get => _isRemoveButtonEnabled;
            set
            {
                _isRemoveButtonEnabled = value;
                SetProperty(ref _isRemoveButtonEnabled, value);
            }
        }
        private Customers _SelectedCustomer;
        public Customers SelectedCustomer
        {
            get => _SelectedCustomer; 
            set 
            {
                _SelectedCustomer = value;
                SetProperty(ref _SelectedCustomer, value);
                if(SelectedCustomer != null)
                {
                    _isRemoveButtonEnabled = true;
                    _isEditButtonEnabled = true;
                }
                else
                {
                    _isEditButtonEnabled = false;
                    _isRemoveButtonEnabled = false;
                }
                OnPropertyChanged(nameof(IsRemoveButtonEnabled));
                OnPropertyChanged(nameof(IsEditButtonEnabled));
            }
        }
        #endregion

        #region Methods
        private async Task DeleteCustomer()
        {
            using (InvoiceGeniusContext context = new InvoiceGeniusContext())
            {
                context.Remove(SelectedCustomer);
                await context.SaveChangesAsync();
            }
            SelectedCustomer = null;
            
            OnPropertyChanged(nameof(SelectedCustomer));
            LoadFromDatabase();
        }
        private void LoadFromDatabase()
        {
            _customersList.Clear();
            using (InvoiceGeniusContext ct = new InvoiceGeniusContext())
            {
                _customersList.AddRange(ct.Customers.ToList());
            }

        }
        #endregion
        #region ctor
        public CustomerViewModels() 
        {
            LoadFromDatabase();
            RemoveCustomerCommand = new RelayCommand(async delegate 
            {
                await Task.Run(() => DeleteCustomer());
            });
        }
        #endregion
    }
}
