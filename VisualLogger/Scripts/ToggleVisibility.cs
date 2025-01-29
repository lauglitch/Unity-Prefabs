using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    [SerializeField] private GameObject loggerPanel;

    /// <summary>
    /// Method to show or hide the LoggerPanel
    /// </summary>
    public void TogglePanelVisibility()
    {
        if (loggerPanel != null)
        {
            bool isActive = loggerPanel.activeSelf;
            loggerPanel.SetActive(!isActive); // Alterna la visibilidad
        }
    }
}
