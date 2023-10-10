using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameManager : MonoBehaviour
{
    public TextMeshProUGUI nameUI;
    public GameObject submitUI;
    private PlantStatusManager plantStatusManager;
    private ProgressManager progressManager;
    // Start is called before the first frame update
    void Start()
    {
        plantStatusManager = FindObjectOfType<PlantStatusManager>();
        progressManager = FindObjectOfType<ProgressManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubmitName(Text name) {
        plantStatusManager.dateOfBirth = (System.DateTime.Now).ToString();
        progressManager.progress += 1;
        nameUI.text = name.text;
        plantStatusManager.plantName = name.text;
        submitUI.SetActive(false);
        foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
            obj.transform.SetParent(plantStatusManager.interactables.transform);
        }
        nameUI.transform.parent.gameObject.SetActive(true);
    }
}
