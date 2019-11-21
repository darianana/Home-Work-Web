﻿using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class StangingWork
    {
        public static List<Staging> stagings = new List<Staging>();
        
        public static void AddConcert(string name, string director, string type) // Добавляет концерт
        {
            if (type == "balet" || type == "opera" || type == "staging")
            {
                stagings.Add(new Staging(name, director, type));
                Console.Write("Success!\r\n");
            }
            Console.WriteLine("Sorry, you wrote the wrong type");
        }
        
        public static int FindId(string name)
        {
           return(stagings.FindIndex(staging => staging.StagingName == name));
        }

        public static void Delete(string name)
        {
            if (FindId(name) != -1)
            {
                stagings.RemoveAt(FindId(name));
                Console.Write("Success!\r\n");
            }
            else
            {
                Console.WriteLine("Sorry, you type something wrong");
            }
        }

        public static void SortType(string type)
        {
            for (int i = 0; i < stagings.Count; i++)
            {
                if (stagings[i].Type == type)
                {
                    Console.WriteLine( $"Name {stagings[i].Type} is: {stagings[i].StagingName} \r\n" +
                                       $"Director {stagings[i].Type} is: {stagings[i].Director} \r\n");
                }
            }
        }
        
        public static void SortName(string name)
        {
            for (int i = 0; i < stagings.Count; i++)
            {
                if (stagings[i].Director == name)
                {
                    Console.WriteLine( $"Name {stagings[i].Type} is: {stagings[i].StagingName} \r\n" +
                                       $"Director {stagings[i].Type} is: {stagings[i].Director} \r\n");
                }
            }
        }

        public static void ReturnAll()
        {
            for (int i = 0; i < stagings.Count; i++)
            {
                Console.WriteLine( $"Name {stagings[i].Type} is: {stagings[i].StagingName} \r\n" +
                                   $"Director {stagings[i].Type} is: {stagings[i].Director}\r\n");
            }
        }

    }
}