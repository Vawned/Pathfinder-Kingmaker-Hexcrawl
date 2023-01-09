using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPositionCheck : MonoBehaviour
{
    public GameObject[] locations;
    public bool isOnRH;
    public bool isOnGB;
    public bool isOnTW;
    public bool isOnKL;
    public bool isOnNM;
    public bool isOnSH;
    public bool isOnDW;
    public bool isOnNH;
    public bool isOnLV;
    public bool isOnHT;
    public bool isOnDR;
    public bool isOnTL;
    public bool isOnRL;
    public bool isOnGL;
    public bool isOnPX;
    public bool isOnGU;
    public bool isOnNU;
    public bool isOnTV;
    public bool isOnBM;

    private RostlandHinterlands rhScript;
    private Greenbelt gbScript;
    private Tuskwater twScript;
    private Kamelands klScript;
    private Narlmarches nmScript;
    private SelenHills shScript;
    private Dunsward dwScript;
    private NomenHeights nhScript;
    private TorsOfLevenies lvScript;
    private Hooktongue htScript;
    private Drelev drScript;
    private TigerLords tlScript;
    private Rushlight rlScript;
    private GlenebonLowlands glScript;
    private Pitax pxScript;
    private GlenebonUplands guScript;
    private Numeria nuScript;
    private ThousandVoices tvScript;
    private BranthlendMountains bmScript;



    // Start is called before the first frame update
    void Start()
    {
        // Declare the variables outside the function to make them accessible in the Update function
        rhScript = locations[0].GetComponent<RostlandHinterlands>();
        gbScript = locations[1].GetComponent<Greenbelt>();
        twScript = locations[2].GetComponent<Tuskwater>();
        klScript = locations[3].GetComponent<Kamelands>();
        nmScript = locations[4].GetComponent<Narlmarches>();
        shScript = locations[5].GetComponent<SelenHills>();
        dwScript = locations[6].GetComponent<Dunsward>();
        nhScript = locations[7].GetComponent<NomenHeights>();
        lvScript = locations[8].GetComponent<TorsOfLevenies>();
        htScript = locations[9].GetComponent<Hooktongue>();
        drScript = locations[10].GetComponent<Drelev>();
        tlScript = locations[11].GetComponent<TigerLords>();
        rlScript = locations[12].GetComponent<Rushlight>();
        glScript = locations[13].GetComponent<GlenebonLowlands>();
        pxScript = locations[14].GetComponent<Pitax>();
        guScript = locations[15].GetComponent<GlenebonUplands>();
        nuScript = locations[16].GetComponent<Numeria>();
        tvScript = locations[17].GetComponent<ThousandVoices>();
        bmScript = locations[18].GetComponent<BranthlendMountains>();
    }

    // Update is called once per frame
    void Update()
    {
        isOnRH = false;
        if (rhScript.onRH)
        {
            // The onRH boolean is true
            isOnRH = true;
        }

        isOnGB = false;
        if (gbScript.onGB)
        {
            // The onDR boolean is true
            isOnGB = true;
        }

        isOnTW = false;
        if (twScript.onTW)
        {
            // The onRH boolean is true
            isOnTW = true;
        }

        isOnKL = false;
        if (klScript.onKL)
        {
            // The onRH boolean is true
            isOnKL = true;
        }
        
        isOnNM = false;
        if (nmScript.onNM)
        {
            // The onRH boolean is true
            isOnNM = true;
        }

        isOnSH = false;
        if (shScript.onSH)
        {
            // The onRH boolean is true
            isOnSH = true;
        }

        isOnDW = false;
        if (dwScript.onDW)
        {
            // The onRH boolean is true
            isOnDW = true;
        }

        isOnNH = false;
        if (nhScript.onNH)
        {
            // The onRH boolean is true
            isOnNH = true;
        }

        isOnLV = false;
        if (lvScript.onLV)
        {
            // The onRH boolean is true
            isOnLV = true;
        }

        isOnHT = false;
        if (htScript.onHT)
        {
            // The onRH boolean is true
            isOnHT = true;
        }

        isOnDR = false;
        if (drScript.onDR)
        {
            // The onRH boolean is true
            isOnDR = true;
        }

        isOnTL = false;
        if (tlScript.onTL)
        {
            // The onRH boolean is true
            isOnTL = true;
        }

        isOnRL = false;
        if (rlScript.onRL)
        {
            // The onRH boolean is true
            isOnRL = true;
        }

        isOnGL = false;
        if (glScript.onGL)
        {
            // The onRH boolean is true
            isOnGL = true;
        }

        isOnPX = false;
        if (pxScript.onPX)
        {
            // The onRH boolean is true
            isOnPX = true;
        }

        isOnGU = false;
        if (guScript.onGU)
        {
            // The onRH boolean is true
            isOnGU = true;
        }

        isOnNU = false;
        if (nuScript.onNU)
        {
            // The onRH boolean is true
            isOnNU = true;
        }

        isOnTV = false;
        if (tvScript.onTV)
        {
            // The onRH boolean is true
            isOnTV = true;
        }

        isOnBM = false;
        if (bmScript.onBM)
        {
            // The onRH boolean is true
            isOnBM = true;
        }


    }
}
