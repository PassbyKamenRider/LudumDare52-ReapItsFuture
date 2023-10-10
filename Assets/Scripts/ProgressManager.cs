using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProgressManager : MonoBehaviour
{
    public int date = 1;
    public int progress;
    public bool needUpdate = true;
    public GameObject talkUIPrefab;
    public GameObject interactables;
    public GameObject nameUI;
    public GameObject talkUI;
    public GameObject blackScreen;
    public TextMeshProUGUI calendar;
    private PlantStatusManager plantStatusManager;
    public ItemManager itemManager;
    // Start is called before the first frame update
    void Start()
    {
        plantStatusManager = FindObjectOfType<PlantStatusManager>();
        itemManager = FindObjectOfType<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (needUpdate) {
            needUpdate = false;
            if (progress == 0) {
                talkUI.SetActive(true);
                talkUI.transform.SetParent(interactables.transform);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 3;
                talkUI.GetComponent<TypeWritter>().nameUI = nameUI;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You got a magic seed from a mysterious traveler, who claims this seed will become the world's best flower if you take enough care of it. First, give your plant a name:";
            }

            if (progress == 1) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 4;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 2) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 5;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 3) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 6;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 4) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 7;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 5) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 8;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 6) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 9;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 7) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 10;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "H ... hAllO?";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 8) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 11;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Hello! I'm ... " + plantStatusManager.plantName + ".";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 9) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 12;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "*nod*";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 10) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 13;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = plantStatusManager.plantName + ", I lave this name.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 11) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 14;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I fell a bit te - thesty. I need some water.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 12) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 15;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Thirsty, thirsty, thirsty. Yeah, I remembered!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 13) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 16;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Okay ... I'll say I'm the .. thirsty earlier next time.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 14) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 17;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "The sky is so blue today. I hope one day I can fly on the sky with the birds!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 15) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 18;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Sure! I'll get enough sunlight and nutrient and grow up very quick!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 16) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 19;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "but I don't want to be a flower, I want to explore the world...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 17) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 20;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "It's weekend, can you tell me more stories about the world? I really want to learn.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 18) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 21;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Yay --- I love stories!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 19) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 22;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Sure, have a nice rest.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 20) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 23;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I met some doves today, they said we'll become neighbors and gave me this stick left for building their nest.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 21) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 24;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Okay, I think we'll become good neighbors.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 22) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 25;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "They won't, I'm here to guard the window.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 23) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 26;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Good morning! I grow some more leaves today, can you see the difference?";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 24) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 27;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Of course! Thank you for taking so much care of me!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 25) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 28;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Thank you for taking so much care of me!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 26) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 29;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I can't believe how vast the world is - the clouds, birds, and buildings. It's an incredible feeling.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 27) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 30;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'll try my best!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 28) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 31;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "It might be, but ... nevermind.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 29) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 32;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Today a raven stops by the window. It tells me about mountains and rivers and gives me a shiny pebble as gift. I hope one day I can go outside and see that amazing view.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 30) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 33;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Friend? I'm so excited! Of course, I'll share everything interesting with you! Can you keep the pebble for me? It's the symbol of my first friendship.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 31) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 34;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "but it doesn't hurt me ... we're friends ...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 32) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 35;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Do you think I can become the most beautiful flower? Sometimes I feel like other plants are way better than me - they are bigger and strongger than me.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 33) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 36;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "... Yeah, you're right. I'll try.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 34) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 37;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "... Yeah, you're right.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 35) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 38;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Oh no! My leaf fell off because of the heavy wind! That's my greenest leaf!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 36) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 39;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "*nod*";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 37) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 40;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "*sob*";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 38) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 41;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Last night I saw those wild plants lose many leaves because of the wind and I understood that losing one leaf doesn't mean anything. I need to become brave in order to grow up.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 39) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 42;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Hey, come to see my new leaves. I'm already as strong as those mature plants, I can take care of myself now, I want to go outside!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 40) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 43;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm tired of being told what to do, I'm not a little seed anymore!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 41) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 44;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I know you've always taken care of me, but I'm strong enough to protect myself.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 42) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 45;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "The weather is gloomy today. My bird friends are all staying in their nests, I'm feeling really bored.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 43) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 46;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You always say something is good for me and never really understand me. I'm just saying my opinions, stop teaching me!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 44) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 47;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Yeah I hate rains, but if you know that why can't you put me outside so I can be closer to my plant friends?";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 45) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 48;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Sometimes I just envy those plants outside - they're free. Unlike me, stay in the silly pot here, alone.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 46) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 49;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm not that weak - I'll find the chance to prove myself someday.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 47) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 50;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I don't want a comfortable life, I want freedom. I don't want to be a beautiful flower and spend my whole life in my room.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 48) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 51;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Why are you packing up your stuff? Where are you going?";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 49) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 52;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Got it. See you.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 50) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 53;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Of course I can take care of myself.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 51) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 54;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You look really tired after yesterday's work. Do you need any help?";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 52) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 55;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Alright...";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 53) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 56;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Sure, have a good rest.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 54) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 57;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I just noticed it's been so long since you planted me. I want to take a photo as a memorial.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 55) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 58;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I also hope I can stay here, but I'm growing up and want to see the world outside.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 56) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 59;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'll remember you too.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 57) {
                if (plantStatusManager.rebellionCount > 8) {
                    // rebellious end
                    talkUI.SetActive(true);
                    talkUI.GetComponent<TypeWritter>().dialogueNumber = 60;
                    talkUI.GetComponent<TypeWritter>().showChoices = false;
                    talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Why I protect my flower under the thorns? That's because you never value my words, you're putting your own expectations on me and blaming me for not being the flower you want.";
                    foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                        obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                    }
                } else if (plantStatusManager.dependentCount > 5) {
                    // dependent end
                    talkUI.SetActive(true);
                    talkUI.GetComponent<TypeWritter>().dialogueNumber = 61;
                    talkUI.GetComponent<TypeWritter>().showChoices = false;
                    talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Where's my flower? Oh, that flower is taking too much nutrient from me, so I get rid of it. You're right, I don't need to be the best flower, I can just stay here, enjoy my comfortable life.";
                    foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                        obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                    }
                } else {
                    // good end
                    talkUI.SetActive(true);
                    talkUI.GetComponent<TypeWritter>().dialogueNumber = 62;
                    talkUI.GetComponent<TypeWritter>().showChoices = false;
                    talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "What a common white flower, right? I decided to go outside. Don't be worry, there're a lot flowers like me, I'll make more friends and overcome the difficulties just like how you helped me.";
                    foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                        obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                    }
                }
            }

            if (progress == 58) {
                if (plantStatusManager.rebellionCount > 8) {
                    // rebellious end
                    talkUI.SetActive(true);
                    talkUI.GetComponent<TypeWritter>().dialogueNumber = 63;
                    talkUI.GetComponent<TypeWritter>().showChoices = false;
                    talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "But every time I told you my opinions and my thoughts, you always held against me. If you want a obedient plant, go buy a fake flower! You're just REAPING MY FUTURE!";
                    foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                        obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                    }
                } else if (plantStatusManager.dependentCount > 5) {
                    // dependent end
                    talkUI.SetActive(true);
                    talkUI.GetComponent<TypeWritter>().dialogueNumber = 64;
                    talkUI.GetComponent<TypeWritter>().showChoices = false;
                    talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Stop being hypocritical ok? It's you who prevent me from doing this and that. It's you who don't want me to do anything. If I'm doing wrong, don't you think you have some responsibilities on that? It's you who REAPED MY FUTURE.";
                    foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                        obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                    }
                } else {
                    // good end
                    talkUI.SetActive(true);
                    talkUI.GetComponent<TypeWritter>().dialogueNumber = 65;
                    talkUI.GetComponent<TypeWritter>().showChoices = false;
                    talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Sure, I'll try my best to become your best flower, from now to the distant future.";
                    foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                        obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                    }
                }
            }

            if (progress == 59) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 66;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "It's the end of the game, thanks for playing!\nIt's my third game jam and first Ludum Dare (also the first solo jam).";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 60) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 67;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I usually do programming instead of making art assets and plotting. \nSorry guys for not having enough time to polish my words :(";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 61) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 68;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I want to write something about the relationship between parents and children. Some parents expect their children to be \"the best flower\" and push them too hard, and some parents spoil their children.";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }

            if (progress == 62) {
                talkUI.SetActive(true);
                talkUI.GetComponent<TypeWritter>().dialogueNumber = 69;
                talkUI.GetComponent<TypeWritter>().showChoices = false;
                talkUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I wonder what's the best way to express a balanced child-parent relationship in game, if you have any suggesions, I'm happy to read your comments!\nThanks for your playing again!";
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
                }
            }
        }
    }

    public void processChoice(int choice, GameObject choiceUI) {
        GameObject newLog;
        talkUI.GetComponent<TypeWritter>().hasEndTyping = false;
        talkUI.GetComponent<TypeWritter>().CharCount = 0;
        talkUI.GetComponent<TypeWritter>().textMesh.maxVisibleCharacters = 0;
        talkUI.GetComponent<TypeWritter>().downArrow.SetActive(false);
        switch (progress) {
            case 1:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You say hello to your plant.";
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You plant the mysterious seed and work on other stuff.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                itemManager.items[0] = 1;
                itemManager.itemObjects[0].GetComponent<Image>().color = Color.white;
                break;

            case 2:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You put your plant under the warm sunlight.";
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Nothing special seems to happen.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                break;

            case 3:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You move the plant under the roof to protect it from the rain.";
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "The sudden rain annoys you. You take a shower and have a nice sleep, didn't care too much about that plant.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                break;
            
            case 4:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You're busy today, but still take some time to take care of your plant.";
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You're busy at work and hopefully your plant will get enough sunlight and water from the nature. You need to work to feed yourself and the plant, afterall.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                break;

            case 5:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "The seed still not seems to sprout today.";
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "The seed still not seems to sprout today.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                break;

            case 6:
                plantStatusManager.needUpdate = true;
                plantStatusManager.plantStatus += 1;
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You say morning to your plant and hopefully it will flurish in the great springtime.";
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You think the seed might already been eaten by the pigeons, maybe it's the time to give up.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                break;

            case 7:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "The seed finally sprout, and it becomes a talking little plant. You have to admit that the magician isn't lying at all.";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "The seed finally sprout, and it becomes a talking little plant. You have to admit that the magician isn't lying at all.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;

                break;

            case 10:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant loves its name. That makes you feel a sense of accomplishment after days of accompany with the plant.";
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant says a complete sentence for the first time, it's remarkable but you're a bit unsatisfied. A magic plant should do better - to be worth your money and time.";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);
                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;
                break;

            case 11:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You taught your plant how to spell thirsty, you're making some more progress, isn't it?";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "A talking plant seems too noisy to you ... especially when you're about to have a rest after a day's work.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 14:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.dependentCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant has its first goal. Although it sounds not duable for a plant to fly, you encourage it to achieve its goal.";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant want to fly like a bird, that's ridiculous. Why it can't have a realistic goal?";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 17:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.dependentCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You spent some time with your plant during the weekend, reading stories for it.";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You had a nice rest today while the plant read storybooks quietly.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 20:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You get a gift from your new \"neighbors\" and return them with some grains and nuts.";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant told you that some doves building new nests nearby, hope they won't mess up your windowsill.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 23:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is growing up, when will it become the best flower as the traveller said? Hope that day won't be too far away.";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is growing up, when will it become the best flower as the traveller said? Hope that day won't be too far away.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;

                break;

            case 26:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is curious about the world. You encourages it to explore the world as it grows up. You know that not everything in the world is as beautiful as it seems, but that's the cost of growing up ... is it?";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is curious about the world. You told it that the world isn't as great as it looks like. If it's not curious about the world, it's less likely it will be hurt by others ... is it?";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 29:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant makes its first friend in its life. It's a remarkable day for your plant!";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You protect your plant from the raven. Although it doens't seem to be happy, that's necessary cost. You don't want it to make bad friends.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 32:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant seems to become nervous about its future. It's the first talking plant you ever had, and you're unsure about how you can encourage it. Maybe that's something it needs to solve by itself.";
                    progress += 1;
                } else {
                    plantStatusManager.dependentCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant seems to become nervous about its future. It's the first talking plant you ever had, and you're unsure about how you can encourage it. Maybe that's something it needs to solve by itself.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 35:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.dependentCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant crys because it loses its favorite leaf. You have to protect it.";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant crys because it loses its favorite leaf. It's not a kid anymore, it needs to become strong, in mind.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 38:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant really grows up. You'll keep the leaf forever as a proof of its braveness. ";
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant really grows up. You'll keep the leaf forever as a proof of its braveness. ";
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);
                progress += 1;

                date += 1;
                plantStatusManager.updateStatus();
                calendar.text = "Day " + date;

                itemManager.items[4] = 1;
                itemManager.itemObjects[4].GetComponent<Image>().color = Color.white;

                break;

            case 39:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is eager to go outside, but you don't think it's the time for it to live alone.";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is eager to go outside, but you don't think it's the time for it to live alone.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 42:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is becoming ... rebellious? Maybe that's a sign of growing up. What should you do?";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant is becoming ... rebellious? Maybe that's a sign of growing up. What should you do?";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 45:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Your plant says it'll wait for the chance to go outside.";
                    progress += 1;
                } else {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You feel that your plant is ungreateful. What can be better than a comfortable life that someone takes care of it?";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 48:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.dependentCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You prepared everything for your plant, that's what a nice parent will do, right?";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You give your plant a chance to show it can live independently.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 51:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.dependentCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You don't want your plant to worry about you. You're strongger than it, and must take more responsibilities.";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You have a really good rest today. Maybe it's the time for your plant to take some of your burdens.";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 54:
                newLog = Instantiate(plantStatusManager.logPrefab, Vector3.zero, Quaternion.identity);
                newLog.transform.SetParent(plantStatusManager.logs.transform);
                
                if (choice == 0) {
                    plantStatusManager.rebellionCount += 1;
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You don't want your plant to leave you - you haven't seen the best flower in the world.";
                    progress += 1;
                } else {
                    newLog.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Day " + date;
                    newLog.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "You take a photo with your plant. Maybe you feel it's the time to let your plant go?";
                    progress += 2;
                }

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 57:

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progress += 1;
                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            case 58:

                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                talkUI.SetActive(false);
                Destroy(choiceUI);

                needUpdate = true;
                break;

            default:
                break;

        }
    }
}
