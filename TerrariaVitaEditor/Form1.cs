using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TerrariaVitaEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path;

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            Text = openFileDialog1.FileName;

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

            textBox2.Text = file;

            Interpreter(file);
        }

        private void Interpreter(string file)
        {
            if (file.StartsWith("1500"))
            {    
                file = file.Remove(0, 4);

                file = Pseudo(file);

                file = Difficulty(file);

                file = HairStyle(file);

                file = Sex(file);

                file = file.Remove(0, 18); //TODO (Helth + Mana)

                file = ColorPlayer(file); //Everything works so far! 

                file = EquippedArmor(file);

                file = EquippedAccessories(file);

                file = EquippedVanity(file);

                file = Inventory(file);

            }
            else
            {
                MessageBox.Show("This is not a valid Vita PLR file!");
            }
        }

        private string Inventory(string file)
        {
            file = file.Remove(0, 54);

            //ITEM 1
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox24.Text = "0";
            }
            else
            {
                string item1 = file.Remove(10, file.Length - 10);
                string item1PART1 = item1.Remove(0, 2);
                item1PART1 = item1PART1.Remove(2, 6);
                string item1PART2 = item1.Remove(2, 8);
                string realitem1 = item1PART1 + item1PART2;
                int item1id = Convert.ToInt32(realitem1, 16);
                textBox24.Text = item1id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 2
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox25.Text = "0";
            }
            else
            {
                string item2 = file.Remove(10, file.Length - 10);
                string item2PART1 = item2.Remove(0, 2);
                item2PART1 = item2PART1.Remove(2, 6);
                string item2PART2 = item2.Remove(2, 8);
                string realitem2 = item2PART1 + item2PART2;
                int item2id = Convert.ToInt32(realitem2, 16);
                textBox25.Text = item2id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 3
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox26.Text = "0";
            }
            else
            {
                string item3 = file.Remove(10, file.Length - 10);
                string item3PART1 = item3.Remove(0, 2);
                item3PART1 = item3PART1.Remove(2, 6);
                string item3PART2 = item3.Remove(2, 8);
                string realitem3 = item3PART1 + item3PART2;
                int item3id = Convert.ToInt32(realitem3, 16);
                textBox26.Text = item3id.ToString();
                file = file.Remove(0, 10);
            } 

            //ITEM 4
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox27.Text = "0";
            }
            else
            {
                string item4 = file.Remove(10, file.Length - 10);
                string item4PART1 = item4.Remove(0, 2);
                item4PART1 = item4PART1.Remove(2, 6);
                string item4PART2 = item4.Remove(2, 8);
                string realitem4 = item4PART1 + item4PART2;
                int item4id = Convert.ToInt32(realitem4, 16);
                textBox27.Text = item4id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 5
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox28.Text = "0";
            }
            else
            {
                string item5 = file.Remove(10, file.Length - 10);
                string item5PART1 = item5.Remove(0, 2);
                item5PART1 = item5PART1.Remove(2, 6);
                string item5PART2 = item5.Remove(2, 8);
                string realitem5 = item5PART1 + item5PART2;
                int item5id = Convert.ToInt32(realitem5, 16);
                textBox28.Text = item5id.ToString();
                file = file.Remove(0, 10);
            } 

            //ITEM 6
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox29.Text = "0";
            }
            else
            {
                string item6 = file.Remove(10, file.Length - 10);
                string item6PART1 = item6.Remove(0, 2);
                item6PART1 = item6PART1.Remove(2, 6);
                string item6PART2 = item6.Remove(2, 8);
                string realitem6 = item6PART1 + item6PART2;
                int item6id = Convert.ToInt32(realitem6, 16);
                textBox29.Text = item6id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 7
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox30.Text = "0";
            }
            else
            {
                string item7 = file.Remove(10, file.Length - 10);
                string item7PART1 = item7.Remove(0, 2);
                item7PART1 = item7PART1.Remove(2, 6);
                string item7PART2 = item7.Remove(2, 8);
                string realitem7 = item7PART1 + item7PART2;
                int item7id = Convert.ToInt32(realitem7, 16);
                textBox30.Text = item7id.ToString();
                file = file.Remove(0, 10);
            } 

            //ITEM 8
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox31.Text = "0";
            }
            else
            {
                string item8 = file.Remove(10, file.Length - 10);
                string item8PART1 = item8.Remove(0, 2);
                item8PART1 = item8PART1.Remove(2, 6);
                string item8PART2 = item8.Remove(2, 8);
                string realitem8 = item8PART1 + item8PART2;
                int item8id = Convert.ToInt32(realitem8, 16);
                textBox31.Text = item8id.ToString();
                file = file.Remove(0, 10);
            } 

            //ITEM 9
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox32.Text = "0";
            }
            else
            {
                string item9 = file.Remove(10, file.Length - 10);
                string item9PART1 = item9.Remove(0, 2);
                item9PART1 = item9PART1.Remove(2, 6);
                string item9PART2 = item9.Remove(2, 8);
                string realitem9 = item9PART1 + item9PART2;
                int item9id = Convert.ToInt32(realitem9, 16);
                textBox32.Text = item9id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 10
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox33.Text = "0";
            }
            else
            {
                string item10 = file.Remove(10, file.Length - 10);
                string item10PART1 = item10.Remove(0, 2);
                item10PART1 = item10PART1.Remove(2, 6);
                string item10PART2 = item10.Remove(2, 8);
                string realitem10 = item10PART1 + item10PART2;
                int item10id = Convert.ToInt32(realitem10, 16);
                textBox33.Text = item10id.ToString();
                file = file.Remove(0, 10);
            }  

            //ITEM 11
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox34.Text = "0";
            }
            else
            {
                string item11 = file.Remove(10, file.Length - 10);
                string item11PART1 = item11.Remove(0, 2);
                item11PART1 = item11PART1.Remove(2, 6);
                string item11PART2 = item11.Remove(2, 8);
                string realitem11 = item11PART1 + item11PART2;
                int item11id = Convert.ToInt32(realitem11, 16);
                textBox34.Text = item11id.ToString();
                file = file.Remove(0, 10);
            }  

            //ITEM 12
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox35.Text = "0";
            }
            else
            {
                string item12 = file.Remove(10, file.Length - 10);
                string item12PART1 = item12.Remove(0, 2);
                item12PART1 = item12PART1.Remove(2, 6);
                string item12PART2 = item12.Remove(2, 8);
                string realitem12 = item12PART1 + item12PART2;
                int item12id = Convert.ToInt32(realitem12, 16);
                textBox35.Text = item12id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 13
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox36.Text = "0";
            }
            else
            {
                string item13 = file.Remove(10, file.Length - 10);
                string item13PART1 = item13.Remove(0, 2);
                item13PART1 = item13PART1.Remove(2, 6);
                string item13PART2 = item13.Remove(2, 8);
                string realitem13 = item13PART1 + item13PART2;
                int item13id = Convert.ToInt32(realitem13, 16);
                textBox36.Text = item13id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 14
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox37.Text = "0";
            }
            else
            {
                string item14 = file.Remove(10, file.Length - 10);
                string item14PART1 = item14.Remove(0, 2);
                item14PART1 = item14PART1.Remove(2, 6);
                string item14PART2 = item14.Remove(2, 8);
                string realitem14 = item14PART1 + item14PART2;
                int item14id = Convert.ToInt32(realitem14, 16);
                textBox37.Text = item14id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 15
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox38.Text = "0";
            }
            else
            {
                string item15 = file.Remove(10, file.Length - 10);
                string item15PART1 = item15.Remove(0, 2);
                item15PART1 = item15PART1.Remove(2, 6);
                string item15PART2 = item15.Remove(2, 8);
                string realitem15 = item15PART1 + item15PART2;
                int item15id = Convert.ToInt32(realitem15, 16);
                textBox38.Text = item15id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 16
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox39.Text = "0";
            }
            else
            {
                string item16 = file.Remove(10, file.Length - 10);
                string item16PART1 = item16.Remove(0, 2);
                item16PART1 = item16PART1.Remove(2, 6);
                string item16PART2 = item16.Remove(2, 8);
                string realitem16 = item16PART1 + item16PART2;
                int item16id = Convert.ToInt32(realitem16, 16);
                textBox39.Text = item16id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 17
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox40.Text = "0";
            }
            else
            {
                string item17 = file.Remove(10, file.Length - 10);
                string item17PART1 = item17.Remove(0, 2);
                item17PART1 = item17PART1.Remove(2, 6);
                string item17PART2 = item17.Remove(2, 8);
                string realitem17 = item17PART1 + item17PART2;
                int item17id = Convert.ToInt32(realitem17, 16);
                textBox40.Text = item17id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 18
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox41.Text = "0";
            }
            else
            {
                string item18 = file.Remove(10, file.Length - 10);
                string item18PART1 = item18.Remove(0, 2);
                item18PART1 = item18PART1.Remove(2, 6);
                string item18PART2 = item18.Remove(2, 8);
                string realitem18 = item18PART1 + item18PART2;
                int item18id = Convert.ToInt32(realitem18, 16);
                textBox41.Text = item18id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 19
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox42.Text = "0";
            }
            else
            {
                string item19 = file.Remove(10, file.Length - 10);
                string item19PART1 = item19.Remove(0, 2);
                item19PART1 = item19PART1.Remove(2, 6);
                string item19PART2 = item19.Remove(2, 8);
                string realitem19 = item19PART1 + item19PART2;
                int item19id = Convert.ToInt32(realitem19, 16);
                textBox42.Text = item19id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 20
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox43.Text = "0";
            }
            else
            {
                string item20 = file.Remove(10, file.Length - 10);
                string item20PART1 = item20.Remove(0, 2);
                item20PART1 = item20PART1.Remove(2, 6);
                string item20PART2 = item20.Remove(2, 8);
                string realitem20 = item20PART1 + item20PART2;
                int item20id = Convert.ToInt32(realitem20, 16);
                textBox43.Text = item20id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 21
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox44.Text = "0";
            }
            else
            {
                string item21 = file.Remove(10, file.Length - 10);
                string item21PART1 = item21.Remove(0, 2);
                item21PART1 = item21PART1.Remove(2, 6);
                string item21PART2 = item21.Remove(2, 8);
                string realitem21 = item21PART1 + item21PART2;
                int item21id = Convert.ToInt32(realitem21, 16);
                textBox44.Text = item21id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 22
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox45.Text = "0";
            }
            else
            {
                string item22 = file.Remove(10, file.Length - 10);
                string item22PART1 = item22.Remove(0, 2);
                item22PART1 = item22PART1.Remove(2, 6);
                string item22PART2 = item22.Remove(2, 8);
                string realitem22 = item22PART1 + item22PART2;
                int item22id = Convert.ToInt32(realitem22, 16);
                textBox45.Text = item22id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 23
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox46.Text = "0";
            }
            else
            {
                string item23 = file.Remove(10, file.Length - 10);
                string item23PART1 = item23.Remove(0, 2);
                item23PART1 = item23PART1.Remove(2, 6);
                string item23PART2 = item23.Remove(2, 8);
                string realitem23 = item23PART1 + item23PART2;
                int item23id = Convert.ToInt32(realitem23, 16);
                textBox46.Text = item23id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 24
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox47.Text = "0";
            }
            else
            {
                string item24 = file.Remove(10, file.Length - 10);
                string item24PART1 = item24.Remove(0, 2);
                item24PART1 = item24PART1.Remove(2, 6);
                string item24PART2 = item24.Remove(2, 8);
                string realitem24 = item24PART1 + item24PART2;
                int item24id = Convert.ToInt32(realitem24, 16);
                textBox47.Text = item24id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 25
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox48.Text = "0";
            }
            else
            {
                string item25 = file.Remove(10, file.Length - 10);
                string item25PART1 = item25.Remove(0, 2);
                item25PART1 = item25PART1.Remove(2, 6);
                string item25PART2 = item25.Remove(2, 8);
                string realitem25 = item25PART1 + item25PART2;
                int item25id = Convert.ToInt32(realitem25, 16);
                textBox48.Text = item25id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 26
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox49.Text = "0";
            }
            else
            {
                string item26 = file.Remove(10, file.Length - 10);
                string item26PART1 = item26.Remove(0, 2);
                item26PART1 = item26PART1.Remove(2, 6);
                string item26PART2 = item26.Remove(2, 8);
                string realitem26 = item26PART1 + item26PART2;
                int item26id = Convert.ToInt32(realitem26, 16);
                textBox49.Text = item26id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 27
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox50.Text = "0";
            }
            else
            {
                string item27 = file.Remove(10, file.Length - 10);
                string item27PART1 = item27.Remove(0, 2);
                item27PART1 = item27PART1.Remove(2, 6);
                string item27PART2 = item27.Remove(2, 8);
                string realitem27 = item27PART1 + item27PART2;
                int item27id = Convert.ToInt32(realitem27, 16);
                textBox50.Text = item27id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 28
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox51.Text = "0";
            }
            else
            {
                string item28 = file.Remove(10, file.Length - 10);
                string item28PART1 = item28.Remove(0, 2);
                item28PART1 = item28PART1.Remove(2, 6);
                string item28PART2 = item28.Remove(2, 8);
                string realitem28 = item28PART1 + item28PART2;
                int item28id = Convert.ToInt32(realitem28, 16);
                textBox51.Text = item28id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 29
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox52.Text = "0";
            }
            else
            {
                string item29 = file.Remove(10, file.Length - 10);
                string item29PART1 = item29.Remove(0, 2);
                item29PART1 = item29PART1.Remove(2, 6);
                string item29PART2 = item29.Remove(2, 8);
                string realitem29 = item29PART1 + item29PART2;
                int item29id = Convert.ToInt32(realitem29, 16);
                textBox52.Text = item29id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 30
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox53.Text = "0";
            }
            else
            {
                string item30 = file.Remove(10, file.Length - 10);
                string item30PART1 = item30.Remove(0, 2);
                item30PART1 = item30PART1.Remove(2, 6);
                string item30PART2 = item30.Remove(2, 8);
                string realitem30 = item30PART1 + item30PART2;
                int item30id = Convert.ToInt32(realitem30, 16);
                textBox53.Text = item30id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 31
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox54.Text = "0";
            }
            else
            {
                string item31 = file.Remove(10, file.Length - 10);
                string item31PART1 = item31.Remove(0, 2);
                item31PART1 = item31PART1.Remove(2, 6);
                string item31PART2 = item31.Remove(2, 8);
                string realitem31 = item31PART1 + item31PART2;
                int item31id = Convert.ToInt32(realitem31, 16);
                textBox54.Text = item31id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 32
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox55.Text = "0";
            }
            else
            {
                string item32 = file.Remove(10, file.Length - 10);
                string item32PART1 = item32.Remove(0, 2);
                item32PART1 = item32PART1.Remove(2, 6);
                string item32PART2 = item32.Remove(2, 8);
                string realitem32 = item32PART1 + item32PART2;
                int item32id = Convert.ToInt32(realitem32, 16);
                textBox55.Text = item32id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 33
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox56.Text = "0";
            }
            else
            {
                string item33 = file.Remove(10, file.Length - 10);
                string item33PART1 = item33.Remove(0, 2);
                item33PART1 = item33PART1.Remove(2, 6);
                string item33PART2 = item33.Remove(2, 8);
                string realitem33 = item33PART1 + item33PART2;
                int item33id = Convert.ToInt32(realitem33, 16);
                textBox56.Text = item33id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 34
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox57.Text = "0";
            }
            else
            {
                string item34 = file.Remove(10, file.Length - 10);
                string item34PART1 = item34.Remove(0, 2);
                item34PART1 = item34PART1.Remove(2, 6);
                string item34PART2 = item34.Remove(2, 8);
                string realitem34 = item34PART1 + item34PART2;
                int item34id = Convert.ToInt32(realitem34, 16);
                textBox57.Text = item34id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 35
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox58.Text = "0";
            }
            else
            {
                string item35 = file.Remove(10, file.Length - 10);
                string item35PART1 = item35.Remove(0, 2);
                item35PART1 = item35PART1.Remove(2, 6);
                string item35PART2 = item35.Remove(2, 8);
                string realitem35 = item35PART1 + item35PART2;
                int item35id = Convert.ToInt32(realitem35, 16);
                textBox58.Text = item35id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 36
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox59.Text = "0";
            }
            else
            {
                string item36 = file.Remove(10, file.Length - 10);
                string item36PART1 = item36.Remove(0, 2);
                item36PART1 = item36PART1.Remove(2, 6);
                string item36PART2 = item36.Remove(2, 8);
                string realitem36 = item36PART1 + item36PART2;
                int item36id = Convert.ToInt32(realitem36, 16);
                textBox59.Text = item36id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 37
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox60.Text = "0";
            }
            else
            {
                string item37 = file.Remove(10, file.Length - 10);
                string item37PART1 = item37.Remove(0, 2);
                item37PART1 = item37PART1.Remove(2, 6);
                string item37PART2 = item37.Remove(2, 8);
                string realitem37 = item37PART1 + item37PART2;
                int item37id = Convert.ToInt32(realitem37, 16);
                textBox60.Text = item37id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 38
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox61.Text = "0";
            }
            else
            {
                string item38 = file.Remove(10, file.Length - 10);
                string item38PART1 = item38.Remove(0, 2);
                item38PART1 = item38PART1.Remove(2, 6);
                string item38PART2 = item38.Remove(2, 8);
                string realitem38 = item38PART1 + item38PART2;
                int item38id = Convert.ToInt32(realitem38, 16);
                textBox61.Text = item38id.ToString();
                file = file.Remove(0, 10);
            }

            //ITEM 39
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox62.Text = "0";
            }
            else
            {
                string item39 = file.Remove(10, file.Length - 10);
                string item39PART1 = item39.Remove(0, 2);
                item39PART1 = item39PART1.Remove(2, 6);
                string item39PART2 = item39.Remove(2, 8);
                string realitem39 = item39PART1 + item39PART2;
                int item39id = Convert.ToInt32(realitem39, 16);
                textBox62.Text = item39id.ToString();
                file = file.Remove(0, 10);
            }
            
            //ITEM 40
            if (file.StartsWith("0000"))
            {
                file = file.Remove(0, 4);
                textBox63.Text = "0";
            }
            else
            {
                string item40 = file.Remove(10, file.Length - 10);
                string item40PART1 = item40.Remove(0, 2);
                item40PART1 = item40PART1.Remove(2, 6);
                string item40PART2 = item40.Remove(2, 8);
                string realitem40 = item40PART1 + item40PART2;
                int item40id = Convert.ToInt32(realitem40, 16);
                textBox63.Text = item40id.ToString();
                file = file.Remove(0, 10);
            }
            
            return file;
        }

        private string EquippedVanity(string file)
        {
            string hexequippedhelmet = file.Remove(6, file.Length - 6);
            if (hexequippedhelmet.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexequippedhelmet = hexequippedhelmet.Remove(4, 2);
            string hexequippedhelmetPART1 = hexequippedhelmet.Remove(0, 2);
            string hexequippedhelmetPART2 = hexequippedhelmet.Remove(2, 2);
            string realhexequippedhelmet = hexequippedhelmetPART1 + hexequippedhelmetPART2;
            int equippedhelmetid = Convert.ToInt32(realhexequippedhelmet, 16);
            textBox21.Text = equippedhelmetid.ToString();
            file = file.Remove(0, 6);

            string hexequippedchest = file.Remove(6, file.Length - 6);
            if (hexequippedchest.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexequippedchest = hexequippedchest.Remove(4, 2);
            string hexequippedchestPART1 = hexequippedchest.Remove(0, 2);
            string hexequippedchestPART2 = hexequippedchest.Remove(2, 2);
            string realhexequippedchest = hexequippedchestPART1 + hexequippedchestPART2;
            int equippedchestid = Convert.ToInt32(realhexequippedchest, 16);
            textBox22.Text = equippedchestid.ToString();
            file = file.Remove(0, 6);

            string hexequippedboots = file.Remove(6, file.Length - 6);
            if (hexequippedboots.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexequippedboots = hexequippedboots.Remove(4, 2);
            string hexequippedbootsPART1 = hexequippedboots.Remove(0, 2);
            string hexequippedbootsPART2 = hexequippedboots.Remove(2, 2);
            string realhexequippedboots = hexequippedbootsPART1 + hexequippedbootsPART2;
            int equippedbootsid = Convert.ToInt32(realhexequippedboots, 16);
            textBox23.Text = equippedbootsid.ToString();

            file = file.Remove(0, 6);

            return file;
        }

        private string EquippedAccessories(string file)
        {
            string hexone = file.Remove(6, file.Length - 6);
            if (hexone.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexone = hexone.Remove(4, 2);
            string hexonePART1 = hexone.Remove(0, 2);
            string hexonePART2 = hexone.Remove(2, 2);
            string realhexequippedone = hexonePART1 + hexonePART2;
            int equippedoneid = Convert.ToInt32(realhexequippedone, 16);
            textBox16.Text = equippedoneid.ToString();
            file = file.Remove(0, 6);

            string hextwo = file.Remove(6, file.Length - 6);
            if (hextwo.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hextwo = hextwo.Remove(4, 2);
            string hextwoPART1 = hextwo.Remove(0, 2);
            string hextwoPART2 = hextwo.Remove(2, 2);
            string realhexequippedtwo = hextwoPART1 + hextwoPART2;
            int equippedtwoid = Convert.ToInt32(realhexequippedtwo, 16);
            textBox17.Text = equippedtwoid.ToString();
            file = file.Remove(0, 6);

            string hexthree = file.Remove(6, file.Length - 6);
            if (hexthree.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexthree = hexthree.Remove(4, 2);
            string hexthreePART1 = hexthree.Remove(0, 2);
            string hexthreePART2 = hexthree.Remove(2, 2);
            string realhexequippedthree = hexthreePART1 + hexthreePART2;
            int equippedthreeid = Convert.ToInt32(realhexequippedthree, 16);
            textBox18.Text = equippedthreeid.ToString();
            file = file.Remove(0, 6);

            string hexfour = file.Remove(6, file.Length - 6);
            if (hexfour.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexfour = hexfour.Remove(4, 2);
            string hexfourPART1 = hexfour.Remove(0, 2);
            string hexfourPART2 = hexfour.Remove(2, 2);
            string realhexequippedfour = hexfourPART1 + hexfourPART2;
            int equippedfourid = Convert.ToInt32(realhexequippedfour, 16);
            textBox19.Text = equippedfourid.ToString();
            file = file.Remove(0, 6);

            string hexfive = file.Remove(6, file.Length - 6);
            if (hexfive.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexfive = hexfive.Remove(4, 2);
            string hexfivePART1 = hexfive.Remove(0, 2);
            string hexfivePART2 = hexfive.Remove(2, 2);
            string realhexequippedfive = hexfivePART1 + hexfivePART2;
            int equippedfiveid = Convert.ToInt32(realhexequippedfive, 16);
            textBox20.Text = equippedfiveid.ToString();
            file = file.Remove(0, 6);

            return file;
        }

        private string EquippedArmor(string file)
        {
            
            string hexequippedhelmet = file.Remove(6, file.Length - 6);
            if (hexequippedhelmet.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexequippedhelmet = hexequippedhelmet.Remove(4, 2);
            string hexequippedhelmetPART1 = hexequippedhelmet.Remove(0, 2);
            string hexequippedhelmetPART2 = hexequippedhelmet.Remove(2, 2);
            string realhexequippedhelmet = hexequippedhelmetPART1 + hexequippedhelmetPART2;
            int equippedhelmetid = Convert.ToInt32(realhexequippedhelmet, 16);
            textBox13.Text = equippedhelmetid.ToString();
            file = file.Remove(0, 6);

            string hexequippedchest = file.Remove(6, file.Length - 6);
            if (hexequippedchest.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexequippedchest = hexequippedchest.Remove(4, 2);
            string hexequippedchestPART1 = hexequippedchest.Remove(0, 2);
            string hexequippedchestPART2 = hexequippedchest.Remove(2, 2);
            string realhexequippedchest = hexequippedchestPART1 + hexequippedchestPART2;
            int equippedchestid = Convert.ToInt32(realhexequippedchest, 16);
            textBox14.Text = equippedchestid.ToString();
            file = file.Remove(0, 6);

            string hexequippedboots = file.Remove(6, file.Length - 6);
            if (hexequippedboots.StartsWith("0000"))
            {
                file = "00" + file;
            }
            hexequippedboots = hexequippedboots.Remove(4, 2);
            string hexequippedbootsPART1 = hexequippedboots.Remove(0, 2);
            string hexequippedbootsPART2 = hexequippedboots.Remove(2, 2);
            string realhexequippedboots = hexequippedbootsPART1 + hexequippedbootsPART2;
            int equippedbootsid = Convert.ToInt32(realhexequippedboots, 16);
            textBox15.Text = equippedbootsid.ToString();
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
                textBox5.Text = "Female";
                return file;
            }
            else if (sex.Equals("01"))
            {
                textBox5.Text = "Male";
                return file;
            }
            else
            {
                textBox5.Text = "Error";
                return file;
            }
        }

        private string HairStyle(string file)
        {
            file = file.Remove(0, 2);
            string hairstyle = file.Remove(2, file.Length - 2);
            textBox4.Text = hairstyle;
            return file;
        }

        private string Difficulty(string file)
        {
            string difficulty = file.Remove(2, file.Length - 2);

            if (difficulty.Equals("00"))
            {
                textBox3.Text = "Easy (Normal)";
                return file;
            }
            else if (difficulty.Equals("01"))
            {
                textBox3.Text = "Normal (Difficile)";
                return file;
            }
            else if (difficulty.Equals("02"))
            {
                textBox3.Text = "Hardcore (Hardcore)";
                return file;
            }
            else
            {
                textBox3.Text = "Error";
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
            MessageBox.Show("Terraria Editor for PSVita v0.1\nBy valentinbreiz.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
