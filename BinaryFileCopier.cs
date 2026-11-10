using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.exmpl2
{
    internal class BinaryFileCopier
    {
        public const string INPUT_FILE = @"C:\Windows\notepad.exe";
        public const string OUTPUT_FILE = @"C:\notepad3.exe";


        static void Main()
        {
            FileStream inFile = new FileStream(INPUT_FILE, FileMode.Open);
            FileStream outFile = new FileStream(OUTPUT_FILE, FileMode.Create);

            byte[] buff = new byte[1024];

            while (true)
            {
                int bytesRead = inFile.Read(buff, 0, buff.Length);

                if(bytesRead == 0)
                {
                    break;
                }

                outFile.Write(buff, 0, bytesRead);

            }
            inFile.Close();
            outFile.Close();
        }
    }


}
