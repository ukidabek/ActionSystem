using UnityEngine;

namespace ActionsSystem.General
{
    public class ActionListAction : BaseAction
    {
        [SerializeField] private ActionList _actionList = new ActionList();

        public override void Perform(params object[] list)
        {
            _actionList.Perform(list);
        }
    }
}
