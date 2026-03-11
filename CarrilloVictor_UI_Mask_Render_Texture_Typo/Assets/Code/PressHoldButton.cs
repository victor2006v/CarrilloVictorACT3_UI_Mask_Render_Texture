using UnityEngine;
using UnityEngine.EventSystems;

public class PressHoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isHolding = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isHolding = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHolding = false;
    }

    public bool IsHolding => isHolding;
}
