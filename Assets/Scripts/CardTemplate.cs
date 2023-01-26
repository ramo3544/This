using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(StatEmulation))]
public class CardTemplate : MonoBehaviour
{
    //private static StatEmulation statEmulations;
    

    public string cardFaction;
    public string cardName;
    public string cardText;

    //Attributes for Card Template

    [SerializeField] float speed;
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
