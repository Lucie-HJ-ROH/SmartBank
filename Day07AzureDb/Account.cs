﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07AzureDb
{
    public class Account
    {
        public static int _account_number = 1000;
        
        public Account(int customer_id, int user_id, string bank_branch_address, string phone_number_branch)
        {
            Customer_id = customer_id;
            User_id = user_id;
            Bank_branch_address = bank_branch_address;
            Phone_number_branch = phone_number_branch;
            Account_number = _account_number++;
        }

        [Key]
        public int Account_id { get; set; }
        
        public int Account_number { get; set; }

        public string Bank_branch_address{ get; set; }
        public string Phone_number_branch { get; set; }


        // Foreign key   
        [Display(Name = "Users")]
        public virtual int User_id { get; set; }

        [ForeignKey("User_id")]
        public virtual Users user { get; set; }


        // Foreign key   
        [Display(Name = "Customer")]
        public virtual int Customer_id { get; set; }

        [ForeignKey("Customer_id")]
        public virtual Customer customers { get; set; }




    }
}
