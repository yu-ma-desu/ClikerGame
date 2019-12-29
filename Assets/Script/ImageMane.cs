using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>  
/// 建物生成のみ
/// </summary>
public class ImageMane : MonoBehaviour
{
    List<GameObject> Images = new List<GameObject>();
    int ImageIndex;

    GameObject scroll;
    Transform parent;

    // Start is called before the first frame update
    private void Awake()
    {
        Images.Add((GameObject)Resources.Load("Prefab/Water"));
        Images.Add((GameObject)Resources.Load("Prefab/Clay"));
        Images.Add((GameObject)Resources.Load("Prefab/Bricks"));

        scroll = GameObject.FindGameObjectWithTag("ScrollView");
        parent = scroll.transform;
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
        Instantiate(Images[ImageIndex], parent);
    }
}
