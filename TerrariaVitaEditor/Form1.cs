using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TerrariaVitaEditor
{
    public partial class Form1 : Form
    {

        //INVENTORY
        string itemID1;
        string itemID2;
        string itemID3;
        string itemID4;
        string itemID5;
        string itemID6;
        string itemID7;
        string itemID8;
        string itemID9;
        string itemID10;
        string itemID11;
        string itemID12;
        string itemID13;
        string itemID14;
        string itemID15;
        string itemID16;
        string itemID17;
        string itemID18;
        string itemID19;
        string itemID20;
        string itemID21;
        string itemID22;
        string itemID23;
        string itemID24;
        string itemID25;
        string itemID26;
        string itemID27;
        string itemID28;
        string itemID29;
        string itemID30;
        string itemID31;
        string itemID32;
        string itemID33;
        string itemID34;
        string itemID35;
        string itemID36;
        string itemID37;
        string itemID38;
        string itemID39;
        string itemID40;

        //AMMOS
        string itemID41;
        string itemID42;
        string itemID43;
        string itemID44;

        string itemCOUNT41;
        string itemCOUNT42;
        string itemCOUNT43;
        string itemCOUNT44;

        //COINS
        string itemID45;
        string itemID46;
        string itemID47;
        string itemID48;

        string itemCOUNT45;
        string itemCOUNT46;
        string itemCOUNT47;
        string itemCOUNT48;

        //EQUIPEDARMOR
        string armorhelmetid;
        string armorchestid;
        string armorbootsid;

        string armorhelmetprefixid;
        string armorchestprefixid;
        string armorbootsprefixid;

        //EQUIPEDVANITY
        string vanityhelmetid;
        string vanitychestid;
        string vanityrbootsid;

        string vanityhelmetprefixid;
        string vanitychestprefixid;
        string vanityrbootsprefixid;

        //EQUIPEDACCESSORIES
        string accessoriesoneid;
        string accessoriesoneprefixid;
        string accessoriestwoid;
        string accessoriestwoprefixid;
        string accessoriesthreeid;
        string accessoriesthreeprefixid;
        string accessoriesfourid;
        string accessoriesfourprefixid;
        string accessoriesfiveid;
        string accessoriesfiveprefixid;

        public Form1()
        {
            InitializeComponent();

            label69.Parent = pictureBox41;
            label69.BackColor = Color.Transparent;
        }

        public string path;

        //Pour la sauvegarde
        public string endfile;
        public string HPMANA;

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox2.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox3.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox4.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox5.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox6.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox7.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox8.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox9.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox10.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox11.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox12.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox13.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox14.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox15.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox16.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox17.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox18.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox19.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox20.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox21.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox22.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox23.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox24.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox25.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox26.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox27.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox28.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox29.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox30.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox31.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox32.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox33.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox34.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox35.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox36.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox37.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox38.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox39.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox40.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox41.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox42.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox43.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox44.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox45.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox46.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox47.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");
            pictureBox48.BackgroundImage = Image.FromFile("Images\\Items\\Item_0.png");

            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            Text = openFileDialog1.FileName;

            try
            {
            FileStream fs = new FileStream(path, FileMode.Open);
            int hexIn;
            string hex = null;

            List<string> value = new List<string>();

            for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
            {
                hex = string.Format("{0:X2}", hexIn);
                value.Add(hex);
            }

            string file = null;
            foreach (string hexvalue in value)
            {
                file = file + hexvalue ;
            }

            fs.Close();

            groupBox1.Enabled = true;
            groupBox8.Enabled = true;
            groupBox9.Enabled = true;
            groupBox10.Enabled = true;

            groupBox5.Enabled = true;
            groupBox6.Enabled = true;
            groupBox7.Enabled = true;


            textBox2.Text = file;

            Interpreter(file);
            }
            catch {}

        }

        private void Interpreter(string file)
        {
            if (file.StartsWith("1500"))
            {    
                try
                {
                    file = file.Remove(0, 4);

                    file = Pseudo(file);

                    file = Difficulty(file);

                    file = HairStyle(file);

                    file = Sex(file);

                    HPMANA = file.Remove(16, file.Length - 16);
                    
                    file = file.Remove(0, 16); //TODO (Helth + Mana)

                    file = ColorPlayer(file);

                    file = EquippedArmor(file);

                    file = EquippedAccessories(file);

                    file = EquippedVanity(file);

                    file = Inventory(file);

                    file = Coin(file);

                    file = Ammo(file);

                    button3.Enabled = true;
                    button2.Enabled = true;
                    textBox2.Enabled = true;

                    endfile = file;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("This is not a valid Vita PLR file!");
            }
        }

        private string Ammo(string file)
        {
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID41 = "0";
            }
            else
            {
                try
                {
                    string ammo1 = file.Remove(10, file.Length - 10);
                    string ammo1PART1 = ammo1.Remove(0, 2);
                    ammo1PART1 = ammo1PART1.Remove(2, 6);
                    string ammo1PART2 = ammo1.Remove(2, 8);
                    string realammo1 = ammo1PART1 + ammo1PART2;
                    int ammo1id = Convert.ToInt32(realammo1, 16);

                    itemCOUNT41 = ammo1.Remove(0 , 4);
                    itemCOUNT41 = itemCOUNT41.Remove(4, 2);
                    string itemCOUNT41PART1 = itemCOUNT41.Remove(0, 2);
                    string itemCOUNT41PART2 = itemCOUNT41.Remove(2, 2);
                    itemCOUNT41 = Convert.ToInt32(itemCOUNT41PART1 + itemCOUNT41PART2, 16).ToString();
                    label69.Text = itemCOUNT41;
                    itemID41 = ammo1id.ToString();

                    pictureBox41.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + ammo1id + ".png");
                }
                catch
                {
                    pictureBox41.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID42 = "0";
            }
            else
            {
                try
                {
                    string ammo2 = file.Remove(10, file.Length - 10);
                    MessageBox.Show(ammo2);
                    string ammo2PART1 = ammo2.Remove(0, 2);
                    ammo2PART1 = ammo2PART1.Remove(2, 6);
                    string ammo2PART2 = ammo2.Remove(2, 8);
                    string realammo2 = ammo2PART1 + ammo2PART2;
                    int ammo2id = Convert.ToInt32(realammo2, 16);
                    itemID42 = ammo2id.ToString();
                    pictureBox42.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + ammo2id + ".png");
                }
                catch
                {
                    pictureBox42.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID43 = "0";
            }
            else
            {
                try
                {
                    string ammo3 = file.Remove(10, file.Length - 10);
                    string ammo3PART1 = ammo3.Remove(0, 2);
                    ammo3PART1 = ammo3PART1.Remove(2, 6);
                    string ammo3PART2 = ammo3.Remove(2, 8);
                    string realammo3 = ammo3PART1 + ammo3PART2;
                    int ammo3id = Convert.ToInt32(realammo3, 16);
                    itemID43 = ammo3id.ToString();
                    pictureBox43.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + ammo3id + ".png");
                }
                catch
                {
                    pictureBox43.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID44 = "0";
            }
            else
            {
                try
                {
                    string ammo4 = file.Remove(10, file.Length - 10);
                    string ammo4PART1 = ammo4.Remove(0, 2);
                    ammo4PART1 = ammo4PART1.Remove(2, 6);
                    string ammo4PART2 = ammo4.Remove(2, 8);
                    string realammo4 = ammo4PART1 + ammo4PART2;
                    int ammo4id = Convert.ToInt32(realammo4, 16);
                    itemID44 = ammo4id.ToString();
                    pictureBox44.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + ammo4id + ".png");
                }
                catch
                {
                    pictureBox44.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }

                file = file.Remove(0, 10);
            }

            return file;
        }

        private string Coin(string file)
        {
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID45 = "0";
            }
            else
            {
                try
                {
                    string coin1 = file.Remove(10, file.Length - 10);
                    string coin1PART1 = coin1.Remove(0, 2);
                    coin1PART1 = coin1PART1.Remove(2, 6);
                    string coin1PART2 = coin1.Remove(2, 8);
                    string realcoin1 = coin1PART1 + coin1PART2;
                    int coin1id = Convert.ToInt32(realcoin1, 16);
                    itemID45 = coin1id.ToString();
                    pictureBox45.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + coin1id + ".png");
                }
                catch
                {
                    pictureBox45.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID46 = "0";
            }
            else
            {
                try
                {
                    string coin2 = file.Remove(10, file.Length - 10);
                    string coin2PART1 = coin2.Remove(0, 2);
                    coin2PART1 = coin2PART1.Remove(2, 6);
                    string coin2PART2 = coin2.Remove(2, 8);
                    string realcoin2 = coin2PART1 + coin2PART2;
                    int coin2id = Convert.ToInt32(realcoin2, 16);
                    itemID46 = coin2id.ToString();
                    pictureBox46.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + coin2id + ".png");
                }
                catch
                {
                    pictureBox46.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID47 = "0";
            }
            else
            {
                try
                {
                    string coin3 = file.Remove(10, file.Length - 10);
                    string coin3PART1 = coin3.Remove(0, 2);
                    coin3PART1 = coin3PART1.Remove(2, 6);
                    string coin3PART2 = coin3.Remove(2, 8);
                    string realcoin3 = coin3PART1 + coin3PART2;
                    int coin3id = Convert.ToInt32(realcoin3, 16);
                    itemID47 = coin3id.ToString();
                    pictureBox47.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + coin3id + ".png");
                }
                catch
                {
                    pictureBox47.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID48 = "0";
            }
            else
            {
                try
                {
                    string coin4 = file.Remove(10, file.Length - 10);
                    string coin4PART1 = coin4.Remove(0, 2);
                    coin4PART1 = coin4PART1.Remove(2, 6);
                    string coin4PART2 = coin4.Remove(2, 8);
                    string realcoin4 = coin4PART1 + coin4PART2;
                    int coin4id = Convert.ToInt32(realcoin4, 16);
                    itemID48 = coin4id.ToString();
                    pictureBox48.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + coin4id + ".png");
                }
                catch
                {
                    pictureBox48.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            return file;
        }

        string unknwonone;

        private string Inventory(string file)
        {
            unknwonone = file.Remove(54, file.Length - 54);

            file = file.Remove(0, 54);

            //ITEM 1
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID1 = "0";
            }
            else
            {
                try
                {
                    string item1 = file.Remove(10, file.Length - 10);
                    string item1PART1 = item1.Remove(0, 2);
                    item1PART1 = item1PART1.Remove(2, 6);
                    string item1PART2 = item1.Remove(2, 8);
                    string realitem1 = item1PART1 + item1PART2;
                    int item1id = Convert.ToInt32(realitem1, 16);
                    itemID1 = item1id.ToString();
                    pictureBox1.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item1id + ".png");

                }
                catch
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }

                file = file.Remove(0, 10);
            }

            //ITEM 2
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID2 = "0";
            }
            else
            {
                try
                {
                    string item2 = file.Remove(10, file.Length - 10);
                    string item2PART1 = item2.Remove(0, 2);
                    item2PART1 = item2PART1.Remove(2, 6);
                    string item2PART2 = item2.Remove(2, 8);
                    string realitem2 = item2PART1 + item2PART2;
                    int item2id = Convert.ToInt32(realitem2, 16);
                    itemID2 = item2id.ToString();
                    pictureBox2.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item2id + ".png");
                }
                catch
                {
                    pictureBox2.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 3
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID3 = "0";
            }
            else
            {
                try
                {
                    string item3 = file.Remove(10, file.Length - 10);
                    string item3PART1 = item3.Remove(0, 2);
                    item3PART1 = item3PART1.Remove(2, 6);
                    string item3PART2 = item3.Remove(2, 8);
                    string realitem3 = item3PART1 + item3PART2;
                    int item3id = Convert.ToInt32(realitem3, 16);
                    itemID3 = item3id.ToString();
                    pictureBox3.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item3id + ".png");
                }
                catch
                {
                    pictureBox3.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            } 

            //ITEM 4
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID4 = "0";
            }
            else
            {
                try
                {
                    string item4 = file.Remove(10, file.Length - 10);
                    string item4PART1 = item4.Remove(0, 2);
                    item4PART1 = item4PART1.Remove(2, 6);
                    string item4PART2 = item4.Remove(2, 8);
                    string realitem4 = item4PART1 + item4PART2;
                    int item4id = Convert.ToInt32(realitem4, 16);
                    itemID4 = item4id.ToString();
                    pictureBox4.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item4id + ".png");
                }
                catch
                {
                    pictureBox4.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 5
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID5 = "0";
            }
            else
            {
                try
                {
                    string item5 = file.Remove(10, file.Length - 10);
                    string item5PART1 = item5.Remove(0, 2);
                    item5PART1 = item5PART1.Remove(2, 6);
                    string item5PART2 = item5.Remove(2, 8);
                    string realitem5 = item5PART1 + item5PART2;
                    int item5id = Convert.ToInt32(realitem5, 16);
                    itemID5 = item5id.ToString();
                    pictureBox5.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item5id + ".png");
                }
                catch
                {
                    pictureBox5.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            } 

            //ITEM 6
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID6 = "0";
            }
            else
            {
                try
                {
                    string item6 = file.Remove(10, file.Length - 10);
                    string item6PART1 = item6.Remove(0, 2);
                    item6PART1 = item6PART1.Remove(2, 6);
                    string item6PART2 = item6.Remove(2, 8);
                    string realitem6 = item6PART1 + item6PART2;
                    int item6id = Convert.ToInt32(realitem6, 16);
                    itemID6 = item6id.ToString();
                    pictureBox6.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item6id + ".png");
                }
                catch
                {
                    pictureBox6.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 7
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID7 = "0";
            }
            else
            {
                try
                {
                    string item7 = file.Remove(10, file.Length - 10);
                    string item7PART1 = item7.Remove(0, 2);
                    item7PART1 = item7PART1.Remove(2, 6);
                    string item7PART2 = item7.Remove(2, 8);
                    string realitem7 = item7PART1 + item7PART2;
                    int item7id = Convert.ToInt32(realitem7, 16);
                    itemID7 = item7id.ToString();
                    pictureBox7.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item7id + ".png");
                }
                catch
                {
                    pictureBox7.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            } 

            //ITEM 8
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID8 = "0";
            }
            else
            {
                try
                {
                    string item8 = file.Remove(10, file.Length - 10);
                    string item8PART1 = item8.Remove(0, 2);
                    item8PART1 = item8PART1.Remove(2, 6);
                    string item8PART2 = item8.Remove(2, 8);
                    string realitem8 = item8PART1 + item8PART2;
                    int item8id = Convert.ToInt32(realitem8, 16);
                    itemID8 = item8id.ToString();
                    pictureBox8.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item8id + ".png");
                }
                catch
                {
                    pictureBox8.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            } 

            //ITEM 9
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID9 = "0";
            }
            else
            {
                try
                {
                    string item9 = file.Remove(10, file.Length - 10);
                    string item9PART1 = item9.Remove(0, 2);
                    item9PART1 = item9PART1.Remove(2, 6);
                    string item9PART2 = item9.Remove(2, 8);
                    string realitem9 = item9PART1 + item9PART2;
                    int item9id = Convert.ToInt32(realitem9, 16);
                    itemID9 = item9id.ToString();
                    pictureBox9.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item9id + ".png");
                }
                catch
                {
                    pictureBox9.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 10
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID10 = "0";
            }
            else
            {
                try
                {
                    string item10 = file.Remove(10, file.Length - 10);
                    string item10PART1 = item10.Remove(0, 2);
                    item10PART1 = item10PART1.Remove(2, 6);
                    string item10PART2 = item10.Remove(2, 8);
                    string realitem10 = item10PART1 + item10PART2;
                    int item10id = Convert.ToInt32(realitem10, 16);
                    itemID10 = item10id.ToString();
                    pictureBox10.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item10id + ".png");
                }
                catch
                {
                    pictureBox10.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }  

            //ITEM 11
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID11 = "0";
            }
            else
            {
                try
                {
                    string item11 = file.Remove(10, file.Length - 10);
                    string item11PART1 = item11.Remove(0, 2);
                    item11PART1 = item11PART1.Remove(2, 6);
                    string item11PART2 = item11.Remove(2, 8);
                    string realitem11 = item11PART1 + item11PART2;
                    int item11id = Convert.ToInt32(realitem11, 16);
                    itemID11 = item11id.ToString();
                    pictureBox11.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item11id + ".png");
                }
                catch
                {
                    pictureBox11.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }  

            //ITEM 12
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID12 = "0";
            }
            else
            {
                try
                {
                    string item12 = file.Remove(10, file.Length - 10);
                    string item12PART1 = item12.Remove(0, 2);
                    item12PART1 = item12PART1.Remove(2, 6);
                    string item12PART2 = item12.Remove(2, 8);
                    string realitem12 = item12PART1 + item12PART2;
                    int item12id = Convert.ToInt32(realitem12, 16);
                    itemID12 = item12id.ToString();
                    pictureBox12.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item12id + ".png");
                }
                catch
                {
                    pictureBox12.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 13
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID13 = "0";
            }
            else
            {
                try
                {
                    string item13 = file.Remove(10, file.Length - 10);
                    string item13PART1 = item13.Remove(0, 2);
                    item13PART1 = item13PART1.Remove(2, 6);
                    string item13PART2 = item13.Remove(2, 8);
                    string realitem13 = item13PART1 + item13PART2;
                    int item13id = Convert.ToInt32(realitem13, 16);
                    itemID13 = item13id.ToString();
                    pictureBox13.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item13id + ".png");
                }
                catch
                {
                    pictureBox13.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 14
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID14 = "0";
            }
            else
            {
                try
                {
                    string item14 = file.Remove(10, file.Length - 10);
                    string item14PART1 = item14.Remove(0, 2);
                    item14PART1 = item14PART1.Remove(2, 6);
                    string item14PART2 = item14.Remove(2, 8);
                    string realitem14 = item14PART1 + item14PART2;
                    int item14id = Convert.ToInt32(realitem14, 16);
                    itemID14 = item14id.ToString();
                    pictureBox14.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item14id + ".png");
                }
                catch
                {
                    pictureBox14.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 15
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID15 = "0";
            }
            else
            {
                try
                {
                    string item15 = file.Remove(10, file.Length - 10);
                    string item15PART1 = item15.Remove(0, 2);
                    item15PART1 = item15PART1.Remove(2, 6);
                    string item15PART2 = item15.Remove(2, 8);
                    string realitem15 = item15PART1 + item15PART2;
                    int item15id = Convert.ToInt32(realitem15, 16);
                    itemID15 = item15id.ToString();
                    pictureBox15.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item15id + ".png");
                }
                catch
                {
                    pictureBox15.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 16
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID16 = "0";
            }
            else
            {
                try
                {
                    string item16 = file.Remove(10, file.Length - 10);
                    string item16PART1 = item16.Remove(0, 2);
                    item16PART1 = item16PART1.Remove(2, 6);
                    string item16PART2 = item16.Remove(2, 8);
                    string realitem16 = item16PART1 + item16PART2;
                    int item16id = Convert.ToInt32(realitem16, 16);
                    itemID16 = item16id.ToString();
                    pictureBox16.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item16id + ".png");
                }
                catch
                {
                    pictureBox16.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 17
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID17 = "0";
            }
            else
            {
                try
                {
                    string item17 = file.Remove(10, file.Length - 10);
                    string item17PART1 = item17.Remove(0, 2);
                    item17PART1 = item17PART1.Remove(2, 6);
                    string item17PART2 = item17.Remove(2, 8);
                    string realitem17 = item17PART1 + item17PART2;
                    int item17id = Convert.ToInt32(realitem17, 16);
                    itemID17 = item17id.ToString();
                    pictureBox17.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item17id + ".png");
                }
                catch
                {
                    pictureBox17.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 18
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID18 = "0";
            }
            else
            {
                try
                {
                    string item18 = file.Remove(10, file.Length - 10);
                    string item18PART1 = item18.Remove(0, 2);
                    item18PART1 = item18PART1.Remove(2, 6);
                    string item18PART2 = item18.Remove(2, 8);
                    string realitem18 = item18PART1 + item18PART2;
                    int item18id = Convert.ToInt32(realitem18, 16);
                    itemID18 = item18id.ToString();
                    pictureBox18.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item18id + ".png");
                }
                catch
                {
                    pictureBox18.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 19
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID19 = "0";
            }
            else
            {
                try
                {
                    string item19 = file.Remove(10, file.Length - 10);
                    string item19PART1 = item19.Remove(0, 2);
                    item19PART1 = item19PART1.Remove(2, 6);
                    string item19PART2 = item19.Remove(2, 8);
                    string realitem19 = item19PART1 + item19PART2;
                    int item19id = Convert.ToInt32(realitem19, 16);
                    itemID19 = item19id.ToString();
                    pictureBox19.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item19id + ".png");
                }
                catch
                {
                    pictureBox19.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 20
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID20 = "0";
            }
            else
            {
                try
                {
                    string item20 = file.Remove(10, file.Length - 10);
                    string item20PART1 = item20.Remove(0, 2);
                    item20PART1 = item20PART1.Remove(2, 6);
                    string item20PART2 = item20.Remove(2, 8);
                    string realitem20 = item20PART1 + item20PART2;
                    int item20id = Convert.ToInt32(realitem20, 16);
                    itemID20 = item20id.ToString();
                    pictureBox20.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item20id + ".png");
                }
                catch
                {
                    pictureBox20.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 21
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID21 = "0";
            }
            else
            {
                try
                {
                    string item21 = file.Remove(10, file.Length - 10);
                    string item21PART1 = item21.Remove(0, 2);
                    item21PART1 = item21PART1.Remove(2, 6);
                    string item21PART2 = item21.Remove(2, 8);
                    string realitem21 = item21PART1 + item21PART2;
                    int item21id = Convert.ToInt32(realitem21, 16);
                    itemID21 = item21id.ToString();
                    pictureBox21.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item21id + ".png");
                }
                catch
                {
                    pictureBox21.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 22
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID22 = "0";
            }
            else
            {
                try
                {
                    string item22 = file.Remove(10, file.Length - 10);
                    string item22PART1 = item22.Remove(0, 2);
                    item22PART1 = item22PART1.Remove(2, 6);
                    string item22PART2 = item22.Remove(2, 8);
                    string realitem22 = item22PART1 + item22PART2;
                    int item22id = Convert.ToInt32(realitem22, 16);
                    itemID22 = item22id.ToString();
                    pictureBox22.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item22id + ".png");
                }
                catch
                {
                    pictureBox22.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 23
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID23 = "0";
            }
            else
            {
                try
                {
                    string item23 = file.Remove(10, file.Length - 10);
                    string item23PART1 = item23.Remove(0, 2);
                    item23PART1 = item23PART1.Remove(2, 6);
                    string item23PART2 = item23.Remove(2, 8);
                    string realitem23 = item23PART1 + item23PART2;
                    int item23id = Convert.ToInt32(realitem23, 16);
                    itemID23 = item23id.ToString();
                    pictureBox23.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item23id + ".png");
                }
                catch
                {
                    pictureBox23.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 24
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID24 = "0";
            }
            else
            {
                try
                {
                    string item24 = file.Remove(10, file.Length - 10);
                    string item24PART1 = item24.Remove(0, 2);
                    item24PART1 = item24PART1.Remove(2, 6);
                    string item24PART2 = item24.Remove(2, 8);
                    string realitem24 = item24PART1 + item24PART2;
                    int item24id = Convert.ToInt32(realitem24, 16);
                    itemID24 = item24id.ToString();
                    pictureBox24.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item24id + ".png");
                    
                }
                catch
                {
                    pictureBox24.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }

                file = file.Remove(0, 10);
            }

            //ITEM 25
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID25 = "0";
            }
            else
            {
                try
                {
                    string item25 = file.Remove(10, file.Length - 10);
                    string item25PART1 = item25.Remove(0, 2);
                    item25PART1 = item25PART1.Remove(2, 6);
                    string item25PART2 = item25.Remove(2, 8);
                    string realitem25 = item25PART1 + item25PART2;
                    int item25id = Convert.ToInt32(realitem25, 16);
                    itemID25 = item25id.ToString();
                    pictureBox25.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item25id + ".png");
                }
                catch
                {
                    pictureBox24.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                file = file.Remove(0, 10);
            }

            //ITEM 26
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID26 = "0";
            }
            else
            {
                try
                {
                    string item26 = file.Remove(10, file.Length - 10);
                    string item26PART1 = item26.Remove(0, 2);
                    item26PART1 = item26PART1.Remove(2, 6);
                    string item26PART2 = item26.Remove(2, 8);
                    string realitem26 = item26PART1 + item26PART2;
                    int item26id = Convert.ToInt32(realitem26, 16);
                    itemID26 = item26id.ToString();
                    pictureBox26.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item26id + ".png");
                }
                catch
                {
                    pictureBox26.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 27
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID27 = "0";
            }
            else
            {
                try
                {
                    string item27 = file.Remove(10, file.Length - 10);
                    string item27PART1 = item27.Remove(0, 2);
                    item27PART1 = item27PART1.Remove(2, 6);
                    string item27PART2 = item27.Remove(2, 8);
                    string realitem27 = item27PART1 + item27PART2;
                    int item27id = Convert.ToInt32(realitem27, 16);
                    itemID27 = item27id.ToString();
                    pictureBox27.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item27id + ".png");
                }
                catch
                {
                    pictureBox27.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 28
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID28 = "0";
            }
            else
            {
                try
                {
                    string item28 = file.Remove(10, file.Length - 10);
                    string item28PART1 = item28.Remove(0, 2);
                    item28PART1 = item28PART1.Remove(2, 6);
                    string item28PART2 = item28.Remove(2, 8);
                    string realitem28 = item28PART1 + item28PART2;
                    int item28id = Convert.ToInt32(realitem28, 16);
                    itemID28 = item28id.ToString();
                    pictureBox28.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item28id + ".png");
                }
                catch
                {
                    pictureBox28.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 29
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID29 = "0";
            }
            else
            {
                try
                {
                    string item29 = file.Remove(10, file.Length - 10);
                    string item29PART1 = item29.Remove(0, 2);
                    item29PART1 = item29PART1.Remove(2, 6);
                    string item29PART2 = item29.Remove(2, 8);
                    string realitem29 = item29PART1 + item29PART2;
                    int item29id = Convert.ToInt32(realitem29, 16);
                    itemID29 = item29id.ToString();
                    pictureBox29.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item29id + ".png");
                }
                catch
                {
                    pictureBox29.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 30
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID30 = "0";
            }
            else
            {
                try
                {
                    string item30 = file.Remove(10, file.Length - 10);
                    string item30PART1 = item30.Remove(0, 2);
                    item30PART1 = item30PART1.Remove(2, 6);
                    string item30PART2 = item30.Remove(2, 8);
                    string realitem30 = item30PART1 + item30PART2;
                    int item30id = Convert.ToInt32(realitem30, 16);
                    itemID30 = item30id.ToString();
                    pictureBox30.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item30id + ".png");
                }
                catch
                {
                    pictureBox30.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 31
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID31 = "0";
            }
            else
            {
                try
                {
                    string item31 = file.Remove(10, file.Length - 10);
                    string item31PART1 = item31.Remove(0, 2);
                    item31PART1 = item31PART1.Remove(2, 6);
                    string item31PART2 = item31.Remove(2, 8);
                    string realitem31 = item31PART1 + item31PART2;
                    int item31id = Convert.ToInt32(realitem31, 16);
                    itemID31 = item31id.ToString();
                    pictureBox31.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item31id + ".png");
                }
                catch
                {
                    pictureBox31.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 32
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID32 = "0";
            }
            else
            {
                try
                {
                    string item32 = file.Remove(10, file.Length - 10);
                    string item32PART1 = item32.Remove(0, 2);
                    item32PART1 = item32PART1.Remove(2, 6);
                    string item32PART2 = item32.Remove(2, 8);
                    string realitem32 = item32PART1 + item32PART2;
                    int item32id = Convert.ToInt32(realitem32, 16);
                    itemID32 = item32id.ToString();
                    pictureBox32.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item32id + ".png");
                }
                catch
                {
                    pictureBox32.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 33
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID33 = "0";
            }
            else
            {
                try
                {
                    string item33 = file.Remove(10, file.Length - 10);
                    string item33PART1 = item33.Remove(0, 2);
                    item33PART1 = item33PART1.Remove(2, 6);
                    string item33PART2 = item33.Remove(2, 8);
                    string realitem33 = item33PART1 + item33PART2;
                    int item33id = Convert.ToInt32(realitem33, 16);
                    itemID33 = item33id.ToString();
                    pictureBox33.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item33id + ".png");
                }
                catch
                {
                    pictureBox33.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 34
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID34 = "0";
            }
            else
            {
                try
                {
                    string item34 = file.Remove(10, file.Length - 10);
                    string item34PART1 = item34.Remove(0, 2);
                    item34PART1 = item34PART1.Remove(2, 6);
                    string item34PART2 = item34.Remove(2, 8);
                    string realitem34 = item34PART1 + item34PART2;
                    int item34id = Convert.ToInt32(realitem34, 16);
                    itemID34 = item34id.ToString();
                    pictureBox34.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item34id + ".png");
                }
                catch
                {
                    pictureBox34.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 35
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID35 = "0";
            }
            else
            {
                try
                {
                    string item35 = file.Remove(10, file.Length - 10);
                    string item35PART1 = item35.Remove(0, 2);
                    item35PART1 = item35PART1.Remove(2, 6);
                    string item35PART2 = item35.Remove(2, 8);
                    string realitem35 = item35PART1 + item35PART2;
                    int item35id = Convert.ToInt32(realitem35, 16);
                    item35 = item35id.ToString();
                    pictureBox35.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item35id + ".png");
                }
                catch
                {
                    pictureBox35.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 36
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID36 = "0";
            }
            else
            {
                try
                {
                    string item36 = file.Remove(10, file.Length - 10);
                    string item36PART1 = item36.Remove(0, 2);
                    item36PART1 = item36PART1.Remove(2, 6);
                    string item36PART2 = item36.Remove(2, 8);
                    string realitem36 = item36PART1 + item36PART2;
                    int item36id = Convert.ToInt32(realitem36, 16);
                    itemID36 = item36id.ToString();
                    pictureBox36.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item36id + ".png");
                }
                catch
                {
                    pictureBox36.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 37
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID37 = "0";
            }
            else
            {
                try
                {
                    string item37 = file.Remove(10, file.Length - 10);
                    string item37PART1 = item37.Remove(0, 2);
                    item37PART1 = item37PART1.Remove(2, 6);
                    string item37PART2 = item37.Remove(2, 8);
                    string realitem37 = item37PART1 + item37PART2;
                    int item37id = Convert.ToInt32(realitem37, 16);
                    itemID37 = item37id.ToString();
                    pictureBox37.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item37id + ".png");
                }
                catch
                {
                    pictureBox37.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 38
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID38 = "0";
            }
            else
            {
                try
                {
                    string item38 = file.Remove(10, file.Length - 10);
                    string item38PART1 = item38.Remove(0, 2);
                    item38PART1 = item38PART1.Remove(2, 6);
                    string item38PART2 = item38.Remove(2, 8);
                    string realitem38 = item38PART1 + item38PART2;
                    int item38id = Convert.ToInt32(realitem38, 16);
                    itemID38 = item38id.ToString();
                    pictureBox38.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item38id + ".png");
                }
                catch
                {
                    pictureBox38.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }

            //ITEM 39
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID39 = "0";
            }
            else
            {
                try
                {
                    string item39 = file.Remove(10, file.Length - 10);
                    string item39PART1 = item39.Remove(0, 2);
                    item39PART1 = item39PART1.Remove(2, 6);
                    string item39PART2 = item39.Remove(2, 8);
                    string realitem39 = item39PART1 + item39PART2;
                    int item39id = Convert.ToInt32(realitem39, 16);
                    itemID39 = item39id.ToString();
                    pictureBox39.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item39id + ".png");
                    
                }
                catch
                {
                    pictureBox39.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }
            
            //ITEM 40
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                itemID40 = "0";
            }
            else
            {
                try
                {
                    string item40 = file.Remove(10, file.Length - 10);
                    string item40PART1 = item40.Remove(0, 2);
                    item40PART1 = item40PART1.Remove(2, 6);
                    string item40PART2 = item40.Remove(2, 8);
                    string realitem40 = item40PART1 + item40PART2;
                    int item40id = Convert.ToInt32(realitem40, 16);
                    itemID40 = item40id.ToString();
                    pictureBox40.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + item40id + ".png");
                }
                catch
                {
                    pictureBox40.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                
                file = file.Remove(0, 10);
            }
            
            return file;
        }

        private string EquippedVanity(string file)
        {
            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexequippedhelmet = file.Remove(6, file.Length - 6);

            string hexequippedhelmetPART1 = hexequippedhelmet.Remove(0, 2);
            hexequippedhelmetPART1 = hexequippedhelmetPART1.Remove(2, 2);
            string hexequippedhelmetPART2 = hexequippedhelmet.Remove(2, 4);
            string hexequippedhelmetPART3 = hexequippedhelmet.Remove(0, 4);

            string realhexequippedhelmet = hexequippedhelmetPART1 + hexequippedhelmetPART2;
            int equippedhelmetid = Convert.ToInt32(realhexequippedhelmet, 16);
            int equippedhelmetprefixid = Convert.ToInt32(hexequippedhelmetPART3, 16);
            
            try
            {
                pictureBox52.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedhelmetid + ".png");
            }
            catch
            {
                pictureBox52.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            vanityhelmetid = equippedhelmetid.ToString();
            vanityhelmetprefixid = equippedhelmetprefixid.ToString();

            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexequippedchest = file.Remove(6, file.Length - 6);

            string hexequippedchestPART1 = hexequippedchest.Remove(0, 2);
            hexequippedchestPART1 = hexequippedchestPART1.Remove(2, 2);
            string hexequippedchestPART2 = hexequippedchest.Remove(2, 4);
            string hexequippedchestPART3 = hexequippedchest.Remove(0, 4);
            string realhexequippedchest = hexequippedchestPART1 + hexequippedchestPART2;
            int equippedchestid = Convert.ToInt32(realhexequippedchest, 16);
            int equippedchestprefixid = Convert.ToInt32(hexequippedchestPART3, 16);

            try
            {
                pictureBox53.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedchestid + ".png");
            }
            catch
            {
                pictureBox53.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            vanitychestid = equippedchestid.ToString();
            vanitychestprefixid = equippedchestprefixid.ToString();
            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexequippedboots = file.Remove(6, file.Length - 6);

            string hexequippedbootsPART1 = hexequippedboots.Remove(0, 2);
            hexequippedbootsPART1 = hexequippedbootsPART1.Remove(2,2);
            string hexequippedbootsPART2 = hexequippedboots.Remove(2, 4);
            string hexequippedbootsPART3 = hexequippedboots.Remove(0, 4);

            string realhexequippedboots = hexequippedbootsPART1 + hexequippedbootsPART2;
            int equippedbootsid = Convert.ToInt32(realhexequippedboots, 16);
            int equippedbootsprefixid = Convert.ToInt32(hexequippedbootsPART3, 16);

            try
            {
                pictureBox54.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedbootsid + ".png");
            }
            catch
            {
                pictureBox54.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            vanityrbootsid = equippedbootsid.ToString();
            vanityrbootsprefixid = equippedbootsprefixid.ToString();

            file = file.Remove(0, 6);

            return file;
        }

        private string EquippedAccessories(string file)
        {
            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexone = file.Remove(6, file.Length - 6);

            string hexonePART1 = hexone.Remove(0, 2);
            hexonePART1 = hexonePART1.Remove(2, 2);
            string hexonePART2 = hexone.Remove(2, 4);
            string hexonePART3 = hexone.Remove(0, 4);

            string realhexequippedone = hexonePART1 + hexonePART2;
            int equippedoneid = Convert.ToInt32(realhexequippedone, 16);
            int equippedoneprefixid = Convert.ToInt32(hexonePART3, 16);

            try
            {
                pictureBox55.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedoneid + ".png");
            }
            catch
            {
                pictureBox55.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            accessoriesoneid = equippedoneid.ToString();
            accessoriesoneprefixid = equippedoneprefixid.ToString();
            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hextwo = file.Remove(6, file.Length - 6);

            string hextwoPART1 = hextwo.Remove(0, 2);
            hextwoPART1 = hextwoPART1.Remove(2, 2);
            string hextwoPART2 = hextwo.Remove(2, 4);
            string hextwoPART3 = hextwo.Remove(0, 4);
            string realhexequippedtwo = hextwoPART1 + hextwoPART2;
            int equippedtwoid = Convert.ToInt32(realhexequippedtwo, 16);
            int equippedtwoprefixid = Convert.ToInt32(hextwoPART3, 16);

            try
            {
                pictureBox56.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedtwoid + ".png");
            }
            catch
            {
                pictureBox56.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            accessoriestwoid = equippedtwoid.ToString();
            accessoriestwoprefixid = equippedtwoprefixid.ToString();
            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexthree = file.Remove(6, file.Length - 6);

            string hexthreePART1 = hexthree.Remove(0, 2);
            hexthreePART1 = hexthreePART1.Remove(2, 2);
            string hexthreePART2 = hexthree.Remove(2, 4);
            string hexthreePART3 = hexthree.Remove(0, 4);
            string realhexequippedthree = hexthreePART1 + hexthreePART2;
            int equippedthreeid = Convert.ToInt32(realhexequippedthree, 16);
            int equippedthreeprefixid = Convert.ToInt32(hexthreePART3, 16);

            try
            {
                pictureBox57.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedthreeid + ".png");
            }
            catch
            {
                pictureBox57.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            accessoriesthreeid = equippedthreeid.ToString();
            accessoriesthreeprefixid = equippedthreeprefixid.ToString();
            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexfour = file.Remove(6, file.Length - 6);

            string hexfourPART1 = hexfour.Remove(0, 2);
            hexfourPART1 = hexfourPART1.Remove(2, 2);
            string hexfourPART2 = hexfour.Remove(2, 4);
            string hexfourPART3 = hexfour.Remove(0, 4);
            string realhexequippedfour = hexfourPART1 + hexfourPART2;
            int equippedfourid = Convert.ToInt32(realhexequippedfour, 16);
            int equippedfourprefixid = Convert.ToInt32(hexfourPART3, 16);

            try
            {
                pictureBox58.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedfourid + ".png");
            }
            catch
            {
                pictureBox58.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            accessoriesfourid = equippedfourid.ToString();
            accessoriesfourprefixid = equippedfourprefixid.ToString();
            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexfive = file.Remove(6, file.Length - 6);

            string hexfivePART1 = hexfive.Remove(0, 2);
            hexfivePART1 = hexfivePART1.Remove(2, 2);
            string hexfivePART2 = hexfive.Remove(2, 4);
            string hexfivePART3 = hexfive.Remove(0, 4);
            string realhexequippedfive = hexfivePART1 + hexfivePART2;
            int equippedfiveid = Convert.ToInt32(realhexequippedfive, 16);
            int equippedfiveprefixid = Convert.ToInt32(hexfivePART3, 16);

            try
            {
                pictureBox59.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedfiveid + ".png");
            }
            catch
            {
                pictureBox59.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            accessoriesfiveid = equippedfiveid.ToString();
            accessoriesfiveprefixid = equippedfiveprefixid.ToString();
            file = file.Remove(0, 6);

            return file;
        }

        private string EquippedArmor(string file)
        {

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexequippedhelmet = file.Remove(6, file.Length - 6);

            string hexequippedhelmetPART1 = hexequippedhelmet.Remove(0, 2);
            hexequippedhelmetPART1 = hexequippedhelmetPART1.Remove(2, 2);

            string hexequippedhelmetPART2 = hexequippedhelmet.Remove(2, 4);

            string hexequippedhelmetPART3 = hexequippedhelmet.Remove(0, 4);

            string realhexequippedhelmet = hexequippedhelmetPART1 + hexequippedhelmetPART2;

            int equippedhelmetid = Convert.ToInt32(realhexequippedhelmet, 16);
            int equippedhelmetprefixid = Convert.ToInt32(hexequippedhelmetPART3, 16);

            try
            {
                pictureBox49.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedhelmetid + ".png");
            }
            catch
            {
                pictureBox49.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            armorhelmetid = equippedhelmetid.ToString();
            armorhelmetprefixid = equippedhelmetprefixid.ToString();

            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexequippedchest = file.Remove(6, file.Length - 6);

            string hexequippedchestPART1 = hexequippedchest.Remove(0, 2);
            hexequippedchestPART1 = hexequippedchestPART1.Remove(2, 2);
            string hexequippedchestPART2 = hexequippedchest.Remove(2, 4);
            string hexequippedchestPART3 = hexequippedchest.Remove(0, 4);

            string realhexequippedchest = hexequippedchestPART1 + hexequippedchestPART2;
            int equippedchestid = Convert.ToInt32(realhexequippedchest, 16);
            int equippedchestprefixid = Convert.ToInt32(hexequippedchestPART3, 16);

            try
            {
                pictureBox50.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedchestid + ".png");
            }
            catch
            {
                pictureBox50.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            armorchestid = equippedchestid.ToString();
            armorchestprefixid = equippedchestprefixid.ToString();


            file = file.Remove(0, 6);

            if (file.StartsWith("0000"))
            {
                file = "00" + file;
            }

            string hexequippedboots = file.Remove(6, file.Length - 6);

            string hexequippedbootsPART1 = hexequippedboots.Remove(0, 2);
            hexequippedbootsPART1 = hexequippedbootsPART1.Remove(2, 2);
            string hexequippedbootsPART2 = hexequippedboots.Remove(2, 4);
            string hexequippedbootsPART3 = hexequippedchest.Remove(0, 4);

            string realhexequippedboots = hexequippedbootsPART1 + hexequippedbootsPART2;
            int equippedbootsid = Convert.ToInt32(realhexequippedboots, 16);
            int equippedbootsprefixid = Convert.ToInt32(hexequippedbootsPART3, 16);

            try
            {
                pictureBox51.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + equippedbootsid + ".png");
            }
            catch
            {
                pictureBox51.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
            }

            armorbootsid = equippedbootsid.ToString();
            armorbootsprefixid = equippedbootsprefixid.ToString();

            file = file.Remove(0, 6);

            return file;
        }

        private string ColorPlayer(string file)
        {
            string haircolor = file.Remove(6, file.Length - 6);
            textBox6.Text = haircolor;
            System.Drawing.Color colorhaircolor = System.Drawing.ColorTranslator.FromHtml("#" + haircolor);
            textBox6.ForeColor = colorhaircolor;
            file = file.Remove(0, 6);

            string skincolor = file.Remove(6, file.Length - 6);
            System.Drawing.Color colorskincolor = System.Drawing.ColorTranslator.FromHtml("#" + skincolor);
            textBox7.ForeColor = colorskincolor;
            textBox7.Text = skincolor;
            file = file.Remove(0, 6);

            string eyecolor = file.Remove(6, file.Length - 6);
            System.Drawing.Color coloreyecolor = System.Drawing.ColorTranslator.FromHtml("#" + eyecolor);
            textBox8.ForeColor = coloreyecolor;
            textBox8.Text = eyecolor;
            file = file.Remove(0, 6);

            string shirtcolor = file.Remove(6, file.Length - 6);
            System.Drawing.Color colorshirtcolor = System.Drawing.ColorTranslator.FromHtml("#" + shirtcolor);
            textBox9.ForeColor = colorshirtcolor;
            textBox9.Text = shirtcolor;
            file = file.Remove(0, 6);

            string undershirtcolor = file.Remove(6, file.Length - 6);
            System.Drawing.Color colorundershirtcolor = System.Drawing.ColorTranslator.FromHtml("#" + undershirtcolor);
            textBox10.ForeColor = colorundershirtcolor;
            textBox10.Text = undershirtcolor;
            file = file.Remove(0, 6);

            string pantscolor = file.Remove(6, file.Length - 6);
            System.Drawing.Color colorpantscolor = System.Drawing.ColorTranslator.FromHtml("#" + pantscolor);
            textBox11.ForeColor = colorpantscolor;
            textBox11.Text = pantscolor;
            file = file.Remove(0, 6);

            string shoescolor = file.Remove(6, file.Length - 6);
            System.Drawing.Color colorshoescolor = System.Drawing.ColorTranslator.FromHtml("#" + shoescolor);
            textBox12.ForeColor = colorshoescolor;
            textBox12.Text = shoescolor;
            file = file.Remove(0, 6);

            return file;
        }

        private string Sex(string file)
        {
            file = file.Remove(0, 6);
            string sex = file.Remove(2, file.Length - 2);
            if (sex.Equals("00"))
            {
                comboBox2.Text = "Female";
                file = file.Remove(0, 2);
                return file;
            }
            else if (sex.Equals("01"))
            {
                comboBox2.Text = "Male";
                file = file.Remove(0, 2);
                return file;
            }
            else
            {
                comboBox2.Text = "Error";
                file = file.Remove(0, 2);
                return file;
            }
        }

        private string HairStyle(string file)
        {
            file = file.Remove(0, 2);
            string hairstyle = file.Remove(2, file.Length - 2);
            int decValue = int.Parse(hairstyle, System.Globalization.NumberStyles.HexNumber);
            decValue = decValue + 1;
            textBox4.Text = decValue.ToString();
            return file;
        }

        private string Difficulty(string file)
        {
            string difficulty = file.Remove(2, file.Length - 2);

            if (difficulty.Equals("00"))
            {
                comboBox1.Text = "Easy (Normal)";
                return file;
            }
            else if (difficulty.Equals("01"))
            {
                comboBox1.Text = "Normal (Difficile)";
                return file;
            }
            else if (difficulty.Equals("02"))
            {
                comboBox1.Text = "Hardcore (Hardcore)";
                return file;
            }
            else
            {
                comboBox1.Text = "Error";
                return file;
            }
        }

        private string Pseudo(string file)
        {
            int lenght = file.Length;
            string pseudolenght = file.Remove(2, lenght - 2);
            int ipseudolenght = Convert.ToInt32(pseudolenght, 16); 
            ipseudolenght = ipseudolenght * 2; //PSEUDO LENGHT
            file = file.Remove(0, 2);
            string hexpseudo = file.Remove(ipseudolenght, file.Length - ipseudolenght);
            string pseudo = HexStringToString(hexpseudo);
            textBox1.Text = pseudo; // AFFICHER LE PSEUDO
            file = file.Remove(0, ipseudolenght);
            return file;
        }

        string HexStringToString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }
            var sb = new StringBuilder();
            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terraria Character Editor for PS Vita v0.1\nBy valentinbreiz from CustomProtocol.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string file = textBox2.Text;
                File.WriteAllBytes(path, StringToByteArray(file));
                MessageBox.Show("Success!");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Make();
            MessageBox.Show("Done!");
        }

        private void Make()
        {
            #region begin

            string file = "1500";

            #endregion

            #region pseudolenght

            int pseudolenght = textBox1.TextLength;
            string pseudolenghta = HexFromID(pseudolenght);

            if (pseudolenghta.Length == 1)
            {
                file = file + "0" + pseudolenghta;
            }
            else
            {
                file = file + pseudolenghta;
            }

            #endregion

            #region pseudo

            file = file + StringToHex(textBox1.Text);

            #endregion

            #region diffuclty

            if (comboBox1.Text == "Easy (Normal)")
            {
                file = file + "00";
            }
            else if (comboBox1.Text == "Normal (Difficile)")
            {
                file = file + "01";
            }
            else if (comboBox1.Text == "Hardcore (Hardcore)")
            {
                file = file + "02";
            }

            #endregion

            #region hairstyle

            int dechairstyle = Int32.Parse(textBox4.Text);

            if (dechairstyle > 134 || dechairstyle < 1)
            {
                MessageBox.Show("Invalid Hair Style");
            }
            else
            {
                int value = Int32.Parse(textBox4.Text);
                value = value - 1;
                file = file + HexFromID(value);
            }

            #endregion

            #region unknown1

            file = file + "0000";

            #endregion

            #region sex

            if (comboBox2.Text == "Female")
            {
                file = file + "00";
            }
            else if (comboBox2.Text == "Male")
            {
                file = file + "01";
            }

            #endregion

            #region HPMANA

            file = file + HPMANA;

            #endregion

            #region charactercolor

            file = file + textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text;

            #endregion

            #region equipedarmor
            if (armorhelmetid == "0") {
                file = file + "0000";
            }
            else
            {
                string equipedhelmet = HexFromIDspecial3b(Int32.Parse(armorhelmetid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(armorhelmetprefixid)));
                if (equipedhelmet.Length == 5)
                {
                    file = file + equipedhelmet + "0";
                }
                else
                {
                    file = file + equipedhelmet;
                }
            }
            if (armorchestid == "0")
            {
                file = file + "0000";
            }
            else
            {
                string equipedchest = HexFromIDspecial3b(Int32.Parse(armorchestid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(armorchestprefixid)));
                if (equipedchest.Length == 5)
                {
                    file = file + equipedchest + "0";
                }
                else
                {
                    file = file + equipedchest;
                }
            }
            if (armorbootsid == "0")
            {
                file = file + "0000";
            }
            else
            {
                string equipedboots = HexFromIDspecial3b(Int32.Parse(armorbootsid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(armorbootsprefixid)));
                if (equipedboots.Length == 5)
                {
                    file = file + equipedboots + "0";
                }
                else
                {
                    file = file + equipedboots;
                }
            }
            #endregion

            #region equipedaccessories

            if (accessoriesoneid == "0")
            {
                file = file + "0000";
            }
            else
            {
                string equippedaccessorie1 = HexFromIDspecial3b(Int32.Parse(accessoriesoneid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(accessoriesoneprefixid)));
                if (equippedaccessorie1.Length == 5)
                {
                    file = file + equippedaccessorie1 + "0";
                }
                else
                {
                    file = file + equippedaccessorie1;
                }
            }

            if (accessoriestwoid == "0")
            {
                file = file + "0000";
            }
            else
            {
                string equippedaccessorie2 = HexFromIDspecial3b(Int32.Parse(accessoriestwoid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(accessoriestwoprefixid)));
                if (equippedaccessorie2.Length == 5)
                {
                    file = file + equippedaccessorie2 + "0";
                }
                else
                {
                    file = file + equippedaccessorie2;
                }
            }

            if (accessoriesthreeid == "0") {
                file = file + "0000";
            }
            else
            {
                string equippedaccessorie3 = HexFromIDspecial3b(Int32.Parse(accessoriesthreeid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(accessoriesthreeprefixid)));
                if (equippedaccessorie3.Length == 5)
                {
                    file = file + equippedaccessorie3 + "0";
                }
                else
                {
                    file = file + equippedaccessorie3;
                }
            }

            if (accessoriesfourid == "0")
            {
                file = file + "0000";
            }
            else
            {
                string equippedaccessorie4 = HexFromIDspecial3b(Int32.Parse(accessoriesfourid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(accessoriesfourprefixid)));
                if (equippedaccessorie4.Length == 5)
                {
                    file = file + equippedaccessorie4 + "0";
                }
                else
                {
                    file = file + equippedaccessorie4;
                }
            }

            if (accessoriesfiveid == "0") {
                file = file + "0000";
            }
            else
            {
                string equippedaccessorie5 = HexFromIDspecial3b(Int32.Parse(accessoriesfiveid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(accessoriesfiveprefixid)));
                if (equippedaccessorie5.Length == 5)
                {
                    file = file + equippedaccessorie5 + "0";
                }
                else
                {
                    file = file + equippedaccessorie5;
                }
            }
            #endregion

            #region equipedvanity

            if (vanityhelmetid == "0")
            {
                file = file + "0000";
            }
            else
            {
                string vanityhelmet = HexFromIDspecial3b(Int32.Parse(vanityhelmetid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(vanityhelmetprefixid)));
                if (vanityhelmet.Length == 5)
                {
                    file = file + vanityhelmet + "0";
                }
                else
                {
                    file = file + vanityhelmet;
                }
            }

            if (vanitychestid == "0") {
                file = file + "0000";
            }
            else
            {
                string vanitychest = HexFromIDspecial3b(Int32.Parse(vanitychestid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(vanitychestprefixid)));
                if (vanitychest.Length == 5)
                {
                    file = file + vanitychest + "0";
                }
                else
                {
                    file = file + vanitychest;
                }
            }

            if (vanityrbootsid == "0") {
                file = file + "0000";
            }
            else
            {
                string vanityboots = HexFromIDspecial3b(Int32.Parse(vanityrbootsid)) + Int32.Parse(HexFromPrefixID(Int32.Parse(vanityrbootsprefixid)));
                if (vanityboots.Length == 5)
                {
                    file = file + vanityboots + "0";
                }
                else
                {
                    file = file + vanityboots;
                }
            }

            #endregion

            #region unknown2

            file = file + unknwonone;

            #endregion

            #region inventory



            #endregion

            textBox3.Text = file;
        }

        private string HexFromID(int ID)
        {
            return ID.ToString("X");
        }

        private string HexFromPrefixID(int ID)
        {
            string hexid = ID.ToString("X");
            if (hexid.Length == 1)
            {
                hexid = "0" + hexid;
                return hexid;
            }
            else
            {
                return hexid;
            }
        }

        private string HexFromIDspecial3b(int ID)
        {
            string hexid = ID.ToString("X");
            if (hexid.Length == 1)
            {
                hexid = "000" + hexid;
            }
            else if (hexid.Length == 2)
            {
                hexid = "00" + hexid;
            }
            else if (hexid.Length == 3)
            {
                hexid = "0" + hexid;
            }

            string hexidPART1 = hexid.Remove(0, 2);
            string hexidPART2 = hexid.Remove(2, 2);
            string realhexid = hexidPART1 + hexidPART2;

            return realhexid;

        }

        private string StringToHex(string hexstring)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in hexstring)
            {
                //Note: X for upper, x for lower case letters
                sb.Append(Convert.ToInt32(t).ToString("x"));
            }
            string stringg = sb.ToString().ToUpper();
            if (stringg.Length == 1)
            {
                stringg = "0" + stringg;
                return stringg;
            }
            else
            {
                return stringg;
            }
        }

        PictureBox lastselected;
        int currentpcturebox;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox1;
            groupBox11.Enabled = true;
            textBox84.Text = itemID1;
            currentpcturebox = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None;}
            catch{ }
            lastselected = pictureBox2;
            groupBox11.Enabled = true;
            textBox84.Text = itemID2;
            currentpcturebox = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox3;
            groupBox11.Enabled = true;
            textBox84.Text = itemID3;
            currentpcturebox = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox4;
            groupBox11.Enabled = true;
            textBox84.Text = itemID4;
            currentpcturebox = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox5;
            groupBox11.Enabled = true;
            textBox84.Text = itemID5;
            currentpcturebox = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox6;
            groupBox11.Enabled = true;
            textBox84.Text = itemID6;
            currentpcturebox = 6;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox7;
            groupBox11.Enabled = true;
            textBox84.Text = itemID7;
            currentpcturebox = 7;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox8;
            groupBox11.Enabled = true;
            textBox84.Text = itemID8;
            currentpcturebox = 8;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox9;
            groupBox11.Enabled = true;
            textBox84.Text = itemID9;
            currentpcturebox = 9;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox10;
            groupBox11.Enabled = true;
            textBox84.Text = itemID10;
            currentpcturebox = 10;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox11;
            groupBox11.Enabled = true;
            textBox84.Text = itemID11;
            currentpcturebox = 11;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox12;
            groupBox11.Enabled = true;
            textBox84.Text = itemID12;
            currentpcturebox = 12;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox13;
            groupBox11.Enabled = true;
            textBox84.Text = itemID13;
            currentpcturebox = 13;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox14;
            groupBox11.Enabled = true;
            textBox84.Text = itemID14;
            currentpcturebox = 14;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox15;
            groupBox11.Enabled = true;
            textBox84.Text = itemID15;
            currentpcturebox = 15;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox16;
            groupBox11.Enabled = true;
            textBox84.Text = itemID16;
            currentpcturebox = 16;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox17;
            groupBox11.Enabled = true;
            textBox84.Text = itemID17;
            currentpcturebox = 17;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox18;
            groupBox11.Enabled = true;
            textBox84.Text = itemID18;
            currentpcturebox = 18;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox19;
            groupBox11.Enabled = true;
            textBox84.Text = itemID19;
            currentpcturebox = 19;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox20;
            groupBox11.Enabled = true;
            textBox84.Text = itemID20;
            currentpcturebox = 20;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox21;
            groupBox11.Enabled = true;
            textBox84.Text = itemID21;
            currentpcturebox = 21;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox22;
            groupBox11.Enabled = true;
            textBox84.Text = itemID22;
            currentpcturebox = 22;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox23;
            groupBox11.Enabled = true;
            textBox84.Text = itemID23;
            currentpcturebox = 23;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox24;
            groupBox11.Enabled = true;
            textBox84.Text = itemID24;
            currentpcturebox = 24;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox25;
            groupBox11.Enabled = true;
            textBox84.Text = itemID25;
            currentpcturebox = 25;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox26;
            groupBox11.Enabled = true;
            textBox84.Text = itemID26;
            currentpcturebox = 26;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox27;
            groupBox11.Enabled = true;
            textBox84.Text = itemID27;
            currentpcturebox = 27;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox29;
            groupBox11.Enabled = true;
            textBox84.Text = itemID29;
            currentpcturebox = 29;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox28;
            groupBox11.Enabled = true;
            textBox84.Text = itemID28;
            currentpcturebox = 28;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox30;
            groupBox11.Enabled = true;
            textBox84.Text = itemID30;
            currentpcturebox = 30;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox31;
            groupBox11.Enabled = true;
            textBox84.Text = itemID31;
            currentpcturebox = 31;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox32;
            groupBox11.Enabled = true;
            textBox84.Text = itemID32;
            currentpcturebox = 32;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox33;
            groupBox11.Enabled = true;
            textBox84.Text = itemID33;
            currentpcturebox = 33;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox34;
            groupBox11.Enabled = true;
            textBox84.Text = itemID34;
            currentpcturebox = 34;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox35;
            groupBox11.Enabled = true;
            textBox84.Text = itemID35;
            currentpcturebox = 35;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox36;
            groupBox11.Enabled = true;
            textBox84.Text = itemID36;
            currentpcturebox = 36;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox37;
            groupBox11.Enabled = true;
            textBox84.Text = itemID37;
            currentpcturebox = 37;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox38;
            groupBox11.Enabled = true;
            textBox84.Text = itemID38;
            currentpcturebox = 38;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox39;
            groupBox11.Enabled = true;
            textBox84.Text = itemID39;
            currentpcturebox = 39;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pictureBox40.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox40;
            groupBox11.Enabled = true;
            textBox84.Text = itemID40;
            currentpcturebox = 40;
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox41.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox41;
            groupBox11.Enabled = true;
            textBox84.Text = itemID41;
            textBox85.Text = itemCOUNT41;
            currentpcturebox = 41;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox42.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox42;
            groupBox11.Enabled = true;
            textBox84.Text = itemID42;
            currentpcturebox = 42;
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pictureBox43.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox43;
            groupBox11.Enabled = true;
            textBox84.Text = itemID43;
            currentpcturebox = 43;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pictureBox44.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox44;
            groupBox11.Enabled = true;
            textBox84.Text = itemID44;
            currentpcturebox = 44;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pictureBox45.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox45;
            groupBox11.Enabled = true;
            textBox84.Text = itemID45;
            currentpcturebox = 45;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox46;
            groupBox11.Enabled = true;
            textBox84.Text = itemID46;
            currentpcturebox = 46;
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pictureBox47.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox47;
            groupBox11.Enabled = true;
            textBox84.Text = itemID47;
            currentpcturebox = 47;
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pictureBox48.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox48;
            groupBox11.Enabled = true;
            textBox84.Text = itemID48;
            currentpcturebox = 48;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentpcturebox == 1)
            {
                try
                {
                    itemID1 = textBox84.Text;
                    pictureBox1.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 2)
            {
                try
                {
                    itemID2 = textBox84.Text;
                    pictureBox2.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox2.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 3)
            {
                try
                {
                    itemID3 = textBox84.Text;
                    pictureBox3.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox3.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 4)
            {
                try
                {
                    itemID4 = textBox84.Text;
                    pictureBox4.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox4.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 5)
            {
                try
                {
                    itemID5 = textBox84.Text;
                    pictureBox5.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox5.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 6)
            {
                try
                {
                    itemID6 = textBox84.Text;
                    pictureBox6.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox6.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 7)
            {
                try
                {
                    itemID7 = textBox84.Text;
                    pictureBox7.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox7.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 8)
            {
                try
                {
                    itemID8 = textBox84.Text;
                    pictureBox8.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox8.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 9)
            {
                try
                {
                    itemID9 = textBox84.Text;
                    pictureBox9.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox9.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 10)
            {
                try
                {
                    itemID10 = textBox84.Text;
                    pictureBox10.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox10.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 11)
            {
                try
                {
                    itemID11 = textBox84.Text;
                    pictureBox11.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox11.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 12)
            {
                try
                {
                    itemID12 = textBox84.Text;
                    pictureBox12.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox12.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 13)
            {
                try
                {
                    itemID13 = textBox84.Text;
                    pictureBox13.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox13.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 14)
            {
                try
                {
                    itemID14 = textBox84.Text;
                    pictureBox14.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox14.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 15)
            {
                try
                {
                    itemID15 = textBox84.Text;
                    pictureBox15.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox15.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 16)
            {
                try
                {
                    itemID16 = textBox84.Text;
                    pictureBox16.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox16.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 17)
            {
                try
                {
                    itemID17 = textBox84.Text;
                    pictureBox17.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox17.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 18)
            {
                try
                {
                    itemID18 = textBox84.Text;
                    pictureBox18.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox18.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 19)
            {
                try
                {
                    itemID19 = textBox84.Text;
                    pictureBox19.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox19.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 20)
            {
                try
                {
                    itemID20 = textBox84.Text;
                    pictureBox20.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox20.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 21)
            {
                try
                {
                    itemID21 = textBox84.Text;
                    pictureBox21.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox21.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 22)
            {
                try
                {
                    itemID22 = textBox84.Text;
                    pictureBox22.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox22.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 23)
            {
                try
                {
                    itemID23 = textBox84.Text;
                    pictureBox23.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox23.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 24)
            {
                try
                {
                    itemID24 = textBox84.Text;
                    pictureBox24.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox24.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 25)
            {
                try
                {
                    itemID25 = textBox84.Text;
                    pictureBox25.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox25.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 26)
            {
                try
                {
                    itemID26 = textBox84.Text;
                    pictureBox26.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox26.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 27)
            {
                try
                {
                    itemID27 = textBox84.Text;
                    pictureBox27.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox27.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 28)
            {
                try
                {
                    itemID28 = textBox84.Text;
                    pictureBox28.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox28.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 29)
            {
                try
                {
                    itemID29 = textBox84.Text;
                    pictureBox29.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox29.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 30)
            {
                try
                {
                    itemID30 = textBox84.Text;
                    pictureBox30.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox30.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 31)
            {
                try
                {
                    itemID31 = textBox84.Text;
                    pictureBox31.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox31.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 32)
            {
                try
                {
                    itemID32 = textBox84.Text;
                    pictureBox32.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox32.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 33)
            {
                try
                {
                    itemID33 = textBox84.Text;
                    pictureBox33.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox33.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 34)
            {
                try
                {
                    itemID34 = textBox84.Text;
                    pictureBox34.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox34.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 35)
            {
                try
                {
                    itemID35 = textBox84.Text;
                    pictureBox35.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox35.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 36)
            {
                try
                {
                    itemID36 = textBox84.Text;
                    pictureBox36.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox36.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 37)
            {
                try
                {
                    itemID37 = textBox84.Text;
                    pictureBox37.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox37.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 38)
            {
                try
                {
                    itemID38 = textBox84.Text;
                    pictureBox38.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox38.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 39)
            {
                try
                {
                    itemID39 = textBox84.Text;
                    pictureBox39.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox39.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 40)
            {
                try
                {
                    itemID40 = textBox84.Text;
                    pictureBox40.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox40.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 41)
            {
                try
                {
                    pictureBox41.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox41.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
                itemID41 = textBox84.Text;
                itemCOUNT41 = textBox85.Text;
                label69.Text = itemCOUNT41;
            }
            else if (currentpcturebox == 42)
            {
                try
                {
                    itemID42 = textBox84.Text;
                    pictureBox42.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox42.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 43)
            {
                try
                {
                    itemID43 = textBox84.Text;
                    pictureBox43.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox43.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 44)
            {
                try
                {
                    itemID44 = textBox84.Text;
                    pictureBox44.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox44.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 45)
            {
                try
                {
                    itemID45 = textBox84.Text;
                    pictureBox45.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox45.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 46)
            {
                try
                {
                    itemID46 = textBox84.Text;
                    pictureBox46.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox46.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 47)
            {
                try
                {
                    itemID47 = textBox84.Text;
                    pictureBox47.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox47.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 48)
            {
                try
                {
                    itemID48 = textBox84.Text;
                    pictureBox48.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox84.Text + ".png");
                }
                catch
                {
                    pictureBox48.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            pictureBox49.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox49;
            groupBox4.Enabled = true;
            textBox26.Text = armorhelmetid;
            textBox24.Text = armorhelmetprefixid;
            currentpcturebox = 49;
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            pictureBox50.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox50;
            groupBox4.Enabled = true;
            textBox26.Text = armorchestid;
            textBox24.Text = armorchestprefixid;
            currentpcturebox = 50;
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            pictureBox51.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox51;
            groupBox4.Enabled = true;
            textBox26.Text = armorbootsid;
            textBox24.Text = armorbootsprefixid;
            currentpcturebox = 51;
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            pictureBox52.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox52;
            groupBox4.Enabled = true;
            textBox26.Text = vanityhelmetid;
            textBox24.Text = vanityhelmetprefixid;
            currentpcturebox = 52;
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            pictureBox53.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox53;
            groupBox4.Enabled = true;
            textBox26.Text = vanitychestid;
            textBox24.Text = vanitychestprefixid;
            currentpcturebox = 53;
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            pictureBox54.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox54;
            groupBox4.Enabled = true;
            textBox26.Text = vanityrbootsid;
            textBox24.Text = vanityrbootsprefixid;
            currentpcturebox = 54;
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            pictureBox55.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox55;
            groupBox4.Enabled = true;
            textBox26.Text = accessoriesoneid;
            textBox24.Text = accessoriesoneprefixid;
            currentpcturebox = 55;
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            pictureBox56.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox56;
            groupBox4.Enabled = true;
            textBox26.Text = accessoriestwoid;
            textBox24.Text = accessoriestwoprefixid;
            currentpcturebox = 56;
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            pictureBox57.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox57;
            groupBox4.Enabled = true;
            textBox26.Text = accessoriesthreeid;
            textBox24.Text = accessoriesthreeprefixid;
            currentpcturebox = 57;
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            pictureBox58.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox58;
            groupBox4.Enabled = true;
            textBox26.Text = accessoriesfourid;
            textBox24.Text = accessoriesfourprefixid;
            currentpcturebox = 58;
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            pictureBox59.BorderStyle = BorderStyle.FixedSingle;
            try { lastselected.BorderStyle = BorderStyle.None; }
            catch { }
            lastselected = pictureBox59;
            groupBox4.Enabled = true;
            textBox26.Text = accessoriesfiveid;
            textBox24.Text = accessoriesfiveprefixid;
            currentpcturebox = 59;
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.customprotocol.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentpcturebox == 49)
            {
                try
                {
                    armorhelmetid = textBox26.Text;
                    armorhelmetprefixid = textBox24.Text;
                    pictureBox49.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox49.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 50)
            {
                try
                {
                    armorchestid = textBox26.Text;
                    armorchestprefixid = textBox24.Text;
                    pictureBox50.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox50.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 51)
            {
                try
                {
                    armorbootsid = textBox26.Text;
                    armorbootsprefixid = textBox24.Text;
                    pictureBox51.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox51.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 52)
            {
                try
                {
                    vanityhelmetid = textBox26.Text;
                    vanityhelmetprefixid = textBox24.Text;
                    pictureBox52.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox52.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 53)
            {
                try
                {
                    vanitychestid = textBox26.Text;
                    vanitychestprefixid = textBox24.Text;
                    pictureBox53.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox53.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 54)
            {
                try
                {
                    vanityrbootsid = textBox26.Text;
                    vanityrbootsprefixid = textBox24.Text;
                    pictureBox54.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox54.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 55)
            {
                try
                {
                    accessoriesoneid = textBox26.Text;
                    accessoriesoneprefixid = textBox24.Text;
                    pictureBox55.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox55.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 56)
            {
                try
                {
                    accessoriestwoid = textBox26.Text;
                    accessoriestwoprefixid = textBox24.Text;
                    pictureBox56.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox56.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 57)
            {
                try
                {
                    accessoriesthreeid = textBox26.Text;
                    accessoriesthreeprefixid = textBox24.Text;
                    pictureBox57.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox57.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 58)
            {
                try
                {
                    accessoriesfourid = textBox26.Text;
                    accessoriesfourprefixid = textBox24.Text;
                    pictureBox58.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox58.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
            else if (currentpcturebox == 59)
            {
                try
                {
                    accessoriesfiveid = textBox26.Text;
                    accessoriesfiveprefixid = textBox24.Text;
                    pictureBox59.BackgroundImage = Image.FromFile("Images\\Items\\Item_" + textBox26.Text + ".png");
                }
                catch
                {
                    pictureBox59.BackgroundImage = Image.FromFile("Images\\Items\\Item_unknown.png");
                }
            }
        }
    }
}
