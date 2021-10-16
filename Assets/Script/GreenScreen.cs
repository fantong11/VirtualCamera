using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GreenScreen : MonoBehaviour
{
    [SerializeField]
    private Transform toggleGreenBg;

    [SerializeField]
    private Material green;
    
    [SerializeField]
    private GameObject camera;

    private ARCameraBackground background;

    [SerializeField]
    private GameObject switchMapObject;

    private SwitchMap switchMap;

    // Start is called before the first frame update
    void Start()
    {
        background = camera.GetComponent<ARCameraBackground>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchGreenScreen()
    {
        switchMap = switchMapObject.GetComponent<SwitchMap>();
        Destroy(switchMap.currentMap);
        background.customMaterial = green;
    }
}
