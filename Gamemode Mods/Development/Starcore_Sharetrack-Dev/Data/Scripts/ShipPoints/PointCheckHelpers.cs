﻿using System.Collections.Generic;

internal static class PointCheckHelpers
{
    public static Dictionary<string, bool> PdDictionary = new Dictionary<string, bool>
    {
        { "MA_T2PDX", true },
        { "MA_T2PDX_Slope", true },
        { "MA_T2PDX_Slope2", true },
        { "MA_Gimbal_Laser_T2", true },
        { "MA_Gimbal_Laser_T2_Armored", true },
        { "MA_Gimbal_Laser_T2_Armored_Slope", true },
        { "MA_Gimbal_Laser_T2_Armored_Slope2", true },
        { "MA_Gimbal_Laser_T2_Armored_Slope45", true },
        { "MA_PDX", true },
        { "MA_Gimbal_Laser", true },
        { "MA_Gimbal_Laser_Armored", true },
        { "MA_Gimbal_Laser_Armored_Slope", true },
        { "MA_Gimbal_Laser_Armored_Slope2", true },
        { "MA_Gimbal_Laser_Armored_Slope45", true },
        { "MA_PDT", true },
        { "MA_Fixed_000", true },
        { "MA_Fixed_001", true },
        { "MA_Fixed_002", true },
        { "MA_Fixed_007", true },
        { "MA_Fixed_003", true },
        { "MA_Fixed_004", true },
        { "MA_Fixed_005", true },
        { "MA_Fixed_006", true },
        { "MA_Fixed_T2", true },
        { "MA_Fixed_T2_Naked", true },
        { "SC_Flare", true },
        { "Starcore_RWR_Projectiles", true },
        { "SA_HMI_Erebos", true },
        { "Laser_Block", true },
        { "HAS_Crossfield", true },
        { "TaiidanHangarFighter", true },
        { "TaiidanRailFighter", true },
        { "Starcore_AMS_I_Block", true },
        { "LargeGatlingTurret_SC", true },
        { "PriestReskin_Block", true },
        { "Priest_Block", true },
        { "APE_Strong", true },
        { "NHI_PD_Turret", true },
        { "NHI_PD_Turret_Half", true },
        { "NHI_PD_Turret_Half_Slope_Top", true },
        { "NHI_PD_Turret_Half_Slope_Tip", true },
        { "NHI_PD_Turret_45_Slope", true },
        { "Starcore_AMS_II_Block", true }
    };

