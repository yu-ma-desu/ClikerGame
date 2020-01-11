using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ClikerGame;

public class HomeButton : MonoBehaviour
{
    [SerializeField] float Weght;
    [SerializeField] float Clere;

    [SerializeField] Text _text = null;
    [SerializeField] string name;
    private void Start()
    {
        _text.text = name;
    }
    public void OnButton()
    {
        GameManeger.Clere = Clere;
        GameManeger.WeghtOver = Weght;
    }
}
