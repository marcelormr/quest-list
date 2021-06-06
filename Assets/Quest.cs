public class Quest
{
    public string name = "Quest Name";
    public string difficulty = "Quest Difficulty";
    public List<Quest> questRequirements = new List<Quest>();
    public OtherRequirements otherRequirements = new OtherRequirements();
    public List<Quest> subquests = new List<Quest>();
    public byte questPointsReward = 0;
    public bool isMiniquest = false;
    public bool isSubquest = false;
    public Quest superQuest = null;
    //Constructor
    public Quest(string name, string difficulty, List<Quest> questRequirements = null, OtherRequirements otherRequirements = null, List<Quest> subquests = null, byte questPointsReward = 0, bool isMiniquest = false, bool isSubquest = false, Quest superQuest = null)
    {
        this.name = name;
        this.difficulty = difficulty;
        this.questRequirements = questRequirements;
        this.otherRequirements = otherRequirements;
        this.subquests = subquests;
        this.questPointsReward = questPointsReward;
        this.isMiniquest = isMiniquest;
        this.isSubquest = isSubquest;
        this.superQuest = superQuest;

    }
}