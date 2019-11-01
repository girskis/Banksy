using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (gameObject.name == "Capsule")
        {
            transform.Rotate(3, 0, 0);
        }
        if (gameObject.name == "Coins")
        {
            transform.Rotate(0, 0, 3);
        }
        
    }
}
