using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    private NumberPicker numberPicker;
    [SerializeField] Text currentSuggestion;
    [SerializeField] SceneLoader sceneLoader;
    // Start is called before the first frame update
    void initialize()
    {
        numberPicker = new NumberPicker(0, 228);
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
        string newSuggestion = numberPicker.suggest().ToString();

        if(newSuggestion.Equals(currentSuggestion.text))
        {
            sceneLoader.failScreen();
        }

        currentSuggestion.text = newSuggestion;
    }
}
