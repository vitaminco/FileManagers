namespace FileManagers.Common
{
    public class FileManager
    {
        protected string _rootPath;
        public FileManager(string rootPath)
        {
            _rootPath = rootPath;
        }

        public string[] GetAllDirs()
        {
            var dirs = Directory.GetDirectories(_rootPath,"*", SearchOption.AllDirectories);

            // xóa các đường dẫn phía trước tệp
            for (int i=0; i<dirs.Length; i++)
            {
                dirs[i] = dirs[i].Replace(_rootPath, string.Empty).Trim(Path.DirectorySeparatorChar); 
            }

            return dirs.OrderBy(x => x).ToArray();
        }
    }
}
