using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ActionsSystem
{
    public abstract class BaseAsyncAction : BaseAction, IAsyncAction
    {
        [SerializeField] private ActionList _actionList = new ActionList();
        public abstract IEnumerator Corutine(params object[] data);

        public override void Perform(params object[] list)
        {
            _actionList.Perform(list);
        }
    }
}
