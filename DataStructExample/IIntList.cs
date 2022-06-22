using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructExample
{
    internal interface IIntList
    {
        /// <summary>
        /// Aggiungere un intero alla lista (come ultimo)
        /// </summary>
        /// <param name="item">Elemento da aggiungere</param>
        void Add(int item);

        /// <summary>
        /// Restituisce la posizione dell'elemento da cercare
        /// </summary>
        /// <param name="item">Elemento da cercare</param>
        /// <returns></returns>
        int IndexOf(int item);

        //Rimuove l'elemento alla posizione indicata
        void RemoveAt(int index);

        //Quanti elementi contiene la lista
        int Count();

        /// <summary>
        /// Restituisce l'elemento in posizione indicata
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <returns></returns>
        int ItemAt(int index);
    }
}
