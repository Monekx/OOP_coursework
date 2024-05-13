using OOP_coursework;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class DiskStorage
{
    private static DiskStorage instance;

    public static DiskStorage Instance
    {
        get
        {
            if (instance == null) { instance = new DiskStorage(); }
            return instance;
        }
    }

    

    public List<Disk> disks;

    private DiskStorage()
    {

        disks = new List<Disk>();
    }

    // Метод для добавления диска в хранилище
    public void AddDisk(Disk disk)
    {

        disks.Add(disk);
    }

    // Метод для удаления диска из хранилища
    public void RemoveDisk(Disk disk)
    {
        disks.Remove(disk);
    }

    public Disk Search(string searchID) 
    {
        Disk result = null;
        foreach (Disk disk in disks)
        {
            if (disk.DiskId.ToString() == searchID)
            {
                result = disk;
                break;
            }
        }

        return result;
    }

    public void UpdateDisk(int id, Disk updatedDisk)
    {
        Disk track = Search(id.ToString());
        track = updatedDisk;
    }

    // Метод для получения всех дисков из хранилища
    public List<Disk> GetAllDisks()
    {
        return disks;
    }
}

