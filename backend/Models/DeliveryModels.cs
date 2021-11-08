using System;

public class DeliveryOption {

    public int DeliveryOptionId {get; set;}
    public string Postcode {get; set;}
    public string WarehouseLocation {get; set;}

        public DeliveryOption(string postcode, string warehouseLocation) {
        this.Postcode = postcode;
        this.WarehouseLocation = warehouseLocation;

    }

}

