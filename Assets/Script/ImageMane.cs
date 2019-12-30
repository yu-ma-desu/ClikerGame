using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClikerGame;


/// <summary>  
/// 建物生成のみ
/// </summary>
public class ImageMane : MonoBehaviour
{
    List<GameObject> Images = new List<GameObject>();
    int ImageIndex;

    Vector3 pos;
    GameObject build;
    GameObject scroll;
    Transform parent;

    float ObjWidth;
    // Start is called before the first frame update
    private void Awake()
    {
        Images.Add((GameObject)Resources.Load("Prefab/Water"));
        Images.Add((GameObject)Resources.Load("Prefab/Clay"));
        Images.Add((GameObject)Resources.Load("Prefab/Bricks"));

        scroll = GameObject.FindGameObjectWithTag("ScrollView");
        parent = scroll.transform;
        build = GameObject.FindGameObjectWithTag("BuildSpown");
        pos = build.transform.position;
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
        Instantiate(Images[ImageIndex], new Vector3(pos.x + 110, pos.y + 100), Quaternion.identity, parent);
        ObjWidth = Images[ImageIndex].GetComponent<RectTransform>().sizeDelta.y;
        GameManeger.ObjSize += ObjWidth;
        pos.y = GameManeger.ObjSize;
    }
}
