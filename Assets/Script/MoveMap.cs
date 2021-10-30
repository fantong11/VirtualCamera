using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    public GameObject switchMap;
    private Transform currentMap;

    private bool moveUp;
    private bool moveLeft;
    private bool moveRight;
    private bool moveDown;
    private bool moveFront;
    private bool moveBack;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        currentMap = switchMap.GetComponent<SwitchMap>().GetCurrentMap().transform;
        if (currentMap)
        {
            if (moveUp)
            {
                currentMap.position += new Vector3(0, -1 * Time.deltaTime, 0);
            }
            if (moveLeft)
            {
                currentMap.position += new Vector3(1 * Time.deltaTime, 0, 0);
            }
            if (moveRight)
            {
                currentMap.position += new Vector3(-1 * Time.deltaTime, 0, 0);
            }
            if (moveDown)
            {
                currentMap.position += new Vector3(0, 1 * Time.deltaTime, 0);
            }
            if (moveFront)
            {
                currentMap.position += new Vector3(0, 0, -1 * Time.deltaTime);
            }
            if (moveBack)
            {
                currentMap.position += new Vector3(0, 0, 1 * Time.deltaTime);
            }
        }
        
    }

    public void OnClickMoveUp()
    {
        moveUp = true;
    }

    public void OnReleaseMoveUp()
    {
        moveUp = false;
    }

    public void OnClickMoveLeft()
    {
        moveLeft = true;
    }

    public void OnReleaseMoveLeft()
    {
        moveLeft = false;
    }

    public void OnClickMoveRight()
    {
        moveRight = true;
    }

    public void OnReleaseMoveRight()
    {
        moveRight = false;
    }

    public void OnClickMoveDown()
    {
        moveDown = true;
    }

    public void OnReleaseMoveDown()
    {
        moveDown = false;
    }

    public void OnClickMoveFront()
    {
        moveFront = true;
    }

    public void OnReleaseMoveFront()
    {
        moveFront = false;
    }

    public void OnClickMoveBack()
    {
        moveBack = true;
    }

    public void OnReleaseMoveBack()
    {
        moveBack = false;
    }
}
