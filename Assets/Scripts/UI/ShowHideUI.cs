using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryExample.UI
{
    public class ShowHideUI : MonoBehaviour
    {
        [SerializeField] KeyCode menuToggleKey = KeyCode.Escape;
        [SerializeField] KeyCode iconToggleKey = KeyCode.Escape;

        [SerializeField] GameObject menuContainer = null;
        [SerializeField] GameObject iconContainer = null;

        void Start() 
        {
            menuContainer.SetActive(false);
        }

        void Update()
        {
            if (Input.GetKeyDown(menuToggleKey))
                menuContainer.SetActive(!menuContainer.activeSelf);

            if (Input.GetKeyDown(iconToggleKey))
                iconContainer.SetActive(!iconContainer.activeSelf);
        }
    }
}