using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Reactive.Linq;
using System.Globalization;
using AutoUpdaterDotNET;

namespace Main_Menu
{
    public partial class Form1 : Form
    {
        string barrel = null;
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e) {
            NewFile.RestoreDirectory = true;
            NewFile.DefaultExt = "txt";
            NewFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            NewFile.Title = "New BL2 Mod";
            NewFile.CheckFileExists = false;
            NewFile.CheckPathExists = true;
            if(NewFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(NewFile.FileName);
                sw.Write(Environment.NewLine);
                sw.Close();
            }
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile.RestoreDirectory = true;
            OpenFile.DefaultExt = "txt";
            OpenFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFile.Title = "Open BL2 Mod";
            OpenFile.CheckFileExists = false;
            OpenFile.CheckPathExists = true;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string Mod = File.ReadAllText(OpenFile.FileName);
            }
        }
        private void SaveMod_Click(object sender, EventArgs e)
        {
            #region Setup
            NewFile.RestoreDirectory = true;
            NewFile.DefaultExt = "txt";
            NewFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            NewFile.Title = "Save BL2 Mod";
            NewFile.CheckFileExists = false;
            NewFile.CheckPathExists = true;
            #endregion
            if (NewFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(NewFile.FileName);
                #region Eridium Pick Up
                if (EridiumPickup.Checked == true)
                {
                    sw.WriteLine("set GD_Currency.A_Item.EridiumBar bAutomaticallyPickup True " + Environment.NewLine);
                    sw.WriteLine("set GD_Currency.A_Item.EridiumStick bAutomaticallyPickup True " + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_TorgueToken.UsableItems.Pickup_TorgueToken bAutomaticallyPickup True" + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_SeraphCrystal.UsableItems.Pickup_SeraphCrystal bAutomaticallyPickup True" + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_SeraphCrystal.UsableItems.Pickup_SeraphCrystal bAutomaticallyPickup True" + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_SeraphCrystal.UsableItems.Pickup_SeraphCrystal bAutomaticallyPickup True" + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_SeraphCrystal.UsableItems.Pickup_SeraphCrystal bAutomaticallyPickup True");
                }
                #endregion
                #region Weapon Stuff
                if (OrigWepName.Text == "12 Pounder")
                {
                    barrel = "GD_Orchid_BossWeapons.Launcher.L_Barrel_Torgue_12Pounder";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_12Pounder PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_12Pounder:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "1340 Shield")
                {
                    sw.WriteLine("set GD_Shields.Titles.Title_Absorption02_1341 PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Shields.Titles.Title_Absorption02_1341:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Aequitas")
                {
                    sw.WriteLine("set GD_Shields.Accessory.Title_Absorption03_Aequitas PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Shields.Accessory.Title_Absorption03_Aequitas:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Bad Touch")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Maliwan_BadTouch";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_BadTouch PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_BadTouch:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Bane")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Dahl_Bane";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Bane PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Bane:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Blockhead")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Tediore_Blockhead";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Blockhead PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Blockhead:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Bone Shredder")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Bandit_BoneShredder";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_BoneShredder PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_BoneShredder:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Boom Puppy")
                {
                    barrel = "GD_Iris_Weapons.AssaultRifles.AR_Barrel_Torgue_BoomPuppy";
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_BoomPuppy PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_BoomPuppy:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Buffalo")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Jakobs_Buffalo";
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "CHOPPER")
                {
                    barrel = "GD_Sage_Weapons.AssaultRifle.AR_Barrel_Vladof_Minigun_Chopper";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Chopper PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Chopper:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Chulainn")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Chulainn";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Chulainn PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Chulainn:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Chère-amie")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Hyperion_ChereAmie";
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Chere-amie PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Chere-amie:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Cobra")
                {
                    barrel = "GD_Iris_Weapons.SniperRifles.SR_Barrel_Dahl_Cobra";
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_Cobra PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_Cobra:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Commerce")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Tediore_Commerce";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Commerce PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Commerce:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Contraband Sky Rocket")
                {
                    sw.WriteLine("set GD_GrenadeMods.Title.Title_SkyRocket PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_GrenadeMods.Title.Title_SkyRocket:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Cracked Sash")
                {
                    sw.WriteLine("set GD_Shields.Titles.Title_Standard02_CrackedSash PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Shields.Titles.Title_Standard02_CrackedSash:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Creamer")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Maliwan_Creamer";
                    sw.WriteLine("set GD_Weap_Launchers.Name.Title.Title__Unique_Creamer PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Launchers.Name.Title.Title__Unique_Creamer:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Crit")
                {
                    sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title__Unique_Crit PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title__Unique_Crit:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    barrel = "GD_Aster_Weapons.SMGs.SMG_Barrel_Hyperion_Crit";
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Dahlminator")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Alien_Homing_Dahlminator";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Dahlminator PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Dahlminator:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }

                }
                else if (OrigWepName.Text == "Damned Cowboy")
                {
                    barrel = "GD_Sage_Weapons.AssaultRifle.AR_Barrel_Bandit_DamnedCowboy";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_DamnedCowboy PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_DamnedCowboy:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Deadly Bloom")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Deputy's Badge")
                {
                    sw.WriteLine("set GD_Shields.Titles.Title_ExplosiveNova02_DeadlyBloom PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Shields.Titles.Title_ExplosiveNova02_DeadlyBloom:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Dog")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Bandit_Dog";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Dog PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Dog:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Elephant Gun")
                {
                    barrel = "GD_Sage_Weapons.SniperRifles.SR_Barrel_Hyperion_ElephantGun";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_ElephantGun PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_ElephantGun:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Fibber - Shotgun")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Fibber.Pistol_Barrel_Bandit_Fibber_2";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Fibber PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Fibber:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Fibber - Ricochet")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Fibber.Pistol_Barrel_Bandit_Fibber_4";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Fibber PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Fibber:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Fibber - Crit")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Fibber.Pistol_Barrel_Bandit_Fibber_3";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Fibber PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Fibber:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Fireball")
                {
                    sw.WriteLine("set GD_Aster_GrenadeMods.Title.Title_Fireball PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_GrenadeMods.Title.Title_Fireball:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Tinderbox")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Dahl_Tinderbox";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Tinderbox PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Tinderbox:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Fremington's Edge")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Dahl_FremingtonsEdge";
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_FremingtonsEdge PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_FremingtonsEdge:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Fuster Cluck")
                {
                    sw.WriteLine("set GD_GrenadeMods.Title.Title_FusterCluck PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_GrenadeMods.Title.Title_FusterCluck:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Good Touch")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Maliwan_GoodTouch";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_GoodTouch PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_GoodTouch:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Greed")
                {
                    barrel = "GD_Orchid_BossWeapons.Pistol.Pistol_Barrel_ScarletsGreed";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_ScarletsGreed PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_ScarletsGreed:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Grog Nozzle")
                {
                    barrel = "GD_Aster_Weapons.Pistols.Pistol_Barrel_Bandit_GrogNozzle";
                    sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title__Unique_GrogNozzle PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title__Unique_GrogNozzle:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Gwen's Head")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Hyperion_GwensHead";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_GwensHead PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_GwensHead:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Hail")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Dahl_Hail";
                    sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title.Title_Unique_Hail PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title.Title_Unique_Hail:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Hive")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Torgue_TheHive";
                    sw.WriteLine("set GD_Weap_Launchers.Name.Title.Title__Unique_TheHive PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Launchers.Name.Title.Title__Unique_TheHive:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Hydra")
                {
                    barrel = "GD_Sage_Weapons.Shotgun.SG_Barrel_Bandit_Hydra";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Hydra PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Hydra:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Jolly Roger")
                {
                    barrel = "GD_Orchid_BossWeapons.Shotgun.SG_Barrel_Bandit_JollyRoger";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_JollyRoger PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_JollyRoger:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Judge")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Tediore_Judge";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Judge PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Judge:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Kiss of Death")
                {
                    sw.WriteLine("set GD_GrenadeMods.Title.Title_KissOfDeath PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_GrenadeMods.Title.Title_KissOfDeath:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Kitten")
                {
                    barrel = "GD_Iris_Weapons.AssaultRifles.AR_Barrel_Vladof_Kitten";
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_Kitten PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_Kitten:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Lady Fist")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Dahl_LadyFist";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_LadyFist PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_LadyFist:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Landscaper")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Jakobs_Landscaper";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Landscaper PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Landscaper:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Lascaux")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Bandit_Lascaux";
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Lascaux PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SMG.Name.Title.Title__Unique_Lascaux:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Law")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Dahl_Law";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Law PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Law:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Lightning Bolt")
                {
                    sw.WriteLine("set GD_Aster_GrenadeMods.Title.Title_LightningBolt PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_GrenadeMods.Title.Title_LightningBolt:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Little Evie")
                {
                    barrel = "GD_Orchid_BossWeapons.Pistol.Pistol_Barrel_Vladof_Evie";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_LittleEvie PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_LittleEvie:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Love Thumper")
                {
                    sw.WriteLine("set GD_Shields.Titles.Title_Roid03_LoveThumper PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Shields.Titles.Title_Roid03_LoveThumper:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Lucrative Opportunity")
                {
                    sw.WriteLine("set GD_Artifacts.A_Item_Unique.Artifact_Opportunity ItemName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Artifacts.A_Item_Unique.Artifact_Opportunity:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Magic Missile")
                {
                    sw.WriteLine("set GD_Aster_GrenadeMods.Title.Title_MagicMissile PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_GrenadeMods.Title.Title_MagicMissile:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Manly Man Shield")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Midnight Star")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Morningstar")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Maliwan_Morningstar";
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Morningstar PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Morningstar:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Moxxi's Endowment")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Octo")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Tediore_Octo";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Octo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Octo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Order")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Orphan Maker")
                {
                    barrel = "GD_Orchid_BossWeapons.Shotgun.SG_Barrel_Jakobs_OrphanMaker";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_OrphanMaker PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_OrphanMaker:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Pimpernel")
                {
                    barrel = "GD_Orchid_BossWeapons.SniperRifles.SR_Barrel_Dahl_Pimpernel";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_Pimpernel PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_Pimpernel:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Pocket Rocket")
                {
                    barrel = "GD_Iris_Weapons.Pistols.Pistol_Barrel_Torgue_PocketRocket";
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_PocketRocket PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_PocketRocket:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Pot O' Gold")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Rapier")
                {
                    barrel = "GD_Orchid_BossWeapons.AssaultRifle.AR_Barrel_Bandit_Rapier";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_Cutlass PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_Cutlass:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Rex")
                {
                    barrel = "GD_Sage_Weapons.Pistols.Pistol_Barrel_Jakobs_Rex";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Rex PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Rex:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Roaster")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Tediore_Roaster";
                    sw.WriteLine("set GD_Weap_Launchers.Name.Title.Title__Unique_Roaster PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set  GD_Weap_Launchers.Name.Title.Title__Unique_Roaster:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Rough Rider")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "RokSalt")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Jakobs_RockSalt";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_RokSalt PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_RokSalt:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Rubi")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Maliwan_Rubi";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Rubi PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Rubi:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Sandhawk")
                {
                    barrel = "GD_Orchid_BossWeapons.SMG.SMG_Barrel_Bandit_SandHawk";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_SandHawk PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_SandHawk:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Scorpio")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Jakobs_Scorpio";
                    sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title.Title_Unique_Scorpio PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title.Title_Unique_Scorpio:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Sheriff's Badge")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Shotgun 1340")
                {
                    barrel = " GD_Weap_Shotgun.Barrel.SG_Barrel_Tediore_Shotgun1340";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Shotgun1340 PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Shotgun1340:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Sloth")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Dahl_Sloth";
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Sloth PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Sloth:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Slow Hand")
                {
                    barrel = "GD_Iris_Weapons.Shotguns.SG_Barrel_Alien_SlowHand";
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_SlowHand PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Iris_Weapons.Name.Title.Title_Unique_SlowHand:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Stinkpot")
                {
                    barrel = "GD_Orchid_BossWeapons.AssaultRifle.AR_Barrel_Torgue_Stinkpot";
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_Stinkpot PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Orchid_BossWeapons.Name.Title.Title__Unique_Stinkpot:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Stomper")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Jakobs_Stomper";
                    sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Jakobs.Title_Unique_Stomper PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Jakobs.Title_Unique_Stomper:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "SWORDSPLOSION")
                {
                    barrel = "GD_Aster_Weapons.Shotguns.SG_Barrel_Alien_Swordsplosion";
                    sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title__Unique_Swordsplosion PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title__Unique_Swordsplosion:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Teapot")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Tediore_Teapot";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Teapot PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Teapot:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Teeth of Terramorphous")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Torgue_Teeth";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Teeth PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Teeth:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "The Afterburner")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Tidal Wave")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Jakobs_TidalWave";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_TidalWave PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_TidalWave:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Trespasser")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Hyperion_Trespasser";
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Trespasser PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Trespasser:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Triquetra")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Bandit_Triquetra";
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Triquetra PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Shotgun.Name.Title.Title__Unique_Triquetra:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Twister")
                {
                    barrel = "GD_Sage_Weapons.Shotgun.SG_Barrel_Torgue_Twister";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Twister PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_Twister:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Vault Hunter's Relic")
                {
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Jakobs_Buffalo:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                }
                else if (OrigWepName.Text == "Veritas")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Hyperion_Veritas";
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Veritas PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Weap_Pistol.Name.Title.Title__Unique_Veritas:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Yellow Jacket")
                {
                    barrel = "GD_Sage_Weapons.SMG.SMG_Barrel_Alien_YellowJacket";
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_YellowJacket PartName " + NewWepName.Text + Environment.NewLine);
                    sw.WriteLine("set GD_Sage_Weapons.Name.Title.Title_Unique_YellowJacket:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text + Environment.NewLine + Environment.NewLine);
                    if (FirinMode.Text != null)
                    {
                        sw.WriteLine("set " + barrel + " CustomFiringModeDefinition FiringModeDefinition'" + FirinMode.Text + "'" + Environment.NewLine);
                    }
                }
                else if (OrigWepName.Text == "Madhous!")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Bandit_Madhouse";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Bandit.Title_Legendary_Madhouse PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Bandit.Title_Legendary_Madhouse:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Gub")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Bandit_Gub";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Bandit.Title_Legendary_Gub PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Bandit.Title_Legendary_Gub:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Badaboom")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Bandit_BadaBoom";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Bandit.Title_Legendary_Badaboom PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Bandit.Title_Legendary_Badaboom:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Slagga")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Bandit_Slagga";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Bandit.Title_Legendary_Slagga PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Bandit.Title_Legendary_Slagga:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Sledge's Shotgun")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Jakobs_Sledges";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Bandit.Title_Legendary_Shotgun PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Bandit.Title_Legendary_Shotgun:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Veruc")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Dahl_Veruc";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Dahl.Title_Legendary_Veruc PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Dahl.Title_Legendary_Veruc:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Emperor")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Dahl_Emperor";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title.Title_Legendary_Dahl_Emperor PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title.Title_Legendary_Dahl_Emperor:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Pitchfork")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Dahl_Pitchfork";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Dahl.Title_Legendary_Pitchfork PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Dahl.Title_Legendary_Pitchfork:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Hornet")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Dahl_Hornet";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Dahl.Title_Legendary_Hornet PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Dahl.Title_Legendary_Hornet:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Mongol")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Vladof_Mongol";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Vladof.Title_Legendary_Mongol PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Vladof.Title_Legendary_Mongol:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Infinity")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Vladof_Infinity";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Vladof.Title_Legendary_Infinity PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Vladof.Title_Legendary_Infinity:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Shredifier")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Vladof_Shredifier";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Vladof.Title_Legendary_Shredifier PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Vladof.Title_Legendary_Shredifier:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Flakker")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Torgue_Flakker";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Torgue.Title_Legendary_Flakker PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Torgue.Title_Legendary_Flakker:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Nukem")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Torgue_Nukem";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Torgue.Title_Legendary_Nukem PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Torgue.Title_Legendary_Nukem:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Unkempt Harold")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Torgue_Calla";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Torgue.Title_Legendary_Calla PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Torgue.Title_Legendary_Calla:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Ogre")
                {
                    barrel = "GD_Aster_Weapons.AssaultRifles.AR_Barrel_Vladof_Ogre";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title_Unique_Ogre PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Aster_Weapons.Name.Title.Title_Unique_Ogre:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "KerBlaster")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Torgue_KerBlaster";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Torgue.Title_Legendary_KerBlaster PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Torgue.Title_Legendary_KerBlaster:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Baby Maker")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Tediore_BabyMaker";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Tediore.Title_Legendary_BabyMaker PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Tediore.Title_Legendary_BabyMaker:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Deliverance")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Tediore_Deliverance";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Tediore.Title_Legendary_Deliverance PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Tediore.Title_Legendary_Deliverance:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Bunny")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Tediore_Bunny";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Tediore.Title_Legendary_Bunny PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Tediore.Title_Legendary_Bunny:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Gunerang")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Tediore_Gunerang";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Tediore.Title_Legendary_Gunerang PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Tediore.Title_Legendary_Gunerang:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "HellFire")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Maliwan_HellFire";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Maliwan.Title_Legendary_HellFire PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Maliwan.Title_Legendary_HellFire:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Volcano")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Maliwan_Volcano";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Maliwan.Title_Legendary_Volcano PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Maliwan.Title_Legendary_Volcano:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Pyrophobia")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Maliwan_Pyrophobia";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Maliwan.Title_Legendary_Pyrophobia PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Maliwan.Title_Legendary_Pyrophobia:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Norfleet")
                {
                    barrel = "GD_Weap_Launchers.Barrel.L_Barrel_Alien_Maliwan_Norfleet";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Maliwan.Title_Barrel_Maliwan_Norfleet PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Launchers.Name.Title_Maliwan.Title_Barrel_Maliwan_Norfleet:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Thunderball Fists")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Maliwan_ThunderballFists";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Maliwan.Title_Legendary_ThunderballFists PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Maliwan.Title_Legendary_ThunderballFists:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Skullmasher")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Jakobs_Skullmasher";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Legendary_Skullmasher PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Jakobs.Title_Legendary_Skullmasher:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Striker")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Hyperion_Striker";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Jakobs.Title_Legendary_Striker PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Jakobs.Title_Legendary_Striker:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Maggie")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Jakobs_Maggie";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Jakobs.Title_Legendary_Maggie PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Jakobs.Title_Legendary_Maggie:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Hammerbuster")
                {
                    barrel = "GD_Weap_AssaultRifle.Barrel.AR_Barrel_Dahl_HammerBuster";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Jakobs.Title_Legendary_HammerBuster PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_AssaultRifle.Name.Title_Jakobs.Title_Legendary_HammerBuster:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Bitch")
                {
                    barrel = "GD_Weap_SMG.Barrel.SMG_Barrel_Hyperion_Bitch";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Hyperion.Title_Legendary_Bitch PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SMG.Name.Title_Hyperion.Title_Legendary_Bitch:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Longbow")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Alien_Longbow";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Longbow PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title.Title__Unique_Longbow:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Invader")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Hyperion_Invader";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Hyperion.Title_Legendary_Invader PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Hyperion.Title_Legendary_Invader:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Conference Call")
                {
                    barrel = "GD_Weap_Shotgun.Barrel.SG_Barrel_Hyperion_ConferenceCall";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Hyperion.Title_Legendary_ConferenceCall PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Shotgun.Name.Title_Hyperion.Title_Legendary_ConferenceCall:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Logan's Gun")
                {
                    barrel = "GD_Weap_Pistol.Barrel.Pistol_Barrel_Hyperion_LogansGun";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Hyperion.Title_Legendary_LogansGun PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_Pistol.Name.Title_Hyperion.Title_Legendary_LogansGun:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                else if (OrigWepName.Text == "Lyuda")
                {
                    barrel = "GD_Weap_SniperRifles.Barrel.SR_Barrel_Vladof_Lyudmila";
                    if (!string.IsNullOrWhiteSpace(NewWepName.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Vladof.Title_Legendary_Lyudmila PartName" + NewWepName);
                    }
                    if (!string.IsNullOrWhiteSpace(RedText.Text))
                    {
                        sw.WriteLine("set GD_Weap_SniperRifles.Name.Title_Vladof.Title_Legendary_Lyudmila:AttributePresentationDefinition_8 NoConstraintText " + RedText.Text);
                    }
                }
                #endregion
                #region Weapon Attribute Effects
                if(Attribute.Text != null)
                {
                    if(Attribute.Text == "Projectiles Per Shot")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects  ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponProjectilesPerShot',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000))");
                    }
                    else if(Attribute.Text == "Projectile Speed")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponProjectileSpeedMultiplier',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Weapon Damage")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponDamage',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000))");
                    }
                    else if(Attribute.Text == "Mag Size")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponClipSize',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Burst Count")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify'D_Attributes.WeaponAutomaticBurstCount',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Fire Rate")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponFireInterval',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Recoil")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponPerShotAccuracyImpulse',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Shot Cost")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponShotCost',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Extra Shot Chance")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponExtraShotChance',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Weapon Accuracy")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponSpread',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if(Attribute.Text == "Reload Speed")
                    {
                        sw.WriteLine("set " + barrel + " WeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponReloadSpeed',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" +AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                }
                #endregion
                #region Rarity
                if(Rarity != null)
                {
                    sw.WriteLine("set " + barrel + " rarity (BaseValueConstant=" + Rarity.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)");
                    sw.WriteLine("set WillowGame.GlobalsDefinition RarityLevelColors ((MinLevel=0,MaxLevel=0,Color=(B=175,G=193,R=205,A=0),DropLifeSpanType=DROP_ShortLived,RarityRating=RARITY_Unknown),(MinLevel=1,MaxLevel=1,Color=(B=255,G=255,R=255,A=255),DropLifeSpanType=DROP_ShortLived,RarityRating=RARITY_Common),(MinLevel=2,MaxLevel=2,Color=(B=11,G=210,R=61,A=255),DropLifeSpanType=DROP_LongLived,RarityRating=RARITY_Uncommon),(MinLevel=3,MaxLevel=3,Color=(B=255,G=142,R=60,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Rare),(MinLevel=4,MaxLevel=4,Color=(B=229,G=63,R=168,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_VeryRare),(MinLevel=5,MaxLevel=5,Color=(B=0,G=180,R=255,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Legendary),(MinLevel=6,MaxLevel=6,Color=(B=168,G=0,R=202,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_VeryRare),(MinLevel=7,MaxLevel=10,Color=(B=0,G=180,R=255,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Legendary),(MinLevel=12,MaxLevel=170,Color=(B=50,G=0,R=230,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Unknown),(MinLevel=171,MaxLevel=175,Color=(B=71,G=71,R=207,A=255),DropLifeSpanType=DROP_ShortLived,RarityRating=RARITY_Unknown),(MinLevel=176,MaxLevel=180,Color=(B=167,G=199,R=255,A=0),DropLifeSpanType=DROP_ShortLived,RarityRating=RARITY_Unknown),(MinLevel=181,MaxLevel=499,Color=(B=13,G=255,R=255,A=0),DropLifeSpanType=DROP_ShortLived,RarityRating=RARITY_Unknown),(MinLevel=500,MaxLevel=500,Color=(B=255,G=255,R=0,A=0),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Unknown),(MinLevel=501,MaxLevel=501,Color=(B=184,G=154,R=255,A=0),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Seraph),(MinLevel=502,MaxLevel=502,Color=(B=255,G=255,R=255,A=0),DropLifeSpanType=DROP_LiveAsLongAsLevel,RarityRating=RARITY_Unknown),(MinLevel=503,MaxLevel=503,Color=(B=200,G=50,R=145,A=255),DropLifeSpanType=DROP_LiveForever,RarityRating=RARITY_Unknown),(MinLevel=504,MaxLevel=504,Color=(B=255,G=255,R=0,A=0),DropLifeSpanType=DROP_VeryShortLived,RarityRating=RARITY_Unknown))");
                }
                #endregion
                #region External Attribute Effects
                if(External.Text != null)
                {
                    if(External.Text == "Convert Damage to Healing Percent")
                    {
                        sw.WriteLine("set " + barrel + " ExternalAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.DamageEnhancementModifiers.PlayerConvertDamageToHealingPercent',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + ExternalNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                }
                #endregion
                #region Gestalt Skeletal Mesh
                if(!string.IsNullOrWhiteSpace(Gestalt.Text))
                {
                    sw.WriteLine("set " + barrel + " GestaltModeSkeletalMeshName " + Gestalt.Text);
                }
                #endregion
                #region Grenade Damage Type
                if(checkBox2.Checked)
                {
                    sw.WriteLine("set " + barrel + " DamageTypeDefinition WillowDamageTypeDefinition'GD_Explosive.DamageType.DmgType_Explosive_Impact'" + Environment.NewLine);
                }
                #endregion
                #region Zoom Attribute Effects
                if (Zoom.Text != null)
                {
                    if (Zoom.Text == "Projectiles Per Shot")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects  ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponProjectilesPerShot',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000))");
                    }
                    else if (Zoom.Text == "Projectile Speed")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponProjectileSpeedMultiplier',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Weapon Damage")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponDamage',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000))");
                    }
                    else if (Zoom.Text == "Mag Size")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponClipSize',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Burst Count")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify'D_Attributes.WeaponAutomaticBurstCount',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Fire Rate")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponFireInterval',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Recoil")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponPerShotAccuracyImpulse',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Shot Cost")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponShotCost',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Extra Shot Chance")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponExtraShotChance',ModifierType=MT_PreAdd,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Weapon Accuracy")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponSpread',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                    else if (Zoom.Text == "Reload Speed")
                    {
                        sw.WriteLine("set " + barrel + " ZoomWeaponAttributeEffects ((AttributeToModify=AttributeDefinition'D_Attributes.Weapon.WeaponReloadSpeed',ModifierType=MT_Scale,BaseModifierValue=(BaseValueConstant=" + AttributeNum.Value + ",BaseValueAttribute=None,InitializationDefinition=None,BaseValueScaleConstant=1.000000)))");
                    }
                }
                #endregion
                sw.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e) 
        {
            var timer = Observable.Interval(TimeSpan.FromSeconds(1));
            Random rnd = new Random();
            timer.Subscribe(l => linkLabel1.LinkColor = Color.FromArgb(rnd.Next(0,256),rnd.Next(0,256),rnd.Next(0,256)));
            timer.Subscribe(l => linkLabel1.VisitedLinkColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            timer.Subscribe(l => linkLabel1.DisabledLinkColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            if(File.Exists(Directory.GetCurrentDirectory() + "\\Settings.ini"))
            {
                var cvt = new FontConverter();
                string fontsetting = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Settings.ini");
                string dark = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Dark.ini");
                var PrintFont = cvt.ConvertFrom(fontsetting) as Font;
                fontDialog1.Font = PrintFont;
                FontSet();
                if(dark.Contains("DarkEnable"))
                {
                    DarkEnable();
                }
            }
            AutoUpdater.Start("https://raw.githubusercontent.com/FromDarkHell/-/master/updates/bl2cpf.xml");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitch.tv/fromdarkhell");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BL2CP/BLCMods");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                FontSet();
                if (!File.Exists(Directory.GetCurrentDirectory() + "\\Settings.ini"))
                {
                    var FontConvert = new FontConverter();
                    string Font = FontConvert.ConvertToString(fontDialog1.Font);
                    byte[] Beet = Encoding.UTF8.GetBytes(Font);
                    File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\Settings.ini", Beet);
                }
            }
        }
        public void FontSet()
        {
            EridiumPickup.Font = fontDialog1.Font;
            label2.Font = fontDialog1.Font;
            OrigWepName.Font = fontDialog1.Font;
            label4.Font = fontDialog1.Font;
            NewWepName.Font = fontDialog1.Font;
            label3.Font = fontDialog1.Font;
            RedText.Font = fontDialog1.Font;
            label12.Font = fontDialog1.Font;
            Rarity.Font = fontDialog1.Font;
            label5.Font = fontDialog1.Font;
            FirinMode.Font = fontDialog1.Font;
            label11.Font = fontDialog1.Font;
            label6.Font = fontDialog1.Font;
            Attribute.Font = fontDialog1.Font;
            label7.Font = fontDialog1.Font;
            AttributeNum.Font = fontDialog1.Font;
            label10.Font = fontDialog1.Font;
            label8.Font = fontDialog1.Font;
            External.Font = fontDialog1.Font;
            ExternalNum.Font = fontDialog1.Font;
            label9.Font = fontDialog1.Font;
            label13.Font = fontDialog1.Font;
            Gestalt.Font = fontDialog1.Font;
            label14.Font = fontDialog1.Font;
            linkLabel1.Font = fontDialog1.Font;
            label15.Font = fontDialog1.Font;
            linkLabel2.Font = fontDialog1.Font;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                DarkEnable();
                FontSet();
                string Dark = "DarkEnable";
                byte[] toBits = Encoding.UTF8.GetBytes(Dark);
                if (!File.Exists(Directory.GetCurrentDirectory() + "\\Dark.ini"))
                {
                    File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\Dark.ini", toBits);
                }
                var FontConvert = new FontConverter();
            }
            else
            {
                this.BackColor = Color.White;
                General.BackColor = Color.White;
                WepCard.BackColor = Color.White;
                WepBarrel.BackColor = Color.White;
                Settings.BackColor = Color.White;
                About.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                EridiumPickup.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                OrigWepName.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                NewWepName.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                RedText.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                Rarity.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                FirinMode.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                Attribute.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                AttributeNum.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                External.ForeColor = Color.Black;
                ExternalNum.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                Gestalt.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                linkLabel2.LinkColor = Color.Black;
                if (!File.Exists(Directory.GetCurrentDirectory() + "\\Dark.ini"))
                {
                    File.Create(Directory.GetCurrentDirectory() + "\\Dark.ini");
                }
                var FontConvert = new FontConverter();
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\Dark.ini","DarkDisable");
            }
        }
        public void DarkEnable()
        {
            this.BackColor = Color.Black;
            General.BackColor = Color.Black;
            WepCard.BackColor = Color.Black;
            checkBox1.ForeColor = Color.White;
            WepBarrel.BackColor = Color.Black;
            Settings.BackColor = Color.Black;
            About.BackColor = Color.Black;
            EridiumPickup.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.White;
        }
    }
}
