using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUIScript : MonoBehaviour
{
    public GameObject sTile;
    public Button rotateLButton;
    public Button rotateRButton;
    public Button changeObjectButton;
    public Button objectButton;
    public Text changeObjectTextField;
    public Text objectTextField;
    public GameObject[] models;
    public GameObject modelSelected;
    public Material defMat;
    public Material selMat;

    // Start is called before the first frame update
    void Start()
    {
        sTile = null;
        Button btnRo = rotateLButton.GetComponent<Button>();
        btnRo.onClick.AddListener(RotateL);

        Button btnRe = changeObjectButton.GetComponent<Button>();
        btnRe.onClick.AddListener(Change);

        Button btnSel = objectButton.GetComponent<Button>();
        btnSel.onClick.AddListener(selectObject);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (sTile != null)
        {
            var tm = TextField;//.GetComponent<Text>();//sTile.transform.GetChild(2)
            tm.text = "TEXTSTRING!";//"x:" + xx.ToString() + "\nz:" + zz.ToString();
        }
        else
        {
            var tm = TextField;//.GetComponent<Text>();
            tm.text = "NONESELECTED!";
        }*/
    }

    void RotateL()
    {
        var td = sTile.GetComponent<touchdetection>();
        td.rotateLeft();
    }

    void Change()
    {
        var td = sTile.GetComponent<touchdetection>();
        if (td.spawnedO == null)
        {
            td.spawnedO = Instantiate(models[1], td.spawnPos.position, td.spawnPos.rotation);
            changeObjectTextField.text = "Verwijder";
        }
        else
        {
            td.deleteTile();
        }

        //var td = sTile.GetComponent<touchdetection>();
        //td.deleteTile();

        updateChangeObjectText();
    }

    void selectObject()
    {
        objectTextField.text = "Object: \ntest";
    }

    public void updateSelectedTile(GameObject newTile)
    {
        if (sTile != null)
        {
            var R = sTile.GetComponent<Renderer>();
            R.material = defMat;
        }
        sTile = newTile;
        var renderer = sTile.GetComponent<Renderer>();
        renderer.material = selMat;

        updateChangeObjectText();
    }

    private void updateChangeObjectText()
    {
        if (sTile.GetComponent<touchdetection>().spawnedO == null)
        {
            changeObjectTextField.text = "Verwijder";
        }
        else
        {
            changeObjectTextField.text = "Plaats";
        }
    }
}
