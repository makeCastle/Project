using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class MassScript : MonoBehaviour {
    private string Mass;
    private int SC;
    private int MassResult;
    private double Result;
    private double ROPA;
    private string Result2;
    // Use this for initialization
    void Start () {
		
	}
	public void SexM()
    {
        SC = 1;
    }
    public void SexF()
    {
        SC = 2;
    }
    public void One()
    {
        Mass = Mass+"1";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
      
    }
    public void Two()
    {
        Mass = Mass+"2";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void Three()
    {
        Mass = Mass + "3";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void Four()
    {
        Mass = Mass + "4";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
	public void Five()
	{
		Mass = Mass + "5";
		GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
	}
	public void Six()
	{
		Mass = Mass + "6";
		GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
	}
    public void Seven()
    {
        Mass = Mass + "7";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void Eight()
    {
        Mass = Mass + "8";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void Nine()
    {
        Mass = Mass + "9";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void Zero()
    {
        Mass = Mass + "0";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void Input()
    {
        MassResult = int.Parse(Mass);
    }
    public void Clear()
    {
        Mass = " ";
        GameObject.Find("InputField").GetComponent<InputField>().text = Mass;
    }
    public void ROPAOne()
    {
        if (GetComponent<Dropdown>().value == 0)
        {
            ROPA = 1;
        } else if (GetComponent<Dropdown>().value == 1) {
            ROPA = 1.3;
        }
        else if (GetComponent<Dropdown>().value == 2)
        {
            ROPA = 1.5;
        }
    }
    public void AgeOne()
    {
        if ((GetComponent<Dropdown>().value == 0) && (SC == 2)) //there are women 18-30
        {
            Result = (0.062 * MassResult + 2.036) * 240 * ROPA;
        }
        else if ((GetComponent<Dropdown>().value == 1) && (SC == 2)) //there are women 30-60
        {
            Result = (0.034 * MassResult + 3.538) * 240 * ROPA;
        }
        else if ((GetComponent<Dropdown>().value == 2) && (SC == 2)) //there are women >60
        {
            Result = (0.0382 * MassResult + 2.7556) * 240 * ROPA;
        }
        else if ((GetComponent<Dropdown>().value == 1) && (SC == 1)) //there are men 18-30
        {
            Result = (0.063 * MassResult + 2.896) * 240 * ROPA;
        }
        else if ((GetComponent<Dropdown>().value == 2) && (SC == 1)) //there are men 30-60
        {
            Result = (0.484 * MassResult + 3.653) * 240 * ROPA;
        }
        else if ((GetComponent<Dropdown>().value == 2) && (SC == 1)) //there are men >60
        {
            Result = (0.491 * MassResult + 2.459) * 240 * ROPA;
        }
    }
   public void Finish()
    {
        Result2 = Result.ToString();
        GameObject.Find("Result").GetComponent<Text>().text = Result2;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
