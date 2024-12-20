using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour, IEndDragHandler
{
    [SerializeField] int maxPage;
    int currentPage;
    Vector3 targetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;

    [SerializeField] float tweenTime;
    [SerializeField] LeanTweenType tweenType;
    float dragThreshould;

    [SerializeField] Button prevBtn;
    [SerializeField] Button nextBtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
        dragThreshould = Screen.width / 15;

        UpdateArrowButton();
    }

    public void Next()
    {
        if (currentPage < maxPage)
        {
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
    }

    public void Previous()
    {
        if (currentPage > 1)
        {
            currentPage--;
            targetPos -= pageStep;
            MovePage();
        }
    }

    void MovePage()
    {
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
        UpdateArrowButton();
    }

    public void backScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ElectricTherapyScene()
    {
        SceneManager.LoadScene("ElectricTherapy");
    }

    void UpdateArrowButton()
    {
        nextBtn.interactable = true;
        prevBtn.interactable = true;
        if (currentPage == 1)
        {
            prevBtn.interactable = false;

            if (GameOverMenu.ETComplete == true)
            {
                nextBtn.interactable = true;
            }
            else
            {
                nextBtn.interactable = false;
            }
        }
        else if (currentPage == maxPage)
        {
            nextBtn.interactable = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //If page swipe more than dragThresould -> page change
        if (Mathf.Abs(eventData.position.x - eventData.pressPosition.x) > dragThreshould)
        {
            if (eventData.position.x > eventData.pressPosition.x)
            {
                Previous();
            }
            else
            { 
                Next();
            }
        }
        else
        {
            MovePage();
        }
    }
}
