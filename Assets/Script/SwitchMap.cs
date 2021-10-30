using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMap : MonoBehaviour
{

    public List<GameObject> MapList;
    //[SerializeField]
    //private GameObject Map;
    public GameObject currentMap;
    private bool isShowingMap = true;
    private int ptr = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetCurrentMap()
    {
        return currentMap;
    }

    public void OnClickBtn2() {
        if (currentMap != null) Destroy(currentMap);
        ptr += 1;
        if (ptr == MapList.Count) ptr = 0;
        currentMap = Instantiate(MapList[ptr]);
    }

    public void OnClickBtn3() {
        if (currentMap != null) Destroy(currentMap);
        ptr -= 1;
        if (ptr == -1) ptr = MapList.Count - 1;
        currentMap = Instantiate(MapList[ptr]);
    }

    public void HideMap()
    {
        isShowingMap = !isShowingMap;
        currentMap.SetActive(isShowingMap);
    }
}
