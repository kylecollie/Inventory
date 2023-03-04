﻿using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;
public class CustomerType
{
    public int CustomerTypeId { get; set; }
    [Required]
    public string CustomerTypeName { get; set; }
    public string Description { get; set; }
}
