using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reticlerotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 d = new Vector3(0,1,0);
        transform.Rotate(d);
        
    }
}
