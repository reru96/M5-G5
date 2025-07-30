using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<ItemSO> items = new List<ItemSO>();

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {

            UseItemById(1);
        }

        if( Input.GetKey(KeyCode.Alpha2))
        {
            UseItemById(2);
        }


    }
    public void AddItem(ItemSO item)
    {
        items.Add(item);
        Debug.Log($"Item con ID {item.Id} aggiunto all'inventario.");
    }

    public void UseItemById(int id)
    {
        ItemSO item = items.Find(i => i.Id == id);
        if (item != null)
        {
            item.Use(gameObject);   
            items.Remove(item);
            Debug.Log($"Item con ID {id} usato e rimosso.");
        }
    }
}
