using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// リザルト画面やる事
/// </summary>
public class Result : MonoBehaviour
{
    [SerializeField] Text Bonus;
    [SerializeField] Text ALL;
    [SerializeField] Text Game;
    [SerializeField] Text Bad;

    [SerializeField] GameObject Succes;
    [SerializeField] GameObject Badddd;
    int _bounus;
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
            Back();
        }
    }
    void Sucess()
    {
        Succes.SetActive(true);
        GameManeger.AllManey += (int)GameManeger.Maney;
        _bounus= GameManeger.ObjCount * 100;
        GameManeger.AllManey += _bounus;
        ALL.text = GameManeger.AllManey.ToString();
        Game.text = GameManeger.Maney.ToString();
        Bonus.text = _bounus.ToString();
    }
    void Failure()
    {
        Badddd.SetActive(true);
        GameManeger.AllManey -= GameManeger.ObjCount * 1000;
        Bad.text = GameManeger.AllManey.ToString();
    }
    void Back()
    {
        GameManeger.ResultInitialize();
        SceneManager.LoadScene(1);
        Sample.Kioku();
    }
}
