// See https://aka.ms/new-console-template for more information
using OopExamPrep01.Domain;

Console.WriteLine("ExamPrep");

Movie movie1 = new Movie() { Name = "Movie 1", Director="Director 1"};
movie1.SetRunningTime(60);
movie1.SetRating("G");

Movie movie2 = new Movie() { Name = "Movie 2", Director = "Director 2" };
movie2.SetRunningTime(120);
movie2.SetRating("PG");


Movie movie3 = new Movie() { Name = "Movie 3", Director = "Director 3" };
movie3.SetRunningTime(180);
movie3.SetRating("NC_17");


Console.WriteLine(movie1);
Console.WriteLine(movie2);
Console.WriteLine(movie3);
