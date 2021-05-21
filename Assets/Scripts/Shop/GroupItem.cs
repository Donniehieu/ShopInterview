using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GroupItem : MonoBehaviour
{
    public List<Item> Items;
    void OnValidate()
    {
        Items = transform.GetComponentsInChildren<Item>(true).ToList();
    }
    public void SetInfo(List<ItemData> dataItems)
    {
        int count = dataItems.Count;
        for (int i = 0; i < Items.Count; i++)
        {
            if (i >= count)
            {
                Items[i].gameObject.SetActive(false);
                continue;
            }
            Items[i].SetInfo(dataItems[i]);
            Items[i].gameObject.SetActive(true);
        }
    }
}
