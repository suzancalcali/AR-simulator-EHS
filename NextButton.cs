using System.Collections;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject Task1Elements;
    public GameObject Task2Elements;

    public void OnClick()
    {
        Task1Elements.gameObject.SetActive(false);
        Task2Elements.gameObject.SetActive(true);
    }
}





