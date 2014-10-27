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
        private enum RScanReturnStatus { NoActionRequired, KeyDiffersWasFixed, KeyDiffersWriteError, KeyDiffersReadError, KeyDiffersUnknownError, UnknownError};

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
            WriteRegistryKey("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\WindowsStore", "RemoveWindowsStore", "1", RegistryValueKind.DWord);

            #endregion

            #region Reg: DisableChangePassword
            /*
             * DisableChangePassword
             * Group Block Version: 0.1a
             */
            WriteRegistryKey("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableChangePassword", "1", RegistryValueKind.DWord);

            #endregion

            #region adminblock

            #endregion
        }

        private static RScanReturnStatus WriteRegistryKey(string keyName, string valueName, object value, RegistryValueKind kind)
        {
            if (!keyName.StartsWith("HKEY_CURRENT_USER\\") && !keyName.StartsWith("HKEY_LOCAL_MACHINE\\"))
            {
                throw new ArgumentException("Key path argument did not start with a registry hive name.", "keypath");
            }

            string keypathstripped = keyName.Replace("HKEY_CURRENT_USER\\", "")
                                            .Replace("HKEY_LOCAL_MACHINE\\", "");
            RegistryKey winstorekey = Registry.CurrentUser.OpenSubKey(keypathstripped, true);
            object keyvalue = winstorekey.GetValue(valueName);
            string keyvaluestr = Convert.ToString(keyvalue);
            if (!keyvaluestr.Equals(value))
            {
                try
                {
                    Registry.SetValue(keyName, valueName, value, kind);
                    MessageBox.Show(valueName + " from "+keyvaluestr+" to "+value+" Successful", pname, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(keyName + " "+valueName+" = " + value, pname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }//try_if

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RegScan");
                    return RScanReturnStatus.UnknownError;
                }//catch_if
            }
            winstorekey.Close();
            return RScanReturnStatus.NoActionRequired;
        }
    }
}
