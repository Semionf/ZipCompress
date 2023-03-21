using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ZipManager
    {
        private ZipManager() { }

        private static readonly ZipManager _Instance = new ZipManager();
        public static ZipManager Instance { get { return _Instance; } }

        public void AddToZip(string Path)
        {
            Folder folder = new Folder
            {
                Path = Path
            };
            ZipManagement.AddFolderToZipFile(folder);
        }
    }
}
