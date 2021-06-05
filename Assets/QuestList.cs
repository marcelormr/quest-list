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
    static Quest demonSlayer_old = new Quest(
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
    static Quest druidicRitual_old = new Quest(
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
    static Quest runeMysteries_old = new Quest(
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
    static Quest deathPlateau_old = new Quest(
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
    static Quest wolfWhistle_old = new Quest(
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
        otherRequirements: new OtherRequirements(
            fletchingLevel: 42,
            constructionLevel: 44
            ),
        questPointsReward: 2
        );
    static Quest theHuntForSurok = new Quest(
        name: "The Hunt for Surok",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { whatLiesBelow },
        otherRequirements: new OtherRequirements(
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
    static Quest sweptAway = new Quest(
        name: "Swept Away",
        difficulty: "Novice",
        questPointsReward: 2 //2 quest points (or 1 quest point; depending on whether you had completed Witch's Potion/Sheep Shearer before they got demoted to a miniquest)
        );
    static Quest purpleCat = new Quest(
        name: "Purple Cat",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            sweptAway,
            gertrudesCat
        },
        isMiniquest: true
        );
    static Quest whileGuthixSleeps = new Quest(
        name: "While Guthix Sleeps",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            defenderOfVarrock,
            dreamMentor,
            theHandInTheSand,
            kingsRansom,
            legendsQuest,
            thePathOfGlouphrie,
            tearsOfGuthix,
            wanted,
            theHuntForSurok
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 25,
            summoningLevel: 23,
            hunterLevel: 55,
            thievingLevel: 60,
            defenceLevel: 65,
            farmingLevel: 65,
            herbloreLevel: 65,
            magicLevel: 75
            ),
        questPointsReward: 5
        );
    static Quest mythsOfTheWhiteLands = new Quest(
        name: "Myths of the White Lands",
        difficulty: "Novice",
        questPointsReward: 2 //2 quest points (or 1 quest point; depending on whether you had completed Witch's Potion/Sheep Shearer before they got demoted to a miniquest)
        );
    static Quest inPyreNeed = new Quest(
        name: "In Pyre Need",
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            firemakingLevel: 55,
            craftingLevel: 52,
            fletchingLevel: 53
            ),
        questPointsReward: 1
        );
    static Quest theChosenCommander = new Quest(
        name: "The Chosen Commander",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { landOfTheGoblins },
        otherRequirements: new OtherRequirements(
            agilityLevel: 46,
            strengthLevel: 46,
            thievingLevel: 46
            ),
        questPointsReward: 3
        );
    static Quest gloriousMemories = new Quest(
        name: "Glorious Memories",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            royalTrouble,
            theFremennikIsles,
            mountainDaughter,
            lunarDiplomacy //Full Reward
        },
        otherRequirements: new OtherRequirements(
            magicLevel: 57,
            agilityLevel: 50,
            herbloreLevel: 43,
            hunterLevel: 41
            ),
        questPointsReward: 1
        );
    static Quest theTaleOfTheMuspah = new Quest(
        name: "The Tale of the Muspah",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(
            firemakingLevel: 6,
            miningLevel: 8,
            magicLevel: 10,
            woodcuttingLevel: 10
            ),
        questPointsReward: 1
        );
    static Quest missingMyMummy = new Quest(
        name: "Missing my Mummy",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            theGolem,
            icthlarinsLittleHelper,
            //Diamond in the Rough
        },
        otherRequirements: new OtherRequirements(
            constructionLevel: 35,
            cookingLevel: 35,
            craftingLevel: 35,
            magicLevel: 35,
            prayerLevel: 35
            ),
        questPointsReward: 1
        );
    static Quest huntForRedRaktuber = new Quest(
        name: "Hunt for Red Raktuber",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            coldWar,
            seaSlug
        },
        otherRequirements: new OtherRequirements(
            thievingLevel: 38,
            constructionLevel: 45,
            hunterLevel: 45
            ),
        questPointsReward: 1
        );
    static Quest theCurseOfArrav = new Quest(
        name: "The Curse of Arrav",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            defenderOfVarrock,
            missingMyMummy,
            shadesOfMortton,
            theTaleOfTheMuspah,
            trollRomance,
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 37,
            summoningLevel: 41,
            agilityLevel: 61,
            rangedLevel: 64,
            strengthLevel: 64,
            miningLevel: 64,
            thievingLevel: 66
            ),
        questPointsReward: 1
        );
    static Quest furNSeek = new Quest(
        name: "Fur 'n Seek",
        difficulty: "Novice",
        questRequirements: new List<Quest> { ragAndBoneMan },
        otherRequirements: new OtherRequirements(slayerLevel: 25),
        questPointsReward: 2
        );
    static Quest forgivenessOfAChaosDwarf = new Quest(
        name: "Forgiveness of a Chaos Dwarf",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            forgettableTaleOfADrunkenDwarf,
            betweenARock
        },
        otherRequirements: new OtherRequirements(
            hunterLevel: 61,
            firemakingLevel: 61,
            strengthLevel: 69
            ),
        questPointsReward: 2
        );
    static Quest unstableFoundations = new Quest(
        name: "Unstable Foundations",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest withinTheLight = new Quest(
        name: "Within the Light",
        difficulty: "Master",
        questRequirements: new List<Quest> { mourningsEndPartII },
        otherRequirements: new OtherRequirements(
            agilityLevel: 69,
            fletchingLevel: 70,
            rangedLevel: 75,
            woodcuttingLevel: 75
            ),
        questPointsReward: 2
        );
    static Quest theTempleAtSenntisten = new Quest(
        name: "The Temple at Senntisten",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            desertTreasure,
            deviousMinds,
            theCurseOfArrav
        },
        otherRequirements: new OtherRequirements(prayerLevel: 50),
        questPointsReward: 2
        );
    static Quest bloodRunsDeep = new Quest(
        name: "Blood Runs Deep",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            dreamMentor,
            gloriousMemories,
            horrorFromTheDeep
        },
        otherRequirements: new OtherRequirements(
            attackLevel: 75,
            strengthLevel: 75,
            slayerLevel: 65
            ),
        questPointsReward: 2
        );
    static Quest nomadsRequiem = new Quest(
        name: "Nomad's Requiem",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest> { kingsRansom },
        otherRequirements: new OtherRequirements(
            magicLevel: 75,
            prayerLevel: 70,
            miningLevel: 66,
            hunterLevel: 65,
            constructionLevel: 60
            ),
        questPointsReward: 3
        );
    static Quest runeMechanics = new Quest(
        name: "Rune Mechanics",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(
            magicLevel: 27,
            runecraftingLevel: 20,
            constructionLevel: 25
            ),
        questPointsReward: 1
        );
    static Quest theBloodPact = new Quest(
        name: "The Blood Pact",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest buyersAndCellars = new Quest(
        name: "Buyers and Cellars",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(thievingLevel: 5),
        questPointsReward: 1
        );
    static Quest fromTinyAcorns = new Quest(
        name: "From Tiny Acorns",
        difficulty: "Novice",
        questRequirements: new List<Quest> { buyersAndCellars },
        otherRequirements: new OtherRequirements(thievingLevel: 24),
        isMiniquest: true
        );
    static Quest lostHerMarbles = new Quest(
        name: "Lost Her Marbles",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { fromTinyAcorns },
        otherRequirements: new OtherRequirements(thievingLevel: 41),
        isMiniquest: true
        );
    static Quest aGuildOfOurOwn = new Quest(
        name: "A Guild of Our Own",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            theFeud,
            lostHerMarbles
        },
        otherRequirements: new OtherRequirements(
            thievingLevel: 62,
            agilityLevel: 40,
            herbloreLevel: 42
            ),
        isMiniquest: true
        );
    static Quest aFairyTaleIIIBattleAtOrksRift = new Quest(
        name: "A Fairy Tale III - Battle At Ork's Rift",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { aFairyTaleIICureAQueen },
        otherRequirements: new OtherRequirements(
            magicLevel: 59,
            farmingLevel: 54,
            thievingLevel: 51,
            summoningLevel: 37,
            craftingLevel: 36
            ),
        questPointsReward: 2
        );
    static Quest elementalWorkshopIII = new Quest(
        name: "Elemental Workshop III",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { elementalWorshopII },
        otherRequirements: new OtherRequirements(
            defenceLevel: 33,
            miningLevel: 20,
            smithingLevel: 33
            ),
        questPointsReward: 1
        );
    //Sheep Shearer and Witch's Potion become miniquests
    static Quest quietBeforeTheSwarm = new Quest(
        name: "Quiet Before the Swarm",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            impCatcher,
            wanted
        },
        otherRequirements: new OtherRequirements(
            attackLevel: 35,
            strengthLevel: 42
            ),
        questPointsReward: 1
        );
    static Quest loveStory = new Quest(
        name: "Love Story",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            swanSong,
            recipeForDisasterFreeingSirAmikVarze
        },
        otherRequirements: new OtherRequirements(
            magicLevel: 77,
            constructionLevel: 68,
            smithingLevel: 68,
            craftingLevel: 67
            ),
        questPointsReward: 2
        );
    static Quest aVoidDance = new Quest(
        name: "A Void Dance",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            quietBeforeTheSwarm,
            druidicRitual
        },
        otherRequirements: new OtherRequirements(
            hunterLevel: 46,
            constructionLevel: 47,
            miningLevel: 47,
            summoningLevel: 48,
            herbloreLevel: 49,
            woodcuttingLevel: 52,
            thievingLevel: 54
            ),
        questPointsReward: 1
        );
    //This quest replaces Romeo & Juliet
    static Quest gunnarsGround = new Quest(
        name: "Gunnar's Ground",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(craftingLevel: 5),
        questPointsReward: 5 //(only if Romeo & Juliet has not been completed)
        );
    static Quest theVoidStaresBack = new Quest(
        name: "The Void Stares Back",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest> { aVoidDance },
        otherRequirements: new OtherRequirements(
            magicLevel: 80,
            attackLevel: 78,
            strengthLevel: 78,
            firemakingLevel: 71,
            constructionLevel: 70,
            craftingLevel: 70,
            smithingLevel: 70,
            summoningLevel: 55,
            defenceLevel: 25
            ),
        questPointsReward: 1
        );
    static Quest doNoEvil = new Quest(
        name: "Do No Evil",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            animalMagnetism,
            dealingWithScabaras,
            desertTreasure,
            missingMyMummy,
            recipeForDisasterFreeingKingAwowogei,
            shadowOfTheStorm,
            smokingKills,
            gardenOfTranquility, //required to restore Senliten tomb
            creatureOfFenkenstrain //required to restore Senliten tomb
        },
        otherRequirements: new OtherRequirements(
            rangedLevel: 50,
            constructionLevel: 64,
            craftingLevel: 68,
            magicLevel: 70,
            thievingLevel: 70
            ),
        questPointsReward: 1
        );
    static Quest kingOfTheDwarves = new Quest(
        name: "King of the Dwarves",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            forgivenessOfAChaosDwarf,
            myArmsBigAdventure
        },
        otherRequirements: new OtherRequirements(
            miningLevel: 68,
            smithingLevel: 70,
            strengthLevel: 77
            ),
        questPointsReward: 2
        );
    static Quest thePrisonerOfGlouphrie = new Quest(
        name: "The Prisoner of Glouphrie",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            thePathOfGlouphrie,
            rovingElves
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 64,
            constructionLevel: 62,
            runecraftingLevel: 61,
            thievingLevel: 64
            ),
        questPointsReward: 1
        );
    static Quest elementalWorkshopIV = new Quest(
        name: "Elemental Workshop IV",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { elementalWorkshopIII },
        otherRequirements: new OtherRequirements(
            craftingLevel: 41,
            runecraftingLevel: 39,
            thievingLevel: 39,
            defenceLevel: 40,
            smithingLevel: 42
            ),
        questPointsReward: 2
        );
    static Quest aClockworkSyringe = new Quest(
        name: "A Clockwork Syringe",
        difficulty: "Master",
        questRequirements: new List<Quest> { rockingOut },
        otherRequirements: new OtherRequirements(
            dungeoneeringLevel: 50,
            slayerLevel: 61,
            constructionLevel: 62,
            summoningLevel: 65,
            smithingLevel: 74,
            thievingLevel: 74,
            defenceLevel: 76
            ),
        questPointsReward: 1
        );
    static Quest threesCompany = new Quest(
        name: "Three's Company",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            dungeoneeringLevel: 6,
            attackLevel: 30,
            magicLevel: 30,
            rangedLevel: 30
            ),
        isMiniquest: true
        );
    static Quest vengeance = new Quest(
        name: "Vengeance",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            dungeoneeringLevel: 23,
            agilityLevel: 55,
            thievingLevel: 55
            ),
        isMiniquest: true
        );
    static Quest thokItToEm = new Quest(
        name: "Thok It To 'Em",
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            dungeoneeringLevel: 59,
            strengthLevel: 70
            ),
        isMiniquest: true
        );
    static Quest deadliestCatch = new Quest(
        name: "Deadliest Catch",
        difficulty: "Master",
        questRequirements: new List<Quest> { towerOfLife },
        otherRequirements: new OtherRequirements(
            herbloreLevel: 3,
            hunterLevel: 67,
            thievingLevel: 70,
            fishingLevel: 70
            ),
        questPointsReward: 1
        );
    static Quest saltInTheWound = new Quest(
        name: "Salt in the Wound",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { kennithsConcerns },
        otherRequirements: new OtherRequirements(
            defenceLevel: 60,
            constitutionLevel: 50,
            herbloreLevel: 47,
            summoningLevel: 45,
            dungeoneeringLevel: 35
            ),
        questPointsReward: 2
        );
    static Quest theBranchesOfDarkmeyer = new Quest(
        name: "The Branches of Darkmeyer",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            legacyOfSeergaze,
            legendsQuest
        },
        otherRequirements: new OtherRequirements(
            woodcuttingLevel: 76,
            fletchingLevel: 70,
            magicLevel: 70,
            slayerLevel: 67,
            craftingLevel: 64,
            farmingLevel: 63,
            agilityLevel: 63
            ),
        questPointsReward: 2
        );
    static Quest ritualOfTheMahjarrat = new Quest( //<3
        name: "Ritual of the Mahjarrat",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            enakhrasLament,
            aFairyTaleIIIBattleAtOrksRift,
            fightArena,
            hazeelCult,
            rockingOut,
            theSlugMenace,
            aTailOfTwoCats,
            theTempleAtSenntisten,
            whileGuthixSleeps
        },
        otherRequirements: new OtherRequirements(
            craftingLevel: 76,
            agilityLevel: 77,
            miningLevel: 76
            ),
        questPointsReward: 3
        );
    static Quest aPiercingNote = new Quest(
        name: "A Piercing Note",
        difficulty: "Novice",
        questPointsReward: 2
        );
    static Quest theFiremakersCurse = new Quest(
        name: "The Firemaker's Curse",
        difficulty: "Master",
        otherRequirements: new OtherRequirements(
            firemakingLevel: 74,
            constitutionLevel: 76,
            agilityLevel: 64
            ),
        questPointsReward: 2
        );
    static Quest druidicRitual = new Quest(
        name: "Druidic Ritual",
        difficulty: "Novice",
        questPointsReward: 4
        );
    static Quest wolfWhistle = new Quest(
        name: "Wolf Whistle",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest deathPlateau = new Quest(
        name: "Death Plateau",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest letThemEatPie = new Quest(
        name: "Let Them Eat Pie",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest theElderKiln = new Quest(
        name: "The Elder Kiln",
        difficulty: "Master",
        otherRequirements: new OtherRequirements(
            magicLevel: 75,
            agilityLevel: 60,
            miningLevel: 41
            ),
        questPointsReward: 2
        );
    //This miniquest is the first one to have "For the full understanding of the story it's recommended to have completed the following:"
    static Quest nadir = new Quest(
        name: "Nadir",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { ritualOfTheMahjarrat },
        otherRequirements: new OtherRequirements(
            dungeoneeringLevel: 55,
            thievingLevel: 45,
            attackLevel: 60
            ),
        isMiniquest: true
        );
    static Quest thokYourBlockOff = new Quest(
        name: "Thok Your Block Off",
        difficulty: "Master",
        questRequirements: new List<Quest> { thokItToEm },
        otherRequirements: new OtherRequirements(
            dungeoneeringLevel: 71,
            strengthLevel: 75
            ),
        isMiniquest: true
        );
    static Quest songFromTheDepths = new Quest(
        name: "Song from the Depths",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest carnilleanRising = new Quest(
        name: "Carnillean Rising",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            theBloodPact,
            hazeelCult
        },
        otherRequirements: new OtherRequirements(
            questPointsRequired: 50,
            thievingLevel: 33,
            constructionLevel: 31
            ),
        questPointsReward: 1
        );
    static Quest someLikeItCold = new Quest(
        name: "Some Like It Cold",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { huntForRedRaktuber },
        otherRequirements: new OtherRequirements(
            fishingLevel: 65,
            craftingLevel: 56,
            constructionLevel: 50,
            thievingLevel: 50
            ),
        questPointsReward: 1
        );
    static Quest stolenHearts = new Quest(
        name: "Stolen Hearts",
        difficulty: "Novice",
        questPointsReward: 3 // (if Prince Ali Rescue has not been completed)
        );
    static Quest diamondInTheRough = new Quest(
        name: "Diamond in the Rough",
        difficulty: "Novice",
        questRequirements: new List<Quest> { diamondInTheRough },
        questPointsReward: 1
        );
    static Quest whatsMineIsYours = new Quest(
        name: "What's Mine is Yours",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(smithingLevel: 5),
        questPointsReward: 1 // (only if you did not complete Doric's Quest before its removal)
        );
    static Quest doricsTaskI = new Quest(
        name: "Doric's Task I",
        difficulty: "Novice",
        questRequirements: new List<Quest> { whatsMineIsYours },
        otherRequirements: new OtherRequirements(smithingLevel: 10),
        isMiniquest: true
        );
    static Quest doricsTaskII = new Quest(
        name: "Doric's Task II",
        difficulty: "Novice",
        questRequirements: new List<Quest>
        {
            doricsTaskI,
            deathPlateau
        },
        otherRequirements: new OtherRequirements(smithingLevel: 20),
        isMiniquest: true
        );
    static Quest doricsTaskIII = new Quest(
        name: "Doric's Task III",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { doricsTaskII },
        otherRequirements: new OtherRequirements(smithingLevel: 30),
        isMiniquest: true
        );
    static Quest doricsTaskIV = new Quest(
        name: "Doric's Task IV",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { doricsTaskIII },
        otherRequirements: new OtherRequirements(smithingLevel: 40),
        isMiniquest: true
        );
    static Quest doricsTaskV = new Quest(
        name: "Doric's Task V",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { doricsTaskIV },
        otherRequirements: new OtherRequirements(smithingLevel: 50),
        isMiniquest: true
        );
    static Quest doricsTaskVI = new Quest(
        name: "Doric's Task VI",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { doricsTaskV },
        otherRequirements: new OtherRequirements(smithingLevel: 60),
        isMiniquest: true
        );
    static Quest doricsTaskVII = new Quest(
        name: "Doric's Task VII",
        difficulty: "Master",
        questRequirements: new List<Quest> { doricsTaskVI },
        otherRequirements: new OtherRequirements(smithingLevel: 65),
        isMiniquest: true
        );
    static Quest doricsTaskVIII = new Quest(
        name: "Doric's Task VIII",
        difficulty: "Master",
        questRequirements: new List<Quest> { doricsTaskVII },
        otherRequirements: new OtherRequirements(smithingLevel: 70),
        isMiniquest: true
        );
    static Quest boricsTaskI = new Quest(
        name: "Boric's Task I",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { whatsMineIsYours },
        otherRequirements: new OtherRequirements(miningLevel: 30),
        isMiniquest: true
        );
    static Quest boricsTaskII = new Quest(
        name: "Boric's Task II",
        difficulty: "Intermediate",
        questRequirements: new List<Quest> { boricsTaskI },
        otherRequirements: new OtherRequirements(miningLevel: 40),
        isMiniquest: true
        );
    static Quest boricsTaskIII = new Quest(
        name: "Boric's Task III",
        difficulty: "Experienced",
        questRequirements: new List<Quest> { boricsTaskII },
        otherRequirements: new OtherRequirements(miningLevel: 60),
        isMiniquest: true
        );
    static Quest runeMysteries = new Quest(
        name: "Rune Mysteries",
        difficulty: "Novice",
        questPointsReward: 1  //(only if you did not complete Rune Mysteries before its removal)
        );
    static Quest runeMemories = new Quest(
        name: "Rune Memories",
        difficulty: "Novice",
        questRequirements: new List<Quest> { runeMemories },
        questPointsReward: 1
        );
    static Quest theBrinkOfExtinction = new Quest(
        name: "The Brink of Extinction",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest> { theElderKiln },
        otherRequirements: new OtherRequirements(
            defenceLevel: 80,
            smithingLevel: 80,
            miningLevel: 72
            ),
        questPointsReward: 3
        );
    static Quest wanderingGaal = new Quest(
        name: "Wandering Ga'al",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            theBrinkOfExtinction,
            desertTreasure
        },
        isMiniquest: true
        );
    static Quest demonSlayer = new Quest(
        name: "Demon Slayer",
        difficulty: "Novice",
        questPointsReward: 3 //(only if you did not complete Demon Slayer before its removal)
        );
    static Quest koscheisTroubles = new Quest(
        name: "Koschei's Troubles",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            bloodRunsDeep,
            ritualOfTheMahjarrat
        },
        otherRequirements: new OtherRequirements(//Optional for total completion:
            strengthLevel: 90,
            prayerLevel: 90
            ),
        isMiniquest: true
        );
    static Quest theWorldWakes = new Quest(
        name: "The World Wakes",
        difficulty: "Grandmaster",
        //The following optional quests are recommended for full storyline comprehension and additional rewards.
        questRequirements: new List<Quest>
        {
            ritualOfTheMahjarrat,
            theChosenCommander,
            theVoidStaresBack,
            theBranchesOfDarkmeyer,
            theFiremakersCurse
        },
        questPointsReward: 3
        );
    static Quest bringingHomeTheBacon = new Quest(
        name: "Bringing Home the Bacon",
        difficulty: "Novice",
        otherRequirements: new OtherRequirements(
            farmingLevel: 14,
            summoningLevel: 14,
            constructionLevel: 14
            ),
        questPointsReward: 1
        );
    static Quest theDeathOfChivalry = new Quest(
        name: "The Death of Chivalry",
        difficulty: "Novice",
        questPointsReward: 3 // (only if you had not completed Black Knights' Fortress before its removal)
        );
    static Quest birthrightOfTheDwarves = new Quest(
        name: "Birthright of the Dwarves",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest> 
        { 
            kingOfTheDwarves,
            watchtower,       //Recommended
            theFremennikIsles //Recommended
        },
        otherRequirements: new OtherRequirements(
            miningLevel: 80,
            smithingLevel: 82,
            strengthLevel: 85
            ),
        questPointsReward: 2
        );
    static Quest missingPresumedDeath = new Quest(
        name: "Missing, Presumed Death",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            theWorldWakes,
            ritualOfTheMahjarrat,
            theDeathOfChivalry,
            koscheisTroubles,
            theChosenCommander
        },
        questPointsReward: 2
        );
    static Quest oneOfAKind = new Quest(
        name: "One of a Kind",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            aTailOfTwoCats,
            theWorldWakes,
            kingsRansom,
            missingPresumedDeath
        },
        otherRequirements: new OtherRequirements(
            divinationLevel: 40,
            dungeoneeringLevel: 67,
            summoningLevel: 74,
            magicLevel: 81
            ),
        questPointsReward: 1
        );
    static Quest mahjarratMemories = new Quest(
        name: "Mahjarrat Memories",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            koscheisTroubles,
            missingPresumedDeath
        },
        otherRequirements: new OtherRequirements(divinationLevel: 60),
        isMiniquest: true
        );
    static Quest fateOfTheGods = new Quest(
        name: "Fate of the Gods",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            missingPresumedDeath,
            theWorldWakes,
            theFiremakersCurse,
            ritualOfTheMahjarrat
        },
        otherRequirements: new OtherRequirements(
            summoningLevel: 67,
            agilityLevel: 73,
            divinationLevel: 75,
            slayerLevel: 76,
            magicLevel: 79
            ),
        questPointsReward: 2
        );
    static Quest aShadowOverAshdale = new Quest(
        name: "A Shadow over Ashdale",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest theMightyFall = new Quest(
        name: "The Mighty Fall",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            missingPresumedDeath,
            theChosenCommander,
            myArmsBigAdventure,
            theHuntForSurok
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 69,
            defenceLevel: 72,
            constitutionLevel: 78,
            attackLevel: 79,
            strengthLevel: 79
            ),
        questPointsReward: 2
        );
    static Quest plaguesEnd = new Quest(
        name: "Plague's End",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            makingHistory,
            catapultConstruction,
            withinTheLight
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 75,
            constructionLevel: 75,
            craftingLevel: 75,
            dungeoneeringLevel: 75,
            herbloreLevel: 75,
            miningLevel: 75,
            prayerLevel: 75,
            rangedLevel: 75,
            summoningLevel: 75,
            woodcuttingLevel: 75
            ),
        questPointsReward: 2
        );
    static Quest brokenHome = new Quest(
        name: "Broken Home",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest heartOfStone = new Quest(
        name: "Heart of Stone",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            carnilleanRising,
            runeMemories,
            runeMechanics,
            theElderKiln,
            fateOfTheGods
        },
        otherRequirements: new OtherRequirements(
            runecraftingLevel: 25,
            magicLevel: 35
            ),
        questPointsReward: 1
        );
    static Quest dishonourAmongThieves = new Quest(
        name: "Dishonour Among Thieves",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            hazeelCult,
            missingPresumedDeath,
            nomadsRequiem,
            nadir
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 30,
            thievingLevel: 30
            ),
        questPointsReward: 2
        );
    static Quest dimensionOfDisaster = new Quest(
        name: "Dimension of Disaster",
        difficulty: "Special",
        questRequirements: new List<Quest>
        {
            theCurseOfArrav,
            shadowOfTheStorm
        },
        subquests: new List<Quest>
        {
            dimensionOfDisasterCoinOfTheRealm,
            dimensionOfDisasterShieldOfArrav,
            dimensionOfDisasterDemonSlayer,
            dimensionOfDisasterDefenderOfVarrock,
            dimensionOfDisasterCurseOfArrav
        },
        questPointsReward: 2
        );
    static Quest dimensionOfDisasterCoinOfTheRealm = new Quest(
        name: "Dimension of Disaster: Coin of the Realm",
        difficulty: "Special",
        questPointsReward: 1,
        isSubquest: true,
        superQuest: dimensionOfDisaster
        );
    static Quest dimensionOfDisasterShieldOfArrav = new Quest(
        name: "Dimension of Disaster: Shield of Arrav",
        difficulty: "Special",
        questRequirements: new List<Quest>
        {
            dimensionOfDisasterCoinOfTheRealm,
            shieldOfArrav
        },
        questPointsReward: 1,
        isSubquest: true,
        superQuest: dimensionOfDisaster
        );
    static Quest dimensionOfDisasterDemonSlayer = new Quest(
        name: "Dimension of Disaster: Demon Slayer",
        difficulty: "Special",
        questRequirements: new List<Quest>
        {
            dimensionOfDisasterCoinOfTheRealm,
            shadowOfTheStorm
        },
        questPointsReward: 3,
        isSubquest: true,
        superQuest: dimensionOfDisaster
        );
    static Quest dimensionOfDisasterDefenderOfVarrock = new Quest(
        name: "Dimension of Disaster: Defender of Varrock",
        difficulty: "Special",
        questRequirements: new List<Quest>
        {
            dimensionOfDisasterCoinOfTheRealm,
            defenderOfVarrock
        },
        questPointsReward: 2,
        isSubquest: true,
        superQuest: dimensionOfDisaster
        );
    static Quest dimensionOfDisasterCurseOfArrav = new Quest(
        name: "Dimension of Disaster: Curse of Arrav",
        difficulty: "Special",
        questRequirements: new List<Quest>
        {
            dimensionOfDisasterCoinOfTheRealm,
            dimensionOfDisasterDemonSlayer,
            dimensionOfDisasterDefenderOfVarrock,
            theCurseOfArrav
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 61,
            strengthLevel: 64,
            rangedLevel: 64
            ),
        questPointsReward: 1,
        isSubquest: true,
        superQuest: dimensionOfDisaster
        );
    static Quest herosWelcome = new Quest(
        name: "Hero's Welcome",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            lunarDiplomacy,
            taiBwoWannaiTrio,
            ritualOfTheMahjarrat,
            oneOfAKind
        },
        otherRequirements: new OtherRequirements(
            divinationLevel: 60,
            miningLevel: 67,
            slayerLevel: 62,
            smithingLevel: 67
            //Completed all Otto Godblessed's Barbarian Training activities
            ),
        questPointsReward: 2
        );
    static Quest theLightWithin = new Quest(
        name: "The Light Within",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            fateOfTheGods,
            meetingHistory,
            plaguesEnd,
            theTempleAtSenntisten,
            theWorldWakes
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 80,
            craftingLevel: 80,
            divinationLevel: 80,
            herbloreLevel: 80,
            prayerLevel: 80,
            slayerLevel: 80,
            woodcuttingLevel: 80
            ),
        questPointsReward: 2
        );
    static Quest theLordOfVampyrium = new Quest(
        name: "The Lord of Vampyrium",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            theBranchesOfDarkmeyer
        },
        otherRequirements: new OtherRequirements(
            attackLevel: 75,
            defenceLevel: 75,
            strengthLevel: 75,
            constitutionLevel: 75,
            constructionLevel: 79,
            slayerLevel: 78,
            hunterLevel: 76
            ),
        questPointsReward: 2
        );
    static Quest callOfTheAncestors = new Quest(
        name: "Call of the Ancestors",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest beneathCursedTides = new Quest(
        name: "Beneath Cursed Tides",
        difficulty: "Intermediate",
        otherRequirements: new OtherRequirements(
            attackLevel: 30,
            strengthLevel: 30,
            magicLevel: 30,
            miningLevel: 30,
            smithingLevel: 30,
            woodcuttingLevel: 30,
            firemakingLevel: 30,
            cookingLevel: 30
            ),
        questPointsReward: 1
        );
    static Quest nomadsElegy = new Quest(
        name: "Nomad's Elegy",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            dishonourAmongThieves,
            heartOfStone,
            theMightyFall,
            throneOfMiscellania,
            nomadsRequiem,
            theVoidStaresBack,
            whileGuthixSleeps,
            bloodRunsDeep
        },
        otherRequirements: new OtherRequirements(
            miningLevel: 75,
            constructionLevel: 75,
            woodcuttingLevel: 75
            ),
        questPointsReward: 1
        );
    static Quest talesOfTheGodWars = new Quest(
        name: "Tales of the God Wars",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            trollStronghold
        },
        otherRequirements: new OtherRequirements(
            constitutionLevel: 70,
            strengthLevel: 60,
            agilityLevel: 60
            ),
        isMiniquest: true
        );
    static Quest theLostToys = new Quest(
        name: "The Lost Toys",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            theLordOfVampyrium
        },
        isMiniquest: true
        );
    static Quest inMemoryOfTheMyreque = new Quest(
        name: "In Memory of the Myreque",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            theLordOfVampyrium
        },
        isMiniquest: true
        );
    static Quest benedictsWorldTour = new Quest(
        name: "Benedict's World Tour",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            stolenHearts
        },
        isMiniquest: true
        );
    static Quest riverOfBlood = new Quest(
        name: "River of Blood",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            theLordOfVampyrium,
            defenderOfVarrock,
            allFiredUp
        },
        otherRequirements: new OtherRequirements(
            herbloreLevel: 80,
            constitutionLevel: 80,
            attackLevel: 78,
            rangedLevel: 78,
            magicLevel: 78,
            firemakingLevel: 76,
            fletchingLevel: 75,
            miningLevel: 72
            ),
        questPointsReward: 3
        );
    static Quest kindredSpirits = new Quest(
        name: "Kindred Spirits",
        difficulty: "Experienced",
        questRequirements: new List<Quest>
        {
            missingPresumedDeath,
            deadliestCatch
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 60,
            craftingLevel: 60,
            herbloreLevel: 60,
            smithingLevel: 60
            ),
        questPointsReward: 1
        );
    static Quest gowerQuest = new Quest(
        name: "Gower Quest",
        difficulty: "Experienced",
        otherRequirements: new OtherRequirements(
            questPointsRequired: 34
            ),
        questPointsReward: 1
        );
    static Quest impressingTheLocals = new Quest(
        name: "Impressing the Locals",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest flagFall = new Quest(
        name: "Flag Fall",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            impressingTheLocals
        },
        isMiniquest: true
        );
    static Quest spiritualEnlightenment = new Quest(
        name: "Spiritual Enlightenment",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            impressingTheLocals
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 90
            ),
        isMiniquest: true
        );
    static Quest headOfTheFamily = new Quest(
        name: "Head of the Family",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            impressingTheLocals
        },
        otherRequirements: new OtherRequirements(
            woodcuttingLevel: 90,
            fishingLevel: 90,
            cookingLevel: 91
            ),
        isMiniquest: true
        );
    static Quest jedHunter = new Quest(
        name: "Jed Hunter",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            flagFall,
            spiritualEnlightenment,
            headOfTheFamily,
            deadliestCatch
        },
        otherRequirements: new OtherRequirements(
            hunterLevel: 90,
            craftingLevel: 91
            ),
        isMiniquest: true
        );
    static Quest talesOfNomad = new Quest(
        name: "Tales of Nomad",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            nomadsElegy
        },
        isMiniquest: true
        );
    static Quest eyeForAnEye = new Quest(
        name: "Eye for an Eye",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            jedHunter
        },
        otherRequirements: new OtherRequirements(
            miningLevel: 90
            ),
        isMiniquest: true
        );
    static Quest harbinger = new Quest(
        name: "Harbinger",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            eyeForAnEye
        },
        isMiniquest: true
        );
    static Quest tuaiLeitsOwn = new Quest(
        name: "Tuai Leit's Own",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            harbinger
        },
        otherRequirements: new OtherRequirements(
            farmingLevel: 86,
            divinationLevel: 90
            ),
        isMiniquest: true
        );
    static Quest ghostsFromThePast = new Quest(
        name: "Ghosts from the Past",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            harbinger
        },
        isMiniquest: true
        );
    static Quest damageControl = new Quest(
        name: "Damage Control",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            harbinger
        },
        isMiniquest: true
        );
    static Quest finalDestination = new Quest(
        name: "Final Destination",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            tuaiLeitsOwn,
            ghostsFromThePast,
            damageControl
        },
        isMiniquest: true
        );
    static Quest childrenOfMah = new Quest(
        name: "Children of Mah",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            dishonourAmongThieves,
            theLightWithin,
            koscheisTroubles
        },
        questPointsReward: 2
        );
    static Quest sliskesEndgame = new Quest(
        name: "Sliske's Endgame",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            theDeathOfChivalry,
            childrenOfMah,
            herosWelcome,
            kindredSpirits,
            nomadsElegy,
            oneOfAKind
        },
        questPointsReward: 3
        );
    static Quest backToTheFreezer = new Quest(
        name: "Back to the Freezer",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            ernestTheChicken,
            someLikeItCold
        },
        otherRequirements: new OtherRequirements(
            slayerLevel: 37,
            runecraftingLevel: 45,
            divinationLevel: 50
            ),
        questPointsReward: 1
        );
    static Quest theJackOfSpades = new Quest(
        name: "The Jack of Spades",
        difficulty: "Novice",
        questRequirements: new List<Quest>
        {
            diamondInTheRough
        },
        questPointsReward: 1
        );
    static Quest crocodileTears = new Quest(
        name: "Crocodile Tears",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            dealingWithScabaras,
            theJackOfSpades,
            missingMyMummy,
            spiritsOfTheElid
        },
        otherRequirements: new OtherRequirements(
            hunterLevel: 73,
            fishingLevel: 72,
            woodcuttingLevel: 47,
            agilityLevel: 30
            ),
        questPointsReward: 1
        );
    static Quest ourManInTheNorth = new Quest(
        name: "Our Man in the North",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            doNoEvil,
            crocodileTears
        },
        questPointsReward: 1
        );
    static Quest phiteClub = new Quest(
        name: "'Phite Club",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            ourManInTheNorth
        },
        questPointsReward: 1
        );
    static Quest evilDavesBigDayOut = new Quest(
        name: "Evil Dave's Big Day Out",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            recipeForDisasterFreeingEvilDave
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 30,
            cookingLevel: 30,
            herbloreLevel: 30,
            magicLevel: 30
            ),
        questPointsReward: 2
        );
    static Quest piecesOfHate = new Quest(
        name: "Pieces of Hate",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            gertrudesCat,
            aClockworkSyringe
        },
        otherRequirements: new OtherRequirements(
            constructionLevel: 81,
            firemakingLevel: 82,
            agilityLevel: 83,
            thievingLevel: 85
            ),
        questPointsReward: 2
        );
    static Quest rebuildingEdgeville = new Quest(
        name: "Rebuilding Edgeville",
        difficulty: "Grandmaster",
        questRequirements: new List<Quest>
        {
            ritualOfTheMahjarrat
        },
        isMiniquest: true
        );
    static Quest youAreIt = new Quest(
        name: "You Are It",
        difficulty: "Intermediate",
        questPointsReward: 1
        );
    static Quest theNeedleSkips = new Quest(
        name: "The Needle Skips",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest violetIsBlue = new Quest(
        name: "Violet is Blue",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest chefsAssistant = new Quest(
        name: "Chef's Assistant",
        difficulty: "Novice",
        questRequirements: new List<Quest>
        {
            chefsAssistant
        },
        otherRequirements: new OtherRequirements(
            cookingLevel: 32
            ),
        questPointsReward: 1
        );
    static Quest curseOfTheBlackStone = new Quest(
        name: "Curse of the Black Stone",
        difficulty: "Master",
        questRequirements: new List<Quest>
        {
            impressingTheLocals
            //Completion of the Temple of Aminishi (any mode)
            //Completion of the Dragonkin Laboratory (any mode)
            //Completion of The Shadow Reef (any mode)
        },
        otherRequirements: new OtherRequirements(
            agilityLevel: 12,
            woodcuttingLevel: 34
            ),
        questPointsReward: 4
        );
    static Quest desperateTimes = new Quest(
        name: "Desperate Times",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            theNeedleSkips,
            youAreIt,
            sliskesEndgame
        },
        otherRequirements: new OtherRequirements(
            miningLevel: 50,
            smithingLevel: 50,
            divinationLevel: 50
            ),
        questPointsReward: 3
        );
    static Quest helpingLaniakea = new Quest(
        name: "Helping Laniakea",
        difficulty: "Novice",
        isMiniquest: true
        );
    static Quest fatherAndSon = new Quest(
        name: "Father and Son",
        difficulty: "Novice",
        isMiniquest: true
        );
    static Quest onceUponASlime = new Quest(
        name: "Once Upon a Slime",
        difficulty: "Novice",
        questPointsReward: 1
        );
    static Quest desperateMeasures = new Quest(
        name: "Desperate Measures",
        difficulty: "Intermediate",
        questRequirements: new List<Quest>
        {
            desperateTimes
        },
        otherRequirements: new OtherRequirements(
            archeologyLevel: 50,
            agilityLevel: 50
            ),
        questPointsReward: 3
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