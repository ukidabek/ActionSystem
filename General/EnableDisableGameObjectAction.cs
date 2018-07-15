using UnityEngine;

namespace ActionsSystem.General
{
    public class EnableDisableGameObjectAction : BaseAction
    {
        [SerializeField] private GameObject _gameObject = null;
        [SerializeField] private bool _enable = false;

        public override void Perform(params object[] list)
        {
            _gameObject.SetActive(_enable);
        }
    }
}