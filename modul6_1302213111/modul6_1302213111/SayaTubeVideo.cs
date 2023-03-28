using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
	private int id;
	public string title;
	private int playCount;

	public SayaTubeVideo(string title)
	{
		Contract.Requires(title.Length <= 200);
		Contract.Requires(title != null); 
		Contract.Requires(playCount > 0);
		this.title = title;
		Random rnd = new Random();
		this.id = rnd.Next(10000, 99999);
		this.playCount = 0;
	}

	public void IncreasePlayCount(int count)
	{
		Contract.Requires(playCount <= 25000000);
		try
		{
			this.playCount = checked(this.playCount + count);
        }
		catch(OverflowException ex)
		{
			Console.WriteLine("Overflow : "+ex.Message);
		}
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
