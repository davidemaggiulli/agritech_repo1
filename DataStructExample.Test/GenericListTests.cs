using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructExample.Test
{
    public class GenericListTests
    {
        [Fact]
        public void CreateEmptyListStringTest()
        {
            //Arrange
            IGenericList<string> list;

            //Act
            list = new GenericList<string>();

            //Assert
            Assert.NotNull(list);
            Assert.Equal(0, list.Count());
        }

        [Fact]
        public void EmptyListShouldThrowIndexOutOfRangeException()
        {
            //Da una lista vuota, se accedo a un qualsiasi elemento, mi aspetto una IndexOutOfRangeException
            IGenericList<int> list;

            list = new GenericList<int>();


            Assert.Throws<IndexOutOfRangeException>(() => list.ItemAt(0));
        }

        [Fact]
        public void ItemAtTest()
        {
            IGenericList<int> list = new GenericList<int>();
            list.Add(2);
            list.Add(3);
            list.Add(100);

            Assert.Equal(100, list.ItemAt(2));
        }

        [Fact]
        public void AddItemTest()
        {
            IGenericList<int> list = new GenericList<int>();
            list.Add(2);
            list.Add(3);

            Assert.Equal(2, list.Count());
            Assert.Equal( 2 ,list.ItemAt(0));
            Assert.Equal( 3 ,list.ItemAt(1));
        }

        [Fact]
        public void RemoveAtTest()
        {
            IGenericList<int> list = new GenericList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            list.RemoveAt(2);

            Assert.Equal(3, list.Count());
            Assert.Equal(-1, list.IndexOf(30));
            Assert.Equal(40, list.ItemAt(2));
        }

        [Fact]
        public void ClearTest()
        {
            IGenericList<int> list = new GenericList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            list.Clear();

            Assert.Equal(0, list.Count());
            Assert.Throws<IndexOutOfRangeException>(() => list.ItemAt(0));
        }
    }
}
