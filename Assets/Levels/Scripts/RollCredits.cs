/// <summary>
/// Roll credits.
/// By Corey Blackburn
/// 3/2/2014
/// Lists the participants by section scrolling upward.
/// </summary>

using UnityEngine;
using System.Collections;

public class RollCredits : MonoBehaviour
{
	
	bool isRolling = false;
	public float rollSpeed;
	public float end;
	
	// Use this for initialization
	void Start ()
	{
		guiText.text =
			section ("Artists") +
				participant ("Rebecca Mroczkowski", "http://www.behance.net/rlmroczkowski") +
				section ("Audio") +
				participant ("Evan Witt", "http://www.fiverbeyond.com/") +
				section ("Programmers") + 
				participant ("Corey Blackburn", "http://www.coreyblackburn.com/") +
				participant ("Maria Mckinley", "http://mariakathryn.net/") +
				participant ("Kerey Roper", "http://www.rivetinggames.com/") +
				section ("REACTOR & HouseOgames") +
				section("Present: HOGjam #4");
		
		isRolling = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isRolling) return;
		
		transform.Translate (Vector3.up * Time.deltaTime * rollSpeed);
		
		if (transform.position.y > end)
		{
			isRolling = false;
			Application.LoadLevel ("main_menu");
		}
	}
	
	string section(string title)
	{
		return "\n" + title + "\n\n";
	}

	string participant(string name, string portfolio)
	{
		if (portfolio != "") return name + "\n" + portfolio + "\n\n";
		else return name + "\n\n";
	}
}
