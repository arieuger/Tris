using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendBar : MonoBehaviour
{
    public GameObject friendBar;

    private void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("GameMode"));
        if(PlayerPrefs.GetInt("GameMode") == 0)
        {
            friendBar.GetComponent<Image>().fillAmount = PlayerPrefs.GetFloat("FriendValue");
        }
        else
        {
            friendBar.GetComponent<Image>().fillAmount = 0f;
        }
    }

    //Valores de 0 a 1 donde 0 é o mínimo e 1 o máximo
    public void ChangeBarValue(float value)
    {
        friendBar.GetComponent<Image>().fillAmount = value;
        PlayerPrefs.SetFloat("FriendValue", value);
    }
}
