using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    float _clickmany;

    ItemManeger item;
    GameObject Script;
    private void Start()
    {
        Script = GameObject.FindGameObjectWithTag("Property");
        item = Script.GetComponent<ItemManeger>();
    }
    private void Update()
    {
        _clickmany = item.ClickManey;
    }
    public void Click()
    {
        item.Maney += _clickmany;
    }
}
