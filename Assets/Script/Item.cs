using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField]
    private Text _nameText = null;
    [SerializeField]
    private string Name =  "アイテム名";
    [SerializeField]
    private Text _price = null;
    [SerializeField]
    float price = 0;
    float second;
    float UpNum;
    float _cklick;
    int ItemCount;

    GameObject Script;
    GameObject ListObj;
    GameObject Script2;

    ListMane list;
    ItemManeger item;
    ImageMane imageMane;
    void Start()
    {
        Script = GameObject.FindGameObjectWithTag("Property");
        ListObj = GameObject.FindGameObjectWithTag("ListObj");
        Script2 = GameObject.Find("ImageMane");
        item = Script.GetComponent<ItemManeger>();
        list = ListObj.GetComponent<ListMane>();
        imageMane = Script2.GetComponent<ImageMane>();
        UpNum = price / 10;
        _cklick = price * 0.2f;
        _nameText.text = Name;
    }

    // Update is called once per frame
    void Update()
    {
        _price.text = $"{price.ToString("f1")}円";
    }
    public void TenItem()
    {
        imageMane.Image(Name);
        if (item.Maney >= price)
        {
            ItemCount++;
            item.Maney += UpNum;
            item.Maney -= price;
            item.SecondManey += second;
            item.ClickManey += _cklick;
            price *= 1.2f;
        }
        if (ItemCount == 1)
        {
            list.Add(Name);
        }
    }
}
