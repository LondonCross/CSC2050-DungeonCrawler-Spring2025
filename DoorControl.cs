using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject[] theDoors;   
    private Dungeon theDungeon;


    void Start()
    {
        CoreSingleton.thePlayer = new Player("Mike");
        this.theDungeon = new Dungeon();

        this.theDoors[0].SetActive(CoreSingleton.northDoor);
        this.theDoors[1].SetActive(CoreSingleton.southDoor);
        this.theDoors[2].SetActive(CoreSingleton.eastDoor);
        this.theDoors[3].SetActive(CoreSingleton.westDoor);
        //MeshRenderer mr = this.theDoors[0].GetComponent<MeshRenderer>();
        //mr.enabled = false;
    }

    void Update()
    {
        
    }
}
