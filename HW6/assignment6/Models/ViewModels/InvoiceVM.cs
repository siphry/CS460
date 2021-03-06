﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// ViewModel class to hold the details of a client's order history, profit, and sales person
/// </summary>
/// 
namespace assignment6.Models.ViewModels
{
    public class InvoiceVM
    {
        [Display(Name = "Stock ID")]
        public int StockID { get; set; }
        public string Description { get; set; }
        [Display(Name = "Total Profit")]
        public decimal TotalProfit { get; set; }
        [Display(Name = "Sales Person")]
        public string SalesPerson { get; set; }

    }
}