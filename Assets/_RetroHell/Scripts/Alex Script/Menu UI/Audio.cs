using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] GameObject sound;
    //Create an enum state for it's on  and off and  call a State as a state
    enum State { On, Off };
    State state;

    public void Music()
    {  //if the state  is On, deactivate the audio, then change the state to Off
        if (state == State.On)
        {
            sound.SetActive(false);
            state = State.Off;
        }
        //if the state  is Off, activate the audio, then change the state to ON
        else if (state == State.Off)
        {
            sound.SetActive(true);
            state = State.On;
        }

    }
}
