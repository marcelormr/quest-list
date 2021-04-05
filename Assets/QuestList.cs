using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class QuestList : MonoBehaviour
{
    #region Skills Declarations
    Skill attack = new Skill("Attack");
    Skill constitution = new Skill("Hitpoints");
    Skill mining = new Skill("Mining");

    Skill strength = new Skill("Strength");
    Skill agility = new Skill("Agility");
    Skill smithing = new Skill("Smithing");

    Skill defence = new Skill("defence");
    Skill herblore = new Skill("Herblore");
    Skill fishing = new Skill("Fishing");

    Skill ranged = new Skill("Ranged");
    Skill thieving = new Skill("Thieving");
    Skill cooking = new Skill("Cooking");

    Skill prayer = new Skill("Prayer");
    Skill crafting = new Skill("Crafting");
    Skill firemaking = new Skill("Firemaking");

    Skill magic = new Skill("Magic");
    Skill fletching = new Skill("Fletching");
    Skill woodcutting = new Skill("Woodcutting");

    Skill runecrafting = new Skill("Runecrafting");
    Skill slayer = new Skill("Slayer");
    Skill farming = new Skill("Farming");

    Skill construction = new Skill("Construction");
    Skill hunter = new Skill("Hunter");
    Skill summoning = new Skill("Summoning");

    Skill dungeoneering = new Skill("Dungeoneering");
    Skill divination = new Skill("Divination");
    Skill invention = new Skill("Invention");

    Skill archeology = new Skill("Archeology");
    #endregion
    static Quest cooksAssistant = new Quest(
        name: "Cook's Assistant",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest demonSlayer = new Quest(
        name: "Demon Slayer",
        difficulty: "Novice",
        questPointsReward: 3
        );
    static Quest theRestlessGhost = new Quest(
        name: "The Restless Ghost",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest romeoAndJuliet = new Quest(
        name: "Romeo & Juliet",
        questPointsReward: 5,
        difficulty: "Novice"
        );
    static Quest sheepShearer = new Quest(
        name: "Sheep Shearer",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest shieldOfArrav = new Quest(
        name: "Shield of Arrav",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest ernestTheChicken = new Quest(
        name: "Ernest the Chicken",
        questPointsReward: 4,
        difficulty: "Novice"
        );
    static Quest vampyreSlayer = new Quest(
        name: "Vampyre Slayer",
        questPointsReward: 3,
        difficulty: "Novice"
        );
    static Quest impCatcher = new Quest(
        name: "Imp Catcher",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest princeAliRescue = new Quest(
        name: "Prince Ali Rescue",
        questPointsReward: 3,
        difficulty: "Novice"
        );
    static Quest doricsQuest = new Quest(
        name: "Doric's Quest",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest blackKnightsFortress = new Quest(
        name: "Black Knight's Fortress",
        questPointsReward: 3,
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(questPointsRequired: 13)
        );
    static Quest witchsPotion = new Quest(
        name: "Witch's Potion",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest theKnightsSword = new Quest(
        name: "The Knight's Sword",
        questPointsReward: 1,
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(miningLevel: 10)
        );
    static Quest goblinDiplomacy = new Quest(
        name: "Goblin Diplomacy",
        questPointsReward: 5,
        difficulty: "Novice"
        );
    static Quest piratesTreasure = new Quest(
        name: "Pirate's Treasure",
        questPointsReward: 2,
        difficulty: "Novice"
        );
    static Quest dragonSlayer = new Quest(
        name: "Dragon Slayer",
        questPointsReward: 2,
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(questPointsRequired: 33)
        );
    static Quest druidicRitual = new Quest(
        name: "Druidic Ritual",
        questPointsReward: 4,
        difficulty: "Novice"
        );
    static Quest lostCity = new Quest(
        name: "Lost City",
        questPointsReward: 3,
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            craftingLevel: 31,
            woodcuttingLevel: 36)
        );
    static Quest witchsHouse = new Quest(
        name: "Witch's House",
        questPointsReward: 4,
        difficulty: "Intermediate"
        );
    static Quest merlinsCrystal = new Quest(
        name: "Merlin's Crystal",
        questPointsReward: 6,
        difficulty: "Intermediate"
        );
    static Quest heroesQuest = new Quest(
        name: "Heroes's Quest",
        questPointsReward: 1,
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            shieldOfArrav,
            lostCity,
            dragonSlayer,
            merlinsCrystal,
            druidicRitual
        },
        otherRequirements: new OtherRequirements(
            questPointsRequired: 56,
            cookingLevel: 53,
            fishingLevel: 53,
            herbloreLevel: 25,
            defenceLevel: 25,
            miningLevel: 50
            )
        );
    static Quest barCrawl = new Quest(
        name: "Bar Crawl",
        difficulty: "Intermediate",
        isMiniquest: true
        );
    static Quest scorpionCatcher = new Quest(
        name: "Scorpion Catcher",
        questPointsReward: 1,
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { barCrawl }
        );
    static Quest familyCrest = new Quest(
        name: "Family Crest",
        questPointsReward: 1,
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            craftingLevel: 40,
            smithingLevel: 40,
            miningLevel: 40,
            magicLevel: 59
            )
        );
    static Quest tribalTotem = new Quest(
        name: "Tribal Totem",
        questPointsReward: 1,
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(thievingLevel: 21)
        );
    static Quest fishingContest = new Quest(
        name: "Fishing Contest",
        questPointsReward: 1,
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(fishingLevel: 10)
        );
    static Quest monksFriend = new Quest(
        name: "Monk's Friend",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest templeOfIkov = new Quest(
        name: "Temple of Ikov",
        questPointsReward: 1,
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(thievingLevel: 42, rangedLevel: 40)
        );
    static Quest clockTower = new Quest(
        name: "Clock Tower",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest holyGrail = new Quest(
        name: "Holy Grail",
        questPointsReward: 2,
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { merlinsCrystal },
        otherRequirements: new OtherRequirements(attackLevel: 30)
        );
    static Quest treeGnomeVillage = new Quest(
        name: "Tree Gnome Village",
        questPointsReward: 2,
        difficulty: "Intermediate"
        );
    static Quest fightArena = new Quest(
        name: "Fight Arena",
        questPointsReward: 2,
        difficulty: "Experienced"
        );
    static Quest hazeelCult = new Quest(
        name: "Hazeel Cult",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest sheepHerder = new Quest(
        name: "Sheep Herder",
        questPointsReward: 4,
        difficulty: "Novice"
        );
    static Quest plagueCity = new Quest(
        name: "Plague City",
        questPointsReward: 1,
        difficulty: "Novice"
        );
    static Quest seaSlug = new Quest(
        name: "Sea Slug",
        questPointsReward: 1,
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(firemakingLevel: 30)
        );
    static Quest waterfallQuest = new Quest(
        name: "Waterfall Quest",
        questPointsReward: 1,
        difficulty: "Intermediate"
        );
    static Quest biohazard = new Quest(
        name: "Biohazard",
        questPointsReward: 3,
        difficulty: "Novice",
        questRequirements: new List<Quest> { plagueCity }
        );
    static Quest junglePotion = new Quest(
        name: "Jungle Potion",
        questPointsReward: 1,
        difficulty: "Novice",
        questRequirements: new List<Quest> { druidicRitual },
        otherRequirements: new OtherRequirements(herbloreLevel: 3)
        );
    static Quest theGrandTree = new Quest(
        name: "The Grand Tree",
        questPointsReward: 5,
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(agilityLevel: 25)
        );
    static Quest shiloVillage = new Quest(
        name: "Shilo Village",
        questPointsReward: 2,
        difficulty: "Experienced",
        questRequirements: new List<Quest> { junglePotion },
        otherRequirements: new OtherRequirements(
            craftingLevel: 20,
            agilityLevel: 32
            )
        );
    static Quest undergroundPass = new Quest(
        name: "Underground Pass",
        questPointsReward: 5,
        difficulty: "Experienced",
        questRequirements: new List<Quest> { biohazard },
        otherRequirements: new OtherRequirements(rangedLevel: 25)
        );
    static Quest observatoryQuest = new Quest(
        name: "Observatory Quest",
        questPointsReward: 2,
        difficulty: "Novice"
        );
    static Quest theTouristTrap = new Quest(
        name: "The Tourist Trap",
        questPointsReward: 2,
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            fletchingLevel: 10,
            smithingLevel: 20
            )
        );
    static Quest watchtower = new Quest(
        name: "Watchtower",
        questPointsReward: 4,
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            herbloreLevel: 14,
            magicLevel: 14,
            thievingLevel: 15,
            agilityLevel: 25,
            miningLevel: 40
            )
        );
    static Quest dwarfCannon = new Quest(
        name: "Dwarf Cannon",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest murderMystery = new Quest(
        name: "Murder Mystery",
        difficulty: "Novice",
        questPointsReward: 3
        );
    static Quest theDigSite = new Quest(
        name: "The Dig Site",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            thievingLevel: 25,
            agilityLevel: 10,
            herbloreLevel: 10
            ),
        questPointsReward: 2
        );
    static Quest gertrudesCat = new Quest(
        name: "Gertrude's Cat",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest legendsQuest = new Quest(
        name: "Legends' Quest",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            familyCrest,
            heroesQuest,
            shiloVillage,
            undergroundPass,
            waterfallQuest
        },
        otherRequirements: new OtherRequirements(
            questPointsRequired: 107,
            agilityLevel: 50,
            craftingLevel: 50,
            herbloreLevel: 45,
            magicLevel: 56,
            miningLevel: 52,
            prayerLevel: 42,
            smithingLevel: 50,
            strengthLevel: 50,
            thievingLevel: 50,
            woodcuttingLevel: 50
            ),
        questPointsReward: 4
        );
    static Quest runeMysteries = new Quest(
        name: "Rune Mysteries",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest bigChompyBirdHunting = new Quest(
        name: "Big Chompy Bird Hunting",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            cookingLevel: 30,
            rangedLevel: 30,
            fletchingLevel: 5
            ),
        questPointsReward: 2
        );
    static Quest elementalWorkshopI = new Quest(
        name: "Elemental Workshop I",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(
            miningLevel: 20,
            smithingLevel: 20,
            craftingLevel: 20
            ),
        questPointsReward: 1
        );
    static Quest priestInPeril = new Quest(
        name: "Priest in Peril",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest natureSpirit = new Quest(
        name: "Nature Spirit",
        difficulty: "Novice",
        questRequirements: new List<Quest>{
            priestInPeril,
            theRestlessGhost
            },
        questPointsReward: 2
        );
    static Quest deathPlateau = new Quest(
        name: "Death Plateau",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest trollStronghold = new Quest(
        name: "Troll Stronghold",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { deathPlateau },
        otherRequirements: new OtherRequirements(
            agilityLevel: 15,
            thievingLevel: 30),
        questPointsReward: 1
        );
    static Quest taiBwoWannaiTrio = new Quest(
        name: "Tai Bwo Wannai Trio",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { junglePotion },
        otherRequirements: new OtherRequirements(
            agilityLevel: 15,
            fishingLevel: 5,
            cookingLevel: 30
            ),
        questPointsReward: 2
        );
    static Quest regicide = new Quest(
        name: "Regicide",
        difficulty: "Master",
        questRequirements: new List<Quest> { undergroundPass },
        otherRequirements: new OtherRequirements(
            agilityLevel: 56,
            craftingLevel: 10
            ),
        questPointsReward: 3
        );
    static Quest eadgarsRuse = new Quest(
        name: "Eadgar's Ruse",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            druidicRitual,
            trollStronghold
        },
        otherRequirements: new OtherRequirements(
            herbloreLevel: 31,
            agilityLevel: 15),
        questPointsReward: 1
        );
    static Quest shadesOfMortton = new Quest(
        name: "Shades of Mort'ton",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            craftingLevel: 20,
            firemakingLevel: 5,
            herbloreLevel: 15),
        questPointsReward: 3
        );
    static Quest theFremennikTrials = new Quest(
        name: "The Fremennik Trials",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            craftingLevel: 40,
            fletchingLevel: 25,
            woodcuttingLevel: 40),
        questPointsReward: 3
        );
    static Quest horrorFromTheDeep = new Quest(
        name: "Horror from the Deep",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { barCrawl },
        otherRequirements: new OtherRequirements(agilityLevel: 35),
        questPointsReward: 2
        );
    static Quest throneOfMiscellania = new Quest(
        name: "Throne of Miscellania",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            heroesQuest,
            theFremennikTrials
        },
        questPointsReward: 1
        );
    static Quest monkeyMadness = new Quest(
        name: "Monkey Madness",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            theGrandTree,
            treeGnomeVillage
        },
        questPointsReward: 3
        );
    static Quest hauntedMine = new Quest(
        name: "Haunted Mine",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { priestInPeril },
        questPointsReward: 2
        );
    static Quest trollRomance = new Quest(
        name: "Troll Romance",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { trollStronghold },
        otherRequirements: new OtherRequirements(agilityLevel: 28),
        questPointsReward: 2
        );
    static Quest inSearchOfTheMyreque = new Quest(
        name: "In Search of the Myreque",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { natureSpirit },
        otherRequirements: new OtherRequirements(agilityLevel: 25),
        questPointsReward: 2
        );
    static Quest creatureOfFenkenstrain = new Quest(
        name: "Creature of Fenkenstrain",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            priestInPeril,
            theRestlessGhost
        },
        otherRequirements: new OtherRequirements(
            craftingLevel: 20,
            thievingLevel: 25
            ),
        questPointsReward: 2
        );
    static Quest rovingElves = new Quest(
        name: "Roving Elves",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            waterfallQuest,
            regicide
        },
        questPointsReward: 1
        );
    static Quest ghostsAhoy = new Quest(
        name: "Ghosts Ahoy",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            priestInPeril,
            theRestlessGhost
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 25,
            cookingLevel: 20
            ),
        questPointsReward: 2
        );
    static Quest oneSmallFavour = new Quest(
        name: "One Small Favour",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            runeMysteries,
            shiloVillage,
            druidicRitual
        },
        otherRequirements: new OtherRequirements(
            herbloreLevel: 18,
            craftingLevel: 25,
            smithingLevel: 30,
            agilityLevel: 36
            ),
        questPointsReward: 2
        );
    static Quest mountainDaughter = new Quest(
        name: "Mountain Daughter",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(agilityLevel: 20),
        questPointsReward: 2
        );
    static Quest betweenARock = new Quest(
        name: "Betwen a Rock...",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            dwarfCannon,
            fishingContest
        },
        otherRequirements: new OtherRequirements(
            defenceLevel: 30,
            miningLevel: 40,
            smithingLevel: 50
            ),
        questPointsReward: 2
        );
    static Quest theFeud = new Quest(
        name: "The Feud",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(thievingLevel: 30),
        questPointsReward: 1
        );
    /*static Quest rogueTrader = new Quest(
        name: "Rogue Trader",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            theFeud,
            runeMysteries,
            icthlarinsLittleHelper,
        },
        isMiniquest: true
        );*/
    static Quest theGolem = new Quest(
        name: "The Golem",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            craftingLevel: 20,
            thievingLevel: 25
            ),
        questPointsReward: 1
        );
    static Quest desertTreasure = new Quest(
        name: "Desert Treasure",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            theDigSite,
            priestInPeril,
            templeOfIkov,
            theTouristTrap,
            trollStronghold,
            waterfallQuest
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 10,
            firemakingLevel: 50,
            magicLevel: 50,
            thievingLevel: 53,
            miningLevel: 50
            ),
        questPointsReward: 3
        );
    static Quest icthlarinsLittleHelper = new Quest(
        name: "Icthlarin's Little Helper",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            princeAliRescue,
            gertrudesCat
        },
        questPointsReward: 2
        );
    static Quest tearsOfGuthix = new Quest(
        name: "Tears of Guthix",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            questPointsRequired: 44,
            firemakingLevel: 49,
            miningLevel: 20,
            craftingLevel: 20
            ),
        questPointsReward: 1
        );
    static Quest zogreFleshEaters = new Quest(
        name: "Zogre Flesh Eaters",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            bigChompyBirdHunting,
            junglePotion
        },
        questPointsReward: 1
        );
    static Quest theLostTribe = new Quest(
        name: "The Lost Tribe",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { goblinDiplomacy },
        otherRequirements: new OtherRequirements(
            agilityLevel: 13,
            miningLevel: 17,
            thievingLevel: 13
            ),
        questPointsReward: 1
        );
    static Quest theGiantDwarf = new Quest(
        name: "The Giant Dwarf",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            craftingLevel: 12,
            firemakingLevel: 16,
            magicLevel: 33,
            thievingLevel: 14
            ),
        questPointsReward: 2
        );
    static Quest enterTheAbyss = new Quest(
        name: "Enter the Abyss",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { runeMysteries },
        isMiniquest: true
        );
    static Quest recruitmentDrive = new Quest(
        name: "Recruitment Drive",
        difficulty: "Novice",
        questRequirements: new List<Quest>
        {
            blackKnightsFortress,
            druidicRitual
        },
        otherRequirements: new OtherRequirements(herbloreLevel: 3),
        questPointsReward: 1
        );
    static Quest mourningsEndPartI = new Quest(
        name: "Mourning's End Part I",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            bigChompyBirdHunting,
            sheepHerder,
            rovingElves
        },
        otherRequirements: new OtherRequirements(
            rangedLevel: 60,
            thievingLevel: 50
            ),
        questPointsReward: 2
        );
    static Quest forgettableTaleOfADrunkenDwarf = new Quest(
        name: "Forgettable Tale of a Drunken Dwarf",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            theGiantDwarf,
            fishingContest
        },
        otherRequirements: new OtherRequirements(
            cookingLevel: 22,
            farmingLevel: 17
            ),
        questPointsReward: 2
        );
    static Quest theCurseOfZaros = new Quest(
        name: "The Curse of Zaros",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            desertTreasure,
            theRestlessGhost
        },
        otherRequirements: new OtherRequirements(prayerLevel: 31),
        isMiniquest: true
        );
    static Quest gardenOfTranquility = new Quest(
        name: "Garden of Tranquility",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { creatureOfFenkenstrain },
        otherRequirements: new OtherRequirements(farmingLevel: 25),
        questPointsReward: 2
        );
    static Quest aTailOfTwoCats = new Quest(
        name: "A Tail of Two Cats",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { icthlarinsLittleHelper },
        questPointsReward: 2
        );
    static Quest wanted = new Quest(
        name: "Wanted!",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            recruitmentDrive,
            theLostTribe,
            priestInPeril,
            enterTheAbyss
        },
        otherRequirements: new OtherRequirements(questPointsRequired: 33),
        questPointsReward: 1
        );
    static Quest mourningsEndPartII = new Quest(
        name: "Mourning's End Part II",
        difficulty: "Master",
        questRequirements: new List<Quest> { mourningsEndPartI },
        questPointsReward: 2
        );
    static Quest rumDeal = new Quest(
        name: "Rum Deal",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            priestInPeril,
            zogreFleshEaters
        },
        otherRequirements: new OtherRequirements(
            farmingLevel: 40,
            craftingLevel: 42,
            prayerLevel: 47,
            fishingLevel: 50,
            slayerLevel: 42
            ),
        questPointsReward: 2
        );
    static Quest shadowOfTheStorm = new Quest(
        name: "Shadow of the Storm",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            demonSlayer,
            theGolem
        },
        otherRequirements: new OtherRequirements(craftingLevel: 30),
        questPointsReward: 1
        );
    static Quest makingHistory = new Quest(
        name: "Making History",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            theRestlessGhost,
            priestInPeril
        },
        questPointsReward: 3
        );
    static Quest ratCatchers = new Quest(
        name: "Rat Catchers",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { icthlarinsLittleHelper },
        questPointsReward: 2
        );
    static Quest spiritsOfTheElid = new Quest(
        name: "Spirits of the Elid",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            magicLevel: 33,
            rangedLevel: 37,
            miningLevel: 37,
            thievingLevel: 37
            ),
        questPointsReward: 2
        );
    static Quest deviousMinds = new Quest(
        name: "Devious Minds",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            trollStronghold,
            wanted,
            doricsQuest,
            enterTheAbyss
        },
        otherRequirements: new OtherRequirements(
            runecraftingLevel: 50,
            fletchingLevel: 50,
            smithingLevel: 65
            ),
        questPointsReward: 1
        );
    static Quest theHandInTheSand = new Quest(
        name: "The Hand in the Sand",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            thievingLevel: 17,
            craftingLevel: 49
            ),
        questPointsReward: 1
        );
    static Quest enakhrasLament = new Quest(
        name: "Enakhra's Lament",
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            craftingLevel: 50,
            firemakingLevel: 45,
            magicLevel: 13
            ),
        questPointsReward: 2
        );
    static Quest cabinFever = new Quest(
        name: "Cabin Fever",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            piratesTreasure,
            rumDeal
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 42,
            craftingLevel: 45,
            smithingLevel: 50,
            rangedLevel: 40
            ),
        questPointsReward: 2
        );
    static Quest aFairyTaleIGrowingPains = new Quest(
        name: "A Fairy Tale I - Growing Pains",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            junglePotion,
            lostCity,
            natureSpirit
        },
        questPointsReward: 2
        );
    static Quest recipeForDisaster = new Quest(
        name: "Recipe for Disaster",
        difficulty: "Special",
        questRequirements: new List<Quest>()
        {
            cooksAssistant,
            goblinDiplomacy,
            fishingContest,
            gertrudesCat,
            shadowOfTheStorm,
            bigChompyBirdHunting,
            biohazard,
            demonSlayer,
            murderMystery,
            natureSpirit,
            witchsHouse,
            lostCity,
            legendsQuest,
            monkeyMadness,
            desertTreasure,
            horrorFromTheDeep
        },
        otherRequirements: new OtherRequirements(
            cookingLevel: 70,
            firemakingLevel: 20,
            agilityLevel: 48,
            questPointsRequired: 176
            ),
        subquests: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            recipeForDisasterFreeingTheGoblinGenerals
        },
        questPointsReward: 0
        );
    static Quest recipeForDisasterAnotherCooksQuest = new Quest(
        name: "Recipe for Disaster: Another Cook's Quest",
        difficulty: "Novice",
        questRequirements: new List<Quest> { cooksAssistant },
        otherRequirements: new OtherRequirements(cookingLevel: 10),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingTheGoblinGenerals = new Quest(
        name: "Recipe for Disaster: Freeing the Goblin Generals",
        difficulty: "Novice",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            goblinDiplomacy
        },
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingTheMountainDwarf = new Quest(
        name: "Recipe for Disaster: Freeing the Mountain Dwarf",
        difficulty: "Novice",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            fishingContest
        },
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingEvilDave = new Quest(
        name: "Recipe for Disaster: Freeing Evil Dave",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            gertrudesCat,
            shadowOfTheStorm
        },
        otherRequirements: new OtherRequirements(cookingLevel: 25),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingTheLumbridgeSage = new Quest(
        name: "Recipe for Disaster: Freeing the Lumbridge Sage",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            bigChompyBirdHunting,
            biohazard,
            demonSlayer,
            murderMystery,
            natureSpirit,
            witchsHouse
        },
        otherRequirements: new OtherRequirements(cookingLevel: 40),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingPiratePete = new Quest(
        name: "Recipe for Disaster: Freeing Pirate Pete",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { recipeForDisasterAnotherCooksQuest },
        otherRequirements: new OtherRequirements(cookingLevel: 31),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingSkrachUglogwee = new Quest(
        name: "Recipe for Disaster: Freeing Skrach Uglogwee",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            bigChompyBirdHunting
        },
        otherRequirements: new OtherRequirements(
            cookingLevel: 41,
            firemakingLevel: 20
            ),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingSirAmikVarze = new Quest(
        name: "Recipe for Disaster: Freeing Sir Amik Varze",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            lostCity,
            legendsQuest
        },
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterFreeingKingAwowogei = new Quest(
        name: "Recipe for Disaster: Freeing King Awowogei",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            recipeForDisasterAnotherCooksQuest,
            monkeyMadness
        },
        otherRequirements: new OtherRequirements(
            cookingLevel: 70,
            agilityLevel: 48
            ),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest recipeForDisasterDefeatingTheCulinaromancer = new Quest(
        name: "Recipe for Disaster: Defeating the Culinaromancer",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            recipeForDisasterFreeingEvilDave,
            recipeForDisasterFreeingTheGoblinGenerals,
            recipeForDisasterFreeingKingAwowogei,
            recipeForDisasterFreeingTheLumbridgeSage,
            recipeForDisasterFreeingTheMountainDwarf,
            recipeForDisasterFreeingPiratePete,
            recipeForDisasterFreeingSirAmikVarze,
            recipeForDisasterFreeingSkrachUglogwee,
            desertTreasure,
            horrorFromTheDeep
        },
        otherRequirements: new OtherRequirements(questPointsRequired: 176),
        isSubquest: true,
        superQuest: recipeForDisaster,
        questPointsReward: 1
        );
    static Quest inAidOfTheMyreque = new Quest(
        name: "In Aid of the Myreque",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { inSearchOfTheMyreque },
        otherRequirements: new OtherRequirements(
            craftingLevel: 25,
            magicLevel: 7,
            miningLevel: 15
            ),
        questPointsReward: 2
        );
    static Quest aSoulsBane = new Quest(
        name: "A Soul's Bane",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest ragAndBoneMan = new Quest(
        name: "Rag and Bone Man",
        difficulty: "Novice",
        questPointsReward: 2
        );
    static Quest swanSong = new Quest(
        name: "Swan Song",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            gardenOfTranquility,
            oneSmallFavour
        },
        otherRequirements: new OtherRequirements(
            magicLevel: 66,
            cookingLevel: 62,
            fishingLevel: 62,
            smithingLevel: 45,
            firemakingLevel: 42,
            craftingLevel: 40
            ),
        questPointsReward: 2
        );
    static Quest royalTrouble = new Quest(
        name: "Royal Trouble",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { throneOfMiscellania },
        otherRequirements: new OtherRequirements(
            agilityLevel: 40,
            slayerLevel: 40
            ),
        questPointsReward: 1
        );
    static Quest deathToTheDorgeshuun = new Quest(
        name: "Death to the Dorgeshuun",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { theLostTribe },
        otherRequirements: new OtherRequirements(
            thievingLevel: 23,
            agilityLevel: 23
            ),
        questPointsReward: 1
        );
    static Quest aFairyTaleIICureAQueen = new Quest(
        name: "A Fairy Tale II - Cure a Queen",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { aFairyTaleIGrowingPains },
        otherRequirements: new OtherRequirements(
            thievingLevel: 40,
            farmingLevel: 49,
            herbloreLevel: 57
            ),
        questPointsReward: 2
        );
    static Quest lunarDiplomacy = new Quest(
        name: "Lunar Diplomacy",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            lostCity,
            theFremennikTrials,
            shiloVillage
        },
        otherRequirements: new OtherRequirements(
            craftingLevel: 61,
            defenceLevel: 40,
            firemakingLevel: 49,
            miningLevel: 60,
            herbloreLevel: 5,
            magicLevel: 65,
            woodcuttingLevel: 55
            ),
        questPointsReward: 2
        );
    static Quest theEyesOfGlouphrie = new Quest(
        name: "The Eyes of Glouphrie",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { theEyesOfGlouphrie },
        otherRequirements: new OtherRequirements(
            constructionLevel: 5,
            magicLevel: 46
            ),
        questPointsReward: 2
        );
    static Quest theDarknessOfHallowvale = new Quest(
        name: "The Darkness of Hallowvale",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { inAidOfTheMyreque },
        otherRequirements: new OtherRequirements(
            constructionLevel: 5,
            miningLevel: 20,
            thievingLevel: 22,
            agilityLevel: 26,
            craftingLevel: 32,
            magicLevel: 33,
            strengthLevel: 40
            ),
        questPointsReward: 2
        );
    static Quest theSlugMenace = new Quest(
        name: "The Slug Menace",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            seaSlug,
            wanted
        },
        otherRequirements: new OtherRequirements(
            craftingLevel: 30,
            runecraftingLevel: 30,
            slayerLevel: 30,
            thievingLevel: 30
            ),
        questPointsReward: 1
        );
    static Quest elementalWorshopII = new Quest(
        name: "Elemental Workshop II",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { elementalWorkshopI },
        otherRequirements: new OtherRequirements(
            magicLevel: 20,
            smithingLevel: 30
            ),
        questPointsReward: 1
        );
    static Quest myArmsBigAdventure = new Quest(
        name: "My Arm's Big Adventure",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            eadgarsRuse,
            theFeud,
            junglePotion
        },
        otherRequirements: new OtherRequirements(
            woodcuttingLevel: 10,
            farmingLevel: 29
            ),
        questPointsReward: 1
        );
    static Quest enlightenedJourney = new Quest(
        name: "Enlightened Journey",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            questPointsRequired: 21,
            firemakingLevel: 20,
            farmingLevel: 30,
            craftingLevel: 36
            ),
        questPointsReward: 1
        );
    static Quest eaglesPeak = new Quest(
        name: "Eagles' Peak",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(hunterLevel: 27),
        questPointsReward: 2
        );
    static Quest animalMagnetism = new Quest(
        name: "Animal Magnetism",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            ernestTheChicken,
            priestInPeril,
            theRestlessGhost
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 18,
            craftingLevel: 19,
            rangedLevel: 30,
            woodcuttingLevel: 35,
            thievingLevel: 15
            ),
        questPointsReward: 1
        );
    static Quest contact = new Quest(
        name: "Contact!",
        difficulty: "Master",
        questRequirements: new List<Quest> { icthlarinsLittleHelper },
        questPointsReward: 1
        );
    static Quest lairOfTarnRazorlor = new Quest(
        name: "Lair of Tarn Razorlor",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { hauntedMine },
        otherRequirements: new OtherRequirements(slayerLevel: 40),
        isMiniquest: true
        );
    static Quest coldWar = new Quest(
        name: "Cold War",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            hunterLevel: 10,
            constructionLevel: 34,
            craftingLevel: 30,
            agilityLevel: 30,
            thievingLevel: 15
            ),
        questPointsReward: 1
        );
    static Quest theFremennikIsles = new Quest(
        name: "The Fremennik Isles",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { theFremennikTrials },
        otherRequirements: new OtherRequirements(
            constructionLevel: 20,
            craftingLevel: 46,
            agilityLevel: 40,
            woodcuttingLevel: 56
            ),
        questPointsReward: 1
        );
    static Quest theGeneralsShadow = new Quest(
        name: "The General's Shadow",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            theCurseOfZaros,
            fightArena
        },
        isMiniquest: true
        );
    static Quest towerOfLife = new Quest(
        name: "Tower of Life",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(constructionLevel: 10),
        questPointsReward: 2
        );
    static Quest theGreatBrainRobbery = new Quest(
        name: "The Great Brain Robbery",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            creatureOfFenkenstrain,
            cabinFever,
            recipeForDisasterFreeingPiratePete
        },
        otherRequirements: new OtherRequirements(
            craftingLevel: 16,
            constructionLevel: 30,
            prayerLevel: 50
            ),
        questPointsReward: 2
        );
    static Quest whatLiesBelow = new Quest(
        name: "What Lies Below",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { enterTheAbyss },
        otherRequirements: new OtherRequirements(runecraftingLevel: 35),
        questPointsReward: 1
        );
    static Quest olafsQuest = new Quest(
        name: "Olaf's Quest",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { theFremennikTrials },
        otherRequirements: new OtherRequirements(
            firemakingLevel: 40,
            woodcuttingLevel: 50
            ),
        questPointsReward: 1
        );
    static Quest anotherSliceOfHAM = new Quest(
        name: "Another Slice of H.A.M.",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            deathToTheDorgeshuun,
            theDigSite,
            theGiantDwarf
        },
        otherRequirements: new OtherRequirements(
            attackLevel: 15,
            prayerLevel: 25
            ),
        questPointsReward: 1
        );
    static Quest dreamMentor = new Quest(
        name: "Dream Mentor",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            eadgarsRuse,
            lunarDiplomacy
        },
        otherRequirements: new OtherRequirements(combatLevel: 85),
        questPointsReward: 2
        );
    static Quest grimTales = new Quest(
        name: "Grim Tales",
        difficulty: "Master",
        questRequirements: new List<Quest> { witchsHouse },
        otherRequirements: new OtherRequirements(
            farmingLevel: 45,
            herbloreLevel: 52,
            thievingLevel: 58,
            agilityLevel: 59,
            woodcuttingLevel: 71
            ),
        questPointsReward: 1
        );
    static Quest kingsRansom = new Quest(
        name: "King's Ransom",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            holyGrail,
            murderMystery,
            oneSmallFavour
        },
        otherRequirements: new OtherRequirements(
            magicLevel: 45,
            defenceLevel: 65),
        questPointsReward: 1
        );
    static Quest thePathOfGlouphrie = new Quest(
        name: "The Path of Glouphrie",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            waterfallQuest,
            theEyesOfGlouphrie,
            treeGnomeVillage
        },
        otherRequirements: new OtherRequirements(
            strengthLevel: 60,
            thievingLevel: 56,
            slayerLevel: 56,
            rangedLevel: 47,
            agilityLevel: 45
            ),
        questPointsReward: 1
        );
    static Quest backToMyRoots = new Quest(
        name: "Back to my Roots",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            aFairyTaleIGrowingPains,
            theHandInTheSand,
            oneSmallFavour,
            tribalTotem
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 55,
            farmingLevel: 53,
            slayerLevel: 59,
            woodcuttingLevel: 72
            ),
        questPointsReward: 1
        );
    static Quest oneFootInTheGrave = new Quest(
        name: "One Foot in the Grave",
        difficulty: "Master",
        questRequirements: new List<Quest> { backToMyRoots },
        isMiniquest: true
        );
    static Quest landOfTheGoblins = new Quest(
        name: "Land of the Goblins",
        difficulty: "Experienced",
        questRequirements: new List<Quest> 
        {
            anotherSliceOfHAM,
            fishingContest
        },
        otherRequirements: new OtherRequirements(
            prayerLevel: 30,
            agilityLevel: 36,
            fishingLevel: 36,
            thievingLevel: 36,
            herbloreLevel: 37
            ),
        questPointsReward: 1
        );
    static Quest hopespearsWill = new Quest(
        name: "Hopespear's Will",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            landOfTheGoblins,
            aFairyTaleIICureAQueen,
            desertTreasure
        },
        otherRequirements: new OtherRequirements(prayerLevel: 40),
        isMiniquest: true
        );
    static Quest dealingWithScabaras = new Quest(
        name: "Dealing with Scabaras",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            contact,
            theFeud,
            zogreFleshEaters
        },
        otherRequirements: new OtherRequirements(
            firemakingLevel: 21,
            agilityLevel: 50,
            thievingLevel: 60,
            strengthLevel: 60
            ),
        questPointsReward: 1
        );
    static Quest wolfWhistle = new Quest(
        name: "Wolf Whistle",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest asAFirstResort = new Quest(
        name: "As a First Resort",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { zogreFleshEaters },
        otherRequirements: new OtherRequirements(
            hunterLevel: 48,
            firemakingLevel: 51,
            woodcuttingLevel: 58
            ),
        questPointsReward: 1
        );
    static Quest catapultConstruction = new Quest(
        name: "Catapult Construction",
        difficulty: "Master",
        questRequirements: new List<Quest> { regicide },
        otherRequirements: new OtherRequirements (
            fletchingLevel: 42,
            constructionLevel: 44
            ),
        questPointsReward: 2
        );
    static Quest theHuntForSurok = new Quest(
        name: "The Hunt for Surok",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { whatLiesBelow },
        otherRequirements: new OtherRequirements (
            prayerLevel: 43,
            miningLevel: 42
            ),
        isMiniquest: true
        );
    static Quest kennithsConcerns = new Quest(
        name: "Kennith's Concerns",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { theSlugMenace },
        otherRequirements: new OtherRequirements(miningLevel: 46),
        questPointsReward: 1
        );
    static Quest legacyOfSeergaze = new Quest(
        name: "Legacy of Seergaze",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            theDarknessOfHallowvale,
            shadesOfMortton
        },
        otherRequirements: new OtherRequirements(
            constructionLevel: 20,
            agilityLevel: 29,
            slayerLevel: 31,
            miningLevel: 35,
            firemakingLevel: 40,
            craftingLevel: 47,
            magicLevel: 49
            ),
        questPointsReward: 2
        );
    static Quest perilsOfIceMountain = new Quest(
        name: "Perils of Ice Mountain",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(
            farmingLevel: 5,
            hunterLevel: 5,
            thievingLevel: 5,
            constructionLevel: 5
            ),
        questPointsReward: 1
        );
    static Quest tokTzKetDill = new Quest(
        name: "TokTz-Ket-Dill",
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            constructionLevel: 50,
            strengthLevel: 45,
            craftingLevel: 43,
            miningLevel: 40
            ),
        questPointsReward: 1
        );
    static Quest smokingKills = new Quest(
        name: "Smoking Kills",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            icthlarinsLittleHelper,
            theRestlessGhost
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 35,
            craftingLevel: 25
            ),
        questPointsReward: 1
        );
    static Quest desertSlayerDungeon = new Quest(
        name: "Desert Slayer Dungeon",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { smokingKills },
        otherRequirements: new OtherRequirements(slayerLevel: 70),
        isMiniquest: true
        );
    static Quest rockingOut = new Quest(
        name: "Rocking Out",
        difficulty: "Master",
        questRequirements: new List<Quest> { theGreatBrainRobbery },
        otherRequirements: new OtherRequirements(
            agilityLevel: 60,
            thievingLevel: 63,
            craftingLevel: 66,
            smithingLevel: 69
            ),
        questPointsReward: 2
        );
    static Quest learningTheRopes = new Quest(
        name: "Learning the Ropes",
        difficulty: "Tutorial",
        questPointsReward: 1
        );
    static Quest spiritOfSummer = new Quest(
        name: "Spirit of Summer",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { theRestlessGhost },
        otherRequirements: new OtherRequirements(
            summoningLevel: 19,
            farmingLevel: 26,
            prayerLevel: 35,
            constructionLevel: 40
            ),
        questPointsReward: 1
        );
    static Quest meetingHistory = new Quest(
        name: "Meeting History",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { makingHistory },
        otherRequirements: new OtherRequirements(herbloreLevel: 3),
        questPointsReward: 1
        );
    static Quest allFiredUp = new Quest(
        name: "All Fired Up",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { priestInPeril },
        otherRequirements: new OtherRequirements(firemakingLevel: 43),
        questPointsReward: 1
        );
    static Quest summersEnd = new Quest(
        name: "Summer's End",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { spiritOfSummer },
        otherRequirements: new OtherRequirements(
            summoningLevel: 23,
            hunterLevel: 35,
            woodcuttingLevel: 37,
            miningLevel: 45,
            firemakingLevel: 47,
            prayerLevel: 55
            ),
        questPointsReward: 1
        );
    static Quest defenderOfVarrock = new Quest(
        name: "Defender of Varrock",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            demonSlayer,
            familyCrest,
            gardenOfTranquility,
            theKnightsSword,
            shieldOfArrav,
            templeOfIkov,
            whatLiesBelow
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 51,
            hunterLevel: 51,
            smithingLevel: 54,
            miningLevel: 59
            ),
        questPointsReward: 2
        );
    private void Start()
    {
        List<Skill> skills = new List<Skill> { attack, constitution, mining, strength, agility, smithing, defence, herblore, fishing, ranged, thieving, cooking, prayer, crafting, firemaking, magic, fletching, woodcutting, runecrafting, slayer, farming, construction, hunter, summoning, dungeoneering, divination, invention, archeology };
        Debug.Log(cooksAssistant.name);
        Debug.Log(cooksAssistant.questPointsReward);
    }
}

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
public class OtherRequirements
{
    byte attackLevel = 1, constitutionLevel = 10, miningLevel = 1,
         strengthLevel = 1, agilityLevel = 1, smithingLevel = 1,
         defenceLevel = 1, herbloreLevel = 1, fishingLevel = 1,
         rangedLevel = 1, thievingLevel = 1, cookingLevel = 1,
         prayerLevel = 1, craftingLevel = 1, firemakingLevel = 1,
         magicLevel = 1, fletchingLevel = 1, woodcuttingLevel = 1,
         runecraftingLevel = 1, slayerLevel = 1, farmingLevel = 1,
         constructionLevel = 1, hunterLevel = 1, summoningLevel = 1,
         dungeoneeringLevel = 1, divinationLevel = 1, inventionLevel = 1,
         archeologyLevel = 1, combatLevel = 3, achievementPoints = 0;
    ushort questPointsRequired = 0;
    public OtherRequirements(
        byte attackLevel = 1, byte constitutionLevel = 10, byte miningLevel = 1,
        byte strengthLevel = 1, byte agilityLevel = 1, byte smithingLevel = 1,
        byte defenceLevel = 1, byte herbloreLevel = 1, byte fishingLevel = 1,
        byte rangedLevel = 1, byte thievingLevel = 1, byte cookingLevel = 1,
        byte prayerLevel = 1, byte craftingLevel = 1, byte firemakingLevel = 1,
        byte magicLevel = 1, byte fletchingLevel = 1, byte woodcuttingLevel = 1,
        byte runecraftingLevel = 1, byte slayerLevel = 1, byte farmingLevel = 1,
        byte constructionLevel = 1, byte hunterLevel = 1, byte summoningLevel = 1,
        byte dungeoneeringLevel = 1, byte divinationLevel = 1, byte inventionLevel = 1,
        byte archeologyLevel = 1, byte combatLevel = 3, byte achievementPoints = 0,
        ushort questPointsRequired = 0)
    {
        this.attackLevel = attackLevel;
        this.constitutionLevel = constitutionLevel;
        this.miningLevel = miningLevel;
        this.strengthLevel = strengthLevel;
        this.agilityLevel = agilityLevel;
        this.smithingLevel = smithingLevel;
        this.defenceLevel = defenceLevel;
        this.herbloreLevel = herbloreLevel;
        this.fishingLevel = fishingLevel;
        this.rangedLevel = rangedLevel;
        this.thievingLevel = thievingLevel;
        this.cookingLevel = cookingLevel;
        this.prayerLevel = prayerLevel;
        this.craftingLevel = craftingLevel;
        this.firemakingLevel = firemakingLevel;
        this.magicLevel = magicLevel;
        this.fletchingLevel = fletchingLevel;
        this.woodcuttingLevel = woodcuttingLevel;
        this.runecraftingLevel = runecraftingLevel;
        this.slayerLevel = slayerLevel;
        this.farmingLevel = farmingLevel;
        this.constructionLevel = constructionLevel;
        this.hunterLevel = hunterLevel;
        this.summoningLevel = summoningLevel;
        this.dungeoneeringLevel = dungeoneeringLevel;
        this.divinationLevel = divinationLevel;
        this.inventionLevel = inventionLevel;
        this.archeologyLevel = archeologyLevel;
        this.combatLevel = combatLevel;
        this.achievementPoints = achievementPoints;
        this.questPointsRequired = questPointsRequired;
    }
}