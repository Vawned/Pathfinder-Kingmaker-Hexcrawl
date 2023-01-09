using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThreatCheck : MonoBehaviour
{
    public D20Roller rollerScript;
    public ParentPositionCheck positionCheck;
    public int displayTime;

    public TextMeshProUGUI encounterResultText; // reference to the text object that will display the encounter result

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rollerScript.rollResult <= 5)
        {
            Debug.Log("Rolled 5 or less");
            if (positionCheck.isOnRH)
            {
                encounterResultText.text = "3 Bandits";
            }
        }

        
    }

    public void EncounterText()
    {
        if (positionCheck.isOnRH)
        {
            if (rollerScript.rollResult <= 5)
            { 
                encounterResultText.text = "3 Bandits";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        
        
        Invoke("HideResultText", displayTime);

    }

    private void HideResultText()
    {
        encounterResultText.gameObject.SetActive(false);
    }
}


//Rostland Hinterlands(RL)
//1 - 5 3 Bandits(use stats for Thorn River bandits on pg. 170)
//    6 - 8 2 Brush Thylacines(pg. 609)
//9 - 11    1 Hunter(Use stats for poacher, GMG)
//    12 - 13   2 Elk(pg. 608)
//14 - 15   2 Wolves(Bestiary 1)
//16 - 17   2 Boars(Bestiary 1)
//18 - 19   3 Thylanices(pg. 609)
//20  1 Grizzly Bear(Bestiary 1)

//Greenbelt

//1 - 5 Roll on Zone 1
//6-8	4 Mitflit Gremilins (Bestiary 1)
//9 - 11    2 Hunting Spiders(Bestiary 1)
//12 - 13   4 Stag Lord Bandits (pg. 177)
//14 - 15   2 Brush Thylacines(pg. 609)
//16 - 17   5 Kobolds(Bestiary 1)
//18 - 19   1 Owlbear(Bestiary 1)
//20  3 Ruffians(GMG)

//Tuskwater
//1 - 5 Roll on Zone 2
//6-8	2 Brush Thylacines (pg. 609)
//9 - 11    1 Owlbear(Bestiary 1)
//12 - 13   6 Stag Lord Bandits (pg. 177)
//14 - 15   3 Ruffians(GMG)
//16 - 17   3 Wargs(Bestiary 1)
//18 - 19   1 Troll(Bestiary 1)
//20  1 Shambler(Bestiary 1)

//Kamelands
//1 - 5 Roll on Zone 3
//6-8	6 Goblins (Bestiary 1)
//9 - 11    1 Troll(Bestiary 1)
//12 - 13   3 Twigjacks(Bestiary 2)
//14 - 15   1 Blodeuwedd(Bestiary 2)
//16 - 17   1 Will - o - wisp(Bestiary 1)
//18 - 19   1 Wyvern(Bestiary 1)
//20  4 Dire Wolves(Bestiary 1)

//Narlmarches
//1 - 5 Roll on Zone 4
//6-8	1 Hydra (Bestiary 1)
//9 - 11    3 Twigjacks(Bestiary 2)
//12 - 13   2 Trolls(Bestiary 1)
//14 - 15   1 Dweomercat(Bestiary 2)
//16 - 17   4 Trollhounds(Bestiary 2)
//18 - 19   2 Ogre Spiders(Bestiary 2)
//20  2 Verdurous Oozes(Bestiary 2)

//Selen Hills
//1-5	Roll 1d12+8 on Zone 5
//6-8	2 Trolls (Bestiary 1)
//9 - 11    3 Megaloceroses(pg. 608)
//12 - 13   2 Manticores(Bestiary 1)
//14 - 15   2 Wyverns(Bestiary 1)
//16 - 17   6 Cultists
//18 - 19   1 Bulette(Bestiary 1)
//20  1 Aurumvorax(Bestiary 2)

//Dunsward
//1 - 5 6 Centaurs(Bestiary 1)
//6 - 8 3 Ogre Spiders(Bestiary 2)
//9 - 11    1 Bulette(Bestiary 1)
//12 - 15   4 Spriggans(Bestiary 2)
//16 - 17   4 Cyclopes(Bestiary 1)
//18 - 19   1 Roc(Bestiary 1)
//20  1 Peluda(Bestiary 2)

//Nomen Heights
//1-5	Roll on Zone 7
//6-8	6 Centaurs (Bestiary 1)
//9 - 11    4 Cyclopes(Bestiary 1)
//12 - 13   2 Chimeras(Bestiary 1)
//14 - 15   1 Peluda(Bestiary 1)
//16 - 17   4 Zombie Hulks(Bestiary 1)
//18 - 19   4 Wyverns(Bestiary 1)
//20  2 Mastodons(Bestiary 2)

//Tors of Levenies
//1-5	Roll on Zone 8
//6-8	4 Zombie Hulks (Bestiary 1)
//9 - 11    2 Chimeras(Bestiary 1)
//12 - 13   2 Leukodaemons(Bestiary 1)
//14 - 15   1 Meladaemon(Bestiary 2)
//16 - 17   1 Thunderbird(Bestiary 2)
//18 - 19   6 Wyverns(Bestiary 1)
//20  One Great Cyclops

//Hooktongue
//1-5	6 Bog Strider (Bestiary 2)
//6 - 8 2 Boggard Wardens(pg. 155)
//9 - 11    6 Will - o - wisp(Bestiary 1)
//12 - 13   3 Nuclelavees(Bestiary 2)
//14 - 15   4 Marsh Giants(Bestiary 2)
//16 - 17   2 Giant Flytraps(Bestiary 1)
//18 - 19   1 Catoplebas(Bestiary 2)
//20  1 Froghemouth(Bestiary 2)

//Drelev
//1 - 5 Roll on Zone 10
//6-8	6 Hill Giants (Bestiary 1)
//9 - 11    1 Cauthooj(Bestiary 1)
//12 - 13   3 Giant Flytraps(Bestiary 1)
//14 - 15   4 Aurumvoraxes(Bestiary 2)
//16 - 17   1 Irlgaunt(Bestiary 2)
//18 - 19   1 Viper Vine(Bestiary 2)
//20  1 Ankou(Bestiary 2)

//Tiger Lords
//1-5	Roll on Zone 11
//6-8	4 Aurumvoraxes (Bestiary 2)
//9 - 11    4 Mastodons(Bestiary 2)
//12 - 13   4 Tiger Lords(pg. 320)
//14 - 15   1 Ankou(Bestiary 2)
//16 - 17   2 Athachs(Bestiary 2)
//18 - 19   1 Dopprilu(Bestiary 2)
//20  1 Jotund Troll(Bestiary 2)

//Rushlight
//1 - 5 Roll on Zone 12
//6-8	6 Mastodons (Bestiary 2)
//9 - 11    1 Ankou(Bestiary 2)
//12 - 13   3 Cauthoojes(Bestiary 1)
//14 - 15   2 Irlgaunts(Bestiary 2)
//16 - 17   1 Wemmuth(Bestiary 1)
//18 - 19   3 Pitax Wardens(pg. 336)
//20  1 Warsworn(Bestiary 1)

//Glenebon Lowlands
//1-5	Roll on Zone 13
//6-8	6 Mammoths (Bestiary 1)
//9 - 11    1 Jotund Troll(Bestiary 2)
//12 - 13   3 Irlgaunts(Bestiary 2)
//14 - 15   4 Athachs(Bestiary 2)
//16 - 17   2 Ankous(Bestiary 2)
//18 - 19   1 Warsworn(Bestiary 1)
//20  Wild Hunt

//Pitax
//1-12	4 Pitaxs Wardens(pg. 336)
//13 - 16   2 Ankous(Bestiary 2)
//17 - 19   Wild Hunt
//20	2 Warsworns (Bestiary 1)

//Glenebon Uplands
//1-5	Roll on Zone 14
//6-8	3 Ankous (Bestiary 2)
//9 - 11    2 Wemmuths(Bestiary 1)
//12 - 13   Wild Hunt
//14-15	6 Elite Atachs (Bestiary 2)
//16 - 17   2 Skulltaker(Bestiary 1)
//18 - 19   4 Hill Giant Butchers (pg. 110)
//20  Minognos - Ushad(pg. 118)

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

//Thousand Voices
//1-5	Roll on Zone 16
//6-8	1 Sard (Bestiary 2)
//9 - 11    1 Bandersnatch(pg. 610)
//12 - 13   6 Elite Ankous(Bestiary 2)
//14 - 15   3 Whimwyrms(pg. 615)
//16 - 17   Wild Hunt
//18-19	Lantern King Emissary
//20	1 Mu Spore (Bestiary 1)

//BranthlendMountains
//1 - 5 Roll on Zone 18
//6-8	2 Skulltakers (Bestiary 1)
//9 - 11    Wild Hunt
//12-13	2 Bandersnatches (pg. 610)
//14 - 15   1 Tor Linnorm(Bestiary 1)
//16 - 17   Ilthuliak(pg. 454)
//18 - 19   4 Whimwyrms(pg. 615)
//20  1 Elite Lerritan(Bestiary 2)