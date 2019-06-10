using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private NumberPicker numberPicker;
    private Narrator narrator;

    // Start is called before the first frame update
    void Start()
    {
        numberPicker = new NumberPicker(0, 1000);
        narrator = new Narrator("John", numberPicker);

        narrator.greet();
        narrator.currentState();
        narrator.suggest();
    }

    public void onBiggerClick ()
    {
        narrator.highter();
        narrator.currentState();
        narrator.suggest();
    }

    public void onLowerClick()
    {
        narrator.lower();
        narrator.currentState();
        narrator.suggest();
    }

    public void onCorrectClick()
    {
        narrator.correct();
        numberPicker = new NumberPicker(0, 1000);
        narrator = new Narrator("... ah, you again!", numberPicker);
        narrator.greet();
    }
}
