﻿using Newtonsoft.Json;
using OOP_coursework;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DiskStorage
{
    private static DiskStorage instance;
    public static DiskStorage Instance
    {
        get
        {
            if (instance == null) { instance = LoadFromJson("save.json") ?? new DiskStorage(); }
            return instance;
        }
    }

    public List<Disk> Disks { get; private set; }

    private DiskStorage()
    {
        Disks = new List<Disk>();
    }

    public void AddDisk(Disk disk)
    {
        Disks.Add(disk);
    }

    public Disk Search(string searchID)
    {
        return Disks.Find(disk => disk.DiskId.ToString() == searchID);
    }

    public void UpdateDisk(int id, Track track)
    {
        Disk disk = Disks.Find(d => d.DiskId == id);
        if (disk != null)
        {
            disk.AddToDisk(track);
        }
    }

    public void RemoveDisk(Disk disk)
    {
        Disks.Remove(disk);
    }

    public List<Disk> GetAllDisks()
    {
        return Disks;
    }

    private static DiskStorage LoadFromJson(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            dynamic data = JsonConvert.DeserializeObject(json);
            DiskStorage diskStor = JsonConvert.DeserializeObject<DiskStorage>(data.Disks.ToString());
            return diskStor;
        }
        return null;
    }

    public string SaveToJson()
    {
        string json = JsonConvert.SerializeObject(this);
        return json;
    }
}
