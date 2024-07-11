using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Drags : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{
	public Vector2 offset;
	public void OnBeginDrag (PointerEventData eventData)
	{
		offset = this.transform.position - Input.mousePosition;
	}
	public void OnDrag (PointerEventData eventData)
	{
		this.transform.position = eventData.position + offset;
	}
	public void OnEndDrag (PointerEventData eventData)
	{
	}


}
