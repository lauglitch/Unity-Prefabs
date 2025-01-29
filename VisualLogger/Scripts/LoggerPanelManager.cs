using UnityEngine;
using UnityEngine.UI;

public class LoggerPanelManager : MonoBehaviour
{
    [SerializeField] private GameObject loggerPanel; 
    [SerializeField] private Text loggerText;      

    private void Awake()
    {
        if (loggerPanel == null)
        {
            Debug.LogError("LoggerPanel not assigned!");
        }

        if (loggerText == null)
        {
            loggerText = GetComponentInChildren<Text>();
        }
    }

    /// <summary>
    /// Show or hide the LoggerPanel.
    /// </summary>
    public void TogglePanelVisibility()
    {
        if (loggerPanel != null)
        {
            loggerPanel.SetActive(!loggerPanel.activeSelf);
        }
    }

    /// <summary>
    /// Adds a message to the LoggerPanel.
    /// </summary>
    /// <param name="message">The message to show.</param>
    public void LogMessage(string message)
    {
        if (loggerText != null)
        {
            loggerText.text += message + "\n";
        }
    }

    /// <summary>
    /// Clear the LoggerPanel.
    /// </summary>
    public void ClearLog()
    {
        if (loggerText != null)
        {
            loggerText.text = "";
        }
    }
}
