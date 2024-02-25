using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = new Vector3(0,1,0);
        transform.Rotate(v);
        myTest();
        float a = 20;
        Debug.Log("a111");
    }

    public void myTest(){
        float b = 10;
        Debug.Log(b);
    }
}
