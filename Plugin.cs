using BepInEx;
using BepInEx.Bootstrap;
using DiskCardGame;
using HarmonyLib;
using Infiniscryption.PackManagement;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        Harmony harmony = new Harmony(PluginGuid);

        // These are variables that exist everywhere in the entire class.
        private const string PluginGuid = "nev.inscryption.BloodBoltsAndBatteriesCardPack";
        private const string PluginName = "BloodBoltsAndBatteriesCardPack";
        private const string PluginVersion = "2.0.0";
        private const string PluginPrefix = "BloodBoltsAndBatteriesCardPack";



        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // This is where you would run all of your other methods.
        private void Awake()
        {
            // Define Vars for Cards
            AddG3KK0();
            AddB0N3W3B();
            AddB0N3W3B2();
            AddSkeleton();
            AddB4B13();
            AddT33N4G3R();
            Add4DULT();
            Add3LD3R();
            AddM3T30R();
            Add45T3R01D();
            AddM00N();
            AddD34THST4R();
            AddB41T3DTR4P();
            AddBl0CKB0T();
            AddBUFFST4T10N();
            AddBurntSkull();
            AddBUZZ();
            AddCEREBUS();
            AddCR3D1TC4RD();
            AddCrocodile();
            AddCUR53D5KU11();
            AddCYB0RG1();
            AddCYB3RMU13();
            AddD1GG3R();
            AddD1V3R();
            AddD3L3T3TH15();
            AddDeadBoy();
            AddDeadlyScarab();
            AddDeadlySkeleton();
            AddFlyingScarab();
            AddGoldenScarab();
            AddGoodBoy();
            AddGremlin();
            AddGuardDog();
            AddF0CU553DF1R3();
            AddF13LD4NT();
            AddG00DB0Y();
            AddH4R3B0T();
            AddH4RDH4T();
            AddH34VY4RT1LL3RY();
            AddH34VY4RT1LL3RY2();
            AddL33PB0T();
            AddM1N3F13LD();
            AddN3CR0B0MB();
            AddPL4YP3N();
            AddR3L04D();
            AddS3NTRYDR0N3();
            AddS34RCHB0T();
            AddSN1P3R();
            Add5P1D3RT4NK();
            AddST04T();
            AddY3T1B0T();
            AddST33LHYDR4();
            AddMadBomber();
            AddReanimatingRemains();
            AddSkeletonArcher();
            AddSkeletonGeneral();
            AddSkeletonMage();
            AddSkeletonWarrior();
            AddSlingerSquirrel();
            AddSquirrelQueen();
            AddSquirrelSkeleton();
            AddSummoningPortal();
            AddTheSquarm();
            AddWarriorSquirrel();
            AddWaxyHusk();
            AddWhale();
            AddWorkerSquirrel();
            AddZombie();
            AddBBBPack();

            // ----------------------------------------------------------------------------------------------------------------------------------------------

            // Create BBB Pack

            static void AddBBBPack()
            {
                if (Chainloader.PluginInfos.ContainsKey("zorro.inscryption.infiniscryption.packmanager"))
                {
                    PackInfo BBBPack = PackManager.GetPackInfo("BloodBoltsAndBatteriesCardPack");
                    BBBPack.Title = "Blood Bolts and Batteries Expansion";
                    BBBPack.SetTexture(TextureHelper.GetImageAsTexture("../Art/Misc/BloodBoltsAndBatteriesCardPack.png"));
                    BBBPack.Description = "A package of Blood Bolts and Batteries.";
                    BBBPack.ValidFor.Add(PackInfo.PackMetacategory.LeshyPack);
                    BBBPack.ValidFor.Add(PackInfo.PackMetacategory.P03Pack);
                }
            }

            // ----------------------------------------------------------------------------------------------------------------------------------------------

            // Create 69 Cards
            static void Add3LD3R()
            {
                CardInfo ELDER = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBB3LD3R",
                    // Card display name.
                    "3LD3R",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Nothing but crushed hopes and dreams remain. Oh and the reamiins"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_3LD3R.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Evolve)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBBSkeleton", 1)
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", ELDER);
            }
            static void Add45T3R01D()
            {
                CardInfo ASTEROID = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBB45T3R01D",
                    // Card display name.
                    "45T3R01D",
                    // Attack.
                    1,
                    // Health.
                    3,
                    // Descryption.
                    description: "Oh look, its hatching!"
                )
                .SetCost(bloodCost: 2, bonesCost: 4, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_45T3R01D.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Evolve)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBBM00N", 1);
                CardManager.Add("BloodBoltsAndBatteriesCardPack", ASTEROID);
            }
            static void Add4DULT()
            {
                CardInfo ADULT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBB4DULT",
                    // Card display name.
                    "4DULT",
                    // Attack.
                    3,
                    // Health.
                    2,
                    // Descryption.
                    description: "A working bot only trying to make it another day"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 4)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_4DULT.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Evolve)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBB3LD3R", 1)
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", ADULT);
            }
            static void Add5P1D3RT4NK()
            {
                CardInfo SPIDERTANK = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBB5P1D3RT4NK",
                    // Card display name.
                    "SN1P3R",
                    // Attack.
                    3,
                    // Health.
                    4,
                    // Descryption.
                    description: "It only has 4 legs"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 5)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_5P1D3RT4NK.png")
                .AddDecal("NevBBBB.png")
                .SetTribes(Tribe.Insect)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("6P2D4RT5NK")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SPIDERTANK);
            }
            static void AddB0N3W3B()
            {
                CardInfo BONEWEB = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBB0N3W3B",
                    // Card display name.
                    "B0N3W3B",
                    // Attack.
                    0,
                    // Health.
                    3,
                    // Descryption.
                    description: "Some assembly required"
                )
                .SetCost(bloodCost: 0, bonesCost: 4, energyCost: 5)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_B0N3W3B.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Evolve)
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddTribes(Tribe.Insect)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBBB0N3W3B2", 1)
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BONEWEB);
            }
            static void AddB0N3W3B2()
            {
                CardInfo BONEWEB2 = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBB0N3W3B2",
                    // Card display name.
                    "Active B0N3 W3B",
                    // Attack.
                    0,
                    // Health.
                    3,
                    // Descryption.
                    description: "Whoops"
                )
                .SetCost(bloodCost: 0, bonesCost: 4, energyCost: 5)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_B0N3W3B.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.PreventAttack)
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddTribes(Tribe.Reptile)
                .SetDefaultEvolutionName("B1N4 W4B")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BONEWEB2);
            }
            static void AddB41T3DTR4P()
            {
                CardInfo BAITEDTRAP = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBB41T3DTR4P",
                    // Card display name.
                    "B41T3D TR4P",
                    // Attack.
                    0,
                    // Health.
                    3,
                    // Descryption.
                    description: "It doesn't technically need a sacrifice, but adds all the flavour"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 1)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_B41T3DTR4P.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.SteelTrap)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("B52T4D TR5P")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BAITEDTRAP);
            }
            static void AddB4B13()
            {
                CardInfo BABIE = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBB4B13",
                    // Card display name.
                    "B4B13",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Luckily I've taken out its soundchip in advance"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_B3B13.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Evolve)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBBT33N4G3R", 1)
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BABIE);
            }
            static void AddBl0CKB0T()
            {
                CardInfo BLOCKBOT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBBl0CKB0T",
                    // Card display name.
                    "Bl0CKB0T",
                    // Attack.
                    0,
                    // Health.
                    5,
                    // Descryption.
                    description: "A Shield for the scales"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_B10CKB0T.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.DeathShield, Ability.WhackAMole)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("B21CKB1T")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BLOCKBOT);
            }
            static void AddBUFFST4T10N()
            {
                CardInfo BUFFSTATION = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBBUFFST4T10N",
                    // Card display name.
                    "BUFF ST4T10N",
                    // Attack.
                    0,
                    // Health.
                    3,
                    // Descryption.
                    description: "While It can't attack, it'll still deal damage indirectly"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_BuffBot.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.BuffNeighbours)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("BUFF ST5T21N")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BUFFSTATION);
            }
            static void AddBurntSkull()
            {
                CardInfo BurntSkull = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBBurntSkull",
                    // Card display name.
                    "Burnt Skull",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "Its bit flammable once played, perfectly safe in your hand though"
                )
                .SetCost(bloodCost: 0, bonesCost: 4, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_BurntSkull.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Tutor, Ability.DrawNewHand)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("Skull but Burnt")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BurntSkull);
            }
            static void AddBUZZ()
            {
                CardInfo BUZZ = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBBUZZ",
                    // Card display name.
                    "BUZZ",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "A mechanical Hornet is no less of an A$$H0L3"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_BUZZ.png")
                .AddDecal("NevBBBB.png")
                .SetTribes(Tribe.Insect)
                .AddAbilities(Ability.Sharp, Ability.Flying)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("Skull but Burnt")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", BUZZ);
            }
            static void AddCEREBUS()
            {
                CardInfo CEREBUS = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBCEREBUS",
                    // Card display name.
                    "CEREBUS",
                    // Attack.
                    2,
                    // Health.
                    6,
                    // Descryption.
                    description: "The Guarddog of Heck, hope you can pay the bone tax"
                )
                .SetCost(bloodCost: 3, bonesCost: 3, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Cerebus.png")
                .AddDecal("NevBBBB.png")
                .SetTribes(Tribe.Canine)
                .AddAbilities(Ability.TriStrike)
                .AddMetaCategories(CardMetaCategory.Rare)
                .SetDefaultEvolutionName("Best Boy Boy Boy")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", CEREBUS);
            }
            static void AddCR3D1TC4RD()
            {
                CardInfo CREDITCARD = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBCR3D1TC4RD",
                    // Card display name.
                    "CR3D1TC4RD",
                    // Attack.
                    0x3e7,
                    // Health.
                    0x3e7,
                    // Descryption.
                    description: "I just need the 4 numbers on the back"
                )
                .SetCost(bloodCost: 4, bonesCost: 10, energyCost: 6)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_None.png")
                .AddDecal("portait_CR3D1TC4RD.png")
                .AddAbilities(Ability.RandomAbility, Ability.RandomConsumable)
                .AddMetaCategories(CardMetaCategory.Rare)
                .SetDefaultEvolutionName("B1TC01N")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", CREDITCARD);
            }
            static void AddCrocodile()
            {
                CardInfo Crocodile = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBCrocodile",
                    // Card display name.
                    "Crocodile",
                    // Attack.
                    2,
                    // Health.
                    4,
                    // Descryption.
                    description: "Once it latches onto an elk, it ain't letting go"
                )
                .SetCost(bloodCost: 2, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Crocodile.png")
                .AddDecal("NevBBBB.png")
                .AddTribes(Tribe.Reptile)
                .AddAbilities(Ability.Strafe, Ability.DeathShield)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("In a while")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", Crocodile);
            }
            static void AddCUR53D5KU11()
            {
                CardInfo CURSEDSKULL = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBCUR53D5KU11",
                    // Card display name.
                    "CUR53D 5KU11",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "It's bark is worse than its byte. Actually its byte hurts for a shorter duration"
                )
                .SetCost(bloodCost: 0, bonesCost: 2, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_CUR53D 5KU11.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Deathtouch)
                .AddMetaCategories(CardMetaCategory.Rare)
                .SetDefaultEvolutionName("CUR64D 6KU22")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", CURSEDSKULL);
            }
            static void AddCYB0RG1()
            {
                CardInfo CYBORG1 = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBCYB0RG1",
                    // Card display name.
                    "CYB0RG1",
                    // Attack.
                    2,
                    // Health.
                    3,
                    // Descryption.
                    description: "Watch out for its Cybork"
                )
                .SetCost(bloodCost: 1, bonesCost: 1, energyCost: 1)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_CYB0RG1.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.BoneDigger)
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddTribes(Tribe.Canine)
                .SetDefaultEvolutionName("CYB1RG2")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", CYBORG1);
            }
            static void AddCYB3RMU13()
            {
                CardInfo CYBERMULE = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBCYB3RMU13",
                    // Card display name.
                    "CYB3R MU13",
                    // Attack.
                    2,
                    // Health.
                    2,
                    // Descryption.
                    description: "Chock full of random loot and rabB1Ts"
                )
                .SetCost(bloodCost: 1, bonesCost: 0, energyCost: 4)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_CYB3RMU13.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Deathtouch)
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddTribes(Tribe.Hooved)
                .SetDefaultEvolutionName("CYB4R MU24")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", CYBERMULE);
            }
            static void AddD1GG3R()
            {
                CardInfo DIGGER = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBD1GG3R",
                    // Card display name.
                    "D1GG3R",
                    // Attack.
                    2,
                    // Health.
                    1,
                    // Descryption.
                    description: "For some reason, it seems to only go underwater not underground"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 4)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_D1GG3R.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Submerge, Ability.BoneDigger)
                .AddMetaCategories(CardMetaCategory.Rare)
                .SetDefaultEvolutionName("D2GG4R")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DIGGER);
            }
            static void AddD1V3R()
            {
                CardInfo DIVER = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBD1V3R",
                    // Card display name.
                    "D1V3R",
                    // Attack.
                    2,
                    // Health.
                    1,
                    // Descryption.
                    description: "That's D1V3R, not D1V4"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 5)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_D1V3R.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Submerge, Ability.Sniper)
                .AddMetaCategories(CardMetaCategory.Rare)
                .SetDefaultEvolutionName("D2V4R")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DIVER);
            }
            static void AddD34THST4R()
            {
                CardInfo DEATHSTAR = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBD34THST4R",
                    // Card display name.
                    "D34THST4R",
                    // Attack.
                    2,
                    // Health.
                    12,
                    // Descryption.
                    description: "Oh look, its hatching!"
                )
                .SetCost(bloodCost: 2, bonesCost: 4, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_D34THST4R.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Deathtouch, Ability.AllStrike)
                .SetDefaultEvolutionName("Was it not big enough already?");
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DEATHSTAR);
            }
            static void AddD3L3T3TH15()
            {
                CardInfo DELETETHIS = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBD3L3T3TH15",
                    // Card display name.
                    "D3L3T3TH15",
                    // Attack.
                    1,
                    // Health.
                    3,
                    // Descryption.
                    description: "I'll catch this one eventually"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_D3L3T3TH15.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.GuardDog, Ability.Sentry)
                .SetDefaultEvolutionName("D4L4T4TH26")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DELETETHIS);
            }
            static void AddDeadBoy()
            {
                CardInfo DeadBoy = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBDeadBoy",
                    // Card display name.
                    "Dead Boy",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Don't worry his tail is still wagging"
                )
                .SetCost(bloodCost: 0, bonesCost: 2, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_DeadBoy.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.BoneDigger)
                .AddTribes(Tribe.Canine)
                .SetDefaultEvolutionName("That's Ruff buddy")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DeadBoy);
            }
            static void AddDeadlyScarab()
            {
                CardInfo DeadlyScarab = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBDeadlyScarab",
                    // Card display name.
                    "Deadly Scarab",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Can you blame it, its eyes are on the side of its head"
                )
                .SetCost(bloodCost: 0, bonesCost: 5, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_DeadlyScarab.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.SplitStrike, Ability.Deathtouch)
                .AddTribes(Tribe.Insect)
                .SetDefaultEvolutionName("Deadlier Scarab")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DeadlyScarab);
            }
            static void AddDeadlySkeleton()
            {
                CardInfo DeadlySkeleton = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBDeadlySkeleton",
                    // Card display name.
                    "Deadly Skeleton",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "The scissors, in card form"
                )
                .SetCost(bloodCost: 0, bonesCost: 2, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_DeadlySkeleton.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Brittle, Ability.Deathtouch)
                .SetDefaultEvolutionName("Why?")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", DeadlySkeleton);
            }
            static void AddF0CU553DF1R3()
            {
                CardInfo FOCUSSEDFIRE = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBF0CU553DF1R3",
                    // Card display name.
                    "F0CU553D F1R3",
                    // Attack.
                    3,
                    // Health.
                    1,
                    // Descryption.
                    description: "Hope you have good aim"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 6)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_F0CU553DF1R3.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.Sniper)
                .SetDefaultEvolutionName("F1CU664D F2R4")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", FOCUSSEDFIRE);
            }
            static void AddF13LD4NT()
            {
                CardInfo FIELDANT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBF13LD4NT",
                    // Card display name.
                    "F13LD 4NT",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "A Self replicating Ant, requires energy to replicate"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 4)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_F13LD4NT.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.DrawAnt, Ability.DrawCopy)
                .AddTraits(Trait.Ant)
                .AddSpecialAbilities(SpecialTriggeredAbility.Ant)
                .AddTribes(Tribe.Insect)
                .SetDefaultEvolutionName("F24LD 5NT")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", FIELDANT);
            }
            static void AddFlyingScarab()
            {
                CardInfo FlyingScarab = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBFlyingScarab",
                    // Card display name.
                    "Flying Scarab",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "Its not like a flying card cares about which lane it hits"
                )
                .SetCost(bloodCost: 0, bonesCost: 3, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_FlyingScarab.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Flying, Ability.SplitStrike)
                .AddTribes(Tribe.Insect)
                .SetDefaultEvolutionName("Flying Hornet")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", FlyingScarab);
            }
            static void AddG00DB0Y()
            {
                CardInfo GOODBOY = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBG00DB0Y",
                    // Card display name.
                    "G00D B0Y",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "WH0'5 4 G00D B0Y?"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_G00DB0Y.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.BoneDigger)
                .AddTribes(Tribe.Canine)
                .SetDefaultEvolutionName("B35T B0Y")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", GOODBOY);
            }
            static void AddG3KK0()
            {
                CardInfo GEKKO = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBG3KK0",
                    // Card display name.
                    "G3KK0",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "Unlike my Geck, this one has a slight cost to it"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 1)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_G3KK0.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddTribes(Tribe.Reptile)
                .SetDefaultEvolutionName("G4KK1")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", GEKKO);
            }
            static void AddGoldenScarab()
            {
                CardInfo GoldenScarab = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBGoldenScarab",
                    // Card display name.
                    "Golden Scarab",
                    // Attack.
                    1,
                    // Health.
                    3,
                    // Descryption.
                    description: "You could get a pretty penny for that, or a pretty scarab"
                )
                .SetCost(bloodCost: 0, bonesCost: 4, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_GoldenScarab.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.RandomConsumable, Ability.SplitStrike)
                .AddTribes(Tribe.Insect)
                .SetDefaultEvolutionName("BL$NG$D SC$R$B")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", GoldenScarab);
            }
            static void AddGoodBoy()
            {
                CardInfo GoodBoy = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBGoodBoy",
                    // Card display name.
                    "Good Boy",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Who's a Good Boy?"
                )
                .SetCost(bloodCost: 1, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_GoodBoy.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.BoneDigger)
                .AddTribes(Tribe.Canine)
                .SetDefaultEvolutionName("Best Boy")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", GoodBoy);
            }
            static void AddGremlin()
            {
                CardInfo Gremlin = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBGremlin",
                    // Card display name.
                    "Gremlin",
                    // Attack.
                    2,
                    // Health.
                    1,
                    // Descryption.
                    description: "Never. Stays. Put."
                )
                .SetCost(bloodCost: 0, bonesCost: 3, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Gremlin.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.Strafe)
                .SetDefaultEvolutionName("Burnt Gremlin")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", Gremlin);
            }
            static void AddGuardDog()
            {
                CardInfo GuardDog = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBGuardDog",
                    // Card display name.
                    "Guard Dog",
                    // Attack.
                    1,
                    // Health.
                    4,
                    // Descryption.
                    description: "Its bark is as bad as its bite"
                )
                .SetCost(bloodCost: 2, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_GuardDog.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddTribes(Tribe.Canine)
                .AddAbilities(Ability.GuardDog, Ability.Sentry)
                .SetDefaultEvolutionName("Now its bite is worse")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", GuardDog);
            }
            static void AddH34VY4RT1LL3RY()
            {
                CardInfo HEAVYARTILLERY = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBH34VY4RT1LL3RY",
                    // Card display name.
                    "H34VY 4RT1LL3RY",
                    // Attack.
                    1,
                    // Health.
                    5,
                    // Descryption.
                    description: "Take a bit of time to set-up and then its fireworks"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 6)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_H34VY4RT1LL3RY.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Evolve)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBBH34VY4RT1LL3RY2", 1)
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", HEAVYARTILLERY);
            }
            static void AddH34VY4RT1LL3RY2()
            {
                CardInfo HEAVYARTILLERY2 = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBH34VY4RT1LL3RY2",
                    // Card display name.
                    "H34VY 4RT1LL3RY",
                    // Attack.
                    2,
                    // Health.
                    5,
                    // Descryption.
                    description: "It isn't really a hat, just a tough shield generator"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 6)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_H34VY4RT1LL3RY2.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.TriStrike, Ability.Sniper)
                .SetDefaultEvolutionName("H45VY 5RT2LL4RY");
                CardManager.Add("BloodBoltsAndBatteriesCardPack", HEAVYARTILLERY2);
            }
            static void AddH4R3B0T()
            {
                CardInfo HAREBOT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBH4R3B0T",
                    // Card display name.
                    "H4R3B0T",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "WabBIT Season"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetPortrait("portrait_H4R3B0T.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.DrawRabbits)
                .SetDefaultEvolutionName("H5R4B1T")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", HAREBOT);
            }
            static void AddH4RDH4T()
            {
                CardInfo HARDHAT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBH4RDH4T",
                    // Card display name.
                    "H4RDH4T",
                    // Attack.
                    2,
                    // Health.
                    3,
                    // Descryption.
                    description: "It isn't really a hat, just a tough shield generator"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetPortrait("portrait_H4RDH4T.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.DeathShield)
                .SetDefaultEvolutionName("H5RDH5T")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", HARDHAT);
            }
            static void AddL33PB0T()
            {
                CardInfo LEEPBOT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBL33PB0T",
                    // Card display name.
                    "H4RDH4T",
                    // Attack.
                    0,
                    // Health.
                    2,
                    // Descryption.
                    description: "A cheap flight blocker, shame it can't bloc--- Play Dinomod, now best mod"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 1)
                .SetCardTemple(CardTemple.Nature)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetPortrait("portrait_leapbot.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Reach)
                .SetDefaultEvolutionName("L44PB1T")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", LEEPBOT);
            }
            static void AddM00N()
            {
                CardInfo MOON = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBM00N",
                    // Card display name.
                    "M00N",
                    // Attack.
                    1,
                    // Health.
                    12,
                    // Descryption.
                    description: "Oh look, its hatching!"
                )
                .SetCost(bloodCost: 2, bonesCost: 4, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_M00N.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Evolve, Ability.AllStrike)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBBD34THST4R", 1);
                CardManager.Add("BloodBoltsAndBatteriesCardPack", MOON);
            }
            static void AddM1N3F13LD()
            {
                CardInfo MINEFIELD = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBM1N3F13LD",
                    // Card display name.
                    "M1N3F13LD",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "8 Bombbots, in one explosive package"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 5)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_M1N3F13LD.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.BombSpawner, Ability.ExplodeOnDeath)
                .SetDefaultEvolutionName("M2N3F24LD")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", MINEFIELD);
            }
            static void AddM3T30R()
            {
                CardInfo METEOR = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBM3T30R",
                    // Card display name.
                    "M3T30R",
                    // Attack.
                    0,
                    // Health.
                    3,
                    // Descryption.
                    description: "Oh look, its hatching!"
                )
                .SetCost(bloodCost: 2, bonesCost: 4, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_M3T30R.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Evolve)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBB45T3R01D", 1)
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", METEOR);
            }
            static void AddMadBomber()
            {
                CardInfo MadBomber = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBMadBomber",
                    // Card display name.
                    "Mad Bomber",
                    // Attack.
                    3,
                    // Health.
                    2,
                    // Descryption.
                    description: "Wanna blow somethin' up? Ha-ha!"
                )
                .SetCost(bloodCost: 3, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_MadBomber.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.BombSpawner)
                .SetDefaultEvolutionName("Madder Bomber")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", MadBomber);
            }
            static void AddN3CR0B0MB()
            {
                CardInfo NECROBOMB = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBN3CR0B0MB",
                    // Card display name.
                    "N3CR0B0MB",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Hold your breath for a few seconds after playing this one"
                )
                .SetCost(bloodCost: 0, bonesCost: 4, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_N3CR0B0MB.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.BombSpawner, Ability.ExplodeOnDeath)
                .SetDefaultEvolutionName("No?")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", NECROBOMB);
            }
            static void AddPL4YP3N()
            {
                CardInfo PLAYPEN = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBPL4YP3N",
                    // Card display name.
                    "PL4YP3N",
                    // Attack.
                    0,
                    // Health.
                    4,
                    // Descryption.
                    description: "Not the Best Baby sitter, but I'm sure you'll find a use for it"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 4)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_P14YP3N.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Sacrificial, Ability.SquirrelStrafe)
                .SetDefaultEvolutionName("PL5YP4N")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", PLAYPEN);
            }
            static void AddR3L04D()
            {
                CardInfo RELOAD = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBR3L04D",
                    // Card display name.
                    "R3L04D",
                    // Attack.
                    0,
                    // Health.
                    1,
                    // Descryption.
                    description: "Burns your hand and draws you a new one. Don't worry, I'll reattach your hand"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 4)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_R3L04D.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.DrawNewHand)
                .SetDefaultEvolutionName("R4L15D")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", RELOAD);
            }
            static void AddReanimatingRemains()
            {
                CardInfo ReanimatingRemains = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBReanimatingRemains",
                    // Card display name.
                    "Reanimating Remains",
                    // Attack.
                    2,
                    // Health.
                    1,
                    // Descryption.
                    description: "You put your left hand in, you put your left hand out, you put your left hand in and shake it all about"
                )
                .SetCost(bloodCost: 0, bonesCost: 3, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_ReanimatingRemains.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.DrawCopyOnDeath, Ability.Brittle)
                .SetDefaultEvolutionName("Uh why?")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", ReanimatingRemains);
            }
            static void AddS34RCHB0T()
            {
                CardInfo SEARCHBOT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBS34RCHB0T",
                    // Card display name.
                    "S34RCHB0T",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "SELECT FROM Deck.array WHERE Card.string = this ADDTO Hand.array"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_534RCHB0T.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Tutor)
                .SetDefaultEvolutionName("Just Google It")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SEARCHBOT);
            }
            static void AddS3NTRYDR0N3()
            {
                CardInfo SENTRYDRONE = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBS3NTRYDR0N3",
                    // Card display name.
                    "S3NTRY DR0N3",
                    // Attack.
                    0,
                    // Health.
                    1,
                    // Descryption.
                    description: "A fragile drone capable of first striking"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 1)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Sentry.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Sentry)
                .SetDefaultEvolutionName("S4NTRY DR1N4")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SENTRYDRONE);
            }
            static void AddSkeleton()
            {
                CardInfo Skeleton = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSkeleton",
                    // Card display name.
                    "Skeleton",
                    // Attack.
                    2,
                    // Health.
                    2,
                    // Descryption.
                    description: "There's one in your closet. Oh wait, that's mine"
                )
                .SetCost(bloodCost: 0, bonesCost: 1, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_skeleton.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Brittle)
                .SetDefaultEvolutionName("Skeletonne")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", Skeleton);
            }
            static void AddSkeletonArcher()
            {
                CardInfo SkeletonArcher = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSkeletonArcher",
                    // Card display name.
                    "Skeleton Archer",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "A sturdy enough Skeleton with a bow and eyes"
                )
                .SetCost(bloodCost: 0, bonesCost: 5, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SkeletonArcher.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Sniper, Ability.Sentry)
                .SetDefaultEvolutionName("Deathguard")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SkeletonArcher);
            }
            static void AddSkeletonGeneral()
            {
                CardInfo SkeletonGeneral = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSkeletonGeneral",
                    // Card display name.
                    "Skeleton General",
                    // Attack.
                    2,
                    // Health.
                    2,
                    // Descryption.
                    description: "As respected in death as they were in life"
                )
                .SetCost(bloodCost: 0, bonesCost: 6, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SkeletonGeneral.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.BuffNeighbours, Ability.DeathShield)
                .SetDefaultEvolutionName("Skeleton Lord")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SkeletonGeneral);
            }
            static void AddSkeletonMage()
            {
                CardInfo SkeletonMage = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSkeletonMage",
                    // Card display name.
                    "Skeleton Mage",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "A sturdy enough Skeleton with a good lookin Top Hat"
                )
                .SetCost(bloodCost: 0, bonesCost: 5, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SkeletonMage.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.SplitStrike, Ability.DrawRabbits)
                .SetDefaultEvolutionName("Skeleton Fraud")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SkeletonMage);
            }
            static void AddSkeletonWarrior()
            {
                CardInfo SkeletonWarrior = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSkeletonWarrior",
                    // Card display name.
                    "Skeleton Warrior",
                    // Attack.
                    2,
                    // Health.
                    1,
                    // Descryption.
                    description: "A very sturdy Skeleton with a shield"
                )
                .SetCost(bloodCost: 0, bonesCost: 5, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SkeletonWarrior.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.DeathShield)
                .SetDefaultEvolutionName("Deathknight")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SkeletonWarrior);
            }
            static void AddSlingerSquirrel()
            {
                CardInfo SlingerSquirrel = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSlingerSquirrel",
                    // Card display name.
                    "Slinger Squirrel",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "This one is quite dumb, its throwing it's lunch away"
                )
                .SetCost(bloodCost: 1, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SlingerSquirrel.png")
                .AddDecal("NevBBBB.png")
                .AddTribes(Tribe.Squirrel)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Sniper)
                .SetDefaultEvolutionName("Sir Peltsalot")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SlingerSquirrel);
            }
            static void AddSN1P3R()
            {
                CardInfo SNIPER = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSN1P3R",
                    // Card display name.
                    "SN1P3R",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "Don't chase its red dot"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Sniper.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Sniper)
                .SetDefaultEvolutionName("SN2P4R")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SNIPER);
            }
            static void AddSquirrelQueen()
            {
                CardInfo SquirrelQueen = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSquirrelQueen",
                    // Card display name.
                    "Squirrel Queen",
                    // Attack.
                    0,
                    // Health.
                    5,
                    // Descryption.
                    description: "Even a lowly squirrel can become a threat when led by their queen"
                )
                .SetCost(bloodCost: 2, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SquirrelQueen.png")
                .AddDecal("NevBBBB.png")
                .AddTribes(Tribe.Squirrel)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.DrawVesselOnHit, Ability.BuffNeighbours)
                .SetDefaultEvolutionName("Madam Squirrel")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SquirrelQueen);
            }
            static void AddSquirrelSkeleton()
            {
                CardInfo SquirrelSkeleton = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSquirrelSkeleton",
                    // Card display name.
                    "Squirrel Skeleton",
                    // Attack.
                    1,
                    // Health.
                    1,
                    // Descryption.
                    description: "Probably should've... fed that one"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_SquirrelSkeleton.png")
                .AddDecal("NevBBBB.png")
                .AddTribes(Tribe.Squirrel)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.QuadrupleBones, Ability.Brittle)
                .SetDefaultEvolutionName("It's dead Jim")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SquirrelSkeleton);
            }
            static void AddST04T()
            {
                CardInfo STOAT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBST04T",
                    // Card display name.
                    "ST04T",
                    // Attack.
                    1,
                    // Health.
                    3,
                    // Descryption.
                    description: "What a horrible amalgamation"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 2)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_ST04T.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("ST15T")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", STOAT);
            }
            static void AddST33LHYDR4()
            {
                CardInfo STEELHYDRA = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBST33LHYDR4",
                    // Card display name.
                    "ST33L HYDR4",
                    // Attack.
                    2,
                    // Health.
                    5,
                    // Descryption.
                    description: "You wouldn't steal a hydra."
                )
                .SetCost(bloodCost: 2, bonesCost: 0, energyCost: 6)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_ST33LHYDR4.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.TailOnHit, Ability.IceCube)
                .SetIceCube("BloodBoltsAndBatteriesCardPack_NevBBBST33LHYDR4")
                .SetDefaultEvolutionName("NevBBBST33LHYDR4")
                .SetTail("BloodBoltsAndBatteriesCardPack_NevBBBST33LHYDR4", "portrait_ST33LHYDR4.png")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", STEELHYDRA);
            }
            static void AddSummoningPortal()
            {
                CardInfo SummoningPortal = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBSummoningPortal",
                    // Card display name.
                    "Summoning Portal",
                    // Attack.
                    0,
                    // Health.
                    5,
                    // Descryption.
                    description: "Summoning infinite goats is a cheap trick"
                )
                .SetCost(bloodCost: 0, bonesCost: 6, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_portal.png")
                .AddDecal("NevBBBB.png")
                .AddTribes(Tribe.Hooved)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Sacrificial, Ability.TripleBlood)
                .SetDefaultEvolutionName("Portal 2 the portal")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", SummoningPortal);
            }
            static void AddT33N4G3R()
            {
                CardInfo TEENAGER = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBT33N4G3R",
                    // Card display name.
                    "T33N4G3R",
                    // Attack.
                    2,
                    // Health.
                    2,
                    // Descryption.
                    description: "A rebellious bot with a future"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 3)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_T33N4G3R.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Evolve)
                .SetEvolve("BloodBoltsAndBatteriesCardPack_NevBBB4DULT", 1)
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", TEENAGER);
            }
            static void AddTheSquarm()
            {
                CardInfo TheSquarm = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBTheSquarm",
                    // Card display name.
                    "The Squarm 3sigils",
                    // Attack.
                    0,
                    // Health.
                    8,
                    // Descryption.
                    description: "I heard you like squirrels"
                )
                .SetCost(bloodCost: 3, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_TheSquarm.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.SquirrelStrafe, Ability.DrawVesselOnHit, Ability.StrafePush)
                .AddTribes(Tribe.Squirrel)
                .SetDefaultEvolutionName("Squarmlord")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", TheSquarm);
            }
            static void AddWarriorSquirrel()
            {
                CardInfo WarriorSquirrel = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBWarriorSquirrel",
                    // Card display name.
                    "Warrior Squirrel",
                    // Attack.
                    1,
                    // Health.
                    2,
                    // Descryption.
                    description: "Aw, looks at its little shield"
                )
                .SetCost(bloodCost: 1, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_WarriorSquirrel.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.DeathShield)
                .AddTribes(Tribe.Squirrel)
                .SetDefaultEvolutionName("Squirrel William")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", WarriorSquirrel);
            }
            static void AddWaxyHusk()
            {
                CardInfo WaxyHusk = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBWaxyHusk",
                    // Card display name.
                    "Waxy Husk",
                    // Attack.
                    0,
                    // Health.
                    8,
                    // Descryption.
                    description: "See? Bee stings can mummify you"
                )
                .SetCost(bloodCost: 0, bonesCost: 4, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_WaxyHusk.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.Reach, Ability.BeesOnHit)
                .AddTribes(Tribe.Insect)
                .SetDefaultEvolutionName("Bee Daddy")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", WaxyHusk);
            }
            static void AddWhale()
            {
                CardInfo Whale = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBWhale",
                    // Card display name.
                    "Whale",
                    // Attack.
                    1,
                    // Health.
                    30,
                    // Descryption.
                    description: "Its no moon, but it'll make you feel like one"
                )
                .SetCost(bloodCost: 4, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Whale.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.Rare)
                .AddAbilities(Ability.WhackAMole, Ability.Reach)
                .SetDefaultEvolutionName("Whoa there buddy")
                .SetRare();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", Whale);
            }
            static void AddWorkerSquirrel()
            {
                CardInfo WorkerSquirrel = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBWorkerSquirrel",
                    // Card display name.
                    "Worker Squirrel",
                    // Attack.
                    0,
                    // Health.
                    2,
                    // Descryption.
                    description: "This one'll work for its spot on the board, it'll want some lunch however"
                )
                .SetCost(bloodCost: 1, bonesCost: 0, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_WorkerSquirrel.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .AddAbilities(Ability.GainBattery, Ability.Sacrificial)
                .AddTribes(Tribe.Squirrel)
                .SetDefaultEvolutionName("Business Squirrel")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", WorkerSquirrel);
            }
            static void AddY3T1B0T()
            {
                CardInfo YETIBOT = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBY3T1B0T",
                    // Card display name.
                    "Y3T1B0T",
                    // Attack.
                    4,
                    // Health.
                    5,
                    // Descryption.
                    description: "If only you had 2 innervates"
                )
                .SetCost(bloodCost: 0, bonesCost: 0, energyCost: 6)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Y3T1B0T.png")
                .AddDecal("NevBBBB.png")
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("Y33T1B0T")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", YETIBOT);
            }
            static void AddZombie()
            {
                CardInfo Zombie = CardManager.New(

                    // Card ID Prefix
                    modPrefix: "BloodBoltsAndBatteriesCardPack",
                    // Card internal name.
                    "NevBBBZombie",
                    // Card display name.
                    "Zombie",
                    // Attack.
                    1,
                    // Health.
                    3,
                    // Descryption.
                    description: "He's not really a zombie, the town drunk got loose again"
                )
                .SetCost(bloodCost: 0, bonesCost: 3, energyCost: 0)
                .SetCardTemple(CardTemple.Nature)
                .SetPortrait("portrait_Zombie.png")
                .AddDecal("NevBBBB.png")
                .AddAbilities(Ability.Strafe)
                .AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer)
                .SetDefaultEvolutionName("Irish Zombie")
                .SetDefaultPart1Card();
                CardManager.Add("BloodBoltsAndBatteriesCardPack", Zombie);
            }

            // --------------------------------------------------------------------------------------------------------------------------------------------------

        }
    }
}
