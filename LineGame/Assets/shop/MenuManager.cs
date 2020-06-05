using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    

    public static MenuManager _instance;
    public static MenuManager Instance { 
        get
    {
            if (_instance==null)
            {
                GameObject _MenuManager = new GameObject();
                _MenuManager.AddComponent<MenuManager>();

            }
            return _instance;
    }
}

    public List<ShopItem> shopItems;

    public GameObject Prefab;
    public Transform content;

    public Text ScoreText;
    public int coincount;


    public string[] keywords = new string[] { "shop", "setting", "timer", "speed","endless","rainbow","return" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public float speed = 1;

  

    protected PhraseRecognizer recognizer;
    protected string word = "return";

    public GameObject ShopPanel;
    public GameObject settingPanel;
    



    public delegate void ItemUseIt(ShopItem shopItem);
    public event ItemUseIt itemusit;
    private void Awake()
    {
        _instance = this;
        InitAllItems();

    }
    private void Start()
    {
        ScoreText.text = coincount.ToString();
        CreateShop();

        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
            Debug.Log(recognizer.IsRunning);
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        switch (word)
        {
            case "shop":
                ShopPanel.SetActive(true);
                settingPanel.SetActive(false);
                break;
            case "setting":
                settingPanel.SetActive(true);
                ShopPanel.SetActive(false);
                break;
            case "return":
                settingPanel.SetActive(false);
                ShopPanel.SetActive(false);
                break;
            case "endless":
                SceneManager.LoadScene(1);
                break;
            case "speed":
                SceneManager.LoadScene(4);
                break;
            case "timer":
                SceneManager.LoadScene(3);
                break;
            case "rainbow":
                SceneManager.LoadScene(2);
                break;
            default:
                break;
        }
        
        
    }
    void InitAllItems()
    {
        foreach (var item in shopItems)
        {
            item.initItem();
        }
    }
    void CreateShop()
    {
        StartCoroutine(createShop());
    }
   
    public void UseCoin(int c)
    {
        //coincount -= c;
        //ScoreText.text = coincount.ToString();
        StartCoroutine(CoinAnimation(c));
    }

    IEnumerator CoinAnimation(int c)
    {
        for (int i = 0; i < c/10; i++)
        {
            yield return new WaitForSeconds(0.02f);
            coincount -= 10;
            ScoreText.text = coincount.ToString();
        }
        

    }

    IEnumerator createShop()
    {
        foreach (var item in shopItems)
        {
            yield return new WaitForSeconds(0.2f);
            GameObject model = Instantiate(Prefab, content);
            model.GetComponent<Model>().SetItem(item);

        }
     
    }
    public void ItemUseitChange(ShopItem _shopitem)
    {
        if (itemusit!=null)
        {
            itemusit(_shopitem);
        }
    }
}
