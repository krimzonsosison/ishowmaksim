using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    public Transform Igrok;
    private bool hasClicked = false;

    public void IncreaseSize()
    {
        if (!hasClicked)
        {
            Igrok.localScale *= 1.5f;
            hasClicked = true;
        }
    }
}