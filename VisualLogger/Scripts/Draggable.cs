using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform draggableRectTransform;
    private Canvas parentCanvas;
    private CanvasGroup canvasGroup;
    private Vector2 offset;

    private void Awake()
    {
        draggableRectTransform = GetComponent<RectTransform>();
        parentCanvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();

        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
    }

    /// <summary>
    /// Start dragging the VisualLogger into the graphical interface while ignore raycasts
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (canvasGroup != null)
        {
            canvasGroup.blocksRaycasts = false;
        }

        // Calculate the offset based on the local position within the Canvas
        Vector2 localPointerPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            eventData.position,
            parentCanvas.worldCamera,
            out localPointerPosition
        );

        // Calculate the displacement between the cursor and the RectTransform
        offset = draggableRectTransform.anchoredPosition - localPointerPosition;
    }

    /// <summary>
    /// Update the position of the VisualLogger in the interface while it is being dragged
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        if (parentCanvas != null)
        {
            Vector2 localPointerPosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                parentCanvas.transform as RectTransform,
                eventData.position,
                parentCanvas.worldCamera,
                out localPointerPosition
            );

            // Apply the offset when dragging
            draggableRectTransform.anchoredPosition = localPointerPosition + offset;
        }
    }

    /// <summary>
    /// Restore raycasts when drag has finished
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        if (canvasGroup != null)
        {
            canvasGroup.blocksRaycasts = true;
        }
    }
}
