namespace Domain
{
    // implement the interface Interface.IDomain
    public class Domain : Interface.IDomain
    {
        private string Filename;
        private inventory Inventory;   
    }
    public Domain(string filename, inventory inventory)
    {
        this.filename = Filename;
        this.inventory = ;
    }
    
    public void Load
    {
        
    }
    
    public void Store
    {
    }
    
    public void AddNonFoodItem
    {
        string name;
        double price;
        string[] materials;
    }
    
}
// only link between the Domain namespace and the Presentation namespace.
// 
// 
// To do this, the constructor must take a filename of type string as an argument.
// This filename must be stored in an object attribute named filename. In addition, the constructor must create
// an Inventory object and store a reference to it in an object variable named inventory

// Override all the methods from Interface.IDomain:
// • Load This method should call Load on inventory with filename as argument.
// • Store This method should call Store on inventory with filename as argument.
// • AddNonFoodItem This method should create a NonFoodItem object with the parameters it
// has received, and call AddItem on inventory with this object as argument.