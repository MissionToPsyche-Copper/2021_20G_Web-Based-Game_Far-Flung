using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionParent : MonoBehaviour, Completion
{
    public bool IsCompleted()
    {

        if (GetComponentInChildren<Completion>() == null)
        {
            Debug.Log("No Completion found");
        }
        foreach (Completion completion in GetComponentsInChildren<Completion>())
        {
            if ((object)completion == this) continue;

            if (!completion.IsCompleted()) return false;
        }
        OnCompletion();
        return true;
    }

    public void OnCompletion()
    {
        SceneManager.LoadScene("Hub");
    }

}


/* COMMON MERGE - DELETE FILE */