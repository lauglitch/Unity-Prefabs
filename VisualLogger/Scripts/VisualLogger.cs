using UnityEngine;

public class VisualLogger : MonoBehaviour
{
    private static VisualLogger instance;
    private LoggerPanelManager loggerPanel;

    private void Awake()
    {
        // Singleton Implementation
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        loggerPanel = GetComponentInChildren<LoggerPanelManager>();
        if (loggerPanel == null)
        {
            Debug.LogError("LoggerPanel not found. Make sure it is a child of VisualLogger.");
        }
    }

    /// <summary>
    /// Writes a message to the logger panel.
    /// </summary>
    /// <param name="message">The message to display.</param>
    public static void Write(string message)
    {
        if (instance?.loggerPanel != null)
        {
            instance.loggerPanel.LogMessage(message);
        }
        else
        {
            Debug.LogError("VisualLogger is not initialized or LoggerPanel is missing.");
        }
    }

    /// <summary>
    /// Clears all messages from the logger panel.
    /// </summary>
    public static void Clear()
    {
        if (instance?.loggerPanel != null)
        {
            instance.loggerPanel.ClearLog();
        }
        else
        {
            Debug.LogError("VisualLogger is not initialized or LoggerPanel is missing.");
        }
    }
}
