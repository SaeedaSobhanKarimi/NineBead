using UnityEngine;
using UnityEngine.EventSystems;
public class DropZone : MonoBehaviour, IDropHandler 
{
	public void OnDrop(PointerEventData eventData) 
	{
		//Debug.Log (eventData.pointerDrag.name + " was dropped on " + gameObject.name);
		//Do checks for what is being drop here 
	}
}