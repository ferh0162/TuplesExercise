﻿// See https://aka.ms/new-console-template for more information
public class TuplesExercise
{
    public static void Main(){
        var TuplesExercise = new TuplesExercise();
        TuplesExercise.Exercise1();
    }

    public void Exercise1()
    {
        //standard måden at oprette en tuple på
        Tuple<string, string> tuple1 = new Tuple<string, string>("hej", "how");

        //Mere brugerventligt code
        var tuple2 = Tuple.Create("hey", "how", true);

        //Nemmere at bruge med flere funktion, som at navngive dine tuples
        var tuple3 = ("hey", "how", Boolean:false);


        Console.WriteLine(tuple1);
        Console.WriteLine(tuple1.Item1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple2.Item1);
        Console.WriteLine(tuple3);
        Console.WriteLine(tuple3.Item1);
        Console.WriteLine(tuple3.Boolean);

        

    }
}