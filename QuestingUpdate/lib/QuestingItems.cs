﻿using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using QuestingUpdate.lib.scripts;
using QuestingUpdate.lib.storage;

namespace QuestingUpdate.lib
{
    class QuestingItems
    {
        public void InitItems()
        {
            CreateItem("CobaltIngot", 20, "Cobalt Ingot",
                "Used in production to produce base components \r\n" + "Part of the Questing Update",
                "6939388A466C45B899EEF83634EEA6C6", "TitaniumIngot", Sprite2("Resources/Ingots/CobaltIngot.png"));
            CreateItem("CobaltOre", 100, "Cobalt Ore",
            "The Base Ore for Cobalt Ingots \r\n" + "Part of the Questing Update",
            "F614E50F801E4806943C8AEEDE851680", "TitaniumOre", Sprite2("Resources/Ore/CobaltOre.png"));
            CreateItem("BronzeIngot", 50, "Bronze Ingot",
            "An Alloy of Copper and Tin \r\n" + "Part of the Questing Update",
            "B336DD641E644F54847FCFEDA51AD91A", "CopperIngot", Sprite2("Resources/Ingots/BronzeIngot.png"));
            CreateItem("TinIngot", 50, "Tin Ingot",
            "A Lightweight and Flimsy Metal \r\n" + "Part of the Questing Update",
            "894431113D60413AA9996840E2C17873", "CopperIngot", Sprite2("Resources/Ingots/TinIngot.png"));
            CreateItem("TinOre", 100, "Tin Ore",
            "The Base Ore for Tin Ingots \r\n" + "Part of the Questing Update",
            "75B8677E7AB04B19AB44BB9CD513E3E1", "CopperOre", Sprite2("Resources/Ore/TinOre.png"));
            CreateItem("SteelIngot", 50, "Steel Ingot",
            "A Lightweight and Strong Alloy \r\n" + "Part of the Questing Update",
            "A810DD6B32D64081B84029724C9496AC", "IronIngot", Sprite2("Resources/Ingots/SteelIngot.png"));
            CreateItem("BronzeBolts", 99, "Bronze Bolts",
            "Alloyed Bolts, Stronger than those of Copper or Tin \r\n" + "Part of the Questing Update",
            "E8C57A5C658E42ECAED404FB2B92A6DD", "CopperBolts", Sprite2("Resources/Items/BronzeBolts.png"));
            CreateItem("BronzePlates", 99, "Bronze Plates",
            "Alloyed Plates, Stronger than those of Copper or Tin \r\n" + "Part of the Questing Update",
            "ABCFA112CE1E4A358C8FFEA726686E93", "CopperPlates", Sprite2("Resources/Items/BronzePlates.png"));
            CreateItem("BronzeTubes", 99, "Bronze Tubes",
            "Alloyed Tubes, Stronger than those of Copper or Tin \r\n" + "Part of the Questing Update",
            "004199204E964EFBA4599E2F7A8BF5C2", "CopperTubes", Sprite2("Resources/Items/BronzeTubes.png"));
            CreateItem("CobaltBolts", 99, "Cobalt Bolts",
            "Shiny Blue Bolts \r\n" + "Part of the Questing Update",
            "7447972B67FA47F28673BA5135827B92", "TitaniumBolts", Sprite2("Resources/Items/CobaltBolts.png"));
            CreateItem("CobaltPlates", 99, "Cobalt Plates",
            "Shiny Blue Plates \r\n" + "Part of the Questing Update",
            "A1F8674359484C92AFFC6B67BD8FA1F4", "TitaniumPlates", Sprite2("Resources/Items/CobaltPlates.png"));
            CreateItem("CobaltTubes", 99, "Cobalt Tubes",
            "Shiny Blue Tubes \r\n" + "Part of the Questing Update",
            "843209B8B0F5409F843EB660AC69535B", "TitaniumTubes", Sprite2("Resources/Items/CobaltTubes.png"));
            CreateItem("SteelBolts", 99, "Steel Bolts",
            "Alloyed Bolts, Stronger than those of Iron \r\n" + "Part of the Questing Update",
            "3F660A0559474433A6E2A91E0C7D62C6", "IronBolts", Sprite2("Resources/Items/SteelBolts.png"));
            CreateItem("SteelPlates", 99, "Steel Plates",
            "Alloyed Plates, Stronger than those of Iron \r\n" + "Part of the Questing Update",
            "704B9BE418024F64BFA8F4CAC549DAB3", "IronPlates", Sprite2("Resources/Items/SteelPlates.png"));
            CreateItem("SteelTubes", 99, "Steel Tubes",
            "Alloyed Tubes, Stronger than those of Iron \r\n" + "Part of the Questing Update",
            "FC6A2C44E9B94320BFF9813306DF53DF", "IronTubes", Sprite2("Resources/Items/SteelTubes.png"));
            CreateItem("TinBolts", 99, "Tin Bolts",
            "Shiny White Bolts, Very Weak \r\n" + "Part of the Questing Update",
            "342B6C85C6D44AC58B89269E41F50E66", "CopperBolts", Sprite2("Resources/Items/TinBolts.png"));
            CreateItem("TinPlates", 99, "Tin Plates",
            "Shiny White Plates, Very Weak \r\n" + "Part of the Questing Update",
            "EF40281A91D54F519452E205D343EADD", "CopperPlates", Sprite2("Resources/Items/TinPlates.png"));
            CreateItem("TinTubes", 99, "Tin Tubes",
            "Shiny White Tubes, Very Weak \r\n" + "Part of the Questing Update",
            "F51DB9FAEA524382A6EF69C540923127", "CopperTubes", Sprite2("Resources/Items/TinTubes.png"));
            CreateItem("NullItem", 1000, "Null Item",
                "This item is to indicate that an item is null",
                "29B8BE6CAB6E43BB99ED496C06553B0A", "IronIngot", Sprite2("Resources/Icon/QuestingLogo.png"));

            // Tier 1 Upgrades
            CreateItem("UpgradeResourceRefining1", 5, "Basic Resource Refining Upgrade", "The Upgrade to Allow for Further Resource Refining \r\n" + "Part of the Questing Update",
                "DA9BBD26D3A44E3DA094BEA4BE6D0B90", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/ResourceRefining.png"));
            CreateItem("UpgradeCopperworking", 5, "Copperworking Upgrade", "The Upgrade to Allow Production of Copper Parts \r\n" + "Part of the Questing Update",
                "16AE4FFC37F044C7B31E6D37726763E0", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/Copperworking.png"));
            CreateItem("UpgradeCopperArmor", 5, "Copper Armor Upgrade", "The Upgrade to Allow Production of Copper Armor \r\n" + "Part of the Questing Update",
                "E4D83E8A4AAC419DA0E09CBF710B40FF", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/CopperArmor.png"));
            CreateItem("UpgradeSimpleWeapons", 5, "Simple Weapons Upgrade", "The Upgrade to Allow Production of Simple Weaponry \r\n" + "Part of the Questing Update",
                "C7A3B3ED36884410A4E61D99B7D91B88", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/SimpleWeapons.png"));
            CreateItem("UpgradeBasicAlloying", 5, "Basic Alloying Upgrade", "The Research Behind the Alloys of this World \r\n" + "Part of the Questing Update",
                "FBF4F9DCA52C4683A1AB998104357E9F", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/BasicAlloying.png"));
            CreateItem("UpgradeAlloyForge1", 5, "Alloy Forge 1 Upgrade", "The Research for Creation of Alloys \r\n" + "Part of the Questing Update",
                "FF35E3D91A0F413ABDC957705190CD2B", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/AlloyForge1.png"));
            CreateItem("UpgradeBronzeworking", 5, "Bronzeworking Upgrade", "The Research for Manipulation of Bronze \r\n" + "Part of the Questing Update",
                "E23517F2F1224360AE37A85F630F59A5", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/Bronzeworking.png"));
            CreateItem("UpgradeTurretsTier1", 5, "Tier 1 Turrets Upgrade", "The Research for the Creation of Turrets \r\n" + "Part of the Questing Update",
                "8D320595B3D1419B9A84104A01C2ADBD", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/TurretsTier1.png"));
            CreateItem("UpgradeBronzeArmor", 5, "Bronze Armor Upgrade", "The Research for the Creation of Bronze Armor \r\n" + "Part of the Questing Update",
                "5D8EB28412594FC0A173042DE8DA39F4", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/BronzeArmor.png"));
            CreateItem("UpgradeDrillshipParts1", 5, "Drillship Parts 1 Upgrade", "The Research for the Creation of Tier 2 Drillship Parts \r\n" + "Part of the Questing Update",
                "B7B1EF06BF1E484383863687DCAD6FD8", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/DrillshipParts1.png"));
            CreateItem("UpgradeAdvancedTurrets1", 5, "Advanced Turrets 1 Upgrade", "The Research for the Creation of Advanced Turrets \r\n" + "Part of the Questing Update",
                "09F0ADFEDF734F39AEC98700F117B6F2", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T1/AdvancedTurrets1.png"));
            CreateItem("UpgradeNull", 5, "Null Upgrade", "The Upgrade to Alloy for Further Resource Refining \r\n" + "Part of the Questing Update",
                "D3DEA69A69BF47CC9893D88EB6565D48", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/NullSchematic.png"));

            // Tier 2 Upgrades
            CreateItem("UpgradeIronRefining", 5, "Iron Refining Upgrade", "Iron... It's just... Iron \r\n" + "Part of the Questing Update",
                "A2F41C4439B44BD9B6F7661A49F4BBC6", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/IronRefining.png"));
            CreateItem("UpgradeIronworking", 5, "Ironworking Upgrade", "Iron into Ingots? Absolutly! \r\n" + "Part of the Questing Update",
                "72494C7FF1654A8B81A4D2F8F3CDDAC0", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/Ironworking.png"));
            CreateItem("UpgradeAdvancedIronParts", 5, "Advanced Iron Parts Upgrade", "Iron isn't useless right? Wrong! \r\n" + "Part of the Questing Update",
                "84025220E5CD4C729B63BB8EF50F9EE0", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/AdvancedIronParts.png"));
            CreateItem("UpgradeIronArmor", 5, "Iron Armor Upgrade", "The Research for the Creation of Iron Armor \r\n" + "Part of the Questing Update",
                "00F785F49BDF4272855FEF7253F660A3", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/IronArmor.png"));
            CreateItem("UpgradeResourceRefining2", 5, "Advanced Resource Refining Upgrade", "Need Resources? We got those. \r\n" + "Part of the Questing Update",
                "D7556249DC4E4FF899ABCFCEDC0F7E30", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/ResourceRefining2.png"));
            CreateItem("UpgradeAdvancedAlloying", 5, "Advanced Alloying Upgrade", "The Research Behind the Advanced Alloys of this World \r\n" + "Part of the Questing Update",
                "667E1658F21942008E5F2DAE964EC27D", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/AdvancedAlloying.png"));
            CreateItem("UpgradeAlloyForge2", 5, "Alloy Forge 2 Upgrade", "The Research for Creation of Iron Alloys \r\n" + "Part of the Questing Update",
                "0DBAB60356DC4BF091E068BC98F9506B", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/AlloyForge2.png"));
            CreateItem("UpgradeSteelworking", 5, "Steelworking Upgrade", "The Research for the Manipulation of Steel \r\n" + "Part of the Questing Update",
                "60B0343DED18402BAB64B3F14F58C7E8", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/Steelworking.png"));
            CreateItem("UpgradeSteelArmor", 5, "Steel Armor Upgrade", "The Research for the Creation of Steel Armor \r\n" + "Part of the Questing Update",
                "0B57AA5FCC484DF2A05329A644B1D052", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/SteelArmor.png"));
            CreateItem("UpgradeImprovedWeapons", 5, "Improved Weapons Upgrade", "The Research for the Creation of Better Weapons \r\n" + "Part of the Questing Update",
                "F676A8F8A6964CD89AC7A015614B288A", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/ImprovedWeapons.png"));
            CreateItem("UpgradeTurretsTier2", 5, "Tier 2 Turrets Upgrade", "The Research for the Creation of Better Weapons \r\n" + "Part of the Questing Update",
                "B1EF9CC1DB5843ABBAD7A25C9C1DFD02", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/TurretsTier2.png"));
            CreateItem("UpgradeAdvancedTurrets2", 5, "Advanced Turrets 2 Upgrade", "The Research for the Creation of Even More Advanced Turrets \r\n" + "Part of the Questing Update",
                "887DA322DAA9466ABEDDA514E7C7B139", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/AdvancedTurrets2.png"));
            CreateItem("UpgradeDrillshipParts2", 5, "Drillship Parts 2 Upgrade", "The Research for the Creation of Tier 3 Drillship Parts \r\n" + "Part of the Questing Update",
                "F04E93F446F94C43BC3577E244AE737B", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T2/DrillshipParts2.png"));


            // Tier 3 Upgrades
            CreateItem("UpgradeExpertAlloying", 5, "Expert Alloying Upgrade", "The Research Behind the Expert Alloys of this World \r\n" + "Part of the Questing Update",
                "0FD0950108794340B738F103E4DA244A", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/ExpertAlloying.png"));
            CreateItem("UpgradeResourceRefining3", 5, "Perfect Resource Refining Upgrade", "The Upgrade to Allow for Further Resource Refining \r\n" + "Part of the Questing Update",
                "9FB8134FF4AA441987F134B74AB26BE1", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/ResourceRefining3.png"));
            CreateItem("UpgradeCobaltRefining", 5, "Cobalt Refining Upgrade", "The Upgrade to Allow for Cobalt Refining \r\n" + "Part of the Questing Update",
                "42E5F6D3E789436EBB24FC590EB997C6", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/CobaltRefining.png"));
            CreateItem("UpgradeCobaltworking", 5, "Cobaltworking Upgrade", "The Upgrade to Allow for the manipulation of Cobalt\r\n" + "Part of the Questing Update",
                "E2AC066575314C2CB312C889277A22D2", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/Cobaltworking.png"));
            CreateItem("UpgradeAdvancedCobaltParts", 5, "Advanced Cobalt Parts Upgrade", "The Upgrade to Allow for the production of Advanced Cobalt Parts\r\n" + "Part of the Questing Update",
                "594BDE909D34459AAEA8313DF73BD94B", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/AdvancedCobaltParts.png"));
            CreateItem("UpgradeAlloyingTier3", 5, "Alloying Tier 3 Upgrade", "The Research for the Production of Titanium\r\n" + "Part of the Questing Update",
                "A5FDC05B014B4AE79B3C71944C71FF36", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/AlloyingTier3.png"));
            CreateItem("UpgradeTitanworking", 5, "Titanworking Upgrade", "The Research for the Manipulation of Titanium\r\n" + "Part of the Questing Update",
                "83499CF8DE544195B3947AF0DE637C5E", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/Titanworking.png"));
            CreateItem("UpgradeCobaltArmor", 5, "Cobalt Armor Upgrade", "The Research for the Creation of Cobalt Armor\r\n" + "Part of the Questing Update",
                "BC561A213B4A4EC3812BBCE66ECA6CEF", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/CobaltArmor.png"));
            CreateItem("UpgradeTitanArmor", 5, "Titan Armor Upgrade", "The Research for the Creation of Titanium Armor\r\n" + "Part of the Questing Update",
                "EFFB2AE586BD451E9DFCF7B1A3AEE9D1", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/TitanArmor.png"));
            CreateItem("UpgradeAdvancedWeapons", 5, "Advanced Weapons Upgrade", "The Research for the Creation of Super Weapons\r\n" + "Part of the Questing Update",
                "A1063F0ABDE144039B1105C262B7A978", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/AdvancedWeapons.png"));
            CreateItem("UpgradeTurretsTier3", 5, "Tier 3 Turrets Upgrade", "The Research for the Creation of Super Turrets\r\n" + "Part of the Questing Update",
                "391CBCB9A49C4C8BAFCD3CF5FC46881A", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/TurretsTier3.png"));
            CreateItem("UpgradeAdvancedTurrets3", 5, "Advanced Turrets 3 Upgrade", "The Research for the Creation of Super Turrets\r\n" + "Part of the Questing Update",
                "D79640D61ED141FAB724FAC0AE12BB76", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/AdvancedTurrets3.png"));
            CreateItem("UpgradeDrillshipParts3", 5, "Drillship Parts 3 Upgrade", "The Research for the Creation of Tier 3 Drillship Parts\r\n" + "Part of the Questing Update",
                "FFC4F1CD59EF4B28A51F763FC8AEDCFC", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/DrillshipParts3.png"));
            CreateItem("UpgradeDrill4", 5, "Ultimate Drill Upgrade", "The Research for the Creation of the Ultimate Drill\r\n" + "Part of the Questing Update",
                "0E7B523219484E6C95B7CCDBB95D4F7C", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/Drill4.png"));
            CreateItem("UpgradeHeatResistance", 5, "Heat Resistance Upgrade", "The Research for the Creation of Heat Resistant Armor\r\n" + "Part of the Questing Update",
                "49AE0A78605B44BCBFDE86B00D9E963B", "UpgradeStarterRefinery", Sprite2("Resources/Schematics/T3/HeatResistance.png"));

            QuestLog.Log("[Questing Update | Items]: Items Loaded...");

            Debug.Log("[Questing Update | Items]: Items Loaded...");
        }

        private static void Initialize<T>(ref T str)
        where T : struct, ISerializationCallbackReceiver
        {
            str.OnAfterDeserialize();
        }
        private Sprite Sprite2(string iconpath)
        {
            var path = System.IO.Path.Combine(Application.persistentDataPath, "Mods", iconpath);
            if (!File.Exists(path))
            {
                QuestLog.Log("ERROR: [Questing Update | Items]: Specified Icon path not found: " + path);

                Debug.LogError("[Questing Update | Items]: Specified Icon path not found: " + path);
                return null;
            }
            var bytes = File.ReadAllBytes(path);


            var texture = new Texture2D(512, 512, TextureFormat.ARGB32, true);
            texture.LoadImage(bytes);

            var sprite = Sprite.Create(texture, new Rect(Vector2.zero, Vector2.one * texture.width), new Vector2(0.5f, 0.5f), texture.width, 0, SpriteMeshType.FullRect, Vector4.zero, false);
            return sprite;
        }

        private void CreateItem(string codename, int maxstack, LocalizedString name, LocalizedString desc, string guidstring, string recipecategoryname, Sprite icon)
        {
            var recipecategory = GameResources.Instance.Items.FirstOrDefault(s => s.name == recipecategoryname);

            var item = ScriptableObject.CreateInstance<ItemDefinition>();
            item.name = codename;
            item.Category = recipecategory.Category;
            item.MaxStack = maxstack;
            item.Icon = icon;
            LocalizedString nameStr = name;
            LocalizedString descStr = desc;
            Initialize(ref nameStr);
            Initialize(ref descStr);

            typeof(ItemDefinition).GetField("m_name", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(item, nameStr);
            typeof(ItemDefinition).GetField("m_description", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(item, descStr);

            var guid = GUID.Parse(guidstring);

            typeof(Definition).GetField("m_assetId", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).SetValue(item, guid);

            AssetReference[] assets = new AssetReference[] { new AssetReference() { Object = item, Guid = guid, Labels = new string[0] } };
            RuntimeAssetStorage.Add(assets, default);

            QuestingDict.questingRegistry[codename] = guid;
            QuestLog.Log("[Questing Update | Items]: Item " + codename + " has been loaded");
        }
    }
}
