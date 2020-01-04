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
    private void FixedUpdate()
    {
        SecondTime += Time.deltaTime;
        if (SecondTime >= 1)
        {
            GameManeger.Maney += SecondNum;
            SecondTime = 0;
        }
    }
    void Update()
    {
        count = GameManeger.Maney;
        CountText.text = $"{clicknum.ToString("f1")}";

        clicknum = GameManeger.ClickManey;
        ALLCount.text = $"{count.ToString("f1")}円";

        SecondNum = GameManeger.SecondManey;
        _secondText.text = $"{SecondNum.ToString("f1")}";
    }
}
