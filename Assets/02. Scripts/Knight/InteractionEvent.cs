using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType { SIGN, DOOR, NPC }
    public InteractionType type; // 상호작용 타입

    public GameObject Popup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Interaction(other.transform);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Popup.SetActive(false);
        }
    }

    private void Interaction(Transform player)
    {
        switch (type)
        {
            case InteractionType.SIGN:
                Popup.SetActive(true);
                break;
            case InteractionType.DOOR:
                break;
            case InteractionType.NPC:
                Popup.SetActive(true);
                break;
        }
    }
}
