using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ボタンでの画面移動
/// </summary>
public class SceneChange : MonoBehaviour
{
    [SerializeField] int SceneNumber;
    public void Secne()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
