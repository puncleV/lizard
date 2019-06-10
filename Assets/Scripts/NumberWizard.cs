using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    private NumberPicker numberPicker;
    [SerializeField] Text currentSuggestion;
    // Start is called before the first frame update
    void initialize()
    {
        numberPicker = new NumberPicker(0, 1000);
    }

    void Start()
    {
        this.initialize();
        this.updateSuggestField();
    }

    public void onBiggerClick ()
    {
        numberPicker.highter();
        this.updateSuggestField();
    }

    public void onLowerClick()
    {
        numberPicker.lower();
        this.updateSuggestField();
    }

    public void updateSuggestField()
    {
        currentSuggestion.text = numberPicker.suggest().ToString();
    }
}
