using System.Collections;
using UnityEngine;

public class TurnOffButton : MonoBehaviour
{
    public GameObject SwitchButton;
    public GameObject NextButton2;
    public GameObject Checkmark2;
    public GameObject NextStepPanel2;
    public float duration = 0.5f;

    public void OnClick()
    {
        StartCoroutine(RotateAndActivate());
    }

    IEnumerator RotateAndActivate()
    {
        SwitchButton.transform.Rotate(Vector3.up * -90);
        yield return new WaitForSeconds(duration);

        NextButton2.gameObject.SetActive(true);
        Checkmark2.gameObject.SetActive(true);
        NextStepPanel2.gameObject.SetActive(true);
    }
}
