﻿using System;
using System.Collections.Generic;
using InazumaElevenSaveEditor.Logic;

namespace InazumaElevenSaveEditor.Common.InazumaElevenGo
{
    public static class Equipments
    {
        // Not Finished 
        public static IDictionary<UInt32, Equipment> Go = new Dictionary<UInt32, Equipment>
        {

        };

        public static IDictionary<UInt32, Equipment> Cs = new Dictionary<UInt32, Equipment>
        {
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Raimon Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Templar Shoe", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("School Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("Milky Way Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Faithy Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Royal Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("Pirate Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("Lunar Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Alpine Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Kirkwood Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("Mirage Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("Galactical Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Olympus Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Dragon Link Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("lighting Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("Ancestral Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Zero Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Reserve Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("Golden Age Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("Ivy Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Kids FC Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Arions Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("Omega Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("White deers Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Omega Z Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Zanark Domain Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("Perfect Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment("Zan Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment("Ghir Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment("Gahr Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment("Ragnarok Shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000000, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0})},
        };

        public static IDictionary<UInt32, Equipment> Galaxy = new Dictionary<UInt32, Equipment>
        {

        };
    }
}
