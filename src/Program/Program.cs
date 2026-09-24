//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            string botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            string channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");

            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno de Discord.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);

            DiscordClient discord = new DiscordClient();

            Console.WriteLine("Conectando con Discord...");
            discord.Login(botToken);

            UcuRideShare rideShare = new UcuRideShare(discord, channelId);

            Driver conductor1 = new StandardDriver(
                "Juan",
                "Pérez",
                "12345678",
                "bill.jpg",
                5.0,
                "Soy conductor de UCURide.",
                "Toyota");

            Driver conductorPool1 = new PoolDriver(
                "Pedro",
                "Rodríguez",
                "45678912",
                "rick.jpg",
                4.8,
                "Tengo lugar para varios pasajeros.",
                "Chevrolet",
                4);

            Passenger pasajero1 = new Passenger(
                "Ana",
                "Gómez",
                "87654321",
                "dan.jpg",
                4.5);

            rideShare.Add(conductor1);
            rideShare.Add(conductorPool1);
            rideShare.Add(pasajero1);

            Console.WriteLine("Usuarios agregados.");
        }
    }
}