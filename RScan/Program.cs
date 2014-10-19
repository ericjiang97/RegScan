#region RScan Details
/*
 * RScan By PhantomLabs
 * Source Code: Version 1.0a (Alpha 1) - Black Titanium
 * License-Type: Open-Source (CODE ONLY) | Commercial License (PROGRAM)
 * Customisable - Request Features via Email.
 * 
 * By Eric Jiang
 * Editors: Evan Petousis, Eric Jiang
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RScan
{
    internal static class Program
    {
        public static string pname = "RegScan";

        private static void Main(string[] args)
        {
            #region RScan_licensestatus
            int licensestatus = 0; //0 - DefaultValue (Unactivated)

            /*
             * If RegistryKey = 1, then is activated.
             * Planned Registry Path: Software\\PhantomLabs\\RegScan
             * int/obj "License" = 1
             */

            #endregion

            #region Reg: WindowsStoreScanner
            /*
             * WindowsStoreScanner Blocker Version 1.0.1b
             * Original Program by Eric Jiang
             * Version 1.0.1a edited by Evan Petousis
             */

            try
            {
                //HKEY_CURRENT_USER\Software\Policies\Microsoft\WindowsStore
                RegistryKey winstorekey = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\WindowsStore", true);
                const string winstorekeyname = "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\WindowsStore";
                object keyvalue = winstorekey.GetValue("RemoveWindowsStore");
                int keyvalueint = Convert.ToInt32(keyvalue);
                if (keyvalueint == 0)
                {
                    Object o = winstorekey.GetValue("RemoveWindowsStore");
                    //WindowsStore Unblocked
                    try
                    {
                        //RemoveWindowsStore is '0'. Reset value to 1
                        Registry.SetValue(winstorekeyname, "RemoveWindowsStore", "1", RegistryValueKind.DWord);
                        winstorekey.SetValue("RemoveWindowsStore", "1");
                        //Remove(?): key.SetValue("RemoveWindowsStore", "1", RegistryValueKind.String);
                        MessageBox.Show("WindowsStore from 0 to 1 Successful", pname, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Object reg = winstorekey.GetValue("RemoveWindowsStore");
                        MessageBox.Show(winstorekeyname + " Value = " + keyvalueint, pname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//try_if

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "RegScan");
                    }//catch_if
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RegScan");
                //ignore
            }

            #endregion

            #region Reg: DisableChangePassword
            /*
             * DisableChangePassword
             * Group Block Version: 0.1a
             */
            try
            {
                RegistryKey dcpKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                const string dcpkeyname = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
                object keyvalue = dcpKey.GetValue("DisableChangePassword");
                int keyvalueint = Convert.ToInt32(keyvalue);
                if (keyvalueint == 0)
                {

                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion

            #region adminblock

            #endregion
        }
    }
}
