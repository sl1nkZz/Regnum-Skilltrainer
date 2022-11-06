using Regnum_Skilltrainer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Regnum_Skilltrainer
{

    public partial class Form1 : Form
    {
        List<string> subclass_list;
        public int[,] levelPoints = new int[60, 2] { { 0, 4 }, { 1, 4 }, { 3, 4 }, { 6, 4 }, { 10, 5 }, { 15, 6 }, { 21, 7 }, { 28, 8 }, { 36, 9 }, { 45, 12 }, { 56, 13 }, { 68, 14 }, { 81, 15 }, { 96, 16 }, { 112, 17 }, { 129, 18 }, { 148, 19 }, { 168, 20 }, { 189, 21 }, { 211, 22 }, { 234, 23 }, { 258, 24 }, { 283, 25 }, { 309, 26 }, { 336, 27 }, { 364, 28 }, { 393, 29 }, { 423, 30 }, { 454, 31 }, { 486, 32 }, { 519, 33 }, { 553, 34 }, { 588, 35 }, { 624, 36 }, { 661, 37 }, { 700, 38 }, { 740, 39 }, { 781, 40 }, { 823, 41 }, { 866, 43 }, { 910, 45 }, { 955, 47 }, { 1001, 49 }, { 1048, 51 }, { 1096, 53 }, { 1145, 55 }, { 1195, 57 }, { 1246, 59 }, { 1298, 61 }, { 1351, 65 }, { 1386, 67 }, { 1421, 69 }, { 1456, 71 }, { 1491, 73 }, { 1526, 75 }, { 1561, 77 }, { 1596, 79 }, { 1631, 81 }, { 1666, 83 }, { 1703, 85 } };
        public int[,] levelPointsMage = new int[60, 2] { { 0, 4 }, { 1, 4 }, { 3, 4 }, { 6, 4 }, { 10, 5 }, { 15, 6 }, { 21, 7 }, { 35, 8 }, { 45, 9 }, { 56, 13 }, { 68, 14 }, { 81, 15 }, { 96, 16 }, { 112, 17 }, { 129, 18 }, { 147, 19 }, { 166, 20 }, { 187, 21 }, { 210, 22 }, { 234, 23 }, { 259, 24 }, { 286, 25 }, { 314, 26 }, { 343, 27 }, { 374, 28 }, { 406, 29 }, { 439, 30 }, { 474, 31 }, { 511, 32 }, { 549, 33 }, { 588, 34 }, { 629, 35 }, { 671, 36 }, { 714, 37 }, { 758, 38 }, { 803, 39 }, { 849, 40 }, { 896, 41 }, { 944, 42 }, { 993, 44 }, { 1043, 46 }, { 1094, 48 }, { 1147, 50 }, { 1201, 52 }, { 1256, 54 }, { 1312, 57 }, { 1369, 60 }, { 1427, 63 }, { 1486, 67 }, { 1546, 73 }, { 1596, 75 }, { 1648, 77 }, { 1700, 79 }, { 1752, 81 }, { 1807, 83 }, { 1863, 85 }, { 1919, 87 }, { 1975, 89 }, { 2031, 91 }, { 2087, 93 } };
        public int[] levelCosts = new int[] { 1, 3, 3, 6, 6, 10, 10, 15, 15, 21, 21, 28, 28, 36, 36, 45, 45, 55 };
        public int[] disLevelUp = new int[] { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37 };
        int subTree1 = 0, subTree2 = 0, subTree3 = 0, subTree4 = 0, subTree5 = 0, subTree6 = 0, subTree7 = 0, wmTreeLevel = 0, maxTreeLevel = 1, maxPowLevel1 = 2, maxPowLevel2 = 2, maxPowLevel3 = 2, maxPowLevel4 = 2, maxPowLevel5 = 2, maxPowLevel6 = 2, maxPowLevel7 = 2, firstTreeSkill1 = -1, firstTreeSkill2 = -1, firstTreeSkill3 = -1, firstTreeSkill4 = -1, firstTreeSkill5 = -1, firstTreeSkill6 = -1, firstTreeSkill7 = -1, firstTreeSkill8 = -1, firstTreeSkill9 = -1, firstTreeSkill10 = -1, scndTreeSkill1 = -1, scndTreeSkill2 = -1, scndTreeSkill3 = -1, scndTreeSkill4 = -1, scndTreeSkill5 = -1, scndTreeSkill6 = -1, scndTreeSkill7 = -1, scndTreeSkill8 = -1, scndTreeSkill9 = -1, scndTreeSkill10 = -1, thrdTreeSkill1 = -1, thrdTreeSkill2 = -1, thrdTreeSkill3 = -1, thrdTreeSkill4 = -1, thrdTreeSkill5 = -1, thrdTreeSkill6 = -1, thrdTreeSkill7 = -1, thrdTreeSkill8 = -1, thrdTreeSkill9 = -1, thrdTreeSkill10 = -1, fourthTreeSkill1 = -1, fourthTreeSkill2 = -1, fourthTreeSkill3 = -1, fourthTreeSkill4 = -1, fourthTreeSkill5 = -1, fourthTreeSkill6 = -1, fourthTreeSkill7 = -1, fourthTreeSkill8 = -1, fourthTreeSkill9 = -1, fourthTreeSkill10 = -1, fifthTreeSkill1 = -1, fifthTreeSkill2 = -1, fifthTreeSkill3 = -1, fifthTreeSkill4 = -1, fifthTreeSkill5 = -1, fifthTreeSkill6 = -1, fifthTreeSkill7 = -1, fifthTreeSkill8 = -1, fifthTreeSkill9 = -1, fifthTreeSkill10 = -1, sixthTreeSkill1 = -1, sixthTreeSkill2 = -1, sixthTreeSkill3 = -1, sixthTreeSkill4 = -1, sixthTreeSkill5 = -1, sixthTreeSkill6 = -1, sixthTreeSkill7 = -1, sixthTreeSkill8 = -1, sixthTreeSkill9 = -1, sixthTreeSkill10 = -1, seventhTreeSkill1 = -1, seventhTreeSkill2 = -1, seventhTreeSkill3 = -1, seventhTreeSkill4 = -1, seventhTreeSkill5 = -1, seventhTreeSkill6 = -1, seventhTreeSkill7 = -1, seventhTreeSkill8 = -1, seventhTreeSkill9 = -1, seventhTreeSkill10 = -1;


        bool set1 = false, set2 = false, set3 = false, set4 = false, set5 = false, set6 = false, set7 = false, skill1 = false, wm1 = false;

        public Form1()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLenght = Resources.Devils_Crew.Length;
            byte[] fontData = Resources.Devils_Crew;
            IntPtr data = Marshal.AllocCoTaskMem(fontLenght);
            Marshal.Copy(fontData, 0, data, fontLenght);
            pfc.AddMemoryFont(data, fontLenght);

            this.BackColor = Color.FromArgb(24, 30, 50);
            //this.ForeColor = Color.FromArgb(153, 255, 204);
            this.ForeColor = Color.FromArgb(75, 215, 175);

            label1.Font = new Font(pfc.Families[0], label1.Font.Size);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            level_drop.SelectedIndex = 0;
            class_drop.SelectedItem = "Archer";
            subclass_drop.SelectedItem = "Marksman";
            int selectedLevel = Int32.Parse(level_drop.SelectedIndex.ToString());
            disPointsLabel.Text = levelPoints[selectedLevel, 0].ToString();
            powPointsLabel.Text = levelPoints[selectedLevel, 1].ToString();
        }

        private void class_drop_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedClass = class_drop.GetItemText(class_drop.SelectedItem);
            subclass_list = new List<string>();

            if (selectedClass == "Archer")
            {
                #region settingDefaultValues

                level_drop.SelectedIndex = 0;
                subClassTreeLevel1.Value = 1;
                subClassTreeLevel2.Value = 1;
                subClassTreeLevel3.Value = 1;
                subClassTreeLevel4.Value = 1;
                subClassTreeLevel5.Value = 1;
                subClassTreeLevel6.Value = 1;
                subClassTreeLevel7.Value = 1;
                subClassTree7.Visible = false;
                subClassTreeLevel7.Visible = false;
                tree7Skill1.Visible = false;
                tree7Skill2.Visible = false;
                tree7Skill3.Visible = false;
                tree7Skill4.Visible = false;
                tree7Skill5.Visible = false;
                tree7Skill6.Visible = false;
                tree7Skill7.Visible = false;
                tree7Skill8.Visible = false;
                tree7Skill9.Visible = false;
                tree7Skill10.Visible = false;
                subTree7Pic1.Visible = false;
                subTree7Pic2.Visible = false;
                subTree7Pic3.Visible = false;
                subTree7Pic4.Visible = false;
                subTree7Pic5.Visible = false;
                subTree7Pic6.Visible = false;
                subTree7Pic7.Visible = false;
                subTree7Pic8.Visible = false;
                subTree7Pic9.Visible = false;
                subTree7Pic10.Visible = false;
                tree7Level1.Visible = false;
                tree7Level2.Visible = false;
                tree7Level3.Visible = false;
                tree7Level4.Visible = false;
                tree7Level5.Visible = false;
                tree7Level6.Visible = false;
                tree7Level7.Visible = false;
                tree7Level8.Visible = false;
                tree7Level9.Visible = false;
                tree7Level10.Visible = false;
                subTree1Pic1.Image = Resources._1Dual_Shot_Power_Icon;
                subTree1Pic2.Image = Resources._2Rapid_Shot_Power_Icon;
                subTree1Pic3.Image = Resources._3Grounding_Arrow_Power_Icon;
                subTree1Pic4.Image = Resources._4Lightness_Power_Icon;
                subTree1Pic5.Image = Resources._5Meditation_Power_Icon;
                subTree1Pic6.Image = Resources._6Adaptability_Power_Icon;
                subTree1Pic7.Image = Resources._7Tear_Apart_Power_Icon;
                subTree1Pic8.Image = Resources._8Duelist_Power_Icon;
                subTree1Pic9.Image = Resources._9Hinder_Power_Icon;
                subTree1Pic10.Image = Resources._10Repetition_Shot_Power_Icon;
                subTree2Pic1.Image = Resources._1Shield_Piercing_Power_Icon;
                subTree2Pic2.Image = Resources._2Parabolic_Shot_Power_Icon;
                subTree2Pic3.Image = Resources._3Maneuver_Power_Icon;
                subTree2Pic4.Image = Resources._4Eagle_s_Eye_Power_Icon;
                subTree2Pic5.Image = Resources._5Point_Shot_Power_Icon;
                subTree2Pic6.Image = Resources._6Omnipresent_Power_Icon;
                subTree2Pic7.Image = Resources._7Break_Apart_Power_Icon;
                subTree2Pic8.Image = Resources._8Specialist_Power_Icon;
                subTree2Pic9.Image = Resources._9Obfuscate_Power_Icon;
                subTree2Pic10.Image = Resources._10Projectile_Rain_Power_Icon;
                subTree3Pic1.Image = Resources._1Ambush_Power_Icon;
                subTree3Pic2.Image = Resources._2Sudden_Strike_Power_Icon;
                subTree3Pic3.Image = Resources._3Stunning_Fist_Power_Icon;
                subTree3Pic4.Image = Resources._4Retaliation_Power_Icon;
                subTree3Pic5.Image = Resources._5Sticky_Touch_Power_Icon;
                subTree3Pic6.Image = Resources._6Dirty_Fighting_Power_Icon;
                subTree3Pic7.Image = Resources._7Finesse_Power_Icon;
                subTree3Pic8.Image = Resources._8Sentinel_Power_Icon;
                subTree3Pic9.Image = Resources._9Distracting_Shot_Power_Icon;
                subTree3Pic10.Image = Resources._10Caltrop_s_Arrow_Power_Icon;
                subTree4Pic1.Image = Resources._1Dodge_Power_Icon;
                subTree4Pic2.Image = Resources._2Mobility_Power_Icon;
                subTree4Pic3.Image = Resources._3Evasive_Tactics_Power_Icon;
                subTree4Pic4.Image = Resources._4Cat_Reflexes_Power_Icon;
                subTree4Pic5.Image = Resources._5Acrobatic_Power_Icon;
                subTree4Pic6.Image = Resources._6Spell_Elude_Power_Icon;
                subTree4Pic7.Image = Resources._7Escapist_Power_Icon;
                subTree4Pic8.Image = Resources._8Wits_Power_Icon;
                subTree4Pic9.Image = Resources._9Low_Profile_Power_Icon;
                subTree4Pic10.Image = Resources._10Son_of_the_Wind_Power_Icon;
                tree1Skill1.Text = "Dual Shot";
                tree1Skill2.Text = "Rapid Shot";
                tree1Skill3.Text = "Grounding Arrow";
                tree1Skill4.Text = "Lightness";
                tree1Skill5.Text = "Meditation";
                tree1Skill6.Text = "Adaptability";
                tree1Skill7.Text = "Tear Apart";
                tree1Skill8.Text = "Duelist";
                tree1Skill9.Text = "Hinder";
                tree1Skill10.Text = "Repetition Shot";
                tree2Skill1.Text = "Shield Piercing";
                tree2Skill2.Text = "Parabolic Shot";
                tree2Skill3.Text = "Maneuver";
                tree2Skill4.Text = "Eagle's Eye";
                tree2Skill5.Text = "Point Shot";
                tree2Skill6.Text = "Omnipresent";
                tree2Skill7.Text = "Break Apart";
                tree2Skill8.Text = "Specialist";
                tree2Skill9.Text = "Obfuscate";
                tree2Skill10.Text = "Projectile Rain";
                tree3Skill1.Text = "Ambush";
                tree3Skill2.Text = "Sudden Strike";
                tree3Skill3.Text = "Stunning Fist";
                tree3Skill4.Text = "Retaliation";
                tree3Skill5.Text = "Sticky Touch";
                tree3Skill6.Text = "Dirty Fighting";
                tree3Skill7.Text = "Finesse";
                tree3Skill8.Text = "Sentinel";
                tree3Skill9.Text = "Distracting Shot";
                tree3Skill10.Text = "Caltrop's Arrow";
                tree4Skill1.Text = "Dodge";
                tree4Skill2.Text = "Mobility";
                tree4Skill3.Text = "Evasive Tactics";
                tree4Skill4.Text = "Cat Reflexes";
                tree4Skill5.Text = "Acrobatic";
                tree4Skill6.Text = "Spell Elude";
                tree4Skill7.Text = "Escapist";
                tree4Skill8.Text = "Wits";
                tree4Skill9.Text = "Low Profile";
                tree4Skill10.Text = "Son of the Wind";

                #endregion
                subclass_list.Add("Marksman");
                subclass_list.Add("Hunter");

                subclass_drop.DataSource = subclass_list;
            }
            else if (selectedClass == "Warrior")
            {
                #region settingDefaultValues

                level_drop.SelectedIndex = 0;
                subClassTreeLevel1.Value = 1;
                subClassTreeLevel2.Value = 1;
                subClassTreeLevel3.Value = 1;
                subClassTreeLevel4.Value = 1;
                subClassTreeLevel5.Value = 1;
                subClassTreeLevel6.Value = 1;
                subClassTreeLevel7.Value = 1;
                subClassTree7.Visible = false;
                subClassTreeLevel7.Visible = false;
                tree7Skill1.Visible = false;
                tree7Skill2.Visible = false;
                tree7Skill3.Visible = false;
                tree7Skill4.Visible = false;
                tree7Skill5.Visible = false;
                tree7Skill6.Visible = false;
                tree7Skill7.Visible = false;
                tree7Skill8.Visible = false;
                tree7Skill9.Visible = false;
                tree7Skill10.Visible = false;
                subTree7Pic1.Visible = false;
                subTree7Pic2.Visible = false;
                subTree7Pic3.Visible = false;
                subTree7Pic4.Visible = false;
                subTree7Pic5.Visible = false;
                subTree7Pic6.Visible = false;
                subTree7Pic7.Visible = false;
                subTree7Pic8.Visible = false;
                subTree7Pic9.Visible = false;
                subTree7Pic10.Visible = false;
                tree7Level1.Visible = false;
                tree7Level2.Visible = false;
                tree7Level3.Visible = false;
                tree7Level4.Visible = false;
                tree7Level5.Visible = false;
                tree7Level6.Visible = false;
                tree7Level7.Visible = false;
                tree7Level8.Visible = false;
                tree7Level9.Visible = false;
                tree7Level10.Visible = false;
                subTree1Pic1.Image = Resources._1Charge_Power_Icon;
                subTree1Pic2.Image = Resources._2Accurate_Swings_Power_Icon;
                subTree1Pic3.Image = Resources._3Disable_Limb_Power_Icon;
                subTree1Pic4.Image = Resources._4Athletic_Power_Icon;
                subTree1Pic5.Image = Resources._5South_Cross_Power_Icon;
                subTree1Pic6.Image = Resources._6Crash_Power_Icon;
                subTree1Pic7.Image = Resources._7Devastate_Power_Icon;
                subTree1Pic8.Image = Resources._8Iron_Skin_Power_Icon;
                subTree1Pic9.Image = Resources._9Fatal_Strike_Power_Icon;
                subTree1Pic10.Image = Resources._10Typhoon_Power_Icon;
                subTree2Pic1.Image = Resources._1Forceful_Blow_Power_Icon;
                subTree2Pic2.Image = Resources._2Brutal_Impacts_Power_Icon;
                subTree2Pic3.Image = Resources._3Ribs_Breaker_Power_Icon;
                subTree2Pic4.Image = Resources._4Lethal_Anatomy_Power_Icon;
                subTree2Pic5.Image = Resources._5Crushing_Power_Icon;
                subTree2Pic6.Image = Resources._6Execution_Power_Icon;
                subTree2Pic7.Image = Resources._7Mind_Squasher_Power_Icon;
                subTree2Pic8.Image = Resources._8Steel_Temper_Power_Icon;
                subTree2Pic9.Image = Resources._9Jaw_Breaker_Power_Icon;
                subTree2Pic10.Image = Resources._10Thunder_Strike_Power_Icon;
                subTree3Pic1.Image = Resources._1Gutting_Power_Icon;
                subTree3Pic2.Image = Resources._2Agile_Maneuvers_Power_Icon;
                subTree3Pic3.Image = Resources._3Balestra_Power_Icon;
                subTree3Pic4.Image = Resources._4Versatility_Power_Icon;
                subTree3Pic5.Image = Resources._5Ripost_Power_Icon;
                subTree3Pic6.Image = Resources._6Impale_Power_Icon;
                subTree3Pic7.Image = Resources._7Brain_Piercing_Power_Icon;
                subTree3Pic8.Image = Resources._8Bendable_Power_Icon;
                subTree3Pic9.Image = Resources._9Multiple_Thrust_Power_Icon;
                subTree3Pic10.Image = Resources._10Lightning_Strike_Power_Icon;
                subTree4Pic1.Image = Resources._1Kick_Power_Icon;
                subTree4Pic2.Image = Resources._2Caution_Power_Icon;
                subTree4Pic3.Image = Resources._3Throat_Cutter_Power_Icon;
                subTree4Pic4.Image = Resources._4Martial_Defense_Power_Icon;
                subTree4Pic5.Image = Resources._5Rigorous_Preparation_Power_Icon;
                subTree4Pic6.Image = Resources._6Back_Slam_Power_Icon;
                subTree4Pic7.Image = Resources._7Onslaught_Power_Icon;
                subTree4Pic8.Image = Resources._8Intimidate_Power_Icon;
                subTree4Pic9.Image = Resources._9Disabling_Power_Icon;
                subTree4Pic10.Image = Resources._10Martial_Reflexes_Power_Icon;
                tree1Skill1.Text = "Charge";
                tree1Skill2.Text = "Accurate Swings";
                tree1Skill3.Text = "Disable Limb";
                tree1Skill4.Text = "Athletic";
                tree1Skill5.Text = "South Cross";
                tree1Skill6.Text = "Crash";
                tree1Skill7.Text = "Devastate";
                tree1Skill8.Text = "Iron Skin";
                tree1Skill9.Text = "Fatal Strike";
                tree1Skill10.Text = "Typhoon";
                tree2Skill1.Text = "Forceful Blow";
                tree2Skill2.Text = "Brutal Impacts";
                tree2Skill3.Text = "Ribs Breaker";
                tree2Skill4.Text = "Lethal Anatomy";
                tree2Skill5.Text = "Crushing";
                tree2Skill6.Text = "Execution";
                tree2Skill7.Text = "Mind Squasher";
                tree2Skill8.Text = "Steel Temper";
                tree2Skill9.Text = "Jaw Breaker";
                tree2Skill10.Text = "Thunder Strike";
                tree3Skill1.Text = "Gutting Power";
                tree3Skill2.Text = "Agile Maneuvers";
                tree3Skill3.Text = "Balestra";
                tree3Skill4.Text = "Versality";
                tree3Skill5.Text = "Ripost";
                tree3Skill6.Text = "Impale";
                tree3Skill7.Text = "Brain Piercing";
                tree3Skill8.Text = "Bendable";
                tree3Skill9.Text = "Multipe Thrust";
                tree3Skill10.Text = "Lightning Strike";
                tree4Skill1.Text = "Kick";
                tree4Skill2.Text = "Caution";
                tree4Skill3.Text = "Troat Cutter";
                tree4Skill4.Text = "Martial Defense";
                tree4Skill5.Text = "Rigorous Preparation";
                tree4Skill6.Text = "Back Slam";
                tree4Skill7.Text = "Onslaught";
                tree4Skill8.Text = "Intimidate";
                tree4Skill9.Text = "Disabling";
                tree4Skill10.Text = "Martial Reflexes";

                #endregion

                subclass_list.Add("Barbarian");
                subclass_list.Add("Knight");

                subclass_drop.DataSource = subclass_list;
            }
            else if (selectedClass == "Mage")
            {
                #region settingDefaultValues

                level_drop.SelectedIndex = 0;
                subClassTreeLevel1.Value = 1;
                subClassTreeLevel2.Value = 1;
                subClassTreeLevel3.Value = 1;
                subClassTreeLevel4.Value = 1;
                subClassTreeLevel5.Value = 1;
                subClassTreeLevel6.Value = 1;
                subClassTreeLevel7.Value = 1;
                subClassTree7.Visible = true;
                subClassTreeLevel7.Visible = true;
                tree7Skill1.Visible = true;
                tree7Skill2.Visible = true;
                tree7Skill3.Visible = true;
                tree7Skill4.Visible = true;
                tree7Skill5.Visible = true;
                tree7Skill6.Visible = true;
                tree7Skill7.Visible = true;
                tree7Skill8.Visible = true;
                tree7Skill9.Visible = true;
                tree7Skill10.Visible = true;
                subTree7Pic1.Visible = true;
                subTree7Pic2.Visible = true;
                subTree7Pic3.Visible = true;
                subTree7Pic4.Visible = true;
                subTree7Pic5.Visible = true;
                subTree7Pic6.Visible = true;
                subTree7Pic7.Visible = true;
                subTree7Pic8.Visible = true;
                subTree7Pic9.Visible = true;
                subTree7Pic10.Visible = true;
                tree7Level1.Visible = true;
                tree7Level2.Visible = true;
                tree7Level3.Visible = true;
                tree7Level4.Visible = true;
                tree7Level5.Visible = true;
                tree7Level6.Visible = true;
                tree7Level7.Visible = true;
                tree7Level8.Visible = true;
                tree7Level9.Visible = true;
                tree7Level10.Visible = true;
                subTree1Pic1.Image = Resources._1Arcane_Missile_Power_Icon;
                subTree1Pic2.Image = Resources._2Beetle_Swarm_Power_Icon;
                subTree1Pic3.Image = Resources._3Blaze_Power_Icon;
                subTree1Pic4.Image = Resources._4Mind_Push_Power_Icon;
                subTree1Pic5.Image = Resources._5Pricking_Ivy_Power_Icon;
                subTree1Pic6.Image = Resources._6Will_Domain_Power_Icon;
                subTree1Pic7.Image = Resources._7Silence_Power_Icon;
                subTree1Pic8.Image = Resources._8Splinter_Wall_Power_Icon;
                subTree1Pic9.Image = Resources._9Time_Master_Power_Icon;
                subTree1Pic10.Image = Resources._10Sultar_s_Devouring_Mass_Power_Icon;
                subTree2Pic1.Image = Resources._1Energy_Barrier_Power_Icon;
                subTree2Pic2.Image = Resources._2Mana_Burn_Power_Icon;
                subTree2Pic3.Image = Resources._3Synergy_Bond_Power_Icon;
                subTree2Pic4.Image = Resources._4Dragon_s_Blood_Power_Icon;
                subTree2Pic5.Image = Resources._5Energy_Borrow_Power_Icon;
                subTree2Pic6.Image = Resources._6Ambitious_Sacrifice_Power_Icon;
                subTree2Pic7.Image = Resources._7Arcane_Devotion_Power_Icon;
                subTree2Pic8.Image = Resources._8Mana_Pool_Power_Icon;
                subTree2Pic9.Image = Resources._9Mana_Communion_Power_Icon;
                subTree2Pic10.Image = Resources._10Mana_Pylon_Power_Icon;
                subTree3Pic1.Image = Resources._1Fire_Magnification_Power_Icon;
                subTree3Pic2.Image = Resources._2Arcane_Acceleration_Power_Icon;
                subTree3Pic3.Image = Resources._3Arcane_Projection_Power_Icon;
                subTree3Pic4.Image = Resources._4Combat_Magic_Power_Icon;
                subTree3Pic5.Image = Resources._5Static_Field_Power_Icon;
                subTree3Pic6.Image = Resources._6Ice_Magnification_Power_Icon;
                subTree3Pic7.Image = Resources._7Protection_Dome_Power_Icon;
                subTree3Pic8.Image = Resources._8Metabolic_Control_Power_Icon;
                subTree3Pic9.Image = Resources._9Lightning_Magnification_Power_Icon;
                subTree3Pic10.Image = Resources._10Evendim_s_Fury_Power_Icon;
                subTree4Pic1.Image = Resources._1Curse_Power_Icon;
                subTree4Pic2.Image = Resources._2Feline_Dexterity_Power_Icon;
                subTree4Pic3.Image = Resources._3Blindness_Power_Icon;
                subTree4Pic4.Image = Resources._4Bless_Power_Icon;
                subTree4Pic5.Image = Resources._5Bear_Strength_Power_Icon;
                subTree4Pic6.Image = Resources._6Bless_Weapon_Power_Icon;
                subTree4Pic7.Image = Resources._7Dispel_Magic_Power_Icon;
                subTree4Pic8.Image = Resources._8Fox_Wits_Power_Icon;
                subTree4Pic9.Image = Resources._9Clumsiness_Power_Icon;
                subTree4Pic10.Image = Resources._10Mass_Dispel_Magic_Power_Icon;
                tree1Skill1.Text = "Arcane Missle";
                tree1Skill2.Text = "Beetle Swarm";
                tree1Skill3.Text = "Blaze";
                tree1Skill4.Text = "Mind Push";
                tree1Skill5.Text = "Pricking Ivy";
                tree1Skill6.Text = "Will Domain";
                tree1Skill7.Text = "Silence Power";
                tree1Skill8.Text = "Splinter Wall";
                tree1Skill9.Text = "Time Master";
                tree1Skill10.Text = "Sultar's Devouring Mass";
                tree2Skill1.Text = "Energy Barrier";
                tree2Skill2.Text = "Mana Burn";
                tree2Skill3.Text = "Synergy Bond";
                tree2Skill4.Text = "Dragon's Blood";
                tree2Skill5.Text = "Energy Borrow";
                tree2Skill6.Text = "Ambitious Sacrifice";
                tree2Skill7.Text = "Arcane Devotion";
                tree2Skill8.Text = "Mana Pool";
                tree2Skill9.Text = "Mana Communion";
                tree2Skill10.Text = "Mana Pylon";
                tree3Skill1.Text = "Fire Magnification";
                tree3Skill2.Text = "Arcane Acceleration";
                tree3Skill3.Text = "Arcane Projection";
                tree3Skill4.Text = "Combat Magic";
                tree3Skill5.Text = "Static Field";
                tree3Skill6.Text = "Ice Magnification";
                tree3Skill7.Text = "Protection Dome";
                tree3Skill8.Text = "Metabolic Control";
                tree3Skill9.Text = "Lightning Magnification";
                tree3Skill10.Text = "Evendim's Fury";
                tree4Skill1.Text = "Curse";
                tree4Skill2.Text = "Feline Dexterity";
                tree4Skill3.Text = "Blindness";
                tree4Skill4.Text = "Bless";
                tree4Skill5.Text = "Bear Strength";
                tree4Skill6.Text = "Bless Weapon";
                tree4Skill7.Text = "Dispel Magic";
                tree4Skill8.Text = "Fox Wits";
                tree4Skill9.Text = "Clumsiness";
                tree4Skill10.Text = "Mass Dispel Magic";

                #endregion

                subclass_list.Add("Warlock");
                subclass_list.Add("Conjurer");

                subclass_drop.DataSource = subclass_list;
            }
        }

        private void subclass_drop_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedSubClass = subclass_drop.GetItemText(subclass_drop.SelectedItem);
            level_drop.SelectedIndex = 0;

            if (selectedSubClass == "Marksman")
            {
                subClassTree1.Text = "Short Bows";
                subClassTree2.Text = "Long Bows";
                subClassTree3.Text = "Tricks";
                subClassTree4.Text = "Evasion";
                subClassTree5.Text = "Arrow Mastery";
                subClassTree6.Text = "Aiming Mastery";
                subTree5Pic1.Image = Resources._1Recharged_Arrows_Power_Icon;
                subTree5Pic2.Image = Resources._2Winter_Stroke_Power_Icon;
                subTree5Pic3.Image = Resources._3Burst_of_Wind_Power_Icon;
                subTree5Pic4.Image = Resources._4Serpent_Bite_Power_Icon;
                subTree5Pic5.Image = Resources._5Ignus_Scorch_Power_Icon;
                subTree5Pic6.Image = Resources._6Ethereal_Arrow_Power_Icon;
                subTree5Pic7.Image = Resources._7Needle_Blast_Power_Icon;
                subTree5Pic8.Image = Resources._8Arcana_Strike_Power_Icon;
                subTree5Pic9.Image = Resources._9Fire_Rain_Power_Icon;
                subTree5Pic10.Image = Resources._10Lightning_Arrow_Power_Icon;
                subTree6Pic1.Image = Resources._1Dead_Eye_Power_Icon;
                subTree6Pic2.Image = Resources._2Focus_Power_Icon;
                subTree6Pic3.Image = Resources._3Finger_Crush_Power_Icon;
                subTree6Pic4.Image = Resources._4Foresight_Power_Icon;
                subTree6Pic5.Image = Resources._5Cyclops_Curse_Power_Icon;
                subTree6Pic6.Image = Resources._6Lethal_Strike_Power_Icon;
                subTree6Pic7.Image = Resources._7Strategic_Position_Power_Icon;
                subTree6Pic8.Image = Resources._8Trained_Eye_Power_Icon;
                subTree6Pic9.Image = Resources._9Seeking_Strike_Power_Icon;
                subTree6Pic10.Image = Resources._10Hawk_s_Gaze_Power_Icon;
                wmSkill1.Image = Resources._1px_War_Council_Power_Icon;
                wmSkill2.Image = Resources._2px_Fire_Arrow_Power_Icon;
                wmSkill3.Image = Resources._3px_Warmaster_s_Might_Power_Icon;
                wmSkill4.Image = Resources._4px_Killer_Instinct_Power_Icon;
                wmSkill5.Image = Resources._5px_Warmaster_Blood_Power_Icon;
                tree5Skill1.Text = "Recharged Arrows";
                tree5Skill2.Text = "Winter Stroke";
                tree5Skill3.Text = "Burst of Wind";
                tree5Skill4.Text = "Serpent Bite";
                tree5Skill5.Text = "Ignus Scorch";
                tree5Skill6.Text = "Ethereal Arrow";
                tree5Skill7.Text = "Needle Blast";
                tree5Skill8.Text = "Arcana Strike";
                tree5Skill9.Text = "Fire Rain";
                tree5Skill10.Text = "Lightning Arrow";
                tree6Skill1.Text = "Dead Eye";
                tree6Skill2.Text = "Focus";
                tree6Skill3.Text = "Finger Crush";
                tree6Skill4.Text = "Foresight";
                tree6Skill5.Text = "Cyclops Curse";
                tree6Skill6.Text = "Lethal Strike";
                tree6Skill7.Text = "Strategic Position";
                tree6Skill8.Text = "Trained Eye";
                tree6Skill9.Text = "Seeking Strike";
                tree6Skill10.Text = "Hawk's Gaze";
                wmLabel1.Text = "War Council";
                wmLabel2.Text = "Fire Arrow";
                wmLabel3.Text = "Warmaster's Might";
                wmLabel4.Text = "Killer Instinct";
                wmLabel5.Text = "Warmaster Blood";
            }
            else if (selectedSubClass == "Hunter")
            {
                subClassTree1.Text = "Short Bows";
                subClassTree2.Text = "Long Bows";
                subClassTree3.Text = "Tricks";
                subClassTree4.Text = "Evasion";
                subClassTree5.Text = "Scouting";
                subClassTree6.Text = "Pets";
                subTree5Pic1.Image = Resources._1Ensnaring_Arrow_Power_Icon;
                subTree5Pic2.Image = Resources._2Death_Sentence_Power_Icon;
                subTree5Pic3.Image = Resources._3Enemy_Surveillance_Power_Icon;
                subTree5Pic4.Image = Resources._4Wild_Spirit_Power_Icon;
                subTree5Pic5.Image = Resources._5Camouflage_Power_Icon;
                subTree5Pic6.Image = Resources._6Camouflage_Corpse_Power_Icon;
                subTree5Pic7.Image = Resources._7Cold_Blood_Power_Icon;
                subTree5Pic8.Image = Resources._8Reveal_Power_Icon;
                subTree5Pic9.Image = Resources._9Confuse_Power_Icon;
                subTree5Pic10.Image = Resources._10Stalker_Surroundings_Power_Icon;
                subTree6Pic1.Image = Resources._1Natural_Dominance_Power_Icon;
                subTree6Pic2.Image = Resources._2Heal_Pet_Power_Icon;
                subTree6Pic3.Image = Resources._3Stalker_Spirit_Power_Icon;
                subTree6Pic4.Image = Resources._4Prominent_Sight_Power_Icon;
                subTree6Pic5.Image = Resources._5Training_Power_Icon;
                subTree6Pic6.Image = Resources._6Revive_Pet_Power_Icon;
                subTree6Pic7.Image = Resources._7Bestial_Wrath_Power_Icon;
                subTree6Pic8.Image = Resources._8Natural_Armor_Power_Icon;
                subTree6Pic9.Image = Resources._9Nature_s_Fury_Power_Icon;
                subTree6Pic10.Image = Resources._10Skin_of_the_Beast_Power_Icon;
                wmSkill1.Image = Resources._1px_War_Council_Power_Icon;
                wmSkill2.Image = Resources._2px_Horn_of_the_Wind_Power_Icon;
                wmSkill3.Image = Resources._3px_Warmaster_s_Might_Power_Icon;
                wmSkill4.Image = Resources._4px_Head_of_the_Pack_Power_Icon;
                wmSkill5.Image = Resources._5px_Warmaster_Blood_Power_Icon;
                tree5Skill1.Text = "Ensnaring Arrow";
                tree5Skill2.Text = "Death Sentence";
                tree5Skill3.Text = "Enemy Surveillance";
                tree5Skill4.Text = "Wild Spirit";
                tree5Skill5.Text = "Camouflage";
                tree5Skill6.Text = "Camouflage Corpse";
                tree5Skill7.Text = "Cold Blood";
                tree5Skill8.Text = "Reveal";
                tree5Skill9.Text = "Confuse";
                tree5Skill10.Text = "Stalker Surroundings";
                tree6Skill1.Text = "Natural Dominance";
                tree6Skill2.Text = "Heal Pet";
                tree6Skill3.Text = "Stalker Spirit";
                tree6Skill4.Text = "Prominent Sight";
                tree6Skill5.Text = "Training";
                tree6Skill6.Text = "Revive Pet";
                tree6Skill7.Text = "Bestial Wrath";
                tree6Skill8.Text = "Natural Armor";
                tree6Skill9.Text = "Nature's Fury";
                tree6Skill10.Text = "Skin of the Beast";
                wmLabel1.Text = "War Council";
                wmLabel2.Text = "Horn of the wind";
                wmLabel3.Text = "Warmaster's Might";
                wmLabel4.Text = "Head of the Pack";
                wmLabel5.Text = "Warmaster Blood";
            }
            else if (selectedSubClass == "Barbarian")
            {
                subClassTree1.Text = "Slashing Weapons";
                subClassTree2.Text = "Blunt Weapons";
                subClassTree3.Text = "Piercing Weapons";
                subClassTree4.Text = "Tactics";
                subClassTree5.Text = "Warcries";
                subClassTree6.Text = "Two Handed Mastery";
                subTree5Pic1.Image = Resources._1Colossus_Power_Icon;
                subTree5Pic2.Image = Resources._2Frenzy_Power_Icon;
                subTree5Pic3.Image = Resources._3Off_with_their_Heads___Power_Icon;
                subTree5Pic4.Image = Resources._4Threat_Power_Icon;
                subTree5Pic5.Image = Resources._5Challenging_Roar_Power_Icon;
                subTree5Pic6.Image = Resources._6Howl_Power_Icon;
                subTree5Pic7.Image = Resources._7Berserk_Power_Icon;
                subTree5Pic8.Image = Resources._8Overwhelming_Strength_Power_Icon;
                subTree5Pic9.Image = Resources._9Spring_Power_Icon;
                subTree5Pic10.Image = Resources._10Unstoppable_Madness_Power_Icon;
                subTree6Pic1.Image = Resources._1Thirst_for_Blood_Power_Icon;
                subTree6Pic2.Image = Resources._2Spiritual_Blow_Power_Icon;
                subTree6Pic3.Image = Resources._3Rend_Power_Icon;
                subTree6Pic4.Image = Resources._4Beast_Attack_Power_Icon;
                subTree6Pic5.Image = Resources._5Deafening_Roar_Power_Icon;
                subTree6Pic6.Image = Resources._6Expansive_Wave_Power_Icon;
                subTree6Pic7.Image = Resources._7Destabilize_Power_Icon;
                subTree6Pic8.Image = Resources._8Fulminating_Power_Icon;
                subTree6Pic9.Image = Resources._9Rage_of_the_Earth_Power_Icon;
                subTree6Pic10.Image = Resources._10Whirlwind_Power_Icon;
                wmSkill1.Image = Resources._1px_War_Council_Power_Icon;
                wmSkill2.Image = Resources._4px_Warmaster_Beacon_Power_Icon;
                wmSkill3.Image = Resources._3px_Warmaster_s_Might_Power_Icon;
                wmSkill4.Image = Resources._2px_Heroic_Shout_Power_Icon;
                wmSkill5.Image = Resources._5px_Warmaster_Blood_Power_Icon;
                tree5Skill1.Text = "Collosus";
                tree5Skill2.Text = "Frenzy";
                tree5Skill3.Text = "Off with their Heads!!";
                tree5Skill4.Text = "Threat";
                tree5Skill5.Text = "Challenging Roar";
                tree5Skill6.Text = "Howl";
                tree5Skill7.Text = "Berserk";
                tree5Skill8.Text = "Overwhelming Strength";
                tree5Skill9.Text = "Spring";
                tree5Skill10.Text = "Unstoppable Madness";
                tree6Skill1.Text = "Thirst for Blood";
                tree6Skill2.Text = "Spiritual Blow";
                tree6Skill3.Text = "Rend";
                tree6Skill4.Text = "Beast Attack";
                tree6Skill5.Text = "Deafening Roar";
                tree6Skill6.Text = "Expansive Wave";
                tree6Skill7.Text = "Destabilize";
                tree6Skill8.Text = "Fulminating";
                tree6Skill9.Text = "Rage of the Earth";
                tree6Skill10.Text = "Whirlwind";
                wmLabel1.Text = "War Council";
                wmLabel2.Text = "Warmaster Beacon";
                wmLabel3.Text = "Warmaster's Might";
                wmLabel4.Text = "Heroic Shout";
                wmLabel5.Text = "Warmaster Blood";
            }
            else if (selectedSubClass == "Knight")
            {
                subClassTree1.Text = "Slashing Weapons";
                subClassTree2.Text = "Blunt Weapons";
                subClassTree3.Text = "Piercing Weapons";
                subClassTree4.Text = "Tactics";
                subClassTree5.Text = "Vanguard";
                subClassTree6.Text = "Shields";
                subTree5Pic1.Image = Resources._1Challenge_Power_Icon;
                subTree5Pic2.Image = Resources._2Taunt_Power_Icon;
                subTree5Pic3.Image = Resources._3Feint_Power_Icon;
                subTree5Pic4.Image = Resources._4Protector_Temple_Power_Icon;
                subTree5Pic5.Image = Resources._5Offensive_Stance_Power_Icon;
                subTree5Pic6.Image = Resources._6Defensive_Support_Power_Icon;
                subTree5Pic7.Image = Resources._7Troll_s_Skin_Power_Icon;
                subTree5Pic8.Image = Resources._8Knight_s_Haste_Power_Icon;
                subTree5Pic9.Image = Resources._9Heroic_Presence_Power_Icon;
                subTree5Pic10.Image = Resources._10Army_of_One_Power_Icon;
                subTree6Pic1.Image = Resources._1Block_Power_Icon;
                subTree6Pic2.Image = Resources._2Shield_Bash_Power_Icon;
                subTree6Pic3.Image = Resources._3Protect_Ally_Power_Icon;
                subTree6Pic4.Image = Resources._4Precise_Block_Power_Icon;
                subTree6Pic5.Image = Resources._5Defensive_Stance_Power_Icon;
                subTree6Pic6.Image = Resources._6Ethereal_Mantle_Power_Icon;
                subTree6Pic7.Image = Resources._7Shield_Wall_Power_Icon;
                subTree6Pic8.Image = Resources._8Steadiness_Power_Icon;
                subTree6Pic9.Image = Resources._9Stars_Shield_Power_Icon;
                subTree6Pic10.Image = Resources._10Deflecting_Barrier_Power_Icon;
                wmSkill1.Image = Resources._1px_War_Council_Power_Icon;
                wmSkill2.Image = Resources._2px_Paladin_s_Aid_Power_Icon;
                wmSkill3.Image = Resources._3px_Warmaster_s_Might_Power_Icon;
                wmSkill4.Image = Resources._4px_Blessed_Power_Icon;
                wmSkill5.Image = Resources._5px_Warmaster_Blood_Power_Icon;
                tree5Skill1.Text = "Challenge";
                tree5Skill2.Text = "Taunt";
                tree5Skill3.Text = "Feint";
                tree5Skill4.Text = "Protector Temple";
                tree5Skill5.Text = "Offensive Stance";
                tree5Skill6.Text = "Defensive Support";
                tree5Skill7.Text = "Troll's Skin";
                tree5Skill8.Text = "Kight's Haste";
                tree5Skill9.Text = "Heroic Presence";
                tree5Skill10.Text = "Army of One";
                tree6Skill1.Text = "Block";
                tree6Skill2.Text = "Shield Bash";
                tree6Skill3.Text = "Protect Ally";
                tree6Skill4.Text = "Precise Block";
                tree6Skill5.Text = "Defensive Stance";
                tree6Skill6.Text = "Ethereal Mantle";
                tree6Skill7.Text = "Shield Wall";
                tree6Skill8.Text = "Steadiness";
                tree6Skill9.Text = "Stars Shield";
                tree6Skill10.Text = "Deflecting Barrier";
                wmLabel1.Text = "War Council";
                wmLabel2.Text = "Paladin's Aid";
                wmLabel3.Text = "Warmaster's Might";
                wmLabel4.Text = "Blessed";
                wmLabel5.Text = "Warmaster Blood";
            }
            else if (selectedSubClass == "Warlock")
            {
                subClassTree1.Text = "Mental";
                subClassTree2.Text = "Mana Control";
                subClassTree3.Text = "Staff Mastery";
                subClassTree4.Text = "Enchantments";
                subClassTree5.Text = "Arcania";
                subClassTree6.Text = "Necromancy";
                subClassTree7.Text = "Elements";
                subTree5Pic1.Image = Resources._1Stalagmite_Power_Icon;
                subTree5Pic2.Image = Resources._2Slow_Power_Icon;
                subTree5Pic3.Image = Resources._3Petrify_Hands_Power_Icon;
                subTree5Pic4.Image = Resources._4Laziness_Power_Icon;
                subTree5Pic5.Image = Resources._5Meteor_Power_Icon;
                subTree5Pic6.Image = Resources._6Wind_Wall_Power_Icon;
                subTree5Pic7.Image = Resources._7Crystal_Blast_Power_Icon;
                subTree5Pic8.Image = Resources._8Fragility_Power_Icon;
                subTree5Pic9.Image = Resources._9Golem_Fist_Power_Icon;
                subTree5Pic10.Image = Resources._10Sultar_s_Terror_Power_Icon;
                subTree6Pic1.Image = Resources._1Vampirism_Power_Icon;
                subTree6Pic2.Image = Resources._2Darkness_Power_Icon;
                subTree6Pic3.Image = Resources._3Infuriate_Power_Icon;
                subTree6Pic4.Image = Resources._4Vitality_Absorption_Power_Icon;
                subTree6Pic5.Image = Resources._5Sadistic_Guards_Power_Icon;
                subTree6Pic6.Image = Resources._6Sadistic_Servants_Power_Icon;
                subTree6Pic7.Image = Resources._7Soulkeeper_Power_Icon;
                subTree6Pic8.Image = Resources._8Cremation_Power_Icon;
                subTree6Pic9.Image = Resources._9Possess_Summoning_Power_Icon;
                subTree6Pic10.Image = Resources._10Master_of_Doom_Power_Icon;
                subTree7Pic1.Image = Resources._1Fire_Ball_Power_Icon;
                subTree7Pic2.Image = Resources._2Ice_Blast_Power_Icon;
                subTree7Pic3.Image = Resources._3Lightning_Power_Icon;
                subTree7Pic4.Image = Resources._4Elemental_Conjunction_Power_Icon;
                subTree7Pic5.Image = Resources._5Freeze_Power_Icon;
                subTree7Pic6.Image = Resources._6Frozen_Storm_Power_Icon;
                subTree7Pic7.Image = Resources._7Elemental_Exposure_Power_Icon;
                subTree7Pic8.Image = Resources._8Magma_Blast_Power_Icon;
                subTree7Pic9.Image = Resources._9Twister_Power_Icon;
                subTree7Pic10.Image = Resources._10Summon_Lightning_Power_Icon;
                wmSkill1.Image = Resources._1px_War_Council_Power_Icon;
                wmSkill2.Image = Resources.px_Offensive_Portal_Power_Icon;
                wmSkill3.Image = Resources._3px_Warmaster_s_Might_Power_Icon;
                wmSkill4.Image = Resources.px_Mass_Prickling_Ivy_Power_Icon;
                wmSkill5.Image = Resources._5px_Warmaster_Blood_Power_Icon;
                tree5Skill1.Text = "Stalagmite";
                tree5Skill2.Text = "Slow";
                tree5Skill3.Text = "Petrify Hands";
                tree5Skill4.Text = "Lazyness";
                tree5Skill5.Text = "Meteor";
                tree5Skill6.Text = "Wind Wall";
                tree5Skill7.Text = "Crystal Blast";
                tree5Skill8.Text = "Fragility";
                tree5Skill9.Text = "Golem Fist";
                tree5Skill10.Text = "Sultar's Terror";
                tree6Skill1.Text = "Vampirism";
                tree6Skill2.Text = "Darkness";
                tree6Skill3.Text = "Infuriate";
                tree6Skill4.Text = "Vitality Absorption";
                tree6Skill5.Text = "Sadistic Guards";
                tree6Skill6.Text = "Sadistic Servants";
                tree6Skill7.Text = "Souldkeeper";
                tree6Skill8.Text = "Cremation";
                tree6Skill9.Text = "Possess Summoning";
                tree6Skill10.Text = "Master of Doom";
                tree7Skill1.Text = "Fire Ball";
                tree7Skill2.Text = "Ice Ball";
                tree7Skill3.Text = "Lightning";
                tree7Skill4.Text = "Elemental Conjunction";
                tree7Skill5.Text = "Freeze";
                tree7Skill6.Text = "Frozen Storm";
                tree7Skill7.Text = "Elemental Exposure";
                tree7Skill8.Text = "Magma Blast";
                tree7Skill9.Text = "Twister";
                tree7Skill10.Text = "Summon Lightning";
                wmLabel1.Text = "War Council";
                wmLabel2.Text = "Offensive Portal";
                wmLabel3.Text = "Warmaster's Might";
                wmLabel4.Text = "Mass Prickling Ivy";
                wmLabel5.Text = "Warmaster Blood";

            }
            else if (selectedSubClass == "Conjurer")
            {
                subClassTree1.Text = "Mental";
                subClassTree2.Text = "Mana Control";
                subClassTree3.Text = "Staff Mastery";
                subClassTree4.Text = "Enchantments";
                subClassTree5.Text = "Life";
                subClassTree6.Text = "Summon";
                subClassTree7.Text = "Sorcery";
                subTree5Pic1.Image = Resources._1Heal_Ally_Power_Icon;
                subTree5Pic2.Image = Resources._2Heal_Self_Power_Icon;
                subTree5Pic3.Image = Resources._3Resurrect_Power_Icon;
                subTree5Pic4.Image = Resources._4Regenerate_Ally_Power_Icon;
                subTree5Pic5.Image = Resources._5Regenerate_Self_Power_Icon;
                subTree5Pic6.Image = Resources._6Divine_Intervention_Power_Icon;
                subTree5Pic7.Image = Resources._7Life_Savior_Power_Icon;
                subTree5Pic8.Image = Resources._8Greater_Regeneration_Power_Icon;
                subTree5Pic9.Image = Resources._9Greater_Healing_Power_Icon;
                subTree5Pic10.Image = Resources._10Mass_Resurrection_Power_Icon;
                subTree6Pic1.Image = Resources._1Summon_Imps_Power_Icon;
                subTree6Pic2.Image = Resources._2Extraplanar_Bond_Power_Icon;
                subTree6Pic3.Image = Resources._3Summon_Demon_Power_Icon;
                subTree6Pic4.Image = Resources._4Material_Bond_Power_Icon;
                subTree6Pic5.Image = Resources._5Summon_Zombies_Power_Icon;
                subTree6Pic6.Image = Resources._6Demonic_Rage_Power_Icon;
                subTree6Pic7.Image = Resources._7Summon_Golem_Power_Icon;
                subTree6Pic8.Image = Resources._8Magical_Armor_Power_Icon;
                subTree6Pic9.Image = Resources._9Blood_Drinker_Power_Icon;
                subTree6Pic10.Image = Resources._10Summon_Lich_Power_Icon;
                subTree7Pic1.Image = Resources._1Force_Armor_Power_Icon;
                subTree7Pic2.Image = Resources._2Shifting_Silhouette_Power_Icon;
                subTree7Pic3.Image = Resources._3Friendly_Shielding_Power_Icon;
                subTree7Pic4.Image = Resources._4Mind_Blank_Power_Icon;
                subTree7Pic5.Image = Resources._5Karma_Mirror_Power_Icon;
                subTree7Pic6.Image = Resources._6Magic_Barrier_Power_Icon;
                subTree7Pic7.Image = Resources._7Material_Wall_Power_Icon;
                subTree7Pic8.Image = Resources._8Sanctuary_Power_Icon;
                subTree7Pic9.Image = Resources._9Insightful_Power_Icon;
                subTree7Pic10.Image = Resources._10Steel_Skin_Power_Icon;
                wmSkill1.Image = Resources._1px_War_Council_Power_Icon;
                wmSkill2.Image = Resources._2px_Defensive_Portal_Power_Icon;
                wmSkill3.Image = Resources._3px_Warmaster_s_Might_Power_Icon;
                wmSkill4.Image = Resources._4px_Divine_Protection_Power_Icon;
                wmSkill5.Image = Resources._5px_Warmaster_Blood_Power_Icon;
                tree5Skill1.Text = "Heal Ally";
                tree5Skill2.Text = "Heal Self";
                tree5Skill3.Text = "Ressurrect";
                tree5Skill4.Text = "Regenerate Ally";
                tree5Skill5.Text = "Regenerate Self";
                tree5Skill6.Text = "Divine Intervention";
                tree5Skill7.Text = "Life Savior";
                tree5Skill8.Text = "Greater Regeneration";
                tree5Skill9.Text = "Greater Healing";
                tree5Skill10.Text = "Mass Ressurection";
                tree6Skill1.Text = "Summon Imps";
                tree6Skill2.Text = "Extraplanar Bond";
                tree6Skill3.Text = "Summon Demon";
                tree6Skill4.Text = "Material Bond";
                tree6Skill5.Text = "Summon Zombies";
                tree6Skill6.Text = "Demonic Rage";
                tree6Skill7.Text = "Summon Golem";
                tree6Skill8.Text = "Magical Armor";
                tree6Skill9.Text = "Blood Drinker";
                tree6Skill10.Text = "Summon Lich";
                tree7Skill1.Text = "Force Armor";
                tree7Skill2.Text = "Shifting Silhouette";
                tree7Skill3.Text = "Friendly Shielding";
                tree7Skill4.Text = "Mind Blank";
                tree7Skill5.Text = "Karma Mirror";
                tree7Skill6.Text = "Magic Barrier";
                tree7Skill7.Text = "Material Wall";
                tree7Skill8.Text = "Sanctuary";
                tree7Skill9.Text = "Insightful";
                tree7Skill10.Text = "Steel Skin";
                wmLabel1.Text = "War Council";
                wmLabel2.Text = "Defensive Portal";
                wmLabel3.Text = "Warmaster's Might";
                wmLabel4.Text = "Divine Protection";
                wmLabel5.Text = "Warmaster Blood";
            }
        }

        private void level_drop_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());
            int selectedLevelPoints = Int32.Parse(level_drop.SelectedIndex.ToString());

            if (selectedLevel >= 3)
            {
                maxTreeLevel = 2;
            }
            if (selectedLevel >= 5)
            {
                maxTreeLevel = 3;
            }
            if (selectedLevel >= 7)
            {
                maxTreeLevel = 4;
            }
            if (selectedLevel >= 9)
            {
                maxTreeLevel = 5;
            }
            if (selectedLevel >= 11)
            {
                maxTreeLevel = 6;
            }
            if (selectedLevel >= 13)
            {
                maxTreeLevel = 7;
            }
            if (selectedLevel >= 15)
            {
                maxTreeLevel = 8;
            }
            if (selectedLevel >= 17)
            {
                maxTreeLevel = 9;
            }
            if (selectedLevel >= 19)
            {
                maxTreeLevel = 10;
            }
            if (selectedLevel >= 21)
            {
                maxTreeLevel = 11;
            }
            if (selectedLevel >= 23)
            {
                maxTreeLevel = 12;
            }
            if (selectedLevel >= 25)
            {
                maxTreeLevel = 13;
            }
            if (selectedLevel >= 27)
            {
                maxTreeLevel = 14;
            }
            if (selectedLevel >= 29)
            {
                maxTreeLevel = 15;
            }
            if (selectedLevel >= 31)
            {
                maxTreeLevel = 16;
            }
            if (selectedLevel >= 33)
            {
                maxTreeLevel = 17;
            }
            if (selectedLevel >= 35)
            {
                maxTreeLevel = 18;
            }
            if (selectedLevel >= 37)
            {
                maxTreeLevel = 19;
            }

            if (selectedLevel == 60)
            {
                wmTreeLvl.Value = 1;
                wmTreeLvl.Visible = true;
                wmTree.Visible = true;
                wmTreeLevel = 0;
            }
            else
            {
                wmTreeLvl.Value = 1;
                wmTreeLvl.Visible = false;
                wmTree.Visible = false;
                wmLabel1.Visible = false;
                wmLabel2.Visible = false;
                wmLabel3.Visible = false;
                wmLabel4.Visible = false;
                wmLabel5.Visible = false;
                wmSkill1.Visible = false;
                wmSkill2.Visible = false;
                wmSkill3.Visible = false;
                wmSkill4.Visible = false;
                wmSkill5.Visible = false;
            }

            if ((string)class_drop.SelectedItem == "Warrior" || (string)class_drop.SelectedItem == "Archer")
            {
                disPointsLabel.Text = levelPoints[selectedLevelPoints, 0].ToString();
                powPointsLabel.Text = levelPoints[selectedLevelPoints, 1].ToString();
                maxPowLevel1 = 2;
                maxPowLevel2 = 2;
                maxPowLevel3 = 2;
                maxPowLevel4 = 2;
                maxPowLevel5 = 2;
                maxPowLevel6 = 2;
                maxPowLevel7 = 2;
                subClassTreeLevel1.Value = 1;
                subClassTreeLevel2.Value = 1;
                subClassTreeLevel3.Value = 1;
                subClassTreeLevel4.Value = 1;
                subClassTreeLevel5.Value = 1;
                subClassTreeLevel6.Value = 1;
                subClassTreeLevel7.Value = 1;
            }
            else if ((string)class_drop.SelectedItem == "Mage")
            {
                disPointsLabel.Text = levelPointsMage[selectedLevelPoints, 0].ToString();
                powPointsLabel.Text = levelPointsMage[selectedLevelPoints, 1].ToString();
                maxPowLevel1 = 2;
                maxPowLevel2 = 2;
                maxPowLevel3 = 2;
                maxPowLevel4 = 2;
                maxPowLevel5 = 2;
                maxPowLevel6 = 2;
                maxPowLevel7 = 2;
                subClassTreeLevel1.Value = 1;
                subClassTreeLevel2.Value = 1;
                subClassTreeLevel3.Value = 1;
                subClassTreeLevel4.Value = 1;
                subClassTreeLevel5.Value = 1;
                subClassTreeLevel6.Value = 1;
                subClassTreeLevel7.Value = 1;
            }
        }

        private void subClassTreeLevel1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel1.Value == 19)
            {
                maxPowLevel1 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel1.Value >= 15)
            {
                maxPowLevel1 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel1.Value >= 11)
            {
                maxPowLevel1 = 3;
            }
            else
            {
                maxPowLevel1 = 2;
            }

            if (!set1)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel1.Value > subTree1)
                {
                    newDisPoints -= levelCosts[subTree1];

                    if (newDisPoints < 0)
                    {
                        set1 = true;
                        subClassTreeLevel1.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel1.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel1.Value == 19)
                            {
                                tree1Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 17)
                            {
                                tree1Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 15)
                            {
                                tree1Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 13)
                            {
                                tree1Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 11)
                            {
                                tree1Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 9)
                            {
                                tree1Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 7)
                            {
                                tree1Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 5)
                            {
                                tree1Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel1.Value >= 3)
                            {
                                tree1Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree1++;
                        }
                        else
                        {
                            set1 = true;
                            subClassTreeLevel1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel1.Value == subTree1)
                {
                    if (subClassTreeLevel1.Value < 3)
                    {
                        tree1Level2.Enabled = false;
                        tree1Level2.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 5)
                    {
                        tree1Level3.Enabled = false;
                        tree1Level3.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 7)
                    {
                        tree1Level4.Enabled = false;
                        tree1Level4.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 9)
                    {
                        tree1Level5.Enabled = false;
                        tree1Level5.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 11)
                    {
                        tree1Level6.Enabled = false;
                        tree1Level6.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 13)
                    {
                        tree1Level7.Enabled = false;
                        tree1Level7.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 15)
                    {
                        tree1Level8.Enabled = false;
                        tree1Level8.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 17)
                    {
                        tree1Level9.Enabled = false;
                        tree1Level9.Value = 0;
                    }
                    else if (subClassTreeLevel1.Value < 19)
                    {
                        tree1Level10.Enabled = false;
                        tree1Level10.Value = 0;
                    }
                    subTree1--;
                    newDisPoints += levelCosts[subTree1];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
                else if (set1 && subClassTreeLevel1.Value == subTree1)
                {
                    disPoints = Int32.Parse(disPointsLabel.Text);
                    newDisPoints = disPoints;

                    subTree1--;
                    newDisPoints += levelCosts[subTree1];
                    disPointsLabel.Text = newDisPoints.ToString();

                    if (subClassTreeLevel1.Value == 1)
                    {
                        set1 = false;
                    }
                }
            }
            else set1 = false;
        }

        private void subClassTreeLevel2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel2.Value == 19)
            {
                maxPowLevel2 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel2.Value >= 15)
            {
                maxPowLevel2 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel2.Value >= 11)
            {
                maxPowLevel2 = 3;
            }
            else
            {
                maxPowLevel2 = 2;
            }

            if (!set2)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel2.Value > subTree2)
                {
                    newDisPoints -= levelCosts[subTree2];

                    if (newDisPoints < 0)
                    {
                        set2 = true;
                        subClassTreeLevel2.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel2.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel2.Value == 19)
                            {
                                tree2Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 17)
                            {
                                tree2Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 15)
                            {
                                tree2Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 13)
                            {
                                tree2Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 11)
                            {
                                tree2Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 9)
                            {
                                tree2Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 7)
                            {
                                tree2Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 5)
                            {
                                tree2Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel2.Value >= 3)
                            {
                                tree2Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree2++;
                        }
                        else
                        {
                            set2 = true;
                            subClassTreeLevel2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel2.Value == subTree2)
                {
                    if (subClassTreeLevel2.Value < 3)
                    {
                        tree2Level2.Enabled = false;
                        tree2Level2.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 5)
                    {
                        tree2Level3.Enabled = false;
                        tree2Level3.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 7)
                    {
                        tree2Level4.Enabled = false;
                        tree2Level4.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 9)
                    {
                        tree2Level5.Enabled = false;
                        tree2Level5.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 11)
                    {
                        tree2Level6.Enabled = false;
                        tree2Level6.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 13)
                    {
                        tree2Level7.Enabled = false;
                        tree2Level7.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 15)
                    {
                        tree2Level8.Enabled = false;
                        tree2Level8.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 17)
                    {
                        tree2Level9.Enabled = false;
                        tree2Level9.Value = 0;
                    }
                    else if (subClassTreeLevel2.Value < 19)
                    {
                        tree2Level10.Enabled = false;
                        tree2Level10.Value = 0;
                    }
                    subTree2--;
                    newDisPoints += levelCosts[subTree2];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
            }
            else if (set2 && subClassTreeLevel2.Value == subTree2)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                subTree2--;
                newDisPoints += levelCosts[subTree2];
                disPointsLabel.Text = newDisPoints.ToString();

                if (subClassTreeLevel2.Value == 1)
                {
                    set2 = false;
                }
            }
            else set2 = false;
        }

        private void subClassTreeLevel3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel3.Value == 19)
            {
                maxPowLevel3 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel3.Value >= 15)
            {
                maxPowLevel3 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel3.Value >= 11)
            {
                maxPowLevel3 = 3;
            }
            else
            {
                maxPowLevel3 = 2;
            }

            if (!set3)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel3.Value > subTree3)
                {
                    newDisPoints -= levelCosts[subTree3];

                    if (newDisPoints < 0)
                    {
                        set3 = true;
                        subClassTreeLevel3.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel3.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel3.Value == 19)
                            {
                                tree3Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 17)
                            {
                                tree3Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 15)
                            {
                                tree3Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 13)
                            {
                                tree3Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 11)
                            {
                                tree3Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 9)
                            {
                                tree3Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 7)
                            {
                                tree3Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 5)
                            {
                                tree3Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel3.Value >= 3)
                            {
                                tree3Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree3++;
                        }
                        else
                        {
                            set3 = true;
                            subClassTreeLevel3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel3.Value == subTree3)
                {
                    if (subClassTreeLevel3.Value < 3)
                    {
                        tree3Level2.Enabled = false;
                        tree3Level2.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 5)
                    {
                        tree3Level3.Enabled = false;
                        tree3Level3.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 7)
                    {
                        tree3Level4.Enabled = false;
                        tree3Level4.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 9)
                    {
                        tree3Level5.Enabled = false;
                        tree3Level5.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 11)
                    {
                        tree3Level6.Enabled = false;
                        tree3Level6.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 13)
                    {
                        tree3Level7.Enabled = false;
                        tree3Level7.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 15)
                    {
                        tree3Level8.Enabled = false;
                        tree3Level8.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 17)
                    {
                        tree3Level9.Enabled = false;
                        tree3Level9.Value = 0;
                    }
                    else if (subClassTreeLevel3.Value < 19)
                    {
                        tree3Level10.Enabled = false;
                        tree3Level10.Value = 0;
                    }
                    subTree3--;
                    newDisPoints += levelCosts[subTree3];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
            }
            else if (set3 && subClassTreeLevel3.Value == subTree3)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                subTree3--;
                newDisPoints += levelCosts[subTree3];
                disPointsLabel.Text = newDisPoints.ToString();

                if (subClassTreeLevel3.Value == 1)
                {
                    set3 = false;
                }
            }
            else set3 = false;
        }

        private void subClassTreeLevel4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel4.Value == 19)
            {
                maxPowLevel4 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel4.Value >= 15)
            {
                maxPowLevel4 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel4.Value >= 11)
            {
                maxPowLevel4 = 3;
            }
            else
            {
                maxPowLevel4 = 2;
            }

            if (!set4)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel4.Value > subTree4)
                {
                    newDisPoints -= levelCosts[subTree4];

                    if (newDisPoints < 0)
                    {
                        set4 = true;
                        subClassTreeLevel4.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel4.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel4.Value == 19)
                            {
                                tree4Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 17)
                            {
                                tree4Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 15)
                            {
                                tree4Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 13)
                            {
                                tree4Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 11)
                            {
                                tree4Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 9)
                            {
                                tree4Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 7)
                            {
                                tree4Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 5)
                            {
                                tree4Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel4.Value >= 3)
                            {
                                tree4Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree4++;
                        }
                        else
                        {
                            set4 = true;
                            subClassTreeLevel4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel4.Value == subTree4)
                {
                    if (subClassTreeLevel4.Value < 3)
                    {
                        tree4Level2.Enabled = false;
                        tree4Level2.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 5)
                    {
                        tree4Level3.Enabled = false;
                        tree4Level3.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 7)
                    {
                        tree4Level4.Enabled = false;
                        tree4Level4.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 9)
                    {
                        tree4Level5.Enabled = false;
                        tree4Level5.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 11)
                    {
                        tree4Level6.Enabled = false;
                        tree4Level6.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 13)
                    {
                        tree4Level7.Enabled = false;
                        tree4Level7.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 15)
                    {
                        tree4Level8.Enabled = false;
                        tree4Level8.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 17)
                    {
                        tree4Level9.Enabled = false;
                        tree4Level9.Value = 0;
                    }
                    else if (subClassTreeLevel4.Value < 19)
                    {
                        tree4Level10.Enabled = false;
                        tree4Level10.Value = 0;
                    }
                    subTree4--;
                    newDisPoints += levelCosts[subTree4];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
            }
            else if (set4 && subClassTreeLevel4.Value == subTree4)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                subTree4--;
                newDisPoints += levelCosts[subTree4];
                disPointsLabel.Text = newDisPoints.ToString();

                if (subClassTreeLevel4.Value == 1)
                {
                    set4 = false;
                }
            }
            else set4 = false;
        }

        private void subClassTreeLevel5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel5.Value == 19)
            {
                maxPowLevel5 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel5.Value >= 15)
            {
                maxPowLevel5 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel5.Value >= 11)
            {
                maxPowLevel5 = 3;
            }
            else
            {
                maxPowLevel5 = 2;
            }

            if (!set5)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel5.Value > subTree5)
                {
                    newDisPoints -= levelCosts[subTree5];

                    if (newDisPoints < 0)
                    {
                        set5 = true;
                        subClassTreeLevel5.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel5.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel5.Value == 19)
                            {
                                tree5Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 17)
                            {
                                tree5Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 15)
                            {
                                tree5Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 13)
                            {
                                tree5Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 11)
                            {
                                tree5Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 9)
                            {
                                tree5Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 7)
                            {
                                tree5Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 5)
                            {
                                tree5Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel5.Value >= 3)
                            {
                                tree5Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree5++;
                        }
                        else
                        {
                            set5 = true;
                            subClassTreeLevel5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel5.Value == subTree5)
                {
                    if (subClassTreeLevel5.Value < 3)
                    {
                        tree5Level2.Enabled = false;
                        tree5Level2.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 5)
                    {
                        tree5Level3.Enabled = false;
                        tree5Level3.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 7)
                    {
                        tree5Level4.Enabled = false;
                        tree5Level4.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 9)
                    {
                        tree5Level5.Enabled = false;
                        tree5Level5.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 11)
                    {
                        tree5Level6.Enabled = false;
                        tree5Level6.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 13)
                    {
                        tree5Level7.Enabled = false;
                        tree5Level7.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 15)
                    {
                        tree5Level8.Enabled = false;
                        tree5Level8.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 17)
                    {
                        tree5Level9.Enabled = false;
                        tree5Level9.Value = 0;
                    }
                    else if (subClassTreeLevel5.Value < 19)
                    {
                        tree5Level10.Enabled = false;
                        tree5Level10.Value = 0;
                    }
                    subTree5--;
                    newDisPoints += levelCosts[subTree5];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
            }
            else if (set4 && subClassTreeLevel5.Value == subTree5)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                subTree5--;
                newDisPoints += levelCosts[subTree5];
                disPointsLabel.Text = newDisPoints.ToString();

                if (subClassTreeLevel5.Value == 1)
                {
                    set5 = false;
                }
            }
            else set5 = false;
        }

        private void subClassTreeLevel6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel6.Value == 19)
            {
                maxPowLevel6 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel6.Value >= 15)
            {
                maxPowLevel6 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel6.Value >= 11)
            {
                maxPowLevel6 = 3;
            }
            else
            {
                maxPowLevel6 = 2;
            }

            if (!set6)
            {

                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel6.Value > subTree6)
                {
                    newDisPoints -= levelCosts[subTree6];

                    if (newDisPoints < 0)
                    {
                        set6 = true;
                        subClassTreeLevel6.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel6.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel6.Value == 19)
                            {
                                tree6Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 17)
                            {
                                tree6Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 15)
                            {
                                tree6Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 13)
                            {
                                tree6Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 11)
                            {
                                tree6Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 9)
                            {
                                tree6Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 7)
                            {
                                tree6Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 5)
                            {
                                tree6Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel6.Value >= 3)
                            {
                                tree6Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree6++;
                        }
                        else
                        {
                            set6 = true;
                            subClassTreeLevel6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel6.Value == subTree6)
                {
                    if (subClassTreeLevel6.Value < 3)
                    {
                        tree6Level2.Enabled = false;
                        tree6Level2.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 5)
                    {
                        tree6Level3.Enabled = false;
                        tree6Level3.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 7)
                    {
                        tree6Level4.Enabled = false;
                        tree6Level4.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 9)
                    {
                        tree6Level5.Enabled = false;
                        tree6Level5.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 11)
                    {
                        tree6Level6.Enabled = false;
                        tree6Level6.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 13)
                    {
                        tree6Level7.Enabled = false;
                        tree6Level7.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 15)
                    {
                        tree6Level8.Enabled = false;
                        tree6Level8.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 17)
                    {
                        tree6Level9.Enabled = false;
                        tree6Level9.Value = 0;
                    }
                    else if (subClassTreeLevel6.Value < 19)
                    {
                        tree6Level10.Enabled = false;
                        tree6Level10.Value = 0;
                    }
                    subTree6--;
                    newDisPoints += levelCosts[subTree6];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
            }
            else if (set6 && subClassTreeLevel6.Value == subTree6)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                subTree6--;
                newDisPoints += levelCosts[subTree6];
                disPointsLabel.Text = newDisPoints.ToString();

                if (subClassTreeLevel6.Value == 1)
                {
                    set6 = false;
                }
            }
            else set6 = false;
        }

        private void subClassTreeLevel7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (selectedLevel >= 37 && subClassTreeLevel7.Value == 19)
            {
                maxPowLevel7 = 5;
            }
            else if (selectedLevel >= 29 && subClassTreeLevel7.Value >= 15)
            {
                maxPowLevel7 = 4;
            }
            else if (selectedLevel >= 19 && subClassTreeLevel7.Value >= 11)
            {
                maxPowLevel7 = 3;
            }
            else
            {
                maxPowLevel7 = 2;
            }

            if (!set7)
            {

                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (subClassTreeLevel7.Value > subTree7)
                {
                    newDisPoints -= levelCosts[subTree7];

                    if (newDisPoints < 0)
                    {
                        set7 = true;
                        subClassTreeLevel7.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (subClassTreeLevel7.Value <= maxTreeLevel)
                        {

                            if (subClassTreeLevel7.Value == 19)
                            {
                                tree7Level10.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 17)
                            {
                                tree7Level9.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 15)
                            {
                                tree7Level8.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 13)
                            {
                                tree7Level7.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 11)
                            {
                                tree7Level6.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 9)
                            {
                                tree7Level5.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 7)
                            {
                                tree7Level4.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 5)
                            {
                                tree7Level3.Enabled = true;
                            }
                            else if (subClassTreeLevel7.Value >= 3)
                            {
                                tree7Level2.Enabled = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            subTree7++;
                        }
                        else
                        {
                            set7 = true;
                            subClassTreeLevel7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (subClassTreeLevel7.Value == subTree7)
                {
                    if (subClassTreeLevel7.Value < 3)
                    {
                        tree7Level2.Enabled = false;
                        tree7Level2.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 5)
                    {
                        tree7Level3.Enabled = false;
                        tree7Level3.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 7)
                    {
                        tree7Level4.Enabled = false;
                        tree7Level4.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 9)
                    {
                        tree7Level5.Enabled = false;
                        tree7Level5.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 11)
                    {
                        tree7Level6.Enabled = false;
                        tree7Level6.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 13)
                    {
                        tree7Level7.Enabled = false;
                        tree7Level7.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 15)
                    {
                        tree7Level8.Enabled = false;
                        tree7Level8.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 17)
                    {
                        tree7Level9.Enabled = false;
                        tree7Level9.Value = 0;
                    }
                    else if (subClassTreeLevel7.Value < 19)
                    {
                        tree7Level10.Enabled = false;
                        tree7Level10.Value = 0;
                    }
                    subTree7--;
                    newDisPoints += levelCosts[subTree7];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
            }
            else if (set7 && subClassTreeLevel7.Value == subTree7)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                subTree7--;
                newDisPoints += levelCosts[subTree7];
                disPointsLabel.Text = newDisPoints.ToString();

                if (subClassTreeLevel7.Value == 1)
                {
                    set7 = false;
                }
            }
            else set7 = false;
        }

        private void tree1Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level1.Value > firstTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level1.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level1.Value <= maxPowLevel1 || tree1Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree1Level1.Value == firstTreeSkill1)
                {
                    firstTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level1.Value == firstTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level2.Value > firstTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level2.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level2.Value <= maxPowLevel1 || tree1Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree1Level2.Value == firstTreeSkill2)
                {
                    firstTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level2.Value == firstTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level3.Value > firstTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level3.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level3.Value <= maxPowLevel1 || tree1Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree1Level3.Value == firstTreeSkill3)
                {
                    firstTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level3.Value == firstTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level4.Value > firstTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level4.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level4.Value <= maxPowLevel1 || tree1Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree1Level4.Value == firstTreeSkill4)
                {
                    firstTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level4.Value == firstTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level5.Value > firstTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level5.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level5.Value <= maxPowLevel1 || tree1Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree1Level5.Value == firstTreeSkill5)
                {
                    firstTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level5.Value == firstTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level6.Value > firstTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level6.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level6.Value <= maxPowLevel1 || tree1Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree1Level6.Value == firstTreeSkill6)
                {
                    firstTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level6.Value == firstTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level7.Value > firstTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level7.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level7.Value <= maxPowLevel1 || tree1Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree1Level7.Value == firstTreeSkill7)
                {
                    firstTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level7.Value == firstTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level8.Value > firstTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level8.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level8.Value <= maxPowLevel1 || tree1Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree1Level8.Value == firstTreeSkill8)
                {
                    firstTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level8.Value == firstTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level9.Value > firstTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level9.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level9.Value <= maxPowLevel1 || tree1Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree1Level9.Value == firstTreeSkill9)
                {
                    firstTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level9.Value == firstTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree1Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree1Level10.Value > firstTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree1Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree1Level10.Value > maxPowLevel1)
                        {
                            skill1 = true;
                            tree1Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree1Level10.Value <= maxPowLevel1 || tree1Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                firstTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree1Level10.Value == firstTreeSkill10)
                {
                    firstTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree1Level10.Value == firstTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    firstTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree1Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level1.Value > scndTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level1.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level1.Value <= maxPowLevel2 || tree2Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree2Level1.Value == scndTreeSkill1)
                {
                    scndTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level1.Value == scndTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level2.Value > scndTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level2.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level2.Value <= maxPowLevel2 || tree2Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree2Level2.Value == scndTreeSkill2)
                {
                    scndTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level2.Value == scndTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level3.Value > scndTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level3.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level3.Value <= maxPowLevel2 || tree2Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree2Level3.Value == scndTreeSkill3)
                {
                    scndTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level3.Value == scndTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level4.Value > scndTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level4.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level4.Value <= maxPowLevel2 || tree2Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree2Level4.Value == scndTreeSkill4)
                {
                    scndTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level4.Value == scndTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level5.Value > scndTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level5.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level5.Value <= maxPowLevel2 || tree2Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree2Level5.Value == scndTreeSkill5)
                {
                    scndTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level5.Value == scndTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level6.Value > scndTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level6.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level6.Value <= maxPowLevel2 || tree2Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree2Level6.Value == scndTreeSkill6)
                {
                    scndTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level6.Value == scndTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level7.Value > scndTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level7.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level7.Value <= maxPowLevel2 || tree2Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree2Level7.Value == scndTreeSkill7)
                {
                    scndTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level7.Value == scndTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level8.Value > scndTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level8.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level8.Value <= maxPowLevel2 || tree2Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree2Level8.Value == scndTreeSkill8)
                {
                    scndTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level8.Value == scndTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level9.Value > scndTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level9.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level9.Value <= maxPowLevel2 || tree2Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree2Level9.Value == scndTreeSkill9)
                {
                    scndTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level9.Value == scndTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree2Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree2Level10.Value > scndTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree2Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree2Level10.Value > maxPowLevel2)
                        {
                            skill1 = true;
                            tree2Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree2Level10.Value <= maxPowLevel2 || tree2Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                scndTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree2Level10.Value == scndTreeSkill10)
                {
                    scndTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree2Level10.Value == scndTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    scndTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree2Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level1.Value > thrdTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level1.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level1.Value <= maxPowLevel3 || tree3Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree3Level1.Value == thrdTreeSkill1)
                {
                    thrdTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level1.Value == thrdTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level2.Value > thrdTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level2.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level2.Value <= maxPowLevel3 || tree3Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree3Level2.Value == thrdTreeSkill2)
                {
                    thrdTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level2.Value == thrdTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level3.Value > thrdTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level3.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level3.Value <= maxPowLevel3 || tree3Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree3Level3.Value == thrdTreeSkill3)
                {
                    thrdTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level3.Value == thrdTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level4.Value > thrdTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level4.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level4.Value <= maxPowLevel3 || tree3Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree3Level4.Value == thrdTreeSkill4)
                {
                    thrdTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level4.Value == thrdTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level5.Value > thrdTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level5.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level5.Value <= maxPowLevel3 || tree3Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree3Level5.Value == thrdTreeSkill5)
                {
                    thrdTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level5.Value == thrdTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level6.Value > thrdTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level6.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level6.Value <= maxPowLevel3 || tree3Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree3Level6.Value == thrdTreeSkill6)
                {
                    thrdTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level6.Value == thrdTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level7.Value > thrdTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level7.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level7.Value <= maxPowLevel3 || tree3Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree3Level7.Value == thrdTreeSkill7)
                {
                    thrdTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level7.Value == thrdTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level8.Value > thrdTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level8.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level8.Value <= maxPowLevel3 || tree3Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree3Level8.Value == thrdTreeSkill8)
                {
                    thrdTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level8.Value == thrdTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level9.Value > thrdTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level9.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level9.Value <= maxPowLevel3 || tree3Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree3Level9.Value == thrdTreeSkill9)
                {
                    thrdTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level9.Value == thrdTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree3Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree3Level10.Value > thrdTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree3Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree3Level10.Value > maxPowLevel3)
                        {
                            skill1 = true;
                            tree3Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree3Level10.Value <= maxPowLevel3 || tree3Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                thrdTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree3Level10.Value == thrdTreeSkill10)
                {
                    thrdTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree3Level10.Value == thrdTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    thrdTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree3Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level1.Value > fourthTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level1.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level1.Value <= maxPowLevel4 || tree4Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree4Level1.Value == fourthTreeSkill1)
                {
                    fourthTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level1.Value == fourthTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level2.Value > fourthTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level2.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level2.Value <= maxPowLevel4 || tree4Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree4Level2.Value == fourthTreeSkill2)
                {
                    fourthTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level2.Value == fourthTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level3.Value > fourthTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level3.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level3.Value <= maxPowLevel4 || tree4Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree4Level3.Value == fourthTreeSkill3)
                {
                    fourthTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level3.Value == fourthTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level4.Value > fourthTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level4.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level4.Value <= maxPowLevel4 || tree4Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree4Level4.Value == fourthTreeSkill4)
                {
                    fourthTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level4.Value == fourthTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level5.Value > fourthTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level5.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level5.Value <= maxPowLevel4 || tree4Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree4Level5.Value == fourthTreeSkill5)
                {
                    fourthTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level5.Value == fourthTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level6.Value > fourthTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level6.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level6.Value <= maxPowLevel4 || tree4Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree4Level6.Value == fourthTreeSkill6)
                {
                    fourthTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level6.Value == fourthTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level7.Value > fourthTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level7.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level7.Value <= maxPowLevel4 || tree4Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree4Level7.Value == fourthTreeSkill7)
                {
                    fourthTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level7.Value == fourthTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level8.Value > fourthTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level8.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level8.Value <= maxPowLevel4 || tree4Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree4Level8.Value == fourthTreeSkill8)
                {
                    fourthTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level8.Value == fourthTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level9.Value > fourthTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level9.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level9.Value <= maxPowLevel4 || tree4Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree4Level9.Value == fourthTreeSkill9)
                {
                    fourthTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level9.Value == fourthTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree4Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree4Level10.Value > fourthTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree4Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree4Level10.Value > maxPowLevel4)
                        {
                            skill1 = true;
                            tree4Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree4Level10.Value <= maxPowLevel4 || tree4Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fourthTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree4Level10.Value == fourthTreeSkill10)
                {
                    fourthTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree4Level10.Value == fourthTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fourthTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree4Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level1.Value > fifthTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level1.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level1.Value <= maxPowLevel5 || tree5Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree5Level1.Value == fifthTreeSkill1)
                {
                    fifthTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level1.Value == fifthTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level2.Value > fifthTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level2.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level2.Value <= maxPowLevel5 || tree5Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree5Level2.Value == fifthTreeSkill2)
                {
                    fifthTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level2.Value == fifthTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level3.Value > fifthTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level3.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level3.Value <= maxPowLevel5 || tree5Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree5Level3.Value == fifthTreeSkill3)
                {
                    fifthTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level3.Value == fifthTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level4.Value > fifthTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level4.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level4.Value <= maxPowLevel5 || tree5Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree5Level4.Value == fifthTreeSkill4)
                {
                    fifthTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level4.Value == fifthTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level5.Value > fifthTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level5.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level5.Value <= maxPowLevel5 || tree5Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree5Level5.Value == fifthTreeSkill5)
                {
                    fifthTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level5.Value == fifthTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level6.Value > fifthTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level6.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level6.Value <= maxPowLevel5 || tree5Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree5Level6.Value == fifthTreeSkill6)
                {
                    fifthTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level6.Value == fifthTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level7.Value > fifthTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level7.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level7.Value <= maxPowLevel5 || tree5Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree5Level7.Value == fifthTreeSkill7)
                {
                    fifthTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level7.Value == fifthTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level8.Value > fifthTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level8.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level8.Value <= maxPowLevel5 || tree5Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree5Level8.Value == fifthTreeSkill8)
                {
                    fifthTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level8.Value == fifthTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level9.Value > fifthTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level9.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level9.Value <= maxPowLevel5 || tree5Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree5Level9.Value == fifthTreeSkill9)
                {
                    fifthTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level9.Value == fifthTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree5Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree5Level10.Value > fifthTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree5Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree5Level10.Value > maxPowLevel5)
                        {
                            skill1 = true;
                            tree5Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree5Level10.Value <= maxPowLevel5 || tree5Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                fifthTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree5Level10.Value == fifthTreeSkill10)
                {
                    fifthTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree5Level10.Value == fifthTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    fifthTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree5Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level1.Value > sixthTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level1.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level1.Value <= maxPowLevel6 || tree6Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree6Level1.Value == sixthTreeSkill1)
                {
                    sixthTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level1.Value == sixthTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level2.Value > sixthTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level2.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level2.Value <= maxPowLevel6 || tree6Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree6Level2.Value == sixthTreeSkill2)
                {
                    sixthTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level2.Value == sixthTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level3.Value > sixthTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level3.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level3.Value <= maxPowLevel6 || tree6Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree6Level3.Value == sixthTreeSkill3)
                {
                    sixthTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level3.Value == sixthTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level4.Value > sixthTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level4.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level4.Value <= maxPowLevel6 || tree6Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree6Level4.Value == sixthTreeSkill4)
                {
                    sixthTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level4.Value == sixthTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level5.Value > sixthTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level5.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level5.Value <= maxPowLevel6 || tree6Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree6Level5.Value == sixthTreeSkill5)
                {
                    sixthTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level5.Value == sixthTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level6.Value > sixthTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level6.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level6.Value <= maxPowLevel6 || tree6Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree6Level6.Value == sixthTreeSkill6)
                {
                    sixthTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level6.Value == sixthTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level7.Value > sixthTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level7.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level7.Value <= maxPowLevel6 || tree6Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree6Level7.Value == sixthTreeSkill7)
                {
                    sixthTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level7.Value == sixthTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level8.Value > sixthTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level8.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level8.Value <= maxPowLevel6 || tree6Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree6Level8.Value == sixthTreeSkill8)
                {
                    sixthTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level8.Value == sixthTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level9.Value > sixthTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level9.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level9.Value <= maxPowLevel6 || tree6Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree6Level9.Value == sixthTreeSkill9)
                {
                    sixthTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level9.Value == sixthTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree6Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree6Level10.Value > sixthTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree6Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree6Level10.Value > maxPowLevel6)
                        {
                            skill1 = true;
                            tree6Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree6Level10.Value <= maxPowLevel6 || tree6Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                sixthTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree6Level10.Value == sixthTreeSkill10)
                {
                    sixthTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree6Level10.Value == sixthTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    sixthTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree6Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level1_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level1.Value > seventhTreeSkill1)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level1.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level1.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level1.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level1.Value <= maxPowLevel7 || tree7Level1.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill1++;
                            }
                        }
                    }
                }
                else if (tree7Level1.Value == seventhTreeSkill1)
                {
                    seventhTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level1.Value == seventhTreeSkill1)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill1--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level1.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level2_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level2.Value > seventhTreeSkill2)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level2.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level2.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level2.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level2.Value <= maxPowLevel7 || tree7Level2.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill2++;
                            }
                        }
                    }
                }
                else if (tree7Level2.Value == seventhTreeSkill2)
                {
                    seventhTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level2.Value == seventhTreeSkill2)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill2--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level2.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level3_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level3.Value > seventhTreeSkill3)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level3.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level3.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level3.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level3.Value <= maxPowLevel7 || tree7Level3.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill3++;
                            }
                        }
                    }
                }
                else if (tree7Level3.Value == seventhTreeSkill3)
                {
                    seventhTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level3.Value == seventhTreeSkill3)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill3--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level3.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level4_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level4.Value > seventhTreeSkill4)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level4.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level4.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level4.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level4.Value <= maxPowLevel7 || tree7Level4.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill4++;
                            }
                        }
                    }
                }
                else if (tree7Level4.Value == seventhTreeSkill4)
                {
                    seventhTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level4.Value == seventhTreeSkill4)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill4--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level4.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level5_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level5.Value > seventhTreeSkill5)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level5.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level5.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level5.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level5.Value <= maxPowLevel7 || tree7Level5.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill5++;
                            }
                        }
                    }
                }
                else if (tree7Level5.Value == seventhTreeSkill5)
                {
                    seventhTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level5.Value == seventhTreeSkill5)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill5--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level5.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level6_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level6.Value > seventhTreeSkill6)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level6.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level6.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level6.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level6.Value <= maxPowLevel7 || tree7Level6.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill6++;
                            }
                        }
                    }
                }
                else if (tree7Level6.Value == seventhTreeSkill6)
                {
                    seventhTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level6.Value == seventhTreeSkill6)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill6--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level6.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level7_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level7.Value > seventhTreeSkill7)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level7.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level7.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level7.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level7.Value <= maxPowLevel7 || tree7Level7.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill7++;
                            }
                        }
                    }
                }
                else if (tree7Level7.Value == seventhTreeSkill7)
                {
                    seventhTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level7.Value == seventhTreeSkill7)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill7--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level7.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level8_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level8.Value > seventhTreeSkill8)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level8.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level8.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level8.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level8.Value <= maxPowLevel7 || tree7Level8.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill8++;
                            }
                        }
                    }
                }
                else if (tree7Level8.Value == seventhTreeSkill8)
                {
                    seventhTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level8.Value == seventhTreeSkill8)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill8--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level8.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level9_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level9.Value > seventhTreeSkill9)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level9.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level9.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level9.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level9.Value <= maxPowLevel7 || tree7Level9.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill9++;
                            }
                        }
                    }
                }
                else if (tree7Level9.Value == seventhTreeSkill9)
                {
                    seventhTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level9.Value == seventhTreeSkill9)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill9--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level9.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void tree7Level10_ValueChanged(object sender, EventArgs e)
        {
            int selectedLevel = Int32.Parse(level_drop.SelectedItem.ToString());

            if (!skill1)
            {
                int powPoints = Int32.Parse(powPointsLabel.Text);
                int newPowPoints = powPoints;

                if (tree7Level10.Value > seventhTreeSkill10)
                {
                    newPowPoints--;

                    if (newPowPoints < 0)
                    {
                        skill1 = true;
                        tree7Level10.Value--;
                        MessageBox.Show("Not enough power points.");
                    }
                    else
                    {
                        if (tree7Level10.Value > maxPowLevel7)
                        {
                            skill1 = true;
                            tree7Level10.Value--;
                            MessageBox.Show("Level too low.");
                        }
                        else
                        {
                            if (tree7Level10.Value <= maxPowLevel7 || tree7Level10.Value == 5)
                            {
                                powPointsLabel.Text = newPowPoints.ToString();
                                seventhTreeSkill10++;
                            }
                        }
                    }
                }
                else if (tree7Level10.Value == seventhTreeSkill10)
                {
                    seventhTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();
                }
                else if (skill1 && tree7Level10.Value == seventhTreeSkill10)
                {
                    powPoints = Int32.Parse(powPointsLabel.Text);
                    newPowPoints = powPoints;

                    seventhTreeSkill10--;
                    newPowPoints++;
                    powPointsLabel.Text = newPowPoints.ToString();

                    if (tree7Level10.Value == 1)
                    {
                        skill1 = false;
                    }
                }
            }
            else skill1 = false;
        }

        private void wmTreeLvl_ValueChanged(object sender, EventArgs e)
        {
            if (!wm1)
            {
                int disPoints = Int32.Parse(disPointsLabel.Text);
                int newDisPoints = disPoints;

                if (wmTreeLvl.Value > wmTreeLevel)
                {
                    newDisPoints -= levelCosts[wmTreeLevel];

                    if (newDisPoints < 0)
                    {
                        wm1 = true;
                        wmTreeLvl.Value--;
                        MessageBox.Show("Not enough discipline points.");
                    }
                    else
                    {
                        if (wmTreeLvl.Value <= maxTreeLevel)
                        {

                            if (wmTreeLvl.Value == 19)
                            {
                                wmSkill5.Visible = true;
                                wmLabel5.Visible = true;
                            }
                            else if (wmTreeLvl.Value >= 15)
                            {
                                wmSkill4.Visible = true;
                                wmLabel4.Visible = true;
                            }
                            else if (wmTreeLvl.Value >= 11)
                            {
                                wmSkill3.Visible = true;
                                wmLabel3.Visible = true;
                            }
                            else if (wmTreeLvl.Value >= 7)
                            {
                                wmSkill2.Visible = true;
                                wmLabel2.Visible = true;
                            }
                            else if (wmTreeLvl.Value >= 3)
                            {
                                wmSkill1.Visible = true;
                                wmLabel1.Visible = true;
                            }
                            disPointsLabel.Text = newDisPoints.ToString();
                            wmTreeLevel++;
                        }
                        else
                        {
                            wm1 = true;
                            wmTreeLvl.Value--;
                            MessageBox.Show("Level too low.");
                        }
                    }
                }
                else if (wmTreeLvl.Value == wmTreeLevel)
                {
                    if (wmTreeLvl.Value < 3)
                    {
                        wmSkill1.Visible = false;
                        wmLabel1.Visible = false;
                    }
                    else if (wmTreeLvl.Value < 7)
                    {
                        wmSkill2.Visible = false;
                        wmLabel2.Visible = false;
                    }
                    else if (wmTreeLvl.Value < 11)
                    {
                        wmSkill3.Visible = false;
                        wmLabel3.Visible = false;
                    }
                    else if (wmTreeLvl.Value < 15)
                    {
                        wmSkill4.Visible = false;
                        wmLabel4.Visible = false;
                    }
                    else if (wmTreeLvl.Value < 19)
                    {
                        wmSkill5.Visible = false;
                        wmLabel5.Visible = false;
                    }
                    wmTreeLevel--;
                    newDisPoints += levelCosts[wmTreeLevel];
                    disPointsLabel.Text = newDisPoints.ToString();
                }
                else if (wm1 && wmTreeLvl.Value == wmTreeLevel)
                {
                    disPoints = Int32.Parse(disPointsLabel.Text);
                    newDisPoints = disPoints;

                    wmTreeLevel--;
                    newDisPoints += levelCosts[wmTreeLevel];
                    disPointsLabel.Text = newDisPoints.ToString();

                    if (wmTreeLvl.Value == 1)
                    {
                        wm1 = false;
                    }
                }
            }
            else wm1 = false;
        }
    }
}

