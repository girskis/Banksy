using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour
{
    public KeyCode moveLeft;
    public KeyCode moveRight;
  
    public float horizVel = 0;
    public int laneNum = 2;
    public string controllocked = "n";
    public Transform BoomObj;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, trackstatic.vertVel, 4);

        if ((Input.GetKeyDown(moveLeft) || Input.GetKey(KeyCode.LeftArrow)) && (laneNum > 1) && (controllocked == "n"))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controllocked = "y";
        }
        if ((Input.GetKeyDown(moveRight) || Input.GetKey(KeyCode.RightArrow)) && (laneNum < 3) && (controllocked == "n"))
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controllocked = "y";

        }
      





    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Lethal")
        {
            Destroy(this.gameObject);
            trackstatic.zVelAdjustment = 0;
            Instantiate(BoomObj, transform.position, BoomObj.rotation);
            trackstatic.gameCompStatus = "You Failed";
          
        }
        if (other.gameObject.name == "Capsule")
        {
            Destroy(other.gameObject);
        }
        

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RampbottomTrigger")
        {
            trackstatic.vertVel = 2;
        }
        if (other.gameObject.name == "RamptopTrigger")
        {
            trackstatic.vertVel = 0;
        }
        if (other.gameObject.name == "Coins")
        {
            Destroy(other.gameObject);
            trackstatic.coinsTotal += 1;
        }
        if (other.gameObject.name == "Exit")
        {
            trackstatic.gameCompStatus = "Success !";
            SceneManager.LoadScene("CompleteLevel");
        }

    }




    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controllocked = "n";
    }



}
