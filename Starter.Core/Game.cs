﻿namespace Starter.Core
{
    /// <summary>
    /// Game Object
    /// </summary>
    public class Game
    {
        /// <summary>
        /// A unique identifier for this Game.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Information about the ruleset being used to run this game.
        /// Example: {"name": "standard", "version": "v1.2.3"}
        /// </summary>
        public Ruleset Ruleset { get; set; }

        /// <summary>
        /// The name of the map used to populate the game board with snakes, food, and hazards. Example: "standard" See Game Maps
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// How much time your snake has to respond to requests for this Game.
        /// Time is in milliseconds.
        /// Example: 500
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// The source of this game. One of:
        /// tournament
        /// league (for League Arenas)
        /// arena (for all other Arenas)
        /// challenge
        /// custom (for all other games sources)
        /// The values for this field may change in the near future.
        /// </summary>
        public string Source { get; set; }
    }
}