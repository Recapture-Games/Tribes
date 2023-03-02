using UnityEngine;

public enum ItemType {
    CopperOre,
    TinOre,
    WoodenLog,
    Stone,
    Meat
}

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

    new public string name = "New Item";
    public ItemType type;
    public Sprite icon = null;
    public bool isDefaultItem = false;

    public virtual void Use() {
        // Use the item
        // Overwrite this method in the subclasses
    }

    public void RemoveFromInventory() {
        Inventory.instance.Remove(this);
    }

}