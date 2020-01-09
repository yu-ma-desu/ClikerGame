using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ClikerGame;

/// <summary>
/// クリックしたときの処理
/// </summary>
public class ClickEvent : MonoBehaviour
{
    float _clickmany;
    private void Update()
    {
        _clickmany = GameManeger.ClickManey;
    }
    public void Click()
    {
        GameManeger.Maney += _clickmany;
    }
}
