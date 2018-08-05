using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ActionsSystem.General
{
    public class SetUIElementInteractable : BaseAction
    {
        [SerializeField] private bool _isInteractable = false;
        [SerializeField] private Selectable _selectable = null;

        public override void Perform(params object[] list)
        {
            _selectable.interactable = _isInteractable;
        }
    }
}