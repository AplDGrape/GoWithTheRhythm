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

    private void Awake()
    {
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
        dragThreshould = Screen.width / 15;

        UpdateArrowButton();
    }

    //Go to next page of level select
    public void Next()
    {
        if (currentPage < maxPage)
        {
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
    }

    //Go to previous page of level select
    public void Previous()
    {
        if (currentPage > 1)
        {
            currentPage--;
            targetPos -= pageStep;
            MovePage();
        }
    }

    //Move pages using Lean Tween import
    void MovePage()
    {
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
        UpdateArrowButton();
    }

    //Go to Main Menu
    public void backScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Go to first Level game scene
    public void ElectricTherapyScene()
    {
        SceneManager.LoadScene("ElectricTherapy");
    }

    //Arrow button status
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

    //Draggable screen (temp)
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
