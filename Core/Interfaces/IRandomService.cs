﻿namespace Core.Interfaces
{
    public interface IRandomService
    {
        /// <summary>
        ///  just returns 'Hello' string - example function
        /// </summary>
        /// <returns> 'Hello' text </returns>
        public string GetRandom();

        /// <summary>
        ///  just returns string with appended Id - example function
        /// </summary>
        /// <param name="id"> id from the request </param>
        /// <returns> string with appended Id </returns>
        public string GetRandomById(int id); 
    }
}