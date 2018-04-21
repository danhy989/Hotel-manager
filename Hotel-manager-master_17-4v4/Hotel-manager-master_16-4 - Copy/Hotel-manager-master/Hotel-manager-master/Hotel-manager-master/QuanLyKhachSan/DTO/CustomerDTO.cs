﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CustomerDTO
    {
        private string customerName;
        private int customerStyle;
        private int customerCMND;
        private string customerAddress;

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public int CustomerStyle
        {
            get
            {
                return customerStyle;
            }

            set
            {
                customerStyle = value;
            }
        }

        public int CustomerCMND
        {
            get
            {
                return customerCMND;
            }

            set
            {
                customerCMND = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }

            set
            {
                customerAddress = value;
            }
        }
        public CustomerDTO() { }
        public CustomerDTO( string customerName  , int customerStyle , int customerCMND ,string customerAddress)
        {
            this.customerName = customerName;
            this.customerStyle = customerStyle;
            this.customerCMND = customerCMND;
            this.customerAddress = customerAddress;
        }
    }
}
