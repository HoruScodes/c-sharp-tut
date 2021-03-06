﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public int CustomerID { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ",";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }

        }
    }
}
