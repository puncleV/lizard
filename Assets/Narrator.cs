using UnityEngine;
using UnityEditor;

public class Narrator
{
    private string _name;
    private NumberPicker _numberPicker;

    public Narrator(string name, NumberPicker numberPicker)
    {
        _name = name;
        _numberPicker = numberPicker;
    }

    public void greet ()
    {
        Debug.Log(string.Concat("Welcome to Number Wizard Inc. ", this._name));
    }

    public void currentState ()
    {
        Debug.Log(string.Concat("Minimum:", _numberPicker.getMin()));
        Debug.Log(string.Concat("Maximum:", _numberPicker.getMax()));
    }

    public void suggest ()
    {
        Debug.Log(string.Concat("Is it right:", _numberPicker.suggest(), "?"));
    }

    public void correct()
    {
        Debug.Log("EZ PZ LEMON SQUEEZE!");
    }

    public void lower()
    {
        this.beforeChooseMessage();
        _numberPicker.lower();
    }
    public void highter()
    {
        this.beforeChooseMessage();
        _numberPicker.highter();
    }
    private void beforeChooseMessage()
    {
        Debug.Log("Hm, let me think a bit more...");
    }
}