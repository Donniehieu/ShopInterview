using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ShopItems
{
    public List<ItemData> items;
}

[Serializable]
public class ItemData
{
    public int id;
    public string icon;
    public string title;
    public string desc;
    public float price;
}