using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Taza : MonoBehaviour, IDropHandler
{
    public GameObject punto, mantequilla, galleta, cremaDeLeche, jugoDeLimon, lecheCondensada, gelatina, huevo;
    public bool correcto;
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {

            if (eventData.pointerDrag == galleta)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == mantequilla)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == cremaDeLeche)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == jugoDeLimon)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == lecheCondensada)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == gelatina)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else if (eventData.pointerDrag == huevo)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = punto.GetComponent<RectTransform>().anchoredPosition;
                correcto = true;
            }
            else
            {
                correcto = false;
            }
            return;
        }
    }
}
