using UnityEngine.UI;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] Text TextComponent;
    [SerializeField] State startingState;
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        TextComponent.text = state.GetStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
