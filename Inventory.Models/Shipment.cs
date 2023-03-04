﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Inventory.Models;
public class Shipment
{
    public int Id { get; set; }
    [Display(Name = "Shipment Number")]
    public string ShipmentName { get; set; }
    [Display(Name = "Sales Order")]
    public int SalesOrderId { get; set; }
    [Display(Name = "Shipment Date")]
    public DateTimeOffset ShipmentDate { get; set; }
    [Display(Name = "Shipment Type")]
    public int ShipmentTypeId { get; set; }
    [Display(Name = "Warehouse")]
    public int WarehouseId { get; set; }
    [Display(Name = "Full Shipment?")]
    public bool IsFullShipment { get; set; }
}
