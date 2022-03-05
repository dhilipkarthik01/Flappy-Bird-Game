using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManagerScript : MonoBehaviour
{
    public Text ValueTxt;
    // Start is called before the first frame update
    void Start()
    {
        ValueTxt.text = PersistenceManagerScript.Instance.Value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToScene1(){
        SceneManager.LoadScene("SampleScene1");
        PersistenceManagerScript.Instance.Value++;
    }

    public void GoToScene2(){
        SceneManager.LoadScene("SampleScene2");
        PersistenceManagerScript.Instance.Value++;
    }

}
