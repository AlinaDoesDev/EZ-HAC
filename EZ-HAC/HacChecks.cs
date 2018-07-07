using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace EZ_HAC
{
    using static Properties.Resources;
    using static Environment;
    class HacChecks
    {
        public static void RunChecks()
        {
            CheckHactoolExe();
            CheckHactoolKeys();
        }

        struct HacInfo
        {
            public string FileHash;
            public string VersionId;
        }

        private static HacInfo[] VerifiedHacVersions =
        {
        new HacInfo{FileHash = Ver110Hash, VersionId = V110},
        new HacInfo{FileHash = Ver101Hash, VersionId = V101},
        new HacInfo{FileHash = Ver100Hash, VersionId = V100}
        };

        public static string HacVersionId;
        private static void CheckHactoolExe()
        {
            try
            {
                string GetFileHash(string FileName)
                {
                    using (SHA256 HashContext = SHA256.Create())
                    {
                        using (FileStream Stream = File.OpenRead(FileName))
                        {
                            return BitConverter.ToString(HashContext.ComputeHash(Stream)).Replace("-", "");
                        }
                    }
                }
                string HacHash = GetFileHash(Binary);
                for (int Index = 0; Index < VerifiedHacVersions.Length; Index++)
                {
                    HacInfo HacVersionInfo = VerifiedHacVersions[Index];
                    if (HacVersionInfo.FileHash == HacHash)
                    {
                        HacVersionId = HacVersionInfo.VersionId;
                        return;
                    }
                }
                DialogResult HashResult = MessageBox.Show(ErrBadHash, ErrHeader, MessageBoxButtons.YesNo);
                if (HashResult == DialogResult.No)
                {
                    Exit(0);
                }
                else
                {
                    HacVersionId = Unknown;
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show(ErrBinaryMissing, ErrHeaderFatal, MessageBoxButtons.OK);
                Exit(0);
            }
        }

        private static void CheckHactoolKeys()
        {
            if (!File.Exists(Keys))
            {
                MessageBox.Show(ErrKeysFileMissing, ErrHeaderFatal, MessageBoxButtons.OK);
                Exit(0);
            }
        }


    }
}
