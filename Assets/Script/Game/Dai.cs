using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ClikerGame;

/// <summary>
/// ゲームクリアか判定
/// </summary>
public class Dai : MonoBehaviour
{
    private void Update()
    {
        //ゲームクリア
        if (GameManeger.Clere < GameManeger.ObjSize)
        {
            GameManeger.ResultChase = 1;
            SceneManager.LoadScene(3);
        }
        //ゲームオーバー
        if (GameManeger.WeghtOver < GameManeger.ObjWeight)
        {
            Destroy(this.gameObject);
            GameManeger.ResultChase = 2;
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("確認用");
            SceneManager.LoadScene(3);
        }
    }
}
