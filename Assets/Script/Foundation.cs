using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foundation : MonoBehaviour
{
    [SerializeField] GameObject _foundation;
    GameObject parent;
    Transform _transform;
    // Start is called before the first frame update
    private void Awake()
    {
        parent = GameObject.FindGameObjectWithTag("Foundation");
        _transform = parent.transform;
        Instantiate(_foundation, _transform);
    }
    void Start()
    {
           
    }
}
