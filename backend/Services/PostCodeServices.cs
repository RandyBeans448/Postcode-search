using System.Linq;
using System.Text.RegularExpressions;

public class PostcodeService : IPostcodeLookup {
    
    private DeliveryOption[] getDeliveryOptionsFromDb() {
        using (var db = new DatabaseContext())
        {
            return db.DeliveryOptions.ToArray();            
        }
    }

    public string[] GetValidDeliveryOptions(string postcode) {

        DeliveryOption[] deliveryOptions = getDeliveryOptionsFromDb();
       
        string[] locations = deliveryOptions.Where(

            option => {
                Regex postcodeRegex = new Regex("^(" + postcode + ")");
                return postcodeRegex.IsMatch(option.Postcode);
            }).Select(result => result.WarehouseLocation).ToArray();

        
        return locations;
    }

}