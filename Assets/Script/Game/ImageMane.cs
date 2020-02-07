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

    [SerializeField] GameObject Gatasu;
    [SerializeField] GameObject Tetu;

    Vector3 pos;
    float SizeY;
    GameObject build;
    GameObject Content;
    Transform parent;
    Transform ContentPos;

    float ObjWidth;
    // Start is called before the first frame update
    private void Awake()
    {
        build = GameObject.FindGameObjectWithTag("BuildSpown");
        Content = GameObject.FindGameObjectWithTag("ScrollView");

        SizeY = Content.GetComponent<RectTransform>().offsetMin.y + 200;
        parent = build.transform;
        pos = parent.transform.position;
        pos.y = SizeY;
        parent.transform.position = pos;
        GameManeger.ObjSize = SizeY;

        ContentPos = Content.transform;

        if (GameManeger.Garasu > 0)Gatasu.SetActive(true);
        
        if (GameManeger.Tetu > 0) Tetu.SetActive(true);
    }
    /// <summary>
    /// 建物生成
    /// </summary>
    /// <param name="ImageName">建造物名前</param>
    public void Image(in string ImageName)
    {
        pos.y = GameManeger.ObjSize;
        Debug.Log(GameManeger.ObjSize);
        parent.transform.position = pos;
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
            case "ガラス":
                ImageIndex = 3;
                break;
            case "鉄":
                ImageIndex = 4;
                break;
            default:
                break;
        }
        Instantiate(Images[ImageIndex],new Vector3 (parent.position.x,parent.position.y),Quaternion.identity, ContentPos);
        ObjWidth = Images[ImageIndex].GetComponent<RectTransform>().sizeDelta.y;
        GameManeger.ObjSize += ObjWidth;
        GameManeger.ObjCount += 1;
    }
}
