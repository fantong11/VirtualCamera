using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject canvas;
    private bool isShowing = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    [System.Obsolete]
    public void ToggleDisplayButton()
    {
        isShowing = !isShowing;
        
        for (int i = 0; i < canvas.transform.GetChildCount(); i++)
        {
            if (canvas.transform.GetChild(i).tag != "DisplayButton")
            {
                canvas.transform.GetChild(i).gameObject.SetActive(isShowing);
            }
        }
        
    }
}
