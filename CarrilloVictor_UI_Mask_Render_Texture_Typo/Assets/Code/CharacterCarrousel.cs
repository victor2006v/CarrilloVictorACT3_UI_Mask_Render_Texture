using UnityEngine;
using UnityEngine.UI;

public class CharacterCarrousel : MonoBehaviour
{
    private RectTransform rectTransform;
    [SerializeField] private PressHoldButton holdButton;
    [SerializeField] private float moveSpeed = 200f;
    private const float MAX_WIDTH_TRANSTITION = -136f;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (holdButton != null && holdButton.IsHolding && rectTransform.anchoredPosition.x > MAX_WIDTH_TRANSTITION)
        {
            MoveLeftImage();
        }
    }
    void MoveLeftImage()
    {
        rectTransform.anchoredPosition += Vector2.left * moveSpeed * Time.deltaTime;
    }
}
