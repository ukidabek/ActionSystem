using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

namespace ActionsSystem
{
	[Serializable]
	public class ActionList
	{
		[SerializeField] private List<BaseAction> _actionsList = new List<BaseAction>();
			
		public void Perform(params object[] parameters)
		{
			foreach (var item in _actionsList)
            {
                if (item is IAsyncAction)
                    AsyncActionHandler.Instance.StartAction(item, parameters);
                else
                    item.Perform(parameters);

            }
		}
	}
}