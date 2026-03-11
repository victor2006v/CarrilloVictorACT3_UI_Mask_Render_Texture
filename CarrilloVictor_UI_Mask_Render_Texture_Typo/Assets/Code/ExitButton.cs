using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private Button exitButton;
    private void Awake()
    {
        exitButton = GetComponent<Button>();
    }

    private void OnEnable()
    {
        exitButton.onClick.AddListener(Exit);
    }

    private void OnDisable()
    {
        exitButton.onClick.RemoveListener(Exit);
    }

    private void Exit() { 
        
        Application.Quit();
    }

}
