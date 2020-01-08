using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ClikerGame;

/// <summary>
/// 台の耐久性
/// </summary>
public class Dai : MonoBehaviour
{
    [SerializeField] int WeghtOver;
    private void Update()
    {
        if (WeghtOver < GameManeger.ObjWeight)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("確認用");
            SceneManager.LoadScene(3);
        }
    }
}
