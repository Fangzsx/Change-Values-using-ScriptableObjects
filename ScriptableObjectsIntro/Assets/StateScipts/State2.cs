using UnityEngine;

[CreateAssetMenu(menuName = "State2")]
public class State2 : ScriptableObject
{
    public string storyText2;

    public string GetStoryText2(){
        return storyText2;
    }
}
