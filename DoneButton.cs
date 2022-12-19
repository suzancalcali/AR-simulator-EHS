using System.Collections;
using UnityEngine;

public class DoneButton : MonoBehaviour
{
    
    public GameObject Task3Elements;
    

    public void OnClick()
    {
        Task3Elements.gameObject.SetActive(false);
        
        
    }
}
