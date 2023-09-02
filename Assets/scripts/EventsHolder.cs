using UnityEngine;

public static class EventsHolder
{
    public delegate void DELEGATE_INPUTS(Vector2 _args);

    public static DELEGATE_INPUTS ON_INPUTS;
}
