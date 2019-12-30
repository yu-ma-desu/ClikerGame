using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;

/// <summary>
/// 生成位置の移動
/// </summary>
public class BuildingSpown : MonoBehaviour
{
    float SizeY;
    float _Size;

    GameObject scroll;
    Transform parent;
    private void Start()
    {
        _Size = SizeY;
    }
    private void Update()
    {
        SizeY = GameManeger.ObjSize;
        if (SizeY != _Size)
        {
            Point();
            _Size = SizeY;
        }
    }
    public void Point()
    {
        
    }
}
