using UnityEngine;

namespace ActionsSystem
{
	public abstract class BaseAction : MonoBehaviour 
	{
		public abstract void Perform(params object[] list);
	}
}
