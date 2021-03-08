using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
   private RectTransform transformacijasLogs;
   public Canvas kanva;

   private void Awake()
   {
       transformacijasLogs=GetComponent<RectTransform>();
   }

   public void OnPointerDown(PointerEventData notikums)
   {
    Debug.Log("Kreisais klikšķis uz pārvietojamā objekta!");
   }

public void OnBeginDrag(PointerEventData notikums)
{
    Debug.Log("Uzsākta vilkšana!");
}

    public void OnDrag(PointerEventData notikums)
    {
        transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }

   public void OnEndDrag(PointerEventData notikums)
   {
       Debug.Log("vilksana pabeigta");
   }
}
