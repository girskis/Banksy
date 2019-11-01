using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShopControlScript : MonoBehaviour
{

    int coinsTotal;
    int isIrelandflagSold;
    int isNCIflagSold;

    public Text coinsTotalText;
    public Text irelandflagPrice;
    public Text NCIflagPrice;

    public Button buyButton;
    public Button buyButton2;

    // Start is called before the first frame update
    void Start()
    {
        trackstatic.coinsTotal = PlayerPrefs.GetInt("CoinsTotal");
    }

    // Update is called once per frame
    void Update()
    {
        coinsTotalText.text = "Coins :" + trackstatic.coinsTotal.ToString() + "€";
        isIrelandflagSold = PlayerPrefs.GetInt("isIrelandflagSold");
        isNCIflagSold = PlayerPrefs.GetInt("isNCIflagSold");

        if (trackstatic.coinsTotal >= 5 && isIrelandflagSold == 0)
        {
            buyButton.interactable = true;
        }
        else
        { 
        buyButton.interactable = false;
        }
        if (trackstatic.coinsTotal >= 4 && isNCIflagSold == 0)
        {
            buyButton2.interactable = true;
        }
        else
        {
            buyButton2.interactable = false;
        }




    }

    public void BuyIrelandFlag()
    {
        trackstatic.coinsTotal -= 5;
        PlayerPrefs.SetInt("isIrelandflagSold", 1);
        irelandflagPrice.text = "Sold !";
        buyButton.gameObject.SetActive(false);

    }
    public void BuyNCIFlag()
    {
        trackstatic.coinsTotal -= 4;
        PlayerPrefs.SetInt("isNCIflagSold", 1);
        NCIflagPrice.text = "Sold !";
        buyButton2.gameObject.SetActive(false);

    }

    public void ExitShop()
    {
        PlayerPrefs.SetInt("CoinsTotal", trackstatic.coinsTotal);
        SceneManager.LoadScene("MainMenu");
    }
    public void ResetPlayerPrefs()
    {
        trackstatic.coinsTotal = 0;
        buyButton.gameObject.SetActive(true);
        buyButton2.gameObject.SetActive(true);
        irelandflagPrice.text = "Price: 5€";
        NCIflagPrice.text = "Price: 4€";
        PlayerPrefs.DeleteAll();
    }


}
