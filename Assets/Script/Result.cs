﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;
using UnityEngine.SceneManagement;

/// <summary>
/// リザルト画面やる事
/// </summary>
public class Result : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameManeger.ResultChase == 1)
        {
            Debug.Log("成功です");
            Sucess();
        }
        else if (GameManeger.ResultChase == 2)
        {
            Debug.Log("失敗です");
            Failure();
        }
        else
        {
            Debug.LogError("予想外です");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("確認用");
            SceneManager.LoadScene(1);
        }
    }
    void Sucess()
    {

    }
    void Failure()
    {

    }
    void Back()
    {
        GameManeger.Clere = 0;
        GameManeger.WeghtOver = 0;
        SceneManager.LoadScene(1);
    }
}
