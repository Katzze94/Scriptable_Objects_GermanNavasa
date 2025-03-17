using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")] //esto es importante para que puedas crearlo desde el menu de create

public class ScriptableItem : ScriptableObject //importante
{
   public string itemName;
   public string itemDescription;

   public int itemPrice;

   public Sprite itemSprite;
}
