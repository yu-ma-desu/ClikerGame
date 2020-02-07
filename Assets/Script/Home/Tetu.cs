using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;

public class Tetu : MonoBehaviour
{
    [SerializeField] int Many;

    public void Up()
    {
        if (GameManeger.AllManey > Many)
        {
            GameManeger.Tetu++;
            GameManeger.AllManey -= Many;
            Sample.Kioku();
            Debug.Log("買えました");
        }
    }
}
