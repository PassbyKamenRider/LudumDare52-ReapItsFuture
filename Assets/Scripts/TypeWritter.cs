using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TypeWritter : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI textMesh;
    [SerializeField] float timeBetweenChars;
    [SerializeField] public GameObject downArrow;
    [SerializeField] GameObject nextDialogue;
    [SerializeField] public int dialogueNumber;
    [SerializeField] public GameObject choiceUI;
    public bool showChoices;
    public int CharCount = 0;
    private float timer = 0;
    public bool hasEndTyping = false;
    public GameObject nameUI;
    private PlantStatusManager plantStatusManager;
    private ProgressManager progressManager;
    private ItemManager itemManager;
    private void Start() {
        downArrow.SetActive(false);
        textMesh.maxVisibleCharacters = CharCount;

        plantStatusManager = FindObjectOfType<PlantStatusManager>();
        progressManager = FindObjectOfType<ProgressManager>();
        itemManager = FindObjectOfType<ItemManager>();

        foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
            obj.transform.SetParent(plantStatusManager.nonInteractables.transform);
        }
    }

    private void Update() {
        if (textMesh.textInfo.characterCount > CharCount) {
            timer += Time.deltaTime;
            if (timer >= timeBetweenChars) {
                timer = 0;
                CharCount += 1;
                textMesh.maxVisibleCharacters = CharCount;

                if (textMesh.textInfo.characterCount == textMesh.maxVisibleCharacters) {
                    downArrow.SetActive(true);
                    hasEndTyping = true;
                }
            }
        }

        if (hasEndTyping && Input.GetKeyDown(KeyCode.Space)) {
            if (nextDialogue) {
                nextDialogue.SetActive(true);
                gameObject.SetActive(false);
            }

            if (dialogueNumber == 2) {
                gameObject.SetActive(false);
                SceneManager.LoadScene("GameScene1");
            }

            if (dialogueNumber == 3) {
                gameObject.SetActive(false);
                nameUI.SetActive(true);
            }

            if (dialogueNumber == 4 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Hello, little seed. You name is " + plantStatusManager.plantName + " and I'll take care of you.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I just doubt that traveler is lying. Whatever, I didn't expect much.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 5 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "What a nice spring! I hope you can grow up soon in the warm weather.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "It's still a seed, I would've knew that traveler's lying.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 6 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Hi " + plantStatusManager.plantName + ", it's raining today. I think you already gets enough water, let me move you under the roof.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I hate the weather today - I'm almost soaked by the rain when waiting for the bus.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }
            
            if (dialogueNumber == 7 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm quite busy today. Bye, I'll water you when I come back.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm quite busy today. You'd better take care of yourself and don't bother me.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 8 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "How are you feeling today, " + plantStatusManager.plantName + "? I hope you'll grow up soon!";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Ugh ... I didn't see any difference, is it really growing?";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 9 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Good morning " + plantStatusManager.plantName + ", look at the green and lush view outside. When will you grow up and make friend with other plants?";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I bet the seed was eaten by those noisy pigeons. *Sigh* I shouldn't put it outside.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 10 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You can talk? That's amazing! Hello " + plantStatusManager.plantName + "!";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Wait, the plant can talk? Am I crazy? That's really interesting.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 11) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[1] = 1;
                itemManager.itemObjects[1].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 12) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[1] = 1;
                itemManager.itemObjects[1].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 13 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You love the name I give you? That's great! Nice to meet you " + plantStatusManager.plantName +"!";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "It's L-O-V-E, love. I shouldn't expect a plant to be that clever.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 14 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You mean you're thirsty? Sure, I'll water you really quick, sorry I didn't notice you're growing and need more water. Also, it's T-H-I-R-S-T-Y, thirsty. You'll learn more words in the future.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You mean you're thirsty? *Sigh* Why don't you say that earlier? I'm about to sleep! That's your water, don't bother me again.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 15) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 16) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 17 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Although I don't know what kind of plant are you, but flowers like dandelion can fly like birds. I hope you can grow up soon and achieve your dream!";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You're a plant, it's impossible for you to become a bird, but I hope you can become the best flower in the world.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 18) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 19) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 20 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Of course! Do you want to hear the story between a rose and the little prince?";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm too tired after a week's work, sorry little *name*, you can read the storybooks by yourself.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 21) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 22) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 23 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "That's great, I'll put some grains and nuts outside as these new neighbors' gift. Say hello to them for me.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Doves? Hope they won't mess up the windowsill.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 24) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                plantStatusManager.needUpdate = true;
                plantStatusManager.plantStatus += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[2] = 1;
                itemManager.itemObjects[2].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 25) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                plantStatusManager.needUpdate = true;
                plantStatusManager.plantStatus += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[2] = 1;
                itemManager.itemObjects[2].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 26 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm so proud of you, little *name*. You'll become strongger and bigger in the future!";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Of course you will grow up, I pay so many efforts on you.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 27) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 28) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 29 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You'll explore more of the world when you grow up. I believe you can.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "It's not as great as it seems. You'll know when you grow up.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 30) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 31) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 32 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm glad you made your first friend! I hope the raven will come back soon so you can share its stories with me.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Raven? That's dangerous, big birds like ravens would hurt you! I'll take the pebble away, listen to me and you're be safe.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 33) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[3] = 1;
                itemManager.itemObjects[3].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 34) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[3] = 1;
                itemManager.itemObjects[3].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 35 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You can. If you try your best to get enough nutrients you'll become the best flower, just like how you learn to speak.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You don't have to be the best flower, you're always the best flower to me, don't put so much stress on yourself.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 36) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 37) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 38 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Oh my poor "+ plantStatusManager.plantName + ", let's get inside.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I know it's hard to see your leaf fall off, but it's part of the nature. If you want to become those strongger plants, you'll have to accept that.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 39) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 40) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 41 && !showChoices) {
                plantStatusManager.needUpdate = true;
                plantStatusManager.plantStatus += 1;

                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You're really growing up, I'm proud of you.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Of course, my brave " + plantStatusManager.plantName;
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 42 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Your roots are not deep enough, you still need the protection of roof.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "What? No way, I raise you up and pay so many efforts on you. I don't want you to take the risk!";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 43) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 44) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 45 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Yeah, some rain is good for plants.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I agree. I also hate rains, especially when it rains on workdays.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 46) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 47) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 48 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "When you're strong enough I'll give you chance to explore the world outside. Leaving you outside would only hurt you for now.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "But I gave you everything you want - fertilizer, water, and care. Why do you keep complaining about the comfortable life I gave you?";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 49) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 50) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 51 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'll go out for work today and might come back at late night. I prepared your water and fertilizer, take care of yourself.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I have work to do. You're not a kid now, take care of yourself.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 52) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 53) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 54 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I'm good, just take care of yourself.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Maybe you can tell your bird friends to be quiet. I really need to take a nap.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 55) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 2;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 56) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;
            }

            if (dialogueNumber == 57 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "As a memorial? It's not the time to leave - you're still young and we'll create more memories in this place.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Sure, I'll keep the photo if you leave me for your goals some day.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 58) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }
                progressManager.progress = 57;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                if (plantStatusManager.rebellionCount > 8) {
                    // rebellious end
                    plantStatusManager.needUpdate = true;
                    plantStatusManager.plantStatus = 5;
                } else if (plantStatusManager.dependentCount > 5) {
                    // dependent end
                    plantStatusManager.needUpdate = true;
                    plantStatusManager.plantStatus = 6;
                } else {
                    // good end
                    plantStatusManager.needUpdate = true;
                    plantStatusManager.plantStatus = 4;
                }
            }

            if (dialogueNumber == 59) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.date += 1;
                plantStatusManager.updateStatus();
                progressManager.calendar.text = "Day " + progressManager.date;

                itemManager.items[5] = 1;
                itemManager.itemObjects[5].GetComponent<Image>().color = Color.white;

                if (plantStatusManager.rebellionCount > 8) {
                    // rebellious end
                    progressManager.progress = 57;
                } else if (plantStatusManager.dependentCount > 5) {
                    // dependent end
                    progressManager.progress = 57;
                } else {
                    // good end
                    progressManager.progress = 57;
                }
            }

            if (dialogueNumber == 60 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "But everything I did is good for you.";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "I paid so many efforts on you!";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 61 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "What about your dreams, your goals?";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Don't you want to explore the world outside?";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 62 && !showChoices) {
                showChoices = true;
                GameObject choice = Instantiate(choiceUI, new Vector3(960, 540, 0), Quaternion.identity);
                choice.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Good luck " + plantStatusManager.plantName + ".";
                choice.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "You're always my best flower.";
                choice.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(0, choice);});
                choice.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(delegate {progressManager.processChoice(1, choice);});
                choice.transform.SetParent(plantStatusManager.interactables.transform);
            }

            if (dialogueNumber == 63) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress = 59;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);

                itemManager.items[7] = 1;
                itemManager.itemObjects[7].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 64) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress = 59;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);

                itemManager.items[8] = 1;
                itemManager.itemObjects[8].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 65) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress = 59;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);

                itemManager.items[6] = 1;
                itemManager.itemObjects[6].GetComponent<Image>().color = Color.white;
            }

            if (dialogueNumber == 66) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.needUpdate = true;
            }

            if (dialogueNumber == 67) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.needUpdate = true;
            }

            if (dialogueNumber == 68) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.needUpdate = true;
            }

            if (dialogueNumber == 69) {
                gameObject.SetActive(false);
                foreach (var obj in plantStatusManager.objectsToDisableWhenTalk) {
                    obj.transform.SetParent(plantStatusManager.interactables.transform);
                }

                progressManager.progress += 1;

                hasEndTyping = false;
                CharCount = 0;
                textMesh.maxVisibleCharacters = 0;
                downArrow.SetActive(false);
                progressManager.needUpdate = true;
            }
        }
    }
}
