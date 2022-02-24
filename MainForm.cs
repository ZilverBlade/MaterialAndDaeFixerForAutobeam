using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace MaterialAndDaeFixerForAutobeam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string[] mainMatStringChunkArray;
        private string[] mainMatStringChunkArray2;


        private string[] daeStringChunkArray;
        private string[] miscStringChunkArray;


        private string seed;

        private string mainMatStringChunk;
        private string daeStringChunk;
        private string miscStringChunk;

        private bool isfixedyet = false;

        private StreamWriter mainMatWriter;
        private StreamWriter daeWriter;
        private StreamWriter miscWriter;

        //carn_name_body0
        //carname
        //material_X
        //engineMesh
        //material_90_eclipse_ultimate_r_xxna_inl_dohc_4_mid_c_2147301655_sectionmesh_inlv_dohc_4_head_mid21
        //

        private void fixBtn_Click(object sender, EventArgs e)
        {
            //FixMaterialNames();       only use this for replacing material names, it's disabled because of my paranoid ass beamng changing the way materials get read
            if (isfixedyet == false)
            {
                if (MessageBox.Show($"Material names haven't been shortned yet. This might cause unpredictable results. Proceed?{Environment.NewLine}(Using this button without pressing the previous is only recommended if dae file already has been modified)", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CutMatCharactersTo64();
                }
            }
            
        }
       

        private void fixBtn_Click1(object sender, EventArgs e)
        {
            isfixedyet = true;
            FixMaterialNames();
        }

        private void CutMatCharactersTo64() 
        {
            
            for (int i = 0; i < mainMatStringChunkArray.Length; i++)
            {
                 //logTextBox.Text += System.Environment.NewLine + "Mat name: " + mainMatStringChunkArray[i];

               // MessageBox.Show(mainMatStringChunkArray[i]);
                if (mainMatStringChunkArray[i].Contains(": {"))
                {
                    //MessageBox.Show(mainMatStringChunkArray[i].ToString().Length.ToString());
                    if (mainMatStringChunkArray[i].Length >= 70)
                    {
                        //logTextBox.Text += System.Environment.NewLine + "*Mat name to cut: " + mainMatStringChunkArray[i];

                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\"", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\t", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace(": {", "");
                        //logTextBox.Text += System.Environment.NewLine + "*Mat shortned: " + mainMatStringChunkArray[i];
                        mainMatStringChunkArray[i] = "\t\"" + mainMatStringChunkArray[i].Remove(63) + "\": {";
                        //logTextBox.Text += System.Environment.NewLine + "*Mat after: " + mainMatStringChunkArray[i];
                    }
                }
                else if (mainMatStringChunkArray[i].Contains("\"name\":"))
                {
                    //MessageBox.Show(mainMatStringChunkArray[i].ToString().Length.ToString());
                    if (mainMatStringChunkArray[i].Length >= 77)
                    {
                        //logTextBox.Text += System.Environment.NewLine + "*Mat name to cut: " + mainMatStringChunkArray[i];
                        
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\"name\": \"", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\",", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\t", "");
                        //MessageBox.Show("joe" + mainMatStringChunkArray[i].ToString().Length.ToString());
                        //logTextBox.Text += System.Environment.NewLine + "*Mat shortned: " + mainMatStringChunkArray[i];
                        mainMatStringChunkArray[i] = "\t\t\"name\": \"" + mainMatStringChunkArray[i].Remove(63) + "\",";
                        //logTextBox.Text += System.Environment.NewLine + "*Mat after: " + mainMatStringChunkArray[i];
                    }
                }
                else if (mainMatStringChunkArray[i].Contains("\"mapTo\":"))
                {
                    //MessageBox.Show(mainMatStringChunkArray[i].ToString().Length.ToString());
                    if (mainMatStringChunkArray[i].Length >= 78)
                    {
                        //logTextBox.Text += System.Environment.NewLine + "*Mat name to cut: " + mainMatStringChunkArray[i];
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\"mapTo\": \"", "");

                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\",", "");
                        
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\t", "");
                        //logTextBox.Text += System.Environment.NewLine + "*Mat shortned: " + mainMatStringChunkArray[i];

                        mainMatStringChunkArray[i] = "\t\t\"mapTo\": \"" + mainMatStringChunkArray[i].Remove(63) + "\",";
                        //logTextBox.Text += System.Environment.NewLine + "*Mat after: " + mainMatStringChunkArray[i];
                    }
                }
            }


            //fix opacity stamp changing "opacityMap"

            logTextBox.Text += System.Environment.NewLine + "Materials file cut successfully";

            mainMatStringChunk = string.Join(System.Environment.NewLine, mainMatStringChunkArray);
            debugText(mainMatStringChunk);
            buildCleanupBtn.Enabled = true;
        }

        private void debugText(string debugChunk)
        {
            Form2 frm = new Form2();
            frm.Show();
            frm.resultTxtBox.Text = debugChunk;
        }

        private void FixMaterialNames()
        {
            try
            {
                mainMatStringChunkArray = File.ReadAllLines(locationTxtBox.Text + @"\main.materials.json");
            }
            catch
            {
                MessageBox.Show("Main JSON Material file not found. Does this car have PBR?", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            for (int i = 0; i < mainMatStringChunkArray.Length; i++)
            {
                if (mainMatStringChunkArray[i].Contains("\"opacityMap\"") == false)
                {
                    mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace(carNameTxtBox.Text, seed);
                }
            }

            logTextBox.Text += "Materials file set up successfully";

            daeStringChunkArray = File.ReadAllLines(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.dae");
            for (int i = 0; i < daeStringChunkArray.Length; i++)
            {
                daeStringChunkArray[i] = daeStringChunkArray[i].Replace(carNameTxtBox.Text, seed);
            }

            logTextBox.Text += System.Environment.NewLine + "DAE (Collada) file set up successfully";
            daeStringChunk = string.Join(System.Environment.NewLine, daeStringChunkArray);
            mainMatStringChunk = string.Join(System.Environment.NewLine, mainMatStringChunkArray);
            buildCleanupBtn.Enabled = true;
        }
        
        private void FixEngineBullshit()
        {
            string[] engineFuckeryStringChunkArrayBefore = new string[99999999];
            string[] engineFuckeryStringChunkArrayAfter = new string[99999999];


            int j = 0;
            mainMatStringChunkArray = File.ReadAllLines(locationTxtBox.Text + @"\main.materials.json");
            mainMatStringChunkArray2 = new string[99999999];
            for (int i = 0; i < mainMatStringChunkArray.Length; i++)
            {
                //mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace(engineMeshNameTxtBox.Text, "M0t0r");
                if (mainMatStringChunkArray[i].Length > 64)
                {
                    if (mainMatStringChunkArray[i].Contains("material_") && mainMatStringChunkArray[i].Contains("M0t0r"))
                    {
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\"", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\t", "");
                        mainMatStringChunkArray[i] = "\"" + mainMatStringChunkArray[i].Remove(18) + "\"";
                    }

                    //setting up for DAE
                    if (mainMatStringChunkArray[i].Contains("material_") && mainMatStringChunkArray[i].Contains("M0t0r"))
                    {
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\"", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\": {", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\t", "");
                        engineFuckeryStringChunkArrayBefore[j] = mainMatStringChunkArray[i];
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Remove(25);
                        engineFuckeryStringChunkArrayAfter[j] = mainMatStringChunkArray[i];
                        logTextBox.Text += System.Environment.NewLine + engineFuckeryStringChunkArrayBefore[j];
                        j += 1;

                    }

                }

            }
            

            for (int i = 0; i < mainMatStringChunkArray.Length; i++)
            {
                if (mainMatStringChunkArray[i].Length > 64)
                {
                    //setting up for DAE
                    if (mainMatStringChunkArray[i].Contains("\": {"))
                    {

                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\"", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\": {", "");
                        mainMatStringChunkArray[i] = mainMatStringChunkArray[i].Replace("\t", "");

                        engineFuckeryStringChunkArrayBefore[j] = mainMatStringChunkArray[i];

                        engineFuckeryStringChunkArrayAfter[j] = mainMatStringChunkArray[i].Remove(25);
                        logTextBox.Text += System.Environment.NewLine + engineFuckeryStringChunkArrayBefore[j];
                        j += 1;
                    }
                }
            }
        
    

            daeStringChunkArray = File.ReadAllLines(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.dae");

            daeStringChunk = string.Join(System.Environment.NewLine, daeStringChunkArray);
            for (int i = 0; i < engineFuckeryStringChunkArrayBefore.Length; i++) {
                daeStringChunk = daeStringChunk.Replace(engineFuckeryStringChunkArrayBefore[i], engineFuckeryStringChunkArrayAfter[i]);
            }
            /* for (int k = 0; k < engineFuckeryStringChunkArrayBefore.Length; k++)
             {
                 for (int i = 0; i < daeStringChunkArray.Length; i++)
                 {
                     if (daeStringChunkArray[i].Contains(engineFuckeryStringChunkArrayBefore[k]))
                     {
                         daeStringChunkArray[i].Replace(engineFuckeryStringChunkArrayBefore[k], engineFuckeryStringChunkArrayAfter[k]);
                     }
                 }             
             }*/

            Form2 frm = new Form2();
            frm.Show();
            frm.resultTxtBox.Text = daeStringChunk;
        }


        private void FinishAndClearAllData()
        {

            
            
            mainMatStringChunkArray = null;
            daeStringChunkArray = null;

            File.Delete(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.dae.bak");
            File.Delete(locationTxtBox.Text + @"\main.materials.json.bak");
            

            File.Move(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.dae", locationTxtBox.Text + $@"\{carNameTxtBox.Text}.dae.bak");
            File.Move(locationTxtBox.Text + @"\main.materials.json", locationTxtBox.Text + @"\main.materials.json.bak");
            

            mainMatWriter = new StreamWriter(locationTxtBox.Text + @"\main.materials.json");
            mainMatWriter.Write(mainMatStringChunk);
            mainMatWriter.Flush();
            mainMatWriter.Close();
            mainMatStringChunk = null;

            daeWriter = new StreamWriter(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.dae");
            daeWriter.Write(daeStringChunk);
            daeWriter.Flush();
            daeWriter.Close();
            daeStringChunk = null;

            miscStringChunkArray = File.ReadAllLines(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.jbeam");
            for (int i = 0; i < miscStringChunkArray.Length; i++)
            {
                miscStringChunkArray[i] = miscStringChunkArray[i].Replace(carNameTxtBox.Text, seed);
            }
            File.Delete(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.jbeam.bak");
            File.Move(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.jbeam", locationTxtBox.Text + $@"\{carNameTxtBox.Text}.jbeam.bak");
            miscStringChunk = string.Join(System.Environment.NewLine, miscStringChunkArray);
            miscStringChunkArray = null;
            miscWriter = new StreamWriter(locationTxtBox.Text + $@"\{carNameTxtBox.Text}.jbeam");
            miscWriter.Write(miscStringChunk);
            miscWriter.Flush();
            miscWriter.Close();
            miscStringChunk = null;

            isfixedyet = false;

            logTextBox.Text += System.Environment.NewLine + "Materials completed!";
             MessageBox.Show("Materials fixed successfully!");

            //FixEngineBullshit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VersionCheckerAPI vcheck = new VersionCheckerAPI();
            vcheck.CheckForUpdates(false);

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            Type type1 = typeof(MainForm);
            this.Text = "BeamNG Material Adjuster 4 Blender v" + type1.Assembly.GetName().Version.Major + "." + type1.Assembly.GetName().Version.Minor + "." + type1.Assembly.GetName().Version.Build + "." + fileVersion.FileVersion.Substring(fileVersion.FileVersion.LastIndexOf(".") + 1);
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "qwertyuiopasdfghjklzxcvbnm3729486510_-";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seed = RandomString(4);
            label1.Text = "random seed: " + seed;
            fixBtn.Enabled = true;
            shortMatCharBtn.Enabled = true;
        }

        private void cleanup_click(object sender, EventArgs e)
        {
            FinishAndClearAllData();
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/c/ZilverBlade");
        }

        private void twitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/zilverblade_");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionCheckerAPI vcheck = new VersionCheckerAPI();

            vcheck.CheckForUpdates(true);
        }
    }
}
