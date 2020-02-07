using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;

public class DodaiUp : MonoBehaviour
{
    [SerializeField] int Many;
    [SerializeField] int Up;

    public void Buy()
    {
        if (GameManeger.AllManey > Many)
        {
            GameManeger.WeghtOver += Up;
            GameManeger.AllManey -= Many;
            Sample.Kioku();
        }
        else
        {
            Debug.Log("買えません");
        }
    }
}
