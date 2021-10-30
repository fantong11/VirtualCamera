using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Transform unityChan;
    public Transform kumasen;

    [SerializeField]
    private Transform toggleGreenBg;
    private Toggle toggle;


    // Start is called before the first frame update
    void Start()
    {
        toggle = toggleGreenBg.GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getStartKumasen()
    {
        StaticClass.avatar = kumasen;
        if (toggle.isOn)
        {
            SceneManager.LoadScene("VirtualCameraWithGreenBackground");
            return;
        }
        SceneManager.LoadScene("VirtualCamera");
    }

    public void getStartUnityChan()
    {
        StaticClass.avatar = unityChan;
        if (toggle.isOn)
        {
            SceneManager.LoadScene("VirtualCameraWithGreenBackground");
            return;
        }
        SceneManager.LoadScene("VirtualCamera");
    }
}
