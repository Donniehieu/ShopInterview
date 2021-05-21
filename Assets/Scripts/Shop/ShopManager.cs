using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public ShopItems ShopItems;
    public List<GroupItem> GroupItems;
    public int idGroup;
    public GameObject panelShow;
#if UNITY_EDITOR
    public TextAsset data;
    public TextMeshProUGUI txtDetail;
    [ContextMenu("Load Data")]
    
    void LoadData()
    {
        ShopItems = JsonUtility.FromJson<ShopItems>(data.text);
        
       
    }
#endif

    void Awake()
    {
        LoadDataToGrid();
    }
    public void LoadDataToGrid()
    {
        int num = 9;

        for (int i = 0; i < GroupItems.Count; i++)
        {
            List<ItemData> ls = ShopItems.items.GetRange(i * num, num);
            GroupItems[i].SetInfo(ls);
        }
    }
   
    public void ClickClose()
    {
        panelShow.SetActive(false);
    }
}
