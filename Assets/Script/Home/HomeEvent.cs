using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeEvent : MonoBehaviour
{
    [SerializeField] string _event = ""; 
    GameObject Home;
    HomeManeger home;
    private void Start()
    {
        Home = GameObject.FindGameObjectWithTag("Home");
        home = Home.GetComponent<HomeManeger>();
    }
    public void Event()
    {
        home.ButtomEvent(_event);
    }
}
