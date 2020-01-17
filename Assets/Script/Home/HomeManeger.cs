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
    // Start is called before the first frame update
    void Start()
    {
        ManeyText.text = $"{GameManeger.AllManey}円";
    }/// <summary>
    /// ボタンを押した時の画面の動き
    /// </summary>
    /// <param name="Event">ボタンの反応</param>
    public void ButtomEvent(string Event)
    {
        switch (Event)
        {
            case "Build":
                BuildObj.SetActive(true);
                break;
            case "Shop":
                break;
            default:
                break;
        }
    }
}
