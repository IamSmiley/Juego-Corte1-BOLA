using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("InGame")]
    public Image levelSlider;
    public Image currentLevetImg;
    public Image nextLevelImg;

    private Material ballMat;

    void Awake()
    {
        ballMat = FindObjectOfType<BOLA>().transform.GetChild(0).GetComponent<MeshRenderer>().material;

        levelSlider.transform.parent.GetComponent<Image>().color = ballMat.color + Color.gray;
        levelSlider.color = ballMat.color;
        currentLevetImg.color = ballMat.color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSliderFill(float fillAmount)
    {
        levelSlider.fillAmount = fillAmount;
    }
}
