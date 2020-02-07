using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ClikerGame;

/// <summary>
/// ホーム関係の神になる予定
/// </summary>
public class HomeManeger : MonoBehaviour
{
    GameObject LastLayer;
    [SerializeField] Text ManeyText;
    [SerializeField] GameObject BuildObj;
    [SerializeField] GameObject SelectButtom;
    [SerializeField] GameObject ShopObj;
    private void Update()
    {
        ManeyText.text = $"{GameManeger.AllManey}円";
    }

    /// <summary>
    /// ボタンを押した時の画面の動き
    /// </summary>
    /// <param name="Event">ボタンの反応</param>
    public void ButtomEvent(string Event)
    {
        switch (Event)
        {
            case "Build":
                BuildObj.SetActive(true);
                SelectButtom.SetActive(false);
                break;
            case "BuldCansel":
                BuildObj.SetActive(false);
                SelectButtom.SetActive(true);
                break;
            case "ShopOpen":
                ShopObj.SetActive(true);
                SelectButtom.SetActive(false);
                break;
            case "ShopClose":
                ShopObj.SetActive(false);
                SelectButtom.SetActive(true);
                break;
            default:
                break;
        }
    }
}
