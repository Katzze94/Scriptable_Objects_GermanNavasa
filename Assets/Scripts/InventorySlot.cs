using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
   
   public ScriptableItem slotItem;
   public int slotNumber;

   public GameObject inspectionWindow;

   public Image inspectionImage;

   public Text inspectionName;

   public Text inspectionDescription;

   public Button closeButton;

   public Button deleteButton;
   
    void Start()
    {
        Button thisButton =  GetComponentInChildren<Button>();
        thisButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null && !inspectionWindow.activeInHierarchy)
        {
            deleteButton.onClick.AddListener(RemoveItem);
            closeButton.onClick.AddListener(CloseWindow);

            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }
    }

     void RemoveItem()
    {
    
    if(inventoryManager.isntance.weapons[slotNumber] !=null)
    {
        inventoryManager.isntance.weapons[slotNumber] = null;
        inventoryManager.isntance.weaponsNames[slotNumber].text = "Empty";
        inventoryManager.isntance.weaponsSprites[slotNumber].sprite = null;
    }

    CloseWindow();
    
    }

    void CloseWindow()
    {
       deleteButton.onClick.RemoveListener(RemoveItem);
        inspectionWindow.SetActive(false);

    }
}
