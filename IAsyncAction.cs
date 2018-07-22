using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionsSystem
{
    public interface IAsyncAction
    {
        IEnumerator Corutine(params object[] data);
    }
}