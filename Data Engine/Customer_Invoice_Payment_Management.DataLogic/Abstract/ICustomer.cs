﻿using Customer_Invoice_Payment_Management.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Invoice_Payment_Management.DataLogic.Abstract
{
    public interface ICustomer
    {
        public List<Customer> GetCustomer(); 
        public int AddCustomerData(Customer CustomerModel, string CustomerNo);
        public int UpdateCustomer(Customer CustomerModel, string CustomerNo, string CustomerName);
        public int DeleteCustomer(string CustomerNo);
        public Customer CustomerById(string CustomerNo);
        public List<Customer> AutoIncrementCustomerNo();
    }
}