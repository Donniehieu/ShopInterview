using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;
using UnityEngine.U2D;
using System;

public class Item : MonoBehaviour
{
    public TextMeshProUGUI txtName, txtPrice, txtDetail, txtItemName;
    public Image icon, iconBuy;
    public ItemData data;
    public ShopManager shopManager;
    public  int id;
    public SpriteAtlas listAtlas;
    string nameSprite, nameSptiteDetail;
    public GameObject panelShow;
    private void OnValidate()
    {
        shopManager = FindObjectOfType<ShopManager>();
        listAtlas = Resources.Load<SpriteAtlas>("AtlasShop");
    }
    public void SetInfo(ItemData param)
    {
        data = param;
        txtName.text = data.title;
        txtPrice.text = data.price.ToString();
        nameSprite = txtName.text.Substring(5);
        int id= Int32.Parse(nameSprite);
        if (id < 9 && id > 1 || id == 1|| id==9)
        {
            icon.sprite = listAtlas.GetSprite("00" + nameSprite);
        }
        else if (id < 99 && id > 10 || id == 10||id==99)
        {
            icon.sprite = listAtlas.GetSprite("0" + nameSprite);
        }
        else
        {
            icon.sprite = listAtlas.GetSprite(nameSprite);
        }
        
    }

    public void ClickShow()
    {

        txtDetail.text = data.desc;
        txtItemName.text = data.title;
        nameSptiteDetail = txtItemName.text.Substring(5);
        int id = Int32.Parse(nameSptiteDetail);
        if (id < 9 && id > 1 || id == 1 || id == 9)
        {
            iconBuy.sprite = listAtlas.GetSprite("00"+ nameSptiteDetail);
          
           
        }
        else if (id < 99 && id > 10 || id == 10 || id == 99)
        {
            iconBuy.sprite = listAtlas.GetSprite("0" + nameSprite);
        }
        else
        {
            iconBuy.sprite = listAtlas.GetSprite(nameSprite);
        }
     
        panelShow.SetActive(true);



    }


}
