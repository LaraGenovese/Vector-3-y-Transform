using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3_script : MonoBehaviour
{
    public Vector3 myVector;
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        myObject.transform.position = myVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
