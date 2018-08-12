using UnityEngine;

namespace ActionsSystem
{
	public abstract class BaseAction : MonoBehaviour 
	{
        public void Perform()
        {
            Perform(null);
        }

		public abstract void Perform(params object[] list);

        protected T SelectObjectForData<T>(params object[] data) where T : class
        {
            for (int i = 0; i < data.Length; i++)
                if (data[i] is T)
                    return data[i] as T;

            return null;
        }
	}
}
