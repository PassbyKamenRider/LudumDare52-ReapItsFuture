using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingIcon : MonoBehaviour
{
    private ActionIcon actionIconStatus;
    private PlantStatusManager plantStatusManager;
    public Sprite[] actionSprites;
    public ProgressManager progressManager;
    // Start is called before the first frame update
    void Start()
    {
        actionIconStatus = FindObjectOfType<ActionIcon>();
        plantStatusManager = FindObjectOfType<PlantStatusManager>();
        progressManager = FindObjectOfType<ProgressManager>();
        GetComponent<Image>().sprite = actionSprites[actionIconStatus.actionNum];
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Input.mousePosition;

        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            actionIconStatus.isOnAction = false;
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (plantStatusManager.isHovering) {
                actionIconStatus.isOnAction = false;
                if (actionIconStatus.actionNum == 0) {
                    progressManager.needUpdate = true;
                }
                if (actionIconStatus.actionNum == 1) {
                    if (plantStatusManager.waterStatus >= 5) {
                    } else {
                        plantStatusManager.waterStatus += 1;
                    }
                }
                if (actionIconStatus.actionNum == 2) {
                    if (plantStatusManager.growthStatus >= 5) {
                    } else {
                        plantStatusManager.growthStatus += 1;
                    }
                }
                if (actionIconStatus.actionNum == 3) {
                    if (plantStatusManager.happinessStatus >= 5) {
                    } else {
                        plantStatusManager.happinessStatus += 1;
                    }
                }
                Destroy(this.gameObject);
            }
        }
    }
}
