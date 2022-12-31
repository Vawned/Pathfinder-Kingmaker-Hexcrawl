using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadIcon : MonoBehaviour
{
    public GameObject[] iconsPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;

    // Start is called before the first frame update
    void Start()
    {
        int selectedIcon = PlayerPrefs.GetInt("selectedIcon");
        GameObject prefab = iconsPrefabs[selectedIcon];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        label.text = prefab.name;
    }

}
