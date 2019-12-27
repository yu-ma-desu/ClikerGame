using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        clicknum = item.ClickManey;
        SecondNum = item.SecondManey;
        CountText.text = $"{clicknum.ToString("f1")}";
        _secondText.text = $"{SecondNum.ToString("f1")}";
        ALLCount.text = $"{count.ToString("f1")}円";
    }
}
