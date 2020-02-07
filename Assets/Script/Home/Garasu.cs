using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;

public class Garasu : MonoBehaviour
{
    [SerializeField] int Many;

    public void Up()
    {
        if (GameManeger.AllManey > Many)
        {
            GameManeger.Garasu++;
            GameManeger.AllManey -= Many;
            Sample.Kioku();
            Debug.Log("買えました");
        }
    }
}
