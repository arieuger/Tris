using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendBar : MonoBehaviour
{
    public GameObject friendBar;

    //Valores de 0 a 1 donde 0 é o mínimo e 1 o máximo
    public void ChangeBarValue(float value)
    {
        friendBar.GetComponent<Image>().fillAmount = value;
    }
}
