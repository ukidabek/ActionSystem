using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ActionsSystem.General
{
    public class WaitForSecondsAction : BaseAsyncAction
    {
        [SerializeField] private float _secondsToWait = 1f;
        public CountdownCallback CountdownCallback = new CountdownCallback();

        public override IEnumerator Corutine(params object[] data)
        {
            var _countDownCounter = _secondsToWait;

            while (_countDownCounter > 0)
            {
                _countDownCounter -= Time.deltaTime;
                CountdownCallback.Invoke(1 - (_countDownCounter / _secondsToWait));
                yield return null;
            }

        }
    }
    [Serializable] public class CountdownCallback : UnityEvent<float> { }
}
