public class Skill
{
    string name = "Skill Name";
    byte minLevel = 1;
    byte maxLevel = 99;
    byte currentLevel = 1;
    public Skill(string skillName, byte currentLevel, byte minLevel, byte maxLevel)
    {
        name = skillName;
        this.currentLevel = currentLevel;
        this.minLevel = minLevel;
        this.maxLevel = maxLevel;
    }
    public Skill(string skillName, byte currentLevel)
    {
        name = skillName;
        this.currentLevel = currentLevel;
        if (skillName == "Dungeoneering" || skillName == "Invention" || skillName == "Slayer" || skillName == "Herblore" || skillName == "Farming" || skillName == "Archeology")
        {
            maxLevel = 120;
        }
        else
        {
            maxLevel = 99;
            minLevel = skillName == "Constitution" ? (byte)10 : (byte)1;
        }
    }
    public Skill(string skillName)
    {
        name = skillName;
        if (skillName == "Dungeoneering" || skillName == "Invention" || skillName == "Slayer" || skillName == "Herblore" || skillName == "Farming" || skillName == "Archeology")
        {
            maxLevel = 120;
        }
        else
        {
            maxLevel = 99;
            switch (skillName)
            {
                case "Constitution":
                    minLevel = 10;
                    currentLevel = 10;
                    break;
                default:
                    minLevel = 1;
                    currentLevel = 1;
                    break;
            }
        }
    }
}