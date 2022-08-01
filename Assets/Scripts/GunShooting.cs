using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject cubeObject = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cubeObject.transform.localPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.13f, gameObject.transform.position.z + 0.2f);
            cubeObject.transform.localScale = new Vector3(0.0135902f, 0.01889082f, 0.07185815f);
        }
    }
}
