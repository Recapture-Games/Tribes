# Inventory

- Inventory - This class will hold a list of InventorySlot instances, and will provide methods for adding, removing, and querying the inventory.

- InventorySlot - This class will hold a reference to an Item, as well as the quantity of that item in the slot.

- Item - This class will hold data about an item, such as its name, icon, and any other relevant attributes.

- IInventoryUI - This interface will define the methods that the inventory UI will need to implement in order to interact with the Inventory class.

- InventoryUI - This class will implement the IInventoryUI interface and provide the visual representation of the inventory to the player. It will update when the Inventory changes and pass player input to the Inventory class.
