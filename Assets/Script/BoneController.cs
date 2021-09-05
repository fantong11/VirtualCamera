using UnityEngine.XR.ARFoundation;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;
using System;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class BoneController : MonoBehaviour
    {
        const int k_NumSkeletonJoints = 91;
        [SerializeField]
        [Tooltip("The root bone of the skeleton.")]
        Transform m_SkeletonRoot;

        /// <summary>
        /// Get/Set the root bone of the skeleton.
        /// </summary>
        public Transform skeletonRoot {
            get {
                return m_SkeletonRoot;
            }
            set {
                m_SkeletonRoot = value;
            }
        }
        
        public Dictionary<JointIndices, Transform> robotBoneMapping = new Dictionary<JointIndices, Transform>();

        public void InitializeSkeletonJoints() {
            Queue<Transform> nodes = new Queue<Transform>();
            nodes.Enqueue(m_SkeletonRoot);
            while (nodes.Count > 0)
            {
                Transform next = nodes.Dequeue();
                for (int i = 0; i< next.childCount; ++i)
                {
                    nodes.Enqueue(next.GetChild(i));
                    ProcessJoint(next);
                }
            }
        }

        private void ProcessJoint(Transform joint)
        {
            int index = GetJointIndex(joint.name);
            if (index >= 0 && index < k_NumSkeletonJoints)
            {
                var jointIndex = (JointIndices)index;

                if (robotBoneMapping.ContainsKey(jointIndex))
                {
                    robotBoneMapping[jointIndex] = joint;
                }
                else
                {
                    robotBoneMapping.Add(jointIndex, joint);
                }
            }
            else
            {
                Debug.LogWarning($"{joint.name} was not found.");
            }

        }

        private int GetJointIndex(string jointName)
        {
            foreach (int i in Enum.GetValues(typeof(JointIndices)))
            {
                var jointIndex = (JointIndices)i;

                var jointIndexName = jointIndex.ToString().ToLower();
                var strippedJointName = jointName.ToLower().Replace("_joint", "").Replace("_", "");

                if (jointIndexName != strippedJointName) continue;

                return (int)jointIndex;
            }
            return -1;
        }
    }
} 