using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject zoomSliderPrefab;
    public Transform canvas;

    // Start is called before the first frame update
    void Start()
    {
        GameObject zoomSlider = Instantiate(zoomSliderPrefab);
        zoomSlider.transform.SetParent(canvas, false);

        //RectTransform zoomSliderTransform = zoomSlider.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
