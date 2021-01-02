using UnityEngine;
using UnityEngine.UI;

public class MainScript2 : MonoBehaviour

{
    [SerializeField] Text textComponent;
    [SerializeField] State2 startingState2;
    State2 state2;
    // Start is called before the first frame update
    void Start()
    {
        state2 = startingState2;
        textComponent.text = state2.GetStoryText2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
