using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ClikerGame;

/// <summary>
/// ゲームの表記関係
/// </summary>
public class Maneger : MonoBehaviour
{
    [SerializeField]
    private Text ALLCount = null;
    [SerializeField]
    private Text CountText = null;
    [SerializeField]
    private Text _secondText = null;

    public float count;
    float clicknum;
    float SecondNum;

    float SecondTime = 0.0f;

    GameManeger _game;
    GameObject Script;
    void Start()
    {
        Script = GameObject.FindGameObjectWithTag("Property");
        _game = Script.GetComponent<GameManeger>();
    }
    private void FixedUpdate()
    {
        SecondTime += Time.deltaTime;
        if (SecondTime >= 1)
        {
            _game.Maney += SecondNum;
            SecondTime = 0;
        }
    }
    void Update()
    {
        count = _game.Maney;
        CountText.text = $"{clicknum.ToString("f1")}";

        clicknum = _game.ClickManey;
        ALLCount.text = $"{count.ToString("f1")}円";

        SecondNum = _game.SecondManey;
        _secondText.text = $"{SecondNum.ToString("f1")}";
    }
}
