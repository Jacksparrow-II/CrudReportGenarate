﻿using Customer_Invoice_Payment_Management.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Invoice_Payment_Management.DataLogic.Abstract
{
    public interface IDashboard
    {
        public List<Dashboard> GetDashboardDetails();
        public List<Chart> DisplayChart();
        public int Editprofile(Userdata UserModel, string UserName, int UserId);
        public Userdata GetEditprofileById(int UserId);
    }
}