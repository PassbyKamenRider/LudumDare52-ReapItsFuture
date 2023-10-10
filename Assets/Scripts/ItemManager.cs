using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemDescription;
    public int[] items;
    public GameObject[] itemObjects;
    private PlantStatusManager plantStatusManager;
    // Start is called before the first frame update
    void Start()
    {
        plantStatusManager = FindObjectOfType<PlantStatusManager>();
        items = new int[9];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayItem(int idx) {
        if (items[idx] == 1) {
            switch(idx) {
                case 0:
                    itemName.text = "Birth Certificate";
                    itemDescription.text = "Name: " + plantStatusManager.plantName + "\n" + "Date of birth: " + plantStatusManager.dateOfBirth;
                    break;
                case 1:
                    itemName.text = "Recording of First Words";
                    itemDescription.text = "A recording of your plant's first word.";
                    break;
                case 2:
                    itemName.text = "Neighbors' Gift";
                    itemDescription.text = "A great stick for building nests, from your pigeon neighbors.";
                    break;
                case 3:
                    itemName.text = "Raven's Pebble";
                    itemDescription.text = "A shiny pebble, the raven loves it.";
                    break;
                case 4:
                    itemName.text = "Proof of Braveness";
                    itemDescription.text = "Your plant's first fallen leaf.";
                    break;
                case 5:
                    itemName.text = "A Photo";
                    itemDescription.text = "The photo of your plant on the windowsill.";
                    break;
                case 6:
                    itemName.text = "Harvest";
                    itemDescription.text = "A common white flower that grows everywhere, but that's your best harvest.";
                    break;
                case 7:
                    itemName.text = "\"Harvest\"";
                    itemDescription.text = "A bloody rose that surrounds with thorns. Why your plant protects its heart under the deep thorns from you? Maybe you shouldn't push it so hard?";
                    break;
                case 8:
                    itemName.text = "\"Harvest\"";
                    itemDescription.text = "A flower that never blooms. Why your plant loses independence and loses the power to grow? Maybe you shouldn't coddle it?";
                    break;
                default:
                    break;
            }
        }
    }
}
