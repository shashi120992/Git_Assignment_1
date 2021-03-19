public class script1 : MonoBehaviour

{
    public Button button;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        button.onclick.AddListener(OnButtonClick);

    }

    private void OnButonClick()
    {
        ScreneManager.LoadScene(scene);

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
