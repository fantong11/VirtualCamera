using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AvatarManager : MonoBehaviour
{
    private GameObject avatarParent;
    private Transform avatar;
    private Vector3 avatarPositionOffset;
    private Vector3 avatarRotationOffset;
    //private 
    private Transform controlledRobot;
    private bool startAvatarTracking = false;
    private bool isBodyTracking = false;
    private AvatarRobotTestSuite avatarRobotTestSuite;
    private ARHumanBodyManager aRHumanBodyManager;

    // Start is called before the first frame update
    void Start()
    {
        avatarRobotTestSuite = GetComponent<AvatarRobotTestSuite>();
        aRHumanBodyManager = FindObjectOfType<ARHumanBodyManager>();

        isBodyTracking = false;
        aRHumanBodyManager.SetTrackablesActive(isBodyTracking);
        aRHumanBodyManager.enabled = isBodyTracking;

        avatar = avatarParent.transform.GetChild(0);

        avatarParent.transform.localPosition += avatarPositionOffset;
        avatarParent.transform.localRotation *= Quaternion.Euler(avatarRotationOffset);



    }

    private void LateUpdate()
    {
        if (!startAvatarTracking) return;

        //avatarParent.transform.localPosition +=  
    }

    public void StartTest()
    {
        isBodyTracking = false;
        aRHumanBodyManager.SetTrackablesActive(isBodyTracking);
        aRHumanBodyManager.enabled = isBodyTracking;

        avatarRobotTestSuite.isTesting = !avatarRobotTestSuite.isTesting;
        if (avatarRobotTestSuite.isTesting)
        {
            StartCoroutine(avatarRobotTestSuite.TestPositionUpdate());
        }
        
    }

    internal void InitRobotPose(Transform transform, Vector3 localPosition, Quaternion localRotation, Dictionary<JointIndices, Transform> robotBoneMapping)
    {
        throw new NotImplementedException();
    }
}
