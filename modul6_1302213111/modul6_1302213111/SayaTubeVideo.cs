using System;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo(string title)
	{
		this.title = title;
		Random rnd = new Random();
		this.id = rnd.Next(10000, 99999);
		this.playCount = 0;
	}

	public void IncreasePlayCount(int playCount)
	{
		this.playCount = playCount;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("===== VIDEO DETAILS =====");
		Console.WriteLine("Video ID\t: " + this.id);
		Console.WriteLine("Title\t\t: " + this.title);
		Console.WriteLine("Play Count\t: " + this.playCount);
	}

	public int GetPlayCount() {
		return playCount;
	}
}
