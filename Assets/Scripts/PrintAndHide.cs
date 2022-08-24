using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public GameObject gameObject;
    public Renderer rend;
    public int i = 3;
    public int randomNum;


    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(200, 251);
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name+ ":" +i);
        if ((i > 99) && GameObject.FindWithTag("Red"))
        {
            gameObject.SetActive(false);
        }
        if ((i == randomNum) && GameObject.FindWithTag("Blue"))
        {
            rend.enabled = false;
        }
        
    }
}
