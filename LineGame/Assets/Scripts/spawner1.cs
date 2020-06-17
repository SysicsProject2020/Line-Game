using UnityEngine;
using UnityEngine.Windows.Speech;
public class spawner1 : MonoBehaviour
{
    public GameObject Splash1;
    public GameObject spawner;
    public float direction;
    public Sprite yadhreb;
    public Sprite rest;


    public string[] keywords;
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    protected PhraseRecognizer recognizer;
    public string word = "";

    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
            Debug.Log(recognizer.IsRunning);
        }

        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
    }
    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        if (word == keywords[0]||keywords[0].Contains(word)||word.Contains(keywords[0]))
        {
            SpawnerSplash();
            AudioManager.playSound("shoot");
            word = "";
        }
       // results.text = "You said: <b>" + word + "</b>";
    }

    



    void SpawnerSplash()
    {
      GameObject splach=  Instantiate(Splash1, transform.position, transform.rotation);
        splach.GetComponent<SplashLeft>().direction = direction;
        
    }


    private void OnMouseUp()
    {
        SpawnerSplash();
        AudioManager.playSound("shoot");

        spawner.gameObject.GetComponent<SpriteRenderer>().sprite = rest;
        

    }
    private void OnMouseDown()
    {
        spawner.gameObject.GetComponent<SpriteRenderer>().sprite = yadhreb ;

    }

}
