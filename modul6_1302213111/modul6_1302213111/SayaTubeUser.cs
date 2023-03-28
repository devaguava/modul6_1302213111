using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
    private int id;
    private List <SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
	{
        Contract.Requires(username.Length <= 100);
        Contract.Requires(username != null);
        Contract.Requires(uploadedVideos!= null);
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
        for (i = 0; i < 8; i++)
        {
            Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].title + " count " + uploadedVideos[i].GetPlayCount());
        }
    }
}
