﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;
public class VendorType
{
    public int VendorTypeId { get; set; }
    [Required]
    public string VendorName { get; set; }
    public string Description { get; set;}
}

