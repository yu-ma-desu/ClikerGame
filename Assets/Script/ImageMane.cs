using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMane : MonoBehaviour
{
    [SerializeField] GameObject Water;
    [SerializeField] GameObject Clay;
    [SerializeField] GameObject Bricks;
    GameObject scroll;
    Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        scroll = GameObject.FindGameObjectWithTag("ScrollView");
        parent = scroll.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Image(string ImageName)
    {
        switch (ImageName)
        {
            case "水":
               Instantiate(Water ,parent);
                break;
            case "粘土":
                break;
            case "木材":
                break;
            default:
                break;
        }
    }
}
