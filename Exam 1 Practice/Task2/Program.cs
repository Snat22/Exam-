using Task2;

var Post1 = new Post();
Post1.Title = "SalmanKhan";
Post1.Description = "BollyWhood";

System.Console.WriteLine($"{Post1.Title} - {Post1.Description} - number of Like : {Post1.Like()}");