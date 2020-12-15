using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiator : MonoBehaviour
{
    public GameObject objectToInstantiate;
    public Transform placeToInstantiateAt;

    private bool CanInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CanInstantiate)
            {

                Instantiate(objectToInstantiate, placeToInstantiateAt.position, placeToInstantiateAt.rotation, placeToInstantiateAt
                    );
            }
            Debug.Log(CanInstantiate);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        CanInstantiate = true;
        Debug.Log("OnTriggerEnter on " + this.name);
    }
    private void OnTriggerExit(Collider other)
    {
        CanInstantiate = false;
    }
}
