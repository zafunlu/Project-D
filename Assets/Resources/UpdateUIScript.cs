using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUIScript : MonoBehaviour
{
    public GameObject sTile;
    public Button rotateButton;
    public Button removeButton;
    public Text TextField;

    // Start is called before the first frame update
    void Start()
    {
        sTile = null;
        Button btnRo = rotateButton.GetComponent<Button>();
        btnRo.onClick.AddListener(Rotate);
        Button btnRe = removeButton.GetComponent<Button>();
        btnRe.onClick.AddListener(Remove);
    }

    // Update is called once per frame
    void Update()
    {
        if (sTile != null)
        {
            var tm = TextField;//.GetComponent<Text>();//sTile.transform.GetChild(2)
            tm.text = "TEXTSTRING!";//"x:" + xx.ToString() + "\nz:" + zz.ToString();
        }
        else
        {
            var tm = TextField;//.GetComponent<Text>();
            tm.text = "NONESELECTED!";
        }
    }

    void Rotate()
    {
        var td = sTile.GetComponent<touchdetection>();
        td.rotateLeft();
    }

    void Remove()
    {
        var td = sTile.GetComponent<touchdetection>();
        td.deleteTile();
    }
}
