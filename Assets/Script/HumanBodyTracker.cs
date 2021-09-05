using System;
using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;
namespace UnityEngine.XR.ARFoundation.Samples
{
    public class HumanBodyTracker : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("The Skeleton prefab to be controlled.")]
        GameObject m_SkeletonPrefab;

        [SerializeField]
        [Tooltip("The ARHumanBodyManager which will produce body tracking events.")]
        ARHumanBodyManager m_HumanBodyManager;

        /// <summary>
        /// Get/Set the <c>ARHumanBodyManager</c>.
        /// </summary>
        public ARHumanBodyManager humanBodyManager
        {
            get { return m_HumanBodyManager; }
            set { m_HumanBodyManager = value; }
        }

        /// <summary>
        /// Get/Set the skeleton prefab.
        /// </summary>
        public GameObject skeletonPrefab
        {
            get { return m_SkeletonPrefab; }
            set { m_SkeletonPrefab = value; }
        }

        Dictionary<TrackableId, BoneController> m_SkeletonTracker = new Dictionary<TrackableId, BoneController>();

        private AvatarManager avatarManager;
        private BoneController boneController;
        private float estimateHeightScaleFactor = 1.0f;

        private void Start()
        {
            avatarManager = GetComponent<AvatarManager>();   
        }

        public void TestHumanBodyAdded(float randomHeight, Vector3 robotInitialPosition)
        {
            var newSkeleton = Instantiate(m_SkeletonPrefab);
            boneController = newSkeleton.GetComponent<BoneController>();
            boneController.InitializeSkeletonJoints();

            boneController.transform.localPosition = robotInitialPosition;

            estimateHeightScaleFactor = randomHeight;
            newSkeleton.transform.localScale = new Vector3(estimateHeightScaleFactor, estimateHeightScaleFactor, estimateHeightScaleFactor);

            avatarManager.InitRobotPose(
                boneController.transform,
                boneController.transform.localPosition,
                boneController.transform.localRotation,
                boneController.robotBoneMapping);
        }

        internal void TestHumanBodyMoved(Vector3 rndPos, Quaternion rndRot, Vector3 rndJointPos, Quaternion rndJointRot)
        {
            throw new NotImplementedException();
        }
    }
}
