using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ImageHashing;

namespace ImageHashingTest
{
    class Program
    {
        public static string file_1 = @"C:\Users\skim.WLDEV-DOMAIN\Desktop\aaa\RE Documents from WIS\test\FOLDER DOCUMENTS_General Records_Scanned  06162010_40646C2B - Copy.tif";
        public static string file_2 = @"C:\Users\skim.WLDEV-DOMAIN\Desktop\aaa\RE Documents from WIS\test\FOLDER DOCUMENTS_General Records_Scanned  06162010_40646C2B.tif";  
        public static string file_3 = @"C:\Users\skim.WLDEV-DOMAIN\Desktop\aaa\RE Documents from WIS\test\FOLDER DOCUMENTS_General Records_Scanned  06162010_40646C2B - Copy (2).tif";  
        public static string file_4 = @"C:\Users\skim.WLDEV-DOMAIN\Desktop\aaa\RE Documents from WIS\test\FOLDER DOCUMENTS_General Records_Scanned  06162010_40646C2B - Copy (2).tif";  
        public static string file_5 = @"C:\Users\skim.WLDEV-DOMAIN\Desktop\aaa\RE Documents from WIS\test\FOLDER DOCUMENTS_General Records_Scanned  06162010_40646C89.tif";  
        public static string file_6 = @"C:\Users\skim.WLDEV-DOMAIN\Desktop\aaa\RE Documents from WIS\test\FOLDER DOCUMENTS_General Records_Scanned  06162010_40646C88.tif";

        static void Main(string[] args)
        {
            CompareAndWrite(file_1, file_2);
            CompareAndWrite(file_1, file_3);
            //CompareAndWrite(file_2, file_4);
            //CompareAndWrite(file_2, file_4);
            CompareAndWrite(file_1, file_5);
            CompareAndWrite(file_1, file_6);
        }

        private static void CompareAndWrite(string file1, string file2)
        {
            Console.WriteLine($"Similarity, diff-same: {ImageHashing.ImageHashing.Similarity(file1, file2)}");
        }
    }
}
