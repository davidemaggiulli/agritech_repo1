using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructExample
{
    public interface IGenericList<T>
    {
        /// <summary>
        /// Aggiungere un intero alla lista (come ultimo)
        /// </summary>
        /// <param name="item">Elemento da aggiungere</param>
        void Add(T item);

        /// <summary>
        /// Restituisce la posizione dell'elemento da cercare
        /// </summary>
        /// <param name="item">Elemento da cercare</param>
        /// <returns></returns>
        int IndexOf(T item);

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
        T ItemAt(int index);

        void Clear();
    }
}
