using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlantStatusManager : MonoBehaviour
{
    public int plantStatus;
    public bool needUpdate;
    public bool isHovering;
    public int waterStatus = 5;
    public int happinessStatus = 5;
    public int growthStatus = 5;
    public int rebellionCount;
    public int dependentCount;
    public TextMeshProUGUI plantLevel;
    public Image waterBar;
    public Image happinessBar;
    public Image growthBar;
    public Sprite[] processBars;
    public string plantName;
    private Animator plantAnimator;
    public string dateOfBirth;

    [SerializeField] public GameObject[] objectsToDisableWhenTalk;
    [SerializeField] public GameObject interactables;
    [SerializeField] public GameObject nonInteractables;
    [SerializeField] public GameObject logs;
    [SerializeField] public GameObject logPrefab;
    [SerializeField] public GameObject deathUI;
    // Start is called before the first frame update
    void Start()
    {
        plantAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (needUpdate) {
            if (plantStatus == 1) {
                plantAnimator.Play("plant_1_anim");
                needUpdate = false;
                plantLevel.text = "Lv " + 2;
            }

            if (plantStatus == 2) {
                plantAnimator.Play("plant_2_anim");
                needUpdate = false;
                plantLevel.text = "Lv " + 3;
            }

            if (plantStatus == 3) {
                plantAnimator.Play("plant_3_anim");
                needUpdate = false;
                plantLevel.text = "Lv " + 4;
            }

            if (plantStatus == 4) {
                plantAnimator.Play("plant_4_anim");
                needUpdate = false;
                plantLevel.text = "Lv " + 5;
            }

            if (plantStatus == 5) {
                plantAnimator.Play("plant_5_anim");
                needUpdate = false;
                plantLevel.text = "Lv " + 5;
            }

            if (plantStatus == 6) {
                plantAnimator.Play("plant_2_anim");
                needUpdate = false;
                plantLevel.text = "Lv " + 5;
            }
        }

        switch (waterStatus) {
            case 0:
                waterBar.sprite = processBars[0];
                break;
            case 1:
                waterBar.sprite = processBars[1];
                break;
            case 2:
                waterBar.sprite = processBars[2];
                break;
            case 3:
                waterBar.sprite = processBars[3];
                break;
            case 4:
                waterBar.sprite = processBars[4];
                break;
            case 5:
                waterBar.sprite = processBars[5];
                break;
            default:
                break;
        }

        switch (growthStatus) {
            case 0:
                growthBar.sprite = processBars[0];
                break;
            case 1:
                growthBar.sprite = processBars[1];
                break;
            case 2:
                growthBar.sprite = processBars[2];
                break;
            case 3:
                growthBar.sprite = processBars[3];
                break;
            case 4:
                growthBar.sprite = processBars[4];
                break;
            case 5:
                growthBar.sprite = processBars[5];
                break;
            default:
                break;
        }

        switch (happinessStatus) {
            case 0:
                happinessBar.sprite = processBars[0];
                break;
            case 1:
                happinessBar.sprite = processBars[1];
                break;
            case 2:
                happinessBar.sprite = processBars[2];
                break;
            case 3:
                happinessBar.sprite = processBars[3];
                break;
            case 4:
                happinessBar.sprite = processBars[4];
                break;
            case 5:
                happinessBar.sprite = processBars[5];
                break;
            default:
                break;
        }
    }

    public void enableInteraction() {
        isHovering = true;
    }

    public void disableInteraction() {
        isHovering = false;
    }

    public void updateStatus() {
        for (int i = 0; i < 3; i++) {
            switch(Random.Range(0, 3)) {
                case 0:
                    waterStatus -= 1;
                    if (waterStatus <= 0) {
                        processDeath();
                    }
                    break;
                case 1:
                    growthStatus -= 1;
                    if (growthStatus <= 0) {
                        processDeath();
                    }
                    break;
                case 2:
                    happinessStatus -= 1;
                    if (happinessStatus <= 0) {
                        processDeath();
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public void processDeath() {
        foreach (var obj in objectsToDisableWhenTalk) {
            obj.transform.SetParent(nonInteractables.transform);
        }
        deathUI.SetActive(true);
    }

    public void restart() {
        SceneManager.LoadScene("GameScene1");
    }
}
