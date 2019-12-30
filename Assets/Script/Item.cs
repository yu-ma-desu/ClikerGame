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

    float second;
    float _cklick;

    GameObject Property;
    GameObject ImageObj;

    GameManeger _game;
    ImageMane imageMane;
    void Start()
    {
        Property = GameObject.FindGameObjectWithTag("Property");
        ImageObj = GameObject.FindGameObjectWithTag("ImageMane");
        _game = Property.GetComponent<GameManeger>();
        imageMane = ImageObj.GetComponent<ImageMane>();
        _nameText.text = Name;
        _price.text = $"{price.ToString("f1")}円";
    }

    public void BuyItem()
    {
        if (_game.Maney >= price)
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
        second = _game.SecondManey <= 1 ? SecondUp : _game.SecondManey * SecondUp;

        imageMane.Image(Name);

        _cklick = price * 0.2f;
        _game.Maney -= price;
        _game.SecondManey += second;
        _game.ClickManey += _cklick;

        price *= 1.2f;
        _price.text = $"{price.ToString("f1")}円";
    }
}
