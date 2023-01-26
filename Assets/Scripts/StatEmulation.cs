using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class StatEmulation : MonoBehaviour
{
    private GameObject _stats;

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
