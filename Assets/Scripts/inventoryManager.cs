using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{


    public static inventoryManager isntance;

    public ScriptableItem[] weapons;
    public Text[] weaponsNames;

    public Image[] weaponsSprites;


    public InventorySlot[] weaponsSlots;

    void Awake()
    {
        if(isntance != null && isntance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            isntance = this;
        }
    }

    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;

                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;


                weaponsSlots[i].slotItem = item;
                weaponsSlots[i]. slotNumber = i;

                return;
            }
        }
    }
    

   

}
