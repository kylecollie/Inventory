﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;
public class PaymentVoucher
{
    public int Id { get; set; }
    [Display(Name = "Payment Voucher Number")]
    public string Name { get; set; }
    [Display(Name = "Bill")]
    public int BillId { get; set; }
    public DateTimeOffset PaymentDate { get; set; }
    [Display(Name = "Payment Type")]
    public int PaymentTypeId { get; set; }
    public double PaymentAmount { get; set; }
    [Display(Name = "Payment Source")]
    public int CashBankId { get; set; }
    [Display(Name = "Full Payment?")]
    public bool IsFullPayment { get; set; } = true;
}
