using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MaterialAndDaeFixerForAutobeam
{
    public class VersionCheckerAPI
    {

         //public bool i() { return true; }

         public void CheckForUpdates(bool ranManually = false)
         {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string v = client.DownloadString("https://pastebin.com/raw/jP8M8bUH");
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
                    string getversion = v.Substring(v.IndexOf("$") + 1, v.LastIndexOf("$") - v.IndexOf("$") - 1);
                    Type type1 = typeof(MainForm);

                    if (Convert.ToInt16(getversion.Substring(getversion.IndexOf("."), getversion.LastIndexOf(".")).Replace(".", "")) > type1.Assembly.GetName().Version.Minor) //new minor version
                    {
                        if (MessageBox.Show($"There is a new version available (version {getversion}){System.Environment.NewLine}Would you like to download it?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start(v.Substring(v.LastIndexOf("$") + 1));
                        }
                    }
                    else if (Convert.ToInt16(getversion.Substring(getversion.LastIndexOf(".") + 1)) > type1.Assembly.GetName().Version.Build && Convert.ToInt16(getversion.Substring(getversion.IndexOf("."), getversion.LastIndexOf(".")).Replace(".", "")) >= type1.Assembly.GetName().Version.Minor) //new build
                    {
                        if (MessageBox.Show($"There is a new build available (version {getversion}){System.Environment.NewLine}Would you like to download it?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start(v.Substring(v.LastIndexOf("$") + 1));
                        }
                    }
                    else if (ranManually == true) //latest version
                    {
                        MessageBox.Show("You're already on the latest version", $"Version {type1.Assembly.GetName().Version.Major + "." + type1.Assembly.GetName().Version.Minor + "." + type1.Assembly.GetName().Version.Build + "." + fileVersion.FileVersion.Substring(fileVersion.FileVersion.LastIndexOf(".") + 1)}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            catch
            {
                MessageBox.Show("An error occured while checking for update. Are you connected to the internet?", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }
    }

}
