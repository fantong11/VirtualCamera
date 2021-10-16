using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Transform unityChan;
    public Transform kumasen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getStartKumasen()
    {
        SceneManager.LoadScene("VirtualCamera");
        StaticClass.avatar = kumasen;
    }

    public void getStartUnityChan()
    {
        SceneManager.LoadScene("VirtualCamera");
        StaticClass.avatar = unityChan;
    }
}
