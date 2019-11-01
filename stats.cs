using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Coins")
        {
            GetComponent<TextMesh>().text = "Coins = " + trackstatic.coinsTotal;
        }
        if (gameObject.name == "Time")
        {
            GetComponent<TextMesh>().text = "Time = " + trackstatic.timeTotal;
        }
        if (gameObject.name == "Status")
        {
            GetComponent<TextMesh>().text = trackstatic.gameCompStatus;
        }
    }
}
