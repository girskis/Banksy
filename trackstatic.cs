using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trackstatic : MonoBehaviour
{


    public static float vertVel = 0;
    public static int coinsTotal = 0;
    public static float timeTotal = 0;
    public static float zVelAdjustment = 1;
    public static string gameCompStatus = "";
    public float waittoload = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTotal += Time.deltaTime;
        if (gameCompStatus == "You Failed")
        {
            waittoload += Time.deltaTime;
        }
        if (waittoload >2)
        {
            SceneManager.LoadScene("CompleteLevel");
        }
    }
}
