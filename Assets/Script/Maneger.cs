using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    ItemManeger item;
    GameObject Script;
    void Start()
    {
        Script = GameObject.FindGameObjectWithTag("Property");
        item = Script.GetComponent<ItemManeger>();
    }
    private void FixedUpdate()
    {
        SecondTime += Time.deltaTime;
        if (SecondTime >= 1)
        {
            item.Maney += SecondNum;
            SecondTime = 0;
        }
    }
    void Update()
    {
        count = item.Maney;
        CountText.text = $"{clicknum.ToString("f1")}";

        clicknum = item.ClickManey;
        ALLCount.text = $"{count.ToString("f1")}円";

        SecondNum = item.SecondManey;
        _secondText.text = $"{SecondNum.ToString("f1")}";
    }
}
