using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public static  class ZipManagement
    {
        public static void AddFolderToZipFile(Folder folder)
        {
            using (FileStream zipFile = File.Open(Path.GetFileName(folder.Path) + ".Zip", FileMode.Create))
            {
                    // Folder to be Zipped
                    DirectoryInfo corpus = new DirectoryInfo(folder.Path);
                using (Aspose.Zip.Archive archive = new Aspose.Zip.Archive())
                {
                    archive.CreateEntries(corpus);
                    // Create ZIP archive
                    archive.Save(zipFile);
                  
                }
                corpus.Delete(true);
            }
        }
    }
}
