using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    public GameObject gameObject;
    private int i = 3;


    // Start is called before the first frame update
    void Start()
    {
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("GameObject's Name:"+i);
        i++;
    }
}
