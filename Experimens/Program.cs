namespace Experimens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\chulg\OneDrive\Рабочий стол\TestFolder");
            //directory.Create();
            //directory.CreateSubdirectory("Data");
            //directory.CreateSubdirectory(@"Help\html");

            //Console.WriteLine("FullName: {0}",directory.FullName);
            //Console.WriteLine("Name: {0}",directory.Name);
            //Console.WriteLine("Parrent: {0}",directory.Parent);
            //Console.WriteLine("Attributes: {0}",directory.Attributes);
            //Console.WriteLine("Root: {0}",directory.Root);
            //FileInfo [] file = directory.GetFiles("*.txt",SearchOption.AllDirectories);
            //Console.WriteLine("Find {0} documens", file.Length);
            //foreach (FileInfo item in file) 
            //{
            //    Console.WriteLine("File {0}",item.Name);
            //    Console.WriteLine("Size {0} bytes",item.Length);
            //}


            //Console.WriteLine("\t == My Disks ==");
            //string[] drive =Directory.GetLogicalDrives();
            //foreach (string item in drive)
            //{
            //    Console.WriteLine("{0}",item);
            //}
            //DriveInfo[] driveInfo = DriveInfo.GetDrives();
            //for (int i = 0; i < driveInfo.Length; i++)
            //{
            //    Console.WriteLine($"\t == Disk {driveInfo[i]} ==");
            //    Console.WriteLine("DiskName: {0}", driveInfo[i].Name);
            //    Console.WriteLine("DiskType: {0}", driveInfo[i].DriveType);
            //    Console.WriteLine("DiskTotalSize: {0} bytes", driveInfo[i].TotalSize);
            //    Console.WriteLine("DiskFormat: {0}", driveInfo[i].DriveFormat);
            //    Console.WriteLine("DiskLabel: {0}", driveInfo[i].VolumeLabel);
            //    Console.WriteLine("DiskFreeSpace: {0}", driveInfo[i].TotalFreeSpace);
            // FileInfo file = new FileInfo(@"C:\Users\chulg\OneDrive\Рабочий стол\TestFolder\file.vdd");
            // FileStream stream = file.Create();
            ////производим операции 
            ////закрываем поток
            // stream.Close();
            //}

            FileInfo fileInfo = new FileInfo(@"C:\Users\chulg\OneDrive\Рабочий стол\TestFolder\1.dat"); // Класс для манипуляции с файлами
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.CreationTime.ToString());


        }

    }
                   
}
    