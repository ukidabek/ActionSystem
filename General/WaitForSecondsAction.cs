using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionsSystem.General
{
    public class WaitForSecondsAction : BaseAsyncAction
    {
        [SerializeField] private float _secondsToWait = 1f;

        public override IEnumerator Corutine(params object[] data)
        {
            yield return new WaitForSeconds(_secondsToWait);
        }
    }
}