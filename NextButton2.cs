using System.Collections;
using UnityEngine;

public class NextButton2 : MonoBehaviour
{
    public GameObject Task2Elements;
    public GameObject Task3Elements;

    public void OnClick()
    {
        Task2Elements.gameObject.SetActive(false);
        Task3Elements.gameObject.SetActive(true);
    }
}

