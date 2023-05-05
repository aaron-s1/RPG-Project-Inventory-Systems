using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using GameDevTV.Core.UI.Dragging;

namespace GameDevTV.UI.Inventories
{
    public class InventorySlotUI : MonoBehaviour, IDragContainer<Sprite>
    {
        // CONFIG DATA
        [SerializeField] InventoryItemIcon icon = null;

        // PUBLIC

        public int MaxAcceptable(Sprite item)
        {
            if (GetItem() == null)
            {
                return int.MaxValue;
            }
            return 0;
        }

        public void AddItems(Sprite item, int number)
        {
            print(gameObject + " AddItems " + item);
            icon.SetItem(item);
        }

        public Sprite GetItem()
        {
            print(gameObject + " GetItem " + icon.GetItem());
            return icon.GetItem();
        }

        public int GetNumber()
        {
            return 1;
        }

        public void RemoveItems(int number)
        {
            print(gameObject + " RemoveItems " + icon.GetItem());
            icon.SetItem(null);
        }
    }
}