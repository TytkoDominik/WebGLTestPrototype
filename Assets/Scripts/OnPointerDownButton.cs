using System;
using Boo.Lang;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class OnPointerDownButton : Button
    {
        private List<Action> _onPointerDownActions = new List<Action>();

        public void AddOnPointerDownListener(Action action)
        {
            _onPointerDownActions.Add(action);
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            foreach (var action in _onPointerDownActions)
            {
                action.Invoke();
            }
            
            base.OnPointerDown(eventData);
        }
    }
}