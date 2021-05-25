using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ingrediente : MonoBehaviour, IBeginDragHandler, IPointerDownHandler
{
    [SerializeField] private Canvas canvas;
    public GameObject prefab;
    public GameObject punto_inicial;
    public Vector3 posInicial;
    private CanvasGroup canvasGroup;
    private CanvasGroup prefab_canvasGroup;
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        prefab_canvasGroup = prefab.GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("instancia");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("clic");
        canvasGroup.blocksRaycasts = false;
        prefab_canvasGroup.blocksRaycasts = true;
        Instantiate(prefab, eventData.delta, punto_inicial.transform.rotation);
    }
}
