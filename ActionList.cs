using UnityEngine;

using System;
using System.Collections.Generic;

namespace ActionsSystem
{
	[Serializable]
	public class ActionList  
	{
		[SerializeField] private List<BaseAction> _actionsList = new List<BaseAction>();
	
		public void Perform()
		{
			Perform(null);
		}

        public void Perform(object parametr)
        {
            Perform(parametr, null);
        }
		
		public void Perform(params object[] parameters)
		{
			foreach (var item in _actionsList)
			{
				item.Perform(parameters);
			}
		}
	}
}