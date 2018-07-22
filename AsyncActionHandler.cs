using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionsSystem
{
    public class AsyncActionHandler : MonoBehaviour
    {
        private static AsyncActionHandler _instance = null;
        public static AsyncActionHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject gameObject = new GameObject();
                    Type type = typeof(AsyncActionHandler);
                    gameObject.name = type.Name;
                    gameObject.transform.position = Vector3.zero;
                    gameObject.transform.rotation = Quaternion.identity;

                    _instance = gameObject.AddComponent(type) as AsyncActionHandler;
                }
                return _instance;
            }
        }

        public void StartAction(BaseAction action, params object[] data)
        {
            StartCoroutine(HandleAsyncAction(action, data));
        }

        private IEnumerator HandleAsyncAction(BaseAction action, params object[] data)
        {
            IAsyncAction asyncAction = action as IAsyncAction;
            yield return asyncAction.Corutine(data);
            action.Perform(data);
        }
    }
}