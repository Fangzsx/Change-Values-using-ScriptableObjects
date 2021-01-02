using UnityEngine;

[CreateAssetMenu(menuName = "State3")]
public class State3 : ScriptableObject
{
    public string storyText3;

    public string GetStoryText3(){
        return storyText3;
    }
}
