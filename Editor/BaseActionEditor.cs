using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ActionsSystem
{
    [CustomEditor(typeof(BaseAction), true)]
    public class BaseActionEditor : Editor
    {
        private BaseAction action = null;

        private void OnEnable()
        {
            action = target as BaseAction;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Perform"))
                action.Perform();
        }
    }
}