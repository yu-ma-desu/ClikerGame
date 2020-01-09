using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;

/// <summary>
/// 土台の生成場所
/// </summary>
public class Foundation : MonoBehaviour
{
    [SerializeField] GameObject _foundation;
    GameObject parent;
    GameObject Content;
    Transform _transform;
    Vector3 pos;
    float SizeY;
    private void Awake()
    {
        parent = GameObject.FindGameObjectWithTag("Foundation");
        Content = GameObject.FindGameObjectWithTag("ScrollView");

        SizeY = Content.GetComponent<RectTransform>().offsetMin.y;
        _transform = parent.transform;
        pos = _transform.transform.position;
        pos.y = SizeY;
        _transform.transform.position = pos;
        Instantiate(_foundation, _transform);
    }
}
