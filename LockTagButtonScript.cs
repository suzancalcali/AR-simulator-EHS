using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockTagButtonScript : MonoBehaviour
{
    public GameObject LOTO;
    public GameObject NextStepPanel3;
    public GameObject Checkmark3;
    public GameObject DoneButton;

    public Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        LOTO.SetActive(true);
        NextStepPanel3.SetActive(true);
        Checkmark3.SetActive(true);
        DoneButton.SetActive(true);
    }
}



