using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class D20Roller : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public ParentPositionCheck posCheck;

    public GameObject player;
    public float displayTime = 3f;
    public int rollResult;
    public int newRollResult;
    public bool noResultText;

    public TextMeshProUGUI rollResultText; // reference to the text object that will display the roll result
    public TextMeshProUGUI encounterResultText; // reference to the text object that will display the encounter result


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // This function is called when the roll button is clicked
    public void RollD20()
    {
        // Generate a random number between 1 and 20
        rollResult = Random.Range(1, 21);
        if (!noResultText)
        {
            if (posCheck.isOnRH)
            {
                IsOnRH();
            }
            if (posCheck.isOnGB)
            {
                IsOnGB();
            }
            if (posCheck.isOnTW)
            {
                IsOnTW();
            }
            if (posCheck.isOnNM)
            {
                IsOnNM();
            }
            if (posCheck.isOnSH)
            {
                IsOnSH();
            }
            if (posCheck.isOnDW)
            {
                IsOnDW();
            }
            if (posCheck.isOnNH)
            {
                IsOnNH();
            }
            if (posCheck.isOnLV)
            {
                IsOnLV();
            }
            if (posCheck.isOnHT)
            {
                IsOnHT();
            }
            if (posCheck.isOnDR)
            {
                IsOnDR();
            }
            if (posCheck.isOnTL)
            {
                IsOnTL();
            }
            if (posCheck.isOnGL)
            {
                IsOnGL();
            }
            if (posCheck.isOnPX)
            {
                IsOnPX();
            }
            if (posCheck.isOnGU)
            {
                IsOnGU();
            }
            if (posCheck.isOnNU)
            {
                IsOnNU();
            }
            if (posCheck.isOnTV)
            {
                IsOnTV();
            }
            if (posCheck.isOnBM)
            {
                IsOnBM();
            }
        }
        // Update the roll result text to show the result of the roll
        rollResultText.text = "You rolled: " + rollResult;
        rollResultText.gameObject.SetActive(true);

        Invoke("HideResultText", displayTime);
    }

    public void IsOnRH()
    {
        //Rostland Hinterlands(RL)
        //1 - 5 3 Bandits(use stats for Thorn River bandits on pg. 170)
        //    6 - 8 2 Brush Thylacines(pg. 609)
        //9 - 11    1 Hunter(Use stats for poacher, GMG)
        //    12 - 13   2 Elk(pg. 608)
        //14 - 15   2 Wolves(Bestiary 1)
        //16 - 17   2 Boars(Bestiary 1)
        //18 - 19   3 Thylanices(pg. 609)
        //20  1 Grizzly Bear(Bestiary 1)
        if (rollResult <= 5)
        {
            encounterResultText.text = "3 Bandits";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "2 Brush Thylacine";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Hunter";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Elk";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Wolves";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "2 Boars";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "3 Thylacines";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Grizzly Bear";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnGB()
    {
        //Greenbelt

        //1 - 5 Roll on Zone 1
        //6-8	4 Mitflit Gremilins (Bestiary 1)
        //9 - 11    2 Hunting Spiders(Bestiary 1)
        //12 - 13   4 Stag Lord Bandits (pg. 177)
        //14 - 15   2 Brush Thylacines(pg. 609)
        //16 - 17   5 Kobolds(Bestiary 1)
        //18 - 19   1 Owlbear(Bestiary 1)
        //20  3 Ruffians(GMG)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "3 Bandits";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "2 Brush Thylacine";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Hunter";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "2 Elk";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "2 Wolves";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Boars";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "3 Thylacines";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Grizzly Bear";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "4 Mitflit Gremlins";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "2 Hunting Spiders";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "4 Stag Lord Bandits";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Brush Thylacines";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "5 Kobolds";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Owlbear";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Shambler";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnTW()
    {
        //Tuskwater
        //1 - 5 Roll on Zone 2
        //6-8	2 Brush Thylacines (pg. 609)
        //9 - 11    1 Owlbear(Bestiary 1)
        //12 - 13   6 Stag Lord Bandits (pg. 177)
        //14 - 15   3 Ruffians(GMG)
        //16 - 17   3 Wargs(Bestiary 1)
        //18 - 19   1 Troll(Bestiary 1)
        //20  1 Shambler(Bestiary 1)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "No Encounter";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "4 Mitflit Gremlins";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "2 Hunting Spiders";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "4 Stag Lord Bandits";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "2 Brush Thylacines";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "5 Kobolds";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Owlbear";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Shambler";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "2 Brush Thylacines";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Owlbear";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "6 Stag Lord Bandits";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "3 Ruffians";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "3 Wargs";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Troll";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Shambler";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnKL()
    {
        //Kamelands
        //1 - 5 Roll on Zone 3
        //6-8	6 Goblins (Bestiary 1)
        //9 - 11    1 Troll(Bestiary 1)
        //12 - 13   3 Twigjacks(Bestiary 2)
        //14 - 15   1 Blodeuwedd(Bestiary 2)
        //16 - 17   1 Will - o - wisp(Bestiary 1)
        //18 - 19   1 Wyvern(Bestiary 1)
        //20  4 Dire Wolves(Bestiary 1)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "No Encounter";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "2 Brush Thylacines";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Owlbear";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "6 Stag Lord Bandits";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "3 Ruffians";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "3 Wargs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Troll";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Shambler";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "6 Goblins";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Troll";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "3 Twigjacks";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "1 Blodeuwedd";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "1 Will-o-wisp";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Wyvern";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "4 Dire Wolves";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnNM()
    {
        //Narlmarches
        //1 - 5 Roll on Zone 4
        //6-8	1 Hydra (Bestiary 1)
        //9 - 11    3 Twigjacks(Bestiary 2)
        //12 - 13   2 Trolls(Bestiary 1)
        //14 - 15   1 Dweomercat(Bestiary 2)
        //16 - 17   4 Trollhounds(Bestiary 2)
        //18 - 19   2 Ogre Spiders(Bestiary 2)
        //20  2 Verdurous Oozes(Bestiary 2)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "No Encounter";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "6 Goblins";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Troll";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "3 Twigjacks";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "1 Blodeuwedd";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "1 Will-o-wisp";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Wyvern";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "4 Dire Wolves";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "1 Hydra";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "3 Twigjacks";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Trolls";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "1 Dweomercat";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "4 Trollhounds";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "2 Ogre Spiders";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "2 Verdurous Oozes";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnSH()
    {
        //Selen Hills
        //1-5	Roll 1d12+8 on Zone 5
        //6-8	2 Trolls (Bestiary 1)
        //9 - 11    3 Megaloceroses(pg. 608)
        //12 - 13   2 Manticores(Bestiary 1)
        //14 - 15   2 Wyverns(Bestiary 1)
        //16 - 17   6 Cultists
        //18 - 19   1 Bulette(Bestiary 1)
        //20  1 Aurumvorax(Bestiary 2)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(9, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "No Encounter";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "1 Hydra";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "3 Twigjacks";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "2 Trolls";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "1 Dweomercat";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "4 Trollhounds";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "2 Ogre Spiders";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "2 Verdurous Oozes";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "2 Trolls";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "3 Megaloceroses";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Manticores";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Wyverns";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "6 Cultists";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Bulette";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Aurumvorax";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnDW()
    {
        //Dunsward
        //1 - 5 6 Centaurs(Bestiary 1)
        //6 - 8 3 Ogre Spiders(Bestiary 2)
        //9 - 11    1 Bulette(Bestiary 1)
        //12 - 15   4 Spriggans(Bestiary 2)
        //16 - 17   4 Cyclopes(Bestiary 1)
        //18 - 19   1 Roc(Bestiary 1)
        //20  1 Peluda(Bestiary 2)
        if (rollResult < 6)
        {
            encounterResultText.text = "6 Centaurs";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "3 Ogre Spiders";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Bulette";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 16)
        {
            encounterResultText.text = "4 Spriggans";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "4 Cyclopes";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Roc";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Peluda";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnNH()
    {
        //Nomen Heights
        //1-5	Roll on Zone 7
        //6-8	6 Centaurs (Bestiary 1)
        //9 - 11    4 Cyclopes(Bestiary 1)
        //12 - 13   2 Chimeras(Bestiary 1)
        //14 - 15   1 Peluda(Bestiary 1)
        //16 - 17   4 Zombie Hulks(Bestiary 1)
        //18 - 19   4 Wyverns(Bestiary 1)
        //20  2 Mastodons(Bestiary 2)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult < 6)
            {
                encounterResultText.text = "6 Centaurs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "3 Ogre Spiders";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Bulette";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 16)
            {
                encounterResultText.text = "4 Spriggans";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "4 Cyclopes";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Roc";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Peluda";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "6 Centaurs";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "4 Cyclopes";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Chimeras";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "1 Peluda";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "4 Zombie Hulks";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "4 Wyverns";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "2 Mastodons";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnLV()
    {
        //Tors of Levenies
        //1-5	Roll on Zone 8
        //6-8	4 Zombie Hulks (Bestiary 1)
        //9 - 11    2 Chimeras(Bestiary 1)
        //12 - 13   2 Leukodaemons(Bestiary 1)
        //14 - 15   1 Meladaemon(Bestiary 2)
        //16 - 17   1 Thunderbird(Bestiary 2)
        //18 - 19   6 Wyverns(Bestiary 1)
        //20  One Great Cyclops
        if (rollResult <= 5)
        {           
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "6 Centaurs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "4 Cyclopes";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "2 Chimeras";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "1 Peluda";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "4 Zombie Hulks";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "4 Wyverns";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "2 Mastodons";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "4 Zombie Hulks";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "2 Chimeras";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Leukodaemons";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "1 Meladaemon";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "1 Thunderbird";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "6 Wyverns";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Great Cyclops";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnHT()
    {
        //Hooktongue
        //1-5	6 Bog Strider (Bestiary 2)
        //6 - 8 2 Boggard Wardens(pg. 155)
        //9 - 11    6 Will - o - wisp(Bestiary 1)
        //12 - 13   3 Nuclelavees(Bestiary 2)
        //14 - 15   4 Marsh Giants(Bestiary 2)
        //16 - 17   2 Giant Flytraps(Bestiary 1)
        //18 - 19   1 Catoplebas(Bestiary 2)
        //20  1 Froghemouth(Bestiary 2)
        if (rollResult < 6)
        {
            encounterResultText.text = "6 Bog Strider";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "2 Boggard Wardens";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "6 Will-o-wisp";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "3 Nuclelavees";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "4 Marsh Giants";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "2 Giant Flytraps";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Catoplebas";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Froghemouth";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnDR()
    {
        //Drelev
        //1 - 5 Roll on Zone 10
        //6-8	6 Hill Giants (Bestiary 1)
        //9 - 11    1 Cauthooj(Bestiary 1)
        //12 - 13   3 Giant Flytraps(Bestiary 1)
        //14 - 15   4 Aurumvoraxes(Bestiary 2)
        //16 - 17   1 Irlgaunt(Bestiary 2)
        //18 - 19   1 Viper Vine(Bestiary 2)
        //20  1 Ankou(Bestiary 2)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult < 6)
            {
                encounterResultText.text = "6 Bog Strider";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "2 Boggard Wardens";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "6 Will-o-wisp";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "3 Nuclelavees";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "4 Marsh Giants";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Giant Flytraps";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Catoplebas";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Froghemouth";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "6 Hill Giants";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Cauthooj";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "3 Giant Flytraps";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "4 Aurumvoraxes";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "1 Irlgaunt";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Viper Vine";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Ankou";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnTL()
    {
        //Tiger Lords
        //1-5	Roll on Zone 11
        //6-8	4 Aurumvoraxes (Bestiary 2)
        //9 - 11    4 Mastodons(Bestiary 2)
        //12 - 13   4 Tiger Lords(pg. 320)
        //14 - 15   1 Ankou(Bestiary 2)
        //16 - 17   2 Athachs(Bestiary 2)
        //18 - 19   1 Dopprilu(Bestiary 2)
        //20  1 Jotund Troll(Bestiary 2)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "6 Hill Giants";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Cauthooj";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "3 Giant Flytraps";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "4 Aurumvoraxes";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "1 Irlgaunt";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Viper Vine";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Ankou";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "4 Aurumvoraxes";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "4 Mastodons";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "4 Tiger Lords";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "1 Ankou";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "2 Athachs";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Dopprilu";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Jotund Troll";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnRL()
    {
        //Rushlight
        //1 - 5 Roll on Zone 12
        //6-8	6 Mastodons (Bestiary 2)
        //9 - 11    1 Ankou(Bestiary 2)
        //12 - 13   3 Cauthoojes(Bestiary 1)
        //14 - 15   2 Irlgaunts(Bestiary 2)
        //16 - 17   1 Wemmuth(Bestiary 1)
        //18 - 19   3 Pitax Wardens(pg. 336)
        //20  1 Warsworn(Bestiary 1)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "4 Aurumvoraxes";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "4 Mastodons";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "4 Tiger Lords";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "1 Ankou";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Athachs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Dopprilu";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Jotund Troll";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "6 Mastodons";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Ankou";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "3 Cauthoojes";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Irlgaunts";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "1 Wemmuth";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "3 Pitax Wardens";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Warsworn";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnGL()
    {
        //Glenebon Lowlands
        //1-5	Roll on Zone 13
        //6-8	6 Mammoths (Bestiary 1)
        //9 - 11    1 Jotund Troll(Bestiary 2)
        //12 - 13   3 Irlgaunts(Bestiary 2)
        //14 - 15   4 Athachs(Bestiary 2)
        //16 - 17   2 Ankous(Bestiary 2)
        //18 - 19   1 Warsworn(Bestiary 1)
        //20  Wild Hunt
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "6 Mastodons";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Ankou";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "3 Cauthoojes";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "2 Irlgaunts";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "1 Wemmuth";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "3 Pitax Wardens";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Warsworn";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "6 Mammoths";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Jotund Troll";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "3 Irlgaunts";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "4 Athachs";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "2 Ankous";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Warsworn";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "Wild Hunt";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnPX()
    {
        //Pitax
        //1-12	4 Pitaxs Wardens(pg. 336)
        //13 - 16   2 Ankous(Bestiary 2)
        //17 - 19   Wild Hunt
        //20	2 Warsworns (Bestiary 1)
        if (rollResult <= 12)
        {
            encounterResultText.text = "4 Pitax Wardens";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 12 && rollResult < 17)
        {
            encounterResultText.text = "2 Ankous";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 16 && rollResult < 20)
        {
            encounterResultText.text = "Wild Hunt";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "2 Warsworns";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnGU()
    {
        //Glenebon Uplands
        //1-5	Roll on Zone 14
        //6-8	3 Ankous (Bestiary 2)
        //9 - 11    2 Wemmuths(Bestiary 1)
        //12 - 13   Wild Hunt
        //14-15	6 Elite Atachs (Bestiary 2)
        //16 - 17   2 Skulltaker(Bestiary 1)
        //18 - 19   4 Hill Giant Butchers (pg. 110)
        //20  Minognos - Ushad(pg. 118)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "6 Mammoths";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Jotund Troll";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "3 Irlgaunts";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "4 Athachs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Ankous";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "1 Warsworn";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "Wild Hunt";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "3 Ankous";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "2 Wemmuths";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "Wild Hunt";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "6 Elite Atachs";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "2 Skulltaker";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "4 Hill Giant Butchers";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "Minognos-Ushad";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnNU() 
    {
        //Numeria
        //1 - 3 Roll on Zone 16
        //4-6	Mammoth Herd (Bestiary 1)
        //7 - 9 4 Hill Giant Butchers (pg. 110)
        //10 - 11   4 Ankous(Bestiary 2)
        //12 - 13   Minognos - Ushad(pg. 118)
        //14 - 15   2 Radiant Wardens(Bestiary 2)
        //16 - 17   1 Elite Adamantine Golem (Bestiary 1)
        //18 - 19   Wild Hunt
        //20	1 Elite Guthallath (Bestiary)
        if (rollResult <= 3)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "3 Ankous";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "2 Wemmuths";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "Wild Hunt";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "6 Elite Atachs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Skulltaker";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "4 Hill Giant Butchers";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "Mignos-Ushad";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 3 && rollResult < 7)
        {
            encounterResultText.text = "Mammoth Herd";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 6 && rollResult < 10)
        {
            encounterResultText.text = "4 Hill Giant Butchers";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 9 && rollResult < 12)
        {
            encounterResultText.text = "4 Ankous";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "Minognos-Ushad";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Radiant Wardens";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "1 Elite Adamantine Golem";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "Wild Hunt";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Elite Guthallath";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnTV()
    {
        //Thousand Voices
        //1-5	Roll on Zone 16
        //6-8	1 Sard (Bestiary 2)
        //9 - 11    1 Bandersnatch(pg. 610)
        //12 - 13   6 Elite Ankous(Bestiary 2)
        //14 - 15   3 Whimwyrms(pg. 615)
        //16 - 17   Wild Hunt
        //18-19	Lantern King Emissary
        //20	1 Mu Spore (Bestiary 1)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "3 Ankous";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "2 Wemmuths";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "Wild Hunt";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "6 Elite Atachs";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Skulltaker";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "4 Hill Giant Butchers";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "Minognos-Ushad";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "1 Sard";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Bandersnatch";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "6 Elite Ankous";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "3 Whimwyrms";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "Wild Hunt";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "Lantern King Emissary";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1  Mu Spore";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnBM()
    {
        //BranthlendMountains
        //1 - 5 Roll on Zone 18
        //6-8	2 Skulltakers (Bestiary 1)
        //9 - 11    Wild Hunt
        //12-13	2 Bandersnatches (pg. 610)
        //14 - 15   1 Tor Linnorm(Bestiary 1)
        //16 - 17   Ilthuliak(pg. 454)
        //18 - 19   4 Whimwyrms(pg. 615)
        //20  1 Elite Lerritan(Bestiary 2)
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "1 Sard";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Bandersnatch";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "6 Elite Ankous";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "3 Whimwyrms";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "Wild Hunt";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "Lantern King Emissary";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1  Mu Spore";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "2 Skulltakers";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "Wild Hunt";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Bandersnatches";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "1 Tor Linnorm";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "Ilthuliak";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "4 Whimwyrms";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Elite Lerritan";
            encounterResultText.gameObject.SetActive(true);
        }
    }

    public void ShowResultText()
    {
        noResultText = !noResultText;
    }
    private void HideResultText()
    {
        rollResultText.gameObject.SetActive(false);
        encounterResultText.gameObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Disable player movement when the button is clicked
        player.GetComponent<MoveParty>().StopMovement();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Enable player movement when the button is released
        player.GetComponent<MoveParty>().StartMovement();

        // Call the Roll method
        RollD20();
    }
}







