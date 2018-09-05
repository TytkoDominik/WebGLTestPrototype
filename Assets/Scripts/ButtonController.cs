using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ButtonController : MonoBehaviour
    {
        [SerializeField]
        private List<Button> _buttons = new List<Button>();

        private void Start()
        {
            OnClick();
        }

        public void OnClick()
        {
            foreach (var button in _buttons)
            {
                button.interactable = false;
            }

            _buttons[Random.Range(0, _buttons.Count)].interactable = true;
        }
    }
}
    
