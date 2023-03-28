// See https://aka.ms/new-console-template for more information

public class PRogram
{
    public static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo1 = new SayaTubeVideo("Review Film Harry Potter 1 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo2 = new SayaTubeVideo("Review Film Harry Potter 2 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo3 = new SayaTubeVideo("Review Film Harry Potter 3 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo("Review Film Harry Potter 4 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo5 = new SayaTubeVideo("Review Film Harry Potter 5 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo6 = new SayaTubeVideo("Review Film Harry Potter 6 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo7 = new SayaTubeVideo("Review Film Harry Potter 7 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo8 = new SayaTubeVideo("Review Film Harry Potter 8 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo9 = new SayaTubeVideo("Review Film Harry Potter 9 oleh Deva Angela");
        SayaTubeVideo sayaTubeVideo10 = new SayaTubeVideo("Review Film Harry Potter 10 oleh Deva Angela");

        sayaTubeVideo1.IncreasePlayCount(1);
        sayaTubeVideo1.PrintVideoDetails();
        sayaTubeVideo2.IncreasePlayCount(2);
        sayaTubeVideo2.PrintVideoDetails();
        sayaTubeVideo3.IncreasePlayCount(3);
        sayaTubeVideo3.PrintVideoDetails();
        sayaTubeVideo4.IncreasePlayCount(4);
        sayaTubeVideo4.PrintVideoDetails();
        sayaTubeVideo5.IncreasePlayCount(5);
        sayaTubeVideo5.PrintVideoDetails();
        sayaTubeVideo6.IncreasePlayCount(6);
        sayaTubeVideo6.PrintVideoDetails();
        sayaTubeVideo7.IncreasePlayCount(7);
        sayaTubeVideo7.PrintVideoDetails();
        sayaTubeVideo8.IncreasePlayCount(8);
        sayaTubeVideo8.PrintVideoDetails();
        sayaTubeVideo9.IncreasePlayCount(9);
        sayaTubeVideo9.PrintVideoDetails();
        sayaTubeVideo10.IncreasePlayCount(10);
        sayaTubeVideo10.PrintVideoDetails();

        Console.WriteLine();

        SayaTubeUser sayaTubeUser1 = new SayaTubeUser("Deva Angela");
        sayaTubeUser1.AddVideo(sayaTubeVideo1);

        sayaTubeUser1.AddVideo(sayaTubeVideo2);

        sayaTubeUser1.AddVideo(sayaTubeVideo3);

        sayaTubeUser1.AddVideo(sayaTubeVideo4);

        sayaTubeUser1.AddVideo(sayaTubeVideo5);

        sayaTubeUser1.AddVideo(sayaTubeVideo6);

        sayaTubeUser1.AddVideo(sayaTubeVideo7);

        sayaTubeUser1.AddVideo(sayaTubeVideo8);

        sayaTubeUser1.AddVideo(sayaTubeVideo9);

        sayaTubeUser1.AddVideo(sayaTubeVideo10);

        sayaTubeUser1.PrintAllVideoPlayCount();


    }
}

