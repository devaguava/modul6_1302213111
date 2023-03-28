using System;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private List <SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
	{
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
	}

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach(SayaTubeVideo video in uploadedVideos) {
            total += video.GetPlayCount();
        }
        return total;

    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null);
        Debug.Assert(video.GetPlayCount() < 1000000000000);
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User: " + this.username);
        int i;
        for (i = 0; i < GetTotalVideoPlayCount(); i++)
        {
            Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i] + " count " + uploadedVideos[i].GetPlayCount());
        }
    }
}
