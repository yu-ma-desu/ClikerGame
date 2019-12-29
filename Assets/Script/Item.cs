using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 建物情報
/// </summary>
public class Item : MonoBehaviour
{
    //Inspectorでいじるとこ
    [SerializeField]
    private Text _nameText = null;
    [SerializeField]
    private string Name = "アイテム名";
    [SerializeField]
    private Text _price = null;
    [SerializeField]
    float price = 0;
    [SerializeField]
    float SecondUp = 0;

    float second;
    float _cklick;

    GameObject Property;
    GameObject ImageObj;

    ItemManeger item;
    ImageMane imageMane;
    void Start()
    {
        Property = GameObject.FindGameObjectWithTag("Property");
        ImageObj = GameObject.FindGameObjectWithTag("ImageMane");
        item = Property.GetComponent<ItemManeger>();
        imageMane = ImageObj.GetComponent<ImageMane>();
        _nameText.text = Name;
        _price.text = $"{price.ToString("f1")}円";
    }

    public void BuyItem()
    {
        if (item.Maney >= price)
        {
            Accounting();
        }
        else
        {
            Debug.Log("買えません");
        }
    }
    void Accounting()
    {
        //三項演算子試し
        second = item.SecondManey <= 1 ? SecondUp : item.SecondManey * SecondUp;

        imageMane.Image(Name);

        _cklick = price * 0.2f;
        item.Maney -= price;
        item.SecondManey += second;
        item.ClickManey += _cklick;

        price *= 1.2f;
        _price.text = $"{price.ToString("f1")}円";
    }
}
