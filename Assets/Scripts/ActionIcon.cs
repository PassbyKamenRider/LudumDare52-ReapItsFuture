using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionIcon : MonoBehaviour
{
    public GameObject floatingIconPrefab;
    public int actionNum;
    public bool isOnAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void processAction(int actionNum) {
        if (!isOnAction) {
            isOnAction = true;
            this.actionNum = actionNum;
            if (actionNum == 0) {
                GameObject floatingIcon = Instantiate(floatingIconPrefab, Input.mousePosition, Quaternion.identity);
                floatingIcon.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
            }
            if (actionNum == 1) {
                GameObject floatingIcon = Instantiate(floatingIconPrefab, Input.mousePosition, Quaternion.identity);
                floatingIcon.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
            }
            if (actionNum == 2) {
                GameObject floatingIcon = Instantiate(floatingIconPrefab, Input.mousePosition, Quaternion.identity);
                floatingIcon.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
            }
            if (actionNum == 3) {
                GameObject floatingIcon = Instantiate(floatingIconPrefab, Input.mousePosition, Quaternion.identity);
                floatingIcon.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
            }
        }
    }
}
