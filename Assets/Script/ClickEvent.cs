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

    GameManeger _game;
    GameObject Script;
    private void Start()
    {
        Script = GameObject.FindGameObjectWithTag("Property");
        _game = Script.GetComponent<GameManeger>();
    }
    private void Update()
    {
        _clickmany = _game.ClickManey;
    }
    public void Click()
    {
        _game.Maney += _clickmany;
    }
}
