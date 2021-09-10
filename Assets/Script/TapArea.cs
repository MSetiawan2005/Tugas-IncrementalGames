using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource buttonSound;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
}
