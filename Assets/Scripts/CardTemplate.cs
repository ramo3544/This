using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(StatEmulation))]
public class CardTemplate : MonoBehaviour
{
    //private static StatEmulation statEmulations;
    

    public string unitFaction;
    public string unitName;
    public string unitText;

    //Attributes for Card Template

    //Coordinates for Movement
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] int z;

    [SerializeField] float power;
    [SerializeField] float armor;
    [SerializeField] float energy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
