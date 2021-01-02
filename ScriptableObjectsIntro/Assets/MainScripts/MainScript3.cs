using UnityEngine.UI;
using UnityEngine;

public class MainScript3 : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State3 startingState3;
    State3 state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState3;
        textComponent.text = state.GetStoryText3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
