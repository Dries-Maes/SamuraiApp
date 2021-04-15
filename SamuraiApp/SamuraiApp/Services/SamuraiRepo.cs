using SamuraiApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SamuraiApp.Services
{
    public class SamuraiRepo : ISamuraiRepo
    {
        private static SamuraiRepo instance;
        private List<Samurai> samurais;

        private SamuraiRepo()
        {
            AddDummyData();
        }

        public static SamuraiRepo GetInstance()
        {
            if (instance == null)
            {
                instance = new SamuraiRepo();
            }
            return instance;
        }

        private void AddDummyData()
        {
            samurais = new List<Samurai>
            {
            GetSamurai("Pieter", Era.Edo, new DateTime(2008,12,25), false),
            GetSamurai("Ward", Era.Edo, new DateTime(1008,12,25) , false),
            GetSamurai("Dries", Era.Edo, new DateTime(2008,12,25), false),
            };
        }

        public Samurai GetSamurai(string name, Era era, DateTime dayOfBirth, bool hasDied, string imagePath = "xamarin_logo.png")
        {
            return new Samurai
            {
                Name = name,
                Era = era,
                DayOfBirth = dayOfBirth,
                HasDied = hasDied,
                ImagePath = imagePath
            };
        }

        public List<Samurai> GetAllSamurais()
        {
            return samurais;
        }

        public void AddSamurai(Samurai samurai)
        {
            samurais.Add(samurai);
        }
    }
}