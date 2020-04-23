using System;
using Cinemachine;
using UnityEngine;


namespace DefaultNamespace
{
    public sealed class TestCinemachine : MonoBehaviour
    {
        [SerializeField] private CinemachineImpulseSource _objectToCheck;
        [SerializeField] private CinemachineVirtualCameraBase _switchCameraTo;
        [SerializeField] private CinemachineTargetGroup _targetGroup;

        private CinemachineBrain _cinemachineBrain;
        private float _distanceToObject;
        
        private void Start()
        {
            _distanceToObject = _objectToCheck.m_ImpulseDefinition.m_DissipationDistance;
            foreach (var targetGroupMTarget in _targetGroup.m_Targets)
            {
                Debug.Log(targetGroupMTarget.target.name);
            }
            
            _cinemachineBrain = Camera.main.GetComponent<CinemachineBrain>();
            if (!_cinemachineBrain.ActiveVirtualCamera.Name.Equals(_switchCameraTo.Name))
            {
                --_cinemachineBrain.ActiveVirtualCamera.Priority; 
            }
        }
    }
}
