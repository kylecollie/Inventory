﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;
public class BillType
{
    public int BillTypeId { get; set; }
    [Required]
    public string BillTypeName { get; set;}
    public string BillTypeDescription { get; set; }
}
