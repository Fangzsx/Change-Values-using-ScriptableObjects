using UnityEngine;

//create new asset menu
[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{

    //create a string variable 
    [TextArea(10,14)][SerializeField]string storyText;

    public string GetStoryText() {
        return storyText;
    }

    
}
