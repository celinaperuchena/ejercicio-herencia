using System.Collections.Generic;
using Ucu.Poo.Cognitive;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    public class UcuRideShare
    {
        private List<Driver> drivers = new List<Driver>();
        private List<Passenger> passengers = new List<Passenger>();
        private DiscordClient discord;
        private ulong channelId;
        private CognitiveFace face = new CognitiveFace();

        public UcuRideShare(DiscordClient discord, ulong channelId)
        {
            this.discord = discord;
            this.channelId = channelId;
        }

        public void Add(Driver driver)
        {
            CognitiveFace.RecognitionResult result =
                this.face.Recognize(driver.Photo);

            if (!result.Success)
            {
                return;
            }

            if (driver.NeedsGlasses && !result.GlassesFound)
            {
                return;
            }

            this.drivers.Add(driver);

            this.discord.SendMessage(
                this.channelId,
                driver.Welcome());

            this.discord.SendImage(
                this.channelId,
                driver.Photo,
                driver.Bio);
        }

        public void Add(Passenger passenger)
        {
            CognitiveFace.RecognitionResult result =
                this.face.Recognize(passenger.Photo);

            if (!result.Success || !result.FaceFound)
            {
                return;
            }

            this.passengers.Add(passenger);

            this.discord.SendImage(
                this.channelId,
                passenger.Photo,
                passenger.Welcome());
        }
    }
}