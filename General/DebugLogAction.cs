using UnityEngine;

namespace ActionsSystem.General
{
    public class DebugLogAction : BaseAction
    {
        [SerializeField] private string _message = string.Empty;

        public override void Perform(params object[] list)
        {
            Debug.Log(_message);
        }
    }
}