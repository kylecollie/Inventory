﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Inventory.Models;
public class PurchaseOrderLine
{
    public int Id { get; set; }
    [Display(Name = "Purchase Order")]
    public int PurchaceOrderId { get; set; }
    public PurchaseOrder PurchaceOrder { get; set; }
    [Display(Name = "Product")]
    public int ProductId { get; set; }
    public string Description { get; set; }
    public double Quantity { get; set; }
    public double Price { get; set; }
    public double Amount { get; set; }
    [Display(Name = "Discount Percentage")]
    public double DiscountPercentage { get; set; }
    [Display(Name = "Discount Amount")]
    public double DiscountAmount { get; set; }
    [Display(Name = "Sub Total")]
    public double SubTotal { get; set;}
    [Display(Name = "Tax Percentage")]
    public double TaxPercentage { get; set; }
    [Display(Name = "Tax Amount")]
    public double TaxAmount { get; set;}
    public double Total { get; set;}

}
