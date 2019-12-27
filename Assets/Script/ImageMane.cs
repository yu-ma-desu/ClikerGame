using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMane : MonoBehaviour
{
    [SerializeField] GameObject Water;
    [SerializeField] GameObject Clay;
    [SerializeField] GameObject Bricks;
    [SerializeField] GameObject ScrollVeiw;
    // Start is called before the first frame update
    void Start()
    {

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
                Instantiate(Water,Vector3.zero, Quaternion.identity,ScrollVeiw);
                break;
            case "粘土":
                Clay.SetActive(true);
                break;
            case "木材":
                Bricks.SetActive(true);
                break;
            default:
                break;
        }
    }
}