    public static Dictionary<string, bool> WeaponsDictionary = new Dictionary<string, bool>
    {
        { "MA_T2PDX", true },
        { "MA_T2PDX_Slope", true },
        { "MA_T2PDX_Slope2", true },
        { "MA_Gimbal_Laser_T2", true },
        { "MA_Gimbal_Laser_T2_Armored", true },
        { "MA_Gimbal_Laser_T2_Armored_Slope", true },
        { "MA_Gimbal_Laser_T2_Armored_Slope2", true },
        { "MA_Gimbal_Laser_T2_Armored_Slope45", true },
        { "MA_PDX", true },
        { "MA_Gimbal_Laser", true },
        { "MA_Gimbal_Laser_Armored", true },
        { "MA_Gimbal_Laser_Armored_Slope", true },
        { "MA_Gimbal_Laser_Armored_Slope2", true },
        { "MA_Gimbal_Laser_Armored_Slope45", true },
        { "MA_PDT", true },
        { "MA_Fixed_000", true },
        { "MA_Fixed_001", true },
        { "MA_Fixed_002", true },
        { "MA_Fixed_007", true },
        { "MA_Fixed_003", true },
        { "MA_Fixed_004", true },
        { "MA_Fixed_005", true },
        { "MA_Fixed_006", true },
        { "MA_Fixed_T2", true },
        { "MA_Fixed_T2_Naked", true },
        { "MA_AC150", true },
        { "MA_AC150_30", true },
        { "MA_AC150_45", true },
        { "MA_AC150_45_Gantry", true },
        { "MA_AC150_Gantry", true },
        { "MA_Gladius", true },
        { "MA_Fixed_T3", true },
        { "MA_Tiger", true },
        { "MA_Crouching_Tiger", true },
        { "K_SA_Gauss_APC", true },
        { "K_SA_Gauss_AMS", true },
        { "K_SA_Gauss_ERC", true },
        { "AMSlaser", true },
        { "ARYXGaussCannon", true },
        { "SC_AR_Eris", true },
        { "AWGGG", true },
        { "ARYXMagnetarCannon", true },
        { "SC_AR_MagnaStar", true },
        { "ARYXPlasmaPulser", true },
        { "SC_AR_Deimos", true },
        { "ARYXLargeRadar", true },
        { "ARYXBurstTurret", true },
        { "SC_AR_Phobos", true },
        { "SC_AR_Afflictor", true },
        { "ARYXBurstTurretSlanted", true },
        { "SC_AR_Afflictor_Slanted", true },
        { "BFG_M", true },
        { "BFTriCannon", true },
        { "K_SA_HeavyMetal_Gauss_ERII", true },
        { "K_SA_HeavyMetal_Gauss_ERIIRF", true },
        { "K_SA_Launcher_FixedMountv2", true },
        { "K_SA_Launcher_FixedMount", true },
        { "K_SA_LoW_CapitalSpinalA", true },
        { "K_SA_HeavyMetal_Gauss_ERFM", true },
        { "K_SA_HeavyMetal_Gauss_A", true },
        { "K_SA_HeavyMetal_Gauss_PGBC", true },
        { "ARYXTempestCannon", true },
        { "SC_AR_Tumult", true },
        { "ARYXLightCoilgun", true },
        { "SC_AR_Heliod", true },
        { "ARYXFocusLance", true },
        { "SC_AR_FocusedBeam", true },
        { "ARYXRailgun", true },
        { "SC_AR_Forager", true },
        { "Static150mm", true },
        { "MediumFocusLance", true },
        { "MA_PDX_sm", true },
        { "MA_PDT_sm", true },
        { "RotaryCannon", true },
        { "Starcore_PPC_Block", true },
        { "Starcore_AMS_II_Block", true },
        { "MA_Derecho", true },
        { "K_SA_Gauss_AMSIIC", true },
        { "SA_HMI_Erebos", true },
        { "HAS_Thanatos", true },
        { "HAS_Alecto", true },
        { "HAS_Assault", true },
        { "HAS_Mammon", true },
        { "HAS_Nyx", true },
        { "ARYXRailgunTurret", true },
        { "MCRNRailWeaponCountsB", true },
        { "K_SA_HeavyMetal_Spinal_Rotary", true },
        { "K_SA_HeavyMetal_Spinal_Rotary_Reskin", true },
        { "MetalStorm", true },
        { "Odin_Rail_2", true },
        { "Odin_Rail_1", true },
        { "MCRN_Heavy_Torpedo", true },
        { "OPA_Heavy_Torpedo", true },
        { "OPA_Light_Missile", true },
        { "UNN_Heavy_Torpedo", true },
        { "UNN_Light_Torpedo", true },
        { "Starcore_Fixed_Coil_Cannon", true },
        { "Starcore_AMS_I_Block", true },
        { "Odin_Torpedo", true },
        { "Odin_Missile_Battery", true },
        { "K_SA_Launcher_VIV", true },
        { "K_SA_Launcher_VI", true },
        { "Starcore_SSRM_Block", true },
        { "ModularSRM8", true },
        { "Starcore_MRM_Block", true },
        { "Starcore_MRM45_Block", true },
        { "ModularMRM10", true },
        { "ModularMiddleMRM10", true },
        { "ModularMRM10Angled", true },
        { "ModularMRM10AngledReversed", true },
        { "ModularLRM5", true },
        { "ModularLRM5Angled", true },
        { "ModularMiddleLRM5", true },
        { "ModularLRM5AngledReversed", true },
        { "Starcore_Arrow_Block", true },
        { "Odin_Laser_Fixed", true },
        { "Odin_Autocannon_Fixed", true },
        { "Odin_PDC", true },
        { "Odin_PDC_45_Slope", true },
        { "Odin_PDC_Half_Slope_Tip", true },
        { "Odin_PDC_Half", true },
        { "Odin_PDC_Half_Slope_Top", true },
        { "Odin_Defense_1x2", true },
        { "Odin_Gatling_Laser", true },
        { "Odin_5x5_Cannon", true },
        { "BlinkDriveLarge", true },
        { "Chet_Flak_Cannon", true },
        { "Odin_CoilCannon", true },
        { "Odin_Autocannon_2", true },
        { "Starcore_M_Laser_Block", true },
        { "Starcore_L_Laser_Block", true },
        { "Starcore_Basic_Warhead", true },
        { "Odin_7x7_Battleshipcannon", true },
        { "Odin_7x7_Battleshipcannon_Surface", true },
        { "Odin_5x5_Battleshipcannon", true },
        { "Odin_5x5_Battleshipcannon_Surface", true },
        { "Odin_3x3_Battleshipcannon", true },
        { "Odin_3x3_Battleshipcannon_Surface", true },
        { "JN_175Fixed", true },
        { "AMP_ArcMelee", true },
        { "AMP_ArcMeleeReskin", true },
        { "AMP_FlameThrower", true },
        { "AMP_CryoShotgun", true },
        { "Hexcannon", true },
        { "HakkeroBeam", true },
        { "HakkeroProjectile", true },
        { "HAS_Esper", true },
        { "HAS_Avenger", true },
        { "SC_Coil_Cannon", true },
        { "NHI_PD_Turret", true },
        { "NHI_PD_Turret_Half", true },
        { "NHI_PD_Turret_Half_Slope_Top", true },
        { "NHI_PD_Turret_Half_Slope_Tip", true },
        { "NHI_PD_Turret_45_Slope", true },
        { "NHI_Light_Autocannon_Turret", true },
        { "NHI_Autocannon_Turret", true },
        { "NHI_Gatling_Laser_Turret", true },
        { "NHI_Light_Railgun_Turret", true },
        { "NHI_Heavy_Gun_Turret", true },
        { "NHI_Mk3_Cannon_Turret", true },
        { "NHI_Mk3_Cannon_Surface_Turret", true },
        { "NHI_Mk2_Cannon_Turret", true },
        { "NHI_Mk2_Cannon_Surface_Turret", true },
        { "NHI_Mk1_Cannon_Turret", true },
        { "NHI_Mk1_Cannon_Surface_Turret", true },
        { "NHI_Fixed_Autocannon", true },
        { "NHI_Fixed_Gatling_Laser", true },
        { "NHI_Kinetic_Cannon_Turret", true },
        { "CLB2X", true },
        { "ERPPC", true },
        { "SC_COV_Plasma_Turret", true },
        { "banshee", true },
        { "TaiidanHangarHuge", true },
        { "TaiidanHangar", true },
        { "TaiidanHangarCompact", true },
        { "NHI_Fixed_Missile_Battery", true },
        { "HakkeroProjectileMini", true },
        { "HakkeroBeamMini", true },
        { "SLAM", true },
        { "TaiidanHangarFighter", true },
        { "TaiidanRailFighter", true },
        { "TaiidanRailBomber", true },
        { "TaiidanHangarBomber", true },
        { "TaiidanHangarBomberMedium", true },
        { "TaiidanSingleHangar", true },
        { "MA_Guardian", true },
        { "Laser_Block", true },
        { "Torp_Block", true },
        { "Heavy_Repeater", true },
        { "Fixed_Rockets", true },
        { "Assault_Coil_Turret", true },
        { "Light_Coil_Turret", true },
        { "RailgunTurret_Block", true },
        { "K_HS_9x9_K3_King", true },
        { "K_HS_9x9_HSRB_Dreadnight", true },
        { "Null_Point_Jump_Disruptor_Large", true },
        { "LargeMissileTurret_SC", true },
        { "LargeBlockMediumCalibreTurret_SC", true },
        { "LargeCalibreTurret_SC", true },
        { "LargeRailgun_SC", true },
        { "LargeBlockLargeCalibreGun_SC", true },
        { "LargeMissileLauncher_SC", true },
        { "NID_Pyroacid", true },
        { "NID_HeavyPyroacid", true },
        { "NID_Bioplasma", true },
        { "NID_Hivedrone", true },
        { "NID_BioplasmaHivedrone", true },
        { "NID_Leap", true },
        { "LightParticleWhip", true },
        { "ParticleWhip", true },
        { "NovaCannon", true },
        { "GothicTorp", true },
        { "MacroCannon", true },
        { "LanceBattery", true },
        { "LanceLightBattery", true },
        { "LanceHeavyBattery", true },
        { "longsword", true },
        { "65_Launcher_FixedMount", true },
        { "Hellfire_Laser_Block", true },
        { "HAS_Cyclops", true },
        { "Reaver_Coilgun", true },
        { "Type18_Artillery", true },
        { "Type21_Artillery", true },
        { "Type24_Artillery", true },
        { "Type19_Driver", true },
        { "Type22_Driver", true },
        { "Type25_Driver", true },
        { "MA_Blister", true },
        { "MA_Blister45", true },
        { "MA_Blister30", true },
        { "MA_Blister32", true },
        { "MA_Meatball", true },
        { "X4_7x7_HeavyTurret", true },
        { "VindicatorKineticLance", true },
        { "DualSnubLaserTurret", true },
        { "DualPulseLaserTurret", true },
        { "GoalieCasemate", true },
        { "HadeanPlasmaBlastgun", true },
        { "DrunkRocketTurret", true },
        { "KreegMagnetarCannon", true },
        { "HeavyFighterBay", true },
        { "Thagomizer", true },
        { "HeavyCarronade_5x5_Turret", true },
        { "UnguidedRocketTurret", true },
        { "NavalHeavyGaussRifle", true },
        { "Devastator_Torp", true },
        { "PriestReskin_Block", true },
        { "APE_Strong", true },
        { "HAS_Crossfield", true },
        { "SC_Flare", true },
        { "Starcore_RWR_Projectiles", true },
        { "Priest_Block", true }
    };

    public static bool NameplateVisible = true;
}