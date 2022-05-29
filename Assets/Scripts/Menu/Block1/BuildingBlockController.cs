using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class BuildingBlockController : MonoBehaviour
{
    [SerializeField] List<Image> imagesList;
    [SerializeField] int buildingNumber = 0;
    [SerializeField] float timeCounter = 0f;
    [SerializeField] float idleTime = 0f;
    [SerializeField] float maxIdleTime = 60f;


    [SerializeField] List<BuildingTextSO> buildingTextSOs;
    [SerializeField] BuildingTextSO globalText;
    [SerializeField] Text buildingText;
    bool faded;
    bool autoSwitching;

    private void Start()
    {
        autoSwitching = true;
        faded = true;
    }
    private void Update()
    {
        if (autoSwitching)
        {
            timeCounter += Time.deltaTime;
            if (faded)
            {
                if (timeCounter >= buildingNumber * 5 + 5)
                {
                    LoadNextInfoBlock(false);
                }
                if (timeCounter >= imagesList.Count * 5) timeCounter = 0;
            }
        }
        else
        {
            idleTime += Time.deltaTime;
            if(idleTime > maxIdleTime)
            {
                SetAutoSwitching();
            }
        }
    }
    public void GetNextBuilding()
    {
        idleTime = 0;
        if (faded)
        {
            autoSwitching = false;
            LoadNextInfoBlock(true);
        }
    }
    void PlayFade(int startState, int endState, bool changeText) {
        faded = false;
        imagesList[startState].DOFade(0.5f, 0.5f).OnComplete(() =>
        {
            imagesList[startState].DOFade(0, 0.5f);
            imagesList[endState].DOFade(1f, 1f).OnComplete(() => { faded = true; });
            if (changeText) buildingText.text = buildingTextSOs[endState].text;
        });
    }
    void LoadNextInfoBlock(bool changeText)
    {
        if (buildingNumber < imagesList.Count - 1)
        {
            PlayFade(buildingNumber, buildingNumber + 1, changeText);
            buildingNumber++;
        }
        else
        {
            PlayFade(buildingNumber, 0, changeText);
            buildingNumber = 0;
        }
    }
    public void SetAutoSwitching()
    {
        autoSwitching = true;
        LoadNextInfoBlock(false);
        buildingText.text = globalText.text;
        timeCounter = buildingNumber * 5;
    }
}
