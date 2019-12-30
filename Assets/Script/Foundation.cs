using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 土台の生成場所
/// もしかしたら後々無くなるかもしれない 
/// </summary>
public class Foundation : MonoBehaviour
{
    [SerializeField] GameObject _foundation;
    GameObject parent;
    Transform _transform;

    private void Awake()
    {
        parent = GameObject.FindGameObjectWithTag("Foundation");
        _transform = parent.transform;
        Instantiate(_foundation, _transform);
    }
}
