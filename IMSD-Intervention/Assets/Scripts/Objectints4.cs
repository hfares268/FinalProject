using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectints4 : MonoBehaviour
{
    public GameObject objectToInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(objectToInstantiate, transform.position + transform.forward, Quaternion.identity, transform);

        }
    }
}

