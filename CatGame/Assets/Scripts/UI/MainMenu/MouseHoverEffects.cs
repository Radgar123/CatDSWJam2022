using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
public class MouseHoverEffects : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{

    private Vector3 startScale;
    public float targetScale;

    public float animTime;
    public AnimationCurve ease;
    public UnityEvent onClick;
    Color normalColor;
    public Color hoverColor;

    public Image image;
    public void OnPointerClick(PointerEventData eventData)
    {
        onClick?.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(gameObject, startScale*targetScale, animTime).setEase(ease);
        image.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(gameObject, startScale, animTime).setEase(ease);
        image.color = normalColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;
        image = GetComponent<Image>();
        normalColor = image.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
