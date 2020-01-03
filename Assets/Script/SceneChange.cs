using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] int SceneNumber;
    public void Secne()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
