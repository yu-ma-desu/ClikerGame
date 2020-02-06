using UnityEngine;
using UnityEngine.UI;
using ClikerGame;

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
    [SerializeField]
    int Weight = 0;

    float second;
    float _cklick = 3;

    GameObject ImageObj;

    ImageMane imageMane;
    void Start()
    {
        ImageObj = GameObject.FindGameObjectWithTag("ImageMane");
        imageMane = ImageObj.GetComponent<ImageMane>();

        _nameText.text = Name;
        _price.text = $"{price.ToString("f1")}円";
    }
     /// <summary>
     /// アイテム買うとこ
     /// </summary>
    public void BuyItem()
    {
        if (GameManeger.Maney >= price)
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
        second = GameManeger.SecondManey <= 1 ? SecondUp : GameManeger.SecondManey * SecondUp;

        imageMane.Image(Name);

        GameManeger.Maney -= price;
        GameManeger.SecondManey += second;

        price *= 1.2f;
        _price.text = $"{price.ToString("f1")}円";

        GameManeger.ObjWeight += Weight;

        if (GameManeger.ObjCount > _cklick)
        {
            GameManeger.ClickManey *= 2;
            _cklick += 3;
        }
    }
}
