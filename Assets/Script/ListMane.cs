using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMane : MonoBehaviour
{
    List<string> ItemObject = new List<string>();
    public enum ItemName
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Add(string _name)
    {
        ItemObject.Add(_name);
        Debug.Log(ItemObject);
    }
}
