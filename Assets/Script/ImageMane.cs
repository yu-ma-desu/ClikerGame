using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;


/// <summary>  
/// 建物生成のみ
/// </summary>
public class ImageMane : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Images = new List<GameObject>();
    int ImageIndex;

    Vector3 pos;
    GameObject build;
    Transform parent;

    float ObjWidth;
    // Start is called before the first frame update
    private void Awake()
    {
        build = GameObject.FindGameObjectWithTag("BuildSpown");
        pos = build.transform.position;
        parent = build.transform;
    }
    private void Start()
    {
        GameManeger.ObjSize = pos.y;
    }
    /// <summary>
    /// 建物生成
    /// </summary>
    /// <param name="ImageName">建造物名前</param>
    public void Image(in string ImageName)
    {
        switch (ImageName)
        {
            case "水":
                ImageIndex = 0;
                break;
            case "粘土":
                ImageIndex = 1;
                break;
            case "木材":
                ImageIndex = 2;
                break;
            default:
                break;
        }
        Instantiate(Images[ImageIndex], new Vector3(pos.x, pos.y), Quaternion.identity, parent);
        ObjWidth = Images[ImageIndex].GetComponent<RectTransform>().sizeDelta.y;
        GameManeger.ObjSize += ObjWidth;
        GameManeger.ObjCount += 1;
        pos.y = GameManeger.ObjSize;
    }
}
